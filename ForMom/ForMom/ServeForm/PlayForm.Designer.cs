namespace ForMom
{
    partial class PlayForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.fullScreenButton = new MetroFramework.Controls.MetroButton();
            this.VideoPlayListView = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.videoList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(0, 23);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(754, 477);
            this.VideoPlayer.TabIndex = 0;
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.Location = new System.Drawing.Point(679, 477);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Size = new System.Drawing.Size(75, 23);
            this.fullScreenButton.TabIndex = 1;
            this.fullScreenButton.Text = "전체화면";
            this.fullScreenButton.UseSelectable = true;
            this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
            // 
            // VideoPlayListView
            // 
            this.VideoPlayListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.videoList});
            this.VideoPlayListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VideoPlayListView.FullRowSelect = true;
            this.VideoPlayListView.Location = new System.Drawing.Point(771, 54);
            this.VideoPlayListView.Name = "VideoPlayListView";
            this.VideoPlayListView.OwnerDraw = true;
            this.VideoPlayListView.Size = new System.Drawing.Size(183, 423);
            this.VideoPlayListView.TabIndex = 2;
            this.VideoPlayListView.UseCompatibleStateImageBehavior = false;
            this.VideoPlayListView.UseSelectable = true;
            this.VideoPlayListView.View = System.Windows.Forms.View.Details;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(771, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "재생 목록";
            // 
            // videoList
            // 
            this.videoList.Text = "영상 제목";
            this.videoList.Width = 183;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 500);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.VideoPlayListView);
            this.Controls.Add(this.fullScreenButton);
            this.Controls.Add(this.VideoPlayer);
            this.Name = "PlayForm";
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private MetroFramework.Controls.MetroButton fullScreenButton;
        private MetroFramework.Controls.MetroListView VideoPlayListView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ColumnHeader videoList;
    }
}
