using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForMom.ServeForm.PlayList
{
    public partial class ConfirmListForm : MetroFramework.Forms.MetroForm
    {
        #region # Initialize

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="videoList"></param>
        public ConfirmListForm(List<Video> videoList)
        {
            InitializeComponent();

            foreach (var video in videoList)
            {
                ListViewItem listViewItem = new ListViewItem("< " + video.videoNum + " >   " + video.videoName);
                PlayVideoListView.Items.Add(listViewItem);
            }
        }

        #endregion

        #region # Button Click Event

        /// <summary>
        /// 닫기 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
