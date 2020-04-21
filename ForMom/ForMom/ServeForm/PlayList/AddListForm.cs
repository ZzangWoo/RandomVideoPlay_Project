using Entity;
using MakeLog;
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

namespace ForMom.ServeForm.PlayList
{
    public partial class AddListForm : MetroFramework.Forms.MetroForm
    {
        #region # Delegate

        // 델리게이트 선언
        public delegate void AddListFormCloseHandler(string listName, List<Video> videos); // 장바구니 생성
        public delegate void ModifyListFormCloseHandler(string preListName, string listName, List<Video> videos); // 장바구니 수정

        // 이벤트 생성
        public event AddListFormCloseHandler AddListFormCloseEvent; // 장바구니 생성
        public event ModifyListFormCloseHandler ModifyListFormCloseEvent; // 장바구니 수정

        #endregion

        #region # 전역변수

        List<Video> videoList; // 영상 리스트
        MainLog log; // 로그

        // 수정 시 처음 입력된 장바구니 이름
        string preListName = string.Empty;

        #endregion

        #region # Initialize

        /// <summary>
        /// 생성자
        /// </summary>
        public AddListForm(string logPath)
        {
            InitializeComponent();

            // Log Class 생성
            log = new MainLog(logPath);

            // 영상 리스트 동적 할당
            videoList = new List<Video>();
        }

        /// <summary>
        /// 생성자 (수정)
        /// </summary>
        /// <param name="cartName"></param>
        /// <param name="videoList"></param>
        public AddListForm(string cartName, List<Video> videoList)
        {
            InitializeComponent();

            // 컨트롤 텍스트 변경
            this.Text = "동영상 장바구니 수정";
            ListNameTextBox.Text = cartName;
            MakeListButton.Text = "수정";

            // 리스트 뷰에 영상 리스트 넣기
            foreach (var video in videoList)
            {
                ListViewItem listViewItem = new ListViewItem("< " + video.videoNum + " >   " + video.videoName);
                VideoListView.Items.Add(listViewItem);
            }

            // 전역변수 리스트 초기화
            this.videoList = videoList;

            // 장바구니 이름 저장
            preListName = cartName;
        }

        #endregion

        #region # Button Click Event

        /// <summary>
        /// 만들기 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeListButton_Click(object sender, EventArgs e)
        {
            string listName = ListNameTextBox.Text;
            // 이름 입력 예외 처리
            if (string.IsNullOrEmpty(listName))
            {
                MessageBox.Show("장바구니 이름을 입력해주세요");
                return;
            }

            // 장바구니 리스트 예외 처리
            if (VideoListView.Items.Count <= 0)
            {
                MessageBox.Show("장바구니에 담겨져있는 영상이 없습니다.\n다시 확인해주세요.");
                return;
            }

            try
            {
                if (MakeListButton.Text == "만들기")
                {
                    this.AddListFormCloseEvent(listName, videoList);
                    this.Close();
                }
                else if (MakeListButton.Text == "수정")
                {
                    this.ModifyListFormCloseEvent(preListName, listName, videoList);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[에러발생] 장바구니를 만들던 도중 에러가 발생했습니다. 관리자에게 문의해주세요.");
                log.WriteLog("[Error] : " + ex);
            }
            
        }

        /// <summary>
        /// 추가 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVideoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "동영상 파일 (*.mov;*.mp4;*.avi;*.3gp;*.wmv;*.mp4)|*.mov;*.mp4;*.avi;*.3gp;*.wmv;*.mp4"; // 파일 확장자
                openFileDialog.Multiselect = false; // 다중 선택 X

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Video video = new Video(videoList.Count + 1, 
                            openFileDialog.FileName, 
                            Path.GetFileName(openFileDialog.FileName));
                        videoList.Add(video);

                        UpdateListView();



                        //VideoListView.Columns[1].DisplayIndex = 0;
                        //VideoListView.Columns[0].DisplayIndex = 1;
                        //VideoListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                        //VideoListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                        //VideoListView.Columns[1].Width = -2;
                        //VideoListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        //VideoListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        //VideoListView.EndUpdate();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("[에러발생] 파일 선택 중 에러가 발생했습니다.\n올바른 파일을 선택해주세요.");
                        log.WriteLog("[Error] : " + ex);
                    }
                }
            }
        }

        /// <summary>
        /// 삭제 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteVideoButton_Click(object sender, EventArgs e)
        {
            if (VideoListView.SelectedItems.Count > 0)
            {
                try
                {
                    int selectIndex = VideoListView.SelectedItems[0].Index + 1;
                    videoList.RemoveAt(selectIndex - 1);

                    foreach (Video video in videoList)
                    {
                        if (video.videoNum > selectIndex)
                        {
                            video.videoNum--;
                        }
                    }

                    UpdateListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[에러발생] 영상을 삭제하는 중 에러가 발생했습니다.\n관리자에게 문의해주세요.");
                    log.WriteLog("[Error] : " + ex);
                }
            }
            else
            {
                MessageBox.Show("삭제할 영상을 선택해주세요.");
            }
            
        }

        /// <summary>
        /// 목록 위로 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListUpButton_Click(object sender, EventArgs e)
        {
            if (VideoListView.SelectedItems.Count > 0)
            {
                int selectIndex = VideoListView.SelectedItems[0].Index + 1;

                if (selectIndex == 1)
                {
                    MessageBox.Show("영상을 더이상 위로 올릴 수가 없습니다.");
                }
                else
                {
                    try
                    {
                        // 선택한 영상 객체 저장 후 List에서 제거
                        Video tempVideo = videoList[selectIndex - 1];
                        tempVideo.videoNum--;
                        videoList.RemoveAt(selectIndex - 1);

                        // 앞에 있는 영상 객체 번호 +1
                        videoList[selectIndex - 2].videoNum++;

                        // 앞에 있는 영상 위치에 저장한 객체 집어넣기
                        videoList.Insert(selectIndex - 2, tempVideo);

                        UpdateListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("[에러발생] : 알 수 없는 에러가 발생했습니다.\n관리자에게 문의해주세요");
                        log.WriteLog("[Error] : " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("위치를 변경 할 영상을 선택해주세요.");
            }
        }

        /// <summary>
        /// 목록 아래로 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListDownButton_Click(object sender, EventArgs e)
        {
            if (VideoListView.SelectedItems.Count > 0)
            {
                int selectIndex = VideoListView.SelectedItems[0].Index + 1;

                if (selectIndex == VideoListView.Items.Count)
                {
                    MessageBox.Show("영상을 더이상 아래로 내릴 수가 없습니다.");
                }
                else
                {
                    try
                    {
                        // 선택한 영상 객체 저장 후 List에서 제거
                        Video tempVideo = videoList[selectIndex - 1];
                        tempVideo.videoNum++;
                        videoList.RemoveAt(selectIndex - 1);

                        // 앞에 있는 영상 객체 번호 +1
                        videoList[selectIndex - 1].videoNum--;

                        // 앞에 있는 영상 위치에 저장한 객체 집어넣기
                        videoList.Insert(selectIndex, tempVideo);

                        UpdateListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("[에러발생] : 알 수 없는 에러가 발생했습니다.\n관리자에게 문의해주세요");
                        log.WriteLog("[Error] : " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("위치를 변경 할 영상을 선택해주세요.");
            }
        }

        #endregion

        #region # Public Method

        /// <summary>
        /// 리스트 뷰 업데이트
        /// </summary>
        public void UpdateListView()
        {
            try
            {
                VideoListView.Items.Clear();

                foreach (Video video in videoList)
                {
                    ListViewItem listViewItem = new ListViewItem("< " + video.videoNum + " >   " + video.videoName);
                    VideoListView.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[에러발생] 영상을 추가하는데 오류가 발생했습니다.\n관리자에게 문의해주세요.");
                log.WriteLog("[Error] : " + ex);
            }
        }



        #endregion

        
    }
}
