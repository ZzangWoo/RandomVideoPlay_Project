using Entity;
using MakeLog;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace ForMom
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        #region # 전역변수

        string logPath = @"C:\TestLog\";
        string randomVideoFolderLists = "RandomVideoFolderLists.txt";

        List<RandomFolder> randomFolderList;

        MainLog log;

        #endregion

        #region # Initialize

        public MainForm()
        {
            InitializeComponent();

            // Log Class 생성
            log = new MainLog(logPath);

            #region ## 저장 로그 파일 불러오기

            randomFolderList = new List<RandomFolder>();

            // 해당 경로에 리스트 저장 로그 파일 있는지 확인
            FileInfo fileInfo = new FileInfo(logPath + randomVideoFolderLists);

            if (fileInfo.Exists)
            {
                GetListLogMessage();
            }

            #endregion

        }

        #endregion

        #region # Button Click Event

        #region ## About Random

        /// <summary>
        /// [랜덤] 폴더 선택
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
                        log.SaveListLog(randomFolderList, randomVideoFolderLists);
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
            if (RandomVideoFolderListView.SelectedItems.Count > 0)
            {
                int index = RandomVideoFolderListView.FocusedItem.Index;

                log.WriteLog(randomFolderList[index].folderPath + " 재생");

                MediaPlayer mediaPlayer = new MediaPlayer();
                mediaPlayer.Open(new Uri(randomFolderList[index].folderPath + @"\내일은 미스트롯.E10.190502.720p-NEXT.mp4"));
                mediaPlayer.Play();
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }
        }

        #endregion

        #region ## About One

        #endregion

        #endregion

        #region # Public Method

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

                    log.SaveListLog(randomFolderList, randomVideoFolderLists);
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

                        log.SaveListLog(randomFolderList, randomVideoFolderLists);
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
                using (StreamReader streamReader = new StreamReader(logPath + randomVideoFolderLists))
                {
                    string listLogMessage = string.Empty;

                    while ((listLogMessage = streamReader.ReadLine()) != null)
                    {
                        string[] folderArray = listLogMessage.Split('\t');

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

                log.SaveListLog(randomFolderList, randomVideoFolderLists);
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


        #endregion

        
    }

}
