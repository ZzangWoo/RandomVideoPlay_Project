using Entity;
using ForMom.ServeForm.PlayList;
using MakeLog;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using WMPLib;

namespace ForMom
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        #region # 전역변수

        List<RandomFolder> randomFolderList;
        Dictionary<string, List<Video>> listDictionary;
        //List<string> randomPlayList; // 랜덤 플레이 리스트

        MainLog log;

        #endregion

        #region # Initialize

        /// <summary>
        /// 생성자
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Log Class 생성
            log = new MainLog(PathList.logPath);

            #region ## 저장 로그 파일 불러오기

            randomFolderList = new List<RandomFolder>();

            #region ### 디렉토리 있는지 확인 - 없으면 생성

            DirectoryInfo directoryInfo = new DirectoryInfo(PathList.mainPath);

            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }

            directoryInfo = new DirectoryInfo(PathList.logPath);

            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }

            directoryInfo = new DirectoryInfo(PathList.randomPath);

            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }
            
            directoryInfo = new DirectoryInfo(PathList.listPath);

            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
                listDictionary = new Dictionary<string, List<Video>>();
            }
            else
            {
                listDictionary = new Dictionary<string, List<Video>>();
                
                foreach (var file in directoryInfo.GetFiles())
                {
                    using (StreamReader streamReader = new StreamReader(file.FullName))
                    {
                        List<Video> videos = new List<Video>();

                        string listString = string.Empty;
                        while ((listString = streamReader.ReadLine()) != null)
                        {
                            string[] listArray = listString.Split(',');

                            Video video = new Video(Int32.Parse(listArray[0]), listArray[1], listArray[2]);
                            videos.Add(video);
                        }

                        listDictionary.Add(Path.GetFileNameWithoutExtension(file.FullName), videos);
                    }
                }

                UpdateVideoCartListView();
            }

            directoryInfo = new DirectoryInfo(PathList.onePath);

            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }

            #endregion

            // 해당 경로에 리스트 저장 로그 파일 있는지 확인 (로그 + 랜덤리스트)
            FileInfo fileInfo = new FileInfo(PathList.randomPath + PathList.randomVideoFolderLists);

            if (fileInfo.Exists)
            {
                GetListLogMessage();
            }

            // 해당 경로에서 장바구니 리스트 파일 있는지 확인 -> 있으면 리스트 가져오기
            directoryInfo = new DirectoryInfo(PathList.listPath);



            #endregion

        }

        #endregion

        #region # Button Click Event

        #region ## About Random

        /// <summary>
        /// [랜덤] 폴더 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomFolderSelectButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Title = "랜덤 플레이 폴더 선택창";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                AddRandomVideoFolderList(dialog.FileName);
            }
        }

        /// <summary>
        /// [랜덤] 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomFolderDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("선택하신 항목이 삭제됩니다.\n계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (RandomVideoFolderListView.SelectedItems.Count > 0)
                    {
                        int index = RandomVideoFolderListView.FocusedItem.Index;

                        log.WriteLog(randomFolderList[index].folderPath + " 삭제");

                        randomFolderList.RemoveAt(index);
                        RandomVideoFolderListView.Items.RemoveAt(index);

                        log.WriteLog("랜덤 리스트 삭제 완료");
                        log.SaveListLog(randomFolderList, PathList.randomVideoFolderLists, PathList.randomPath);
                        log.WriteLog("랜덤 리스트 업데이트 완료");
                    }
                    else
                    {
                        MessageBox.Show("선택된 항목이 없습니다.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[에러발생] 리스트 삭제 중 에러가 발생하였습니다. 관리자에게 문의해주세요.");
                log.WriteLog("[Error] : \n" + ex);
            }
        }

        /// <summary>
        /// [랜덤] 재생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomFolderPlayButton_Click(object sender, EventArgs e)
        {
            #region ### 폼 중복 열기 방지
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "PlayForm")
                {
                    openForm.Activate();
                    return;
                }
            }
            #endregion

            #region ### 예외처리
            if (RandomVideoFolderListView.SelectedItems.Count > 0)
            {
                int index = RandomVideoFolderListView.FocusedItem.Index;

                DirectoryInfo directoryInfo = new DirectoryInfo(randomFolderList[index].folderPath);

                log.WriteLog(randomFolderList[index].folderPath + " 폴더 랜덤 재생 시작");

                // 재생할 영상 개수 확인
                if (RandomVedioCountUpDown.Value != 0)
                {
                    log.WriteLog("[랜덤 재생] : 재생할 영상 개수 확인");
                    // 폴더 경로 확인
                    if (directoryInfo.Exists)
                    {
                        log.WriteLog("[랜덤 재생] : 폴더 경로 확인");

                        // 폴더 안 동영상 개수 확인
                        int vedioCount = CountFolderVideos(randomFolderList[index].folderPath);
                        if (vedioCount > 0)
                        {
                            log.WriteLog("[랜덤 재생] : 폴더 안 동영상 개수 확인");
                            // 재생할 영상 개수와 폴더 안 영상 개수 비교
                            if (vedioCount >= RandomVedioCountUpDown.Value)
                            {
                                try
                                {
                                    log.WriteLog("[랜덤 재생] : 재생할 영상 개수와 폴더 안 영상 개수 비교 확인");
                                    List<string> randomPlayList = AddPlayList(randomFolderList[index].folderPath);

                                    PlayForm playForm = new PlayForm(randomPlayList);
                                    playForm.Owner = this;
                                    playForm.Show();

                                    //WindowsMediaPlayer player = new WindowsMediaPlayer();
                                    //IWMPPlaylist playList = player.playlistCollection.newPlaylist("RandomPlayList");
                                    //IWMPMedia media;

                                    //foreach (var list in randomPlayList)
                                    //{
                                    //    media = player.newMedia(list);
                                    //    playList.appendItem(media);
                                    //}

                                    //player.currentPlaylist = playList;

                                    //player.openPlayer(randomPlayList[0]);
                                    //if (player.playState == WMPPlayState.wmppsPlaying)
                                    //{
                                    //    player.fullScreen = true;
                                    //}
                                    //player.openPlayer(randomFolderList[index].folderPath + @"\내일은 미스트롯.E10.190502.720p-NEXT.mp4");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("[에러발생] 동영상을 실행하는데 에러가 발생했습니다.\n관리자에게 문의하세요");
                                    log.WriteLog("[Error] : " + ex);
                                }
                            }
                            else
                            {
                                log.WriteLog("[WARNING] : 재생할 영상 개수가 폴더 안 영상 개수보다 많음");
                                MessageBox.Show("폴더 안의 영상 개수보다 재생할 영상 개수가 더 많습니다.\n재생할 영상 개수를 다시 설정해주세요.");
                            }
                        }
                        else
                        {
                            log.WriteLog("[WARNING] : 폴더 안 동영상 존재하지 않음");
                            MessageBox.Show("선택한 폴더에 동영상이 없습니다.\n해당 폴더를 다시 한 번 확인해주세요.");
                        }
                    }
                    else
                    {
                        log.WriteLog("[WARNING] : 폴더 경로 확인 실패");
                        MessageBox.Show("선택한 폴더가 존재하지 않습니다.");

                        randomFolderList.RemoveAt(index);
                        RandomVideoFolderListView.Items.RemoveAt(index);

                        log.WriteLog("랜덤 리스트 삭제 완료");
                        log.SaveListLog(randomFolderList, PathList.randomVideoFolderLists, PathList.randomPath);
                        log.WriteLog("랜덤 리스트 업데이트 완료");
                    }

                    //WindowsMediaPlayer player = new WindowsMediaPlayer();
                    //player.openPlayer(randomFolderList[index].folderPath + @"\내일은 미스트롯.E10.190502.720p-NEXT.mp4");
                }
                else
                {
                    log.WriteLog("[WARNING] : 재생할 영상 개수가 0");
                    MessageBox.Show("재생할 영상 개수가 설정되지 않았습니다. 설정해주세요.");
                }
                
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }
            #endregion
        }

        #endregion

        #region ## About PlayList

        /// <summary>
        /// 리스트 추가 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddListButton_Click(object sender, EventArgs e)
        {
            AddListForm addListForm = new AddListForm(PathList.logPath);

            #region ### 폼 중복 열기 방지
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "AddListForm")
                {
                    openForm.Activate();
                    return;
                }
            }
            #endregion

            addListForm.AddListFormCloseEvent += new AddListForm.AddListFormCloseHandler(ListEvent);
            addListForm.ShowDialog();
        }

        /// <summary>
        /// 장바구니 목록 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("선택하신 항목이 삭제됩니다.\n계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (VideoCartListView.SelectedItems.Count > 0)
                    {
                        int index = VideoCartListView.FocusedItem.Index;
                        string cartName = VideoCartListView.Items[index].Text;
                        
                        VideoCartListView.Items.RemoveAt(index);

                        FileInfo fileInfo = new FileInfo(PathList.listPath + cartName + ".csv");
                        fileInfo.Delete();

                        listDictionary.Remove(cartName);

                        UpdateVideoCartListView();
                    }
                    else
                    {
                        MessageBox.Show("선택된 항목이 없습니다.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[에러발생] 리스트 삭제 중 에러가 발생하였습니다. 관리자에게 문의해주세요.");
                log.WriteLog("[Error] : In the Video Cart List (Delete) \n" + ex);
            }
        }

        #endregion

        #region ## About One

        #endregion

        #endregion

        #region # Public Method

        /// <summary>
        /// 선택한 폴더에 있는 영상 플레이리스트에 추가
        /// </summary>
        /// <param name="path"></param>
        public List<string> AddPlayList(string path)
        {
            List<string> playList = new List<string>();

            var files = Directory.GetFiles(path);
            var rand = new Random();

            int playCount = (int)RandomVedioCountUpDown.Value;
            if (playCount == 1)
            {
                playList.Add(files[rand.Next(files.Length)]);
            }
            else
            {
                while (playCount > 0)
                {
                    string randomVideoName = files[rand.Next(files.Length)];
                    if (playList.Count == 0 || !playList.Contains(randomVideoName))
                    {
                        playList.Add(randomVideoName);
                        playCount--;
                    }
                }
            }

            return playList;
            
        }

        /// <summary>
        /// 선택한 폴더 리스트 추가
        /// </summary>
        /// <param name="folderName"></param>
        public void AddRandomVideoFolderList(string folderPath)
        {
            int videoCount = CountFolderVideos(folderPath);

            try
            {
                if (RandomVideoFolderListView.Items.Count == 0)
                {
                    RandomFolder randomFolder = new RandomFolder(folderPath, Path.GetFileName(folderPath));
                    randomFolderList.Add(randomFolder);

                    ListViewItem listViewItem = new ListViewItem(randomFolder.folderName);
                    listViewItem.SubItems.Add(videoCount.ToString() + "개");
                    RandomVideoFolderListView.Items.Add(listViewItem);

                    log.SaveListLog(randomFolderList, PathList.randomVideoFolderLists, PathList.randomPath);
                    log.WriteLog(folderName + " 추가");
                }
                else
                {
                    bool isName = true;
                    // 리스트 중복 체크
                    for (int i = 0; i < RandomVideoFolderListView.Items.Count; i++)
                    {
                        ListViewItem listViewItem = RandomVideoFolderListView.Items[i];
                        if (listViewItem.SubItems[0].Text.Contains(Path.GetFileName(folderPath)))
                        {
                            isName = false;
                        }
                    }

                    if (isName)
                    {
                        RandomFolder randomFolder = new RandomFolder(folderPath, Path.GetFileName(folderPath));
                        randomFolderList.Add(randomFolder);

                        ListViewItem listViewItem = new ListViewItem(Path.GetFileName(folderPath));
                        listViewItem.SubItems.Add(videoCount.ToString() + "개");
                        RandomVideoFolderListView.Items.Add(listViewItem);

                        log.SaveListLog(randomFolderList, PathList.randomVideoFolderLists, PathList.randomPath);
                        log.WriteLog(folderName + " 추가");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("[에러발생] 관리자에게 문의하세요");
                log.WriteLog("[Error] : " + e);
            }
        }

        /// <summary>
        /// 폴더 내에 파일 개수 Count
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        public int CountFolderVideos(string folderPath)
        {
            int videoCount = 0;

            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

            foreach (var list in directoryInfo.GetFiles())
            {
                string filePath = list.FullName;
                string extension = Path.GetExtension(filePath);
                if (extension == ".mov" || extension == ".mp3" || extension == ".avi"
                    || extension == ".3gp" || extension == ".wmv" || extension == ".mp4")
                {
                    videoCount++;
                }
            }

            return videoCount;
        }

        /// <summary>
        /// 사용자가 추가한 리스트 로그를 List에 저장
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public void InsertListLogMessage(string type, string message)
        {
            if (type == "Random")
            {
                
            }
            else if (type == "One")
            {

            }
        }

        /// <summary>
        /// 텍스트 파일에서 리스트 저장 기록 가져와서 List에 저장
        /// </summary>
        public void GetListLogMessage()
        {
            log.WriteLog("리스트 가져오기");

            try
            {
                using (StreamReader streamReader = new StreamReader(PathList.randomPath + PathList.randomVideoFolderLists))
                {
                    string listLogMessage = string.Empty;

                    while ((listLogMessage = streamReader.ReadLine()) != null)
                    {
                        string[] folderArray = listLogMessage.Split(',');

                        DirectoryInfo directoryInfo = new DirectoryInfo(folderArray[0]);
                        if (directoryInfo.Exists)
                        {
                            RandomFolder randomFolder = new RandomFolder(folderArray[0], folderArray[1]);
                            randomFolderList.Add(randomFolder);
                        }
                        else
                        {
                            MessageBox.Show(folderArray[1] + " 폴더가 존재하지 않습니다. 경로를 다시 확인해주세요.");
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("[에러발생] 리스트 가져오기에 실패했습니다. 로그파일을 확인해주세요.");
                log.WriteLog("[Error] : 리스트 가져오기 실패\n" + e);
            }
            finally
            {
                log.WriteLog("리스트 가져오기 성공");
            }

            UpdateRandomListView();

        }

        /// <summary>
        /// 랜덤 ListView 업데이트
        /// </summary>
        public void UpdateRandomListView()
        {
            log.WriteLog("랜덤 ListView Update 시작");

            try
            {
                foreach (var list in randomFolderList)
                {
                    ListViewItem listViewItem = new ListViewItem(list.folderName);
                    listViewItem.SubItems.Add(CountFolderVideos(list.folderPath).ToString() + "개");

                    RandomVideoFolderListView.Items.Add(listViewItem);
                }

                log.SaveListLog(randomFolderList, PathList.randomVideoFolderLists, PathList.randomPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("[에러 발생] : 리스트 업데이트에 실패했습니다. 관리자에게 문의해주세요.");
                log.WriteLog("[Error] : 랜덤 ListView Update 실패\n" + e);
            }
            finally
            {
                log.WriteLog("랜덤 ListView Update 성공");
            }
        }

        /// <summary>
        /// 장바구니 목록 업데이트
        /// </summary>
        public void UpdateVideoCartListView()
        {
            try
            {
                VideoCartListView.Items.Clear();

                foreach (var item in listDictionary)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Key);
                    listViewItem.SubItems.Add(item.Value.Count.ToString() + "개");

                    VideoCartListView.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[에러발생] 장바구니 목록 갱신할 때 오류가 발생했습니다.\n관리자에게 문의해주세요.");
                log.WriteLog("[Error] : " + ex);
            }
        }

        #endregion

        #region # Event Handler

        /// <summary>
        /// 장바구니 만들고 나서의 Event
        /// </summary>
        /// <param name="listName"></param>
        /// <param name="videos"></param>
        private void ListEvent(string listName, List<Video> videos)
        {
            listDictionary.Add(listName, videos);

            log.SaveVideoCartLists(listDictionary, listName);

            UpdateVideoCartListView();
        }


        #endregion

        
    }

}
