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
        #region # 전역변수
        
        List<Video> videoList; // 영상 리스트
        MainLog log; // 로그

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

        #endregion

        #region # Button Click Event

        /// <summary>
        /// 만들기 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeListButton_Click(object sender, EventArgs e)
        {
            try
            {
                string listName = ListNameTextBox.Text;

                if (string.IsNullOrEmpty(listName))
                {
                    MessageBox.Show("장바구니 이름을 입력해주세요");
                    return;
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
                        Video video = new Video(openFileDialog.FileName, Path.GetFileName(openFileDialog.FileName));
                        videoList.Add(video);

                        ListViewItem listViewItem = new ListViewItem("< " + videoList.Count.ToString() + " >   " + video.videoName);
                        VideoListView.Items.Add(listViewItem);

                        
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

        #endregion

        #region # Public Method



        #endregion


    }
}
