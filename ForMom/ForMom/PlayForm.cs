using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace ForMom
{
    public partial class PlayForm : MetroFramework.Forms.MetroForm
    {
        #region # 전역변수

        List<string> playList;

        #endregion

        #region # Initialize

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="playList"></param>
        public PlayForm(List<string> playList)
        {
            InitializeComponent();

            this.playList = playList;

            #region ## 플레이 리스트 추가

            foreach (var list in playList)
            {
                ListViewItem listViewItem = new ListViewItem(Path.GetFileName(list));
                VideoPlayListView.Items.Add(listViewItem);
            }

            #endregion

            #region ## 비디오 재생 리스트 추가 후 재생

            IWMPPlaylist wMPPlaylist = VideoPlayer.playlistCollection.newPlaylist("RandomPlayList");
            IWMPMedia media;

            foreach (var list in playList)
            {
                media = VideoPlayer.newMedia(list);
                wMPPlaylist.appendItem(media);
            }
            
            VideoPlayer.currentPlaylist = wMPPlaylist;

            #endregion
        }

        #endregion

        #region # Button Click Event

        /// <summary>
        /// 전체화면 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            VideoPlayer.fullScreen = true;
        }

        #endregion
    }
}
