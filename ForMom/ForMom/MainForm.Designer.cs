namespace ForMom
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.RandomVideoFolderListView = new MetroFramework.Controls.MetroListView();
            this.folderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.RandomFolderSelectButton = new MetroFramework.Controls.MetroButton();
            this.RandomFolderDeleteButton = new MetroFramework.Controls.MetroButton();
            this.RandomFolderPlayButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.RandomVedioCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.metroUserControl2 = new MetroFramework.Controls.MetroUserControl();
            this.metroUserControl3 = new MetroFramework.Controls.MetroUserControl();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.playListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddListButton = new MetroFramework.Controls.MetroButton();
            this.ListPlayButton = new MetroFramework.Controls.MetroButton();
            this.ListDeleteButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.RandomVedioCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroUserControl1.Location = new System.Drawing.Point(43, 81);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(449, 445);
            this.metroUserControl1.TabIndex = 2;
            this.metroUserControl1.UseCustomBackColor = true;
            this.metroUserControl1.UseSelectable = true;
            // 
            // RandomVideoFolderListView
            // 
            this.RandomVideoFolderListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandomVideoFolderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.folderName,
            this.folderCount});
            this.RandomVideoFolderListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RandomVideoFolderListView.FullRowSelect = true;
            this.RandomVideoFolderListView.Location = new System.Drawing.Point(73, 130);
            this.RandomVideoFolderListView.Name = "RandomVideoFolderListView";
            this.RandomVideoFolderListView.OwnerDraw = true;
            this.RandomVideoFolderListView.Size = new System.Drawing.Size(392, 272);
            this.RandomVideoFolderListView.Style = MetroFramework.MetroColorStyle.Silver;
            this.RandomVideoFolderListView.TabIndex = 3;
            this.RandomVideoFolderListView.UseCompatibleStateImageBehavior = false;
            this.RandomVideoFolderListView.UseSelectable = true;
            this.RandomVideoFolderListView.View = System.Windows.Forms.View.Details;
            // 
            // folderName
            // 
            this.folderName.Text = "폴더 이름";
            this.folderName.Width = 300;
            // 
            // folderCount
            // 
            this.folderCount.Text = "영상 개수";
            this.folderCount.Width = 92;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.metroLabel1.Location = new System.Drawing.Point(73, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "랜덤 재생";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // RandomFolderSelectButton
            // 
            this.RandomFolderSelectButton.BackColor = System.Drawing.Color.Azure;
            this.RandomFolderSelectButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RandomFolderSelectButton.Location = new System.Drawing.Point(74, 458);
            this.RandomFolderSelectButton.Name = "RandomFolderSelectButton";
            this.RandomFolderSelectButton.Size = new System.Drawing.Size(115, 44);
            this.RandomFolderSelectButton.TabIndex = 5;
            this.RandomFolderSelectButton.Text = "폴더 추가";
            this.RandomFolderSelectButton.UseCustomBackColor = true;
            this.RandomFolderSelectButton.UseSelectable = true;
            this.RandomFolderSelectButton.Click += new System.EventHandler(this.RandomFolderSelectButton_Click);
            // 
            // RandomFolderDeleteButton
            // 
            this.RandomFolderDeleteButton.BackColor = System.Drawing.Color.Azure;
            this.RandomFolderDeleteButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RandomFolderDeleteButton.Location = new System.Drawing.Point(214, 458);
            this.RandomFolderDeleteButton.Name = "RandomFolderDeleteButton";
            this.RandomFolderDeleteButton.Size = new System.Drawing.Size(115, 44);
            this.RandomFolderDeleteButton.TabIndex = 5;
            this.RandomFolderDeleteButton.Text = "삭제";
            this.RandomFolderDeleteButton.UseCustomBackColor = true;
            this.RandomFolderDeleteButton.UseCustomForeColor = true;
            this.RandomFolderDeleteButton.UseSelectable = true;
            this.RandomFolderDeleteButton.Click += new System.EventHandler(this.RandomFolderDeleteButton_Click);
            // 
            // RandomFolderPlayButton
            // 
            this.RandomFolderPlayButton.BackColor = System.Drawing.Color.Azure;
            this.RandomFolderPlayButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RandomFolderPlayButton.Location = new System.Drawing.Point(351, 458);
            this.RandomFolderPlayButton.Name = "RandomFolderPlayButton";
            this.RandomFolderPlayButton.Size = new System.Drawing.Size(115, 44);
            this.RandomFolderPlayButton.TabIndex = 5;
            this.RandomFolderPlayButton.Text = "재생";
            this.RandomFolderPlayButton.UseCustomBackColor = true;
            this.RandomFolderPlayButton.UseCustomForeColor = true;
            this.RandomFolderPlayButton.UseSelectable = true;
            this.RandomFolderPlayButton.Click += new System.EventHandler(this.RandomFolderPlayButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(153, 418);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "재생할 영상 개수";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // RandomVedioCountUpDown
            // 
            this.RandomVedioCountUpDown.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RandomVedioCountUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RandomVedioCountUpDown.Location = new System.Drawing.Point(292, 420);
            this.RandomVedioCountUpDown.Name = "RandomVedioCountUpDown";
            this.RandomVedioCountUpDown.Size = new System.Drawing.Size(60, 17);
            this.RandomVedioCountUpDown.TabIndex = 7;
            // 
            // metroUserControl2
            // 
            this.metroUserControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroUserControl2.Location = new System.Drawing.Point(523, 81);
            this.metroUserControl2.Name = "metroUserControl2";
            this.metroUserControl2.Size = new System.Drawing.Size(449, 445);
            this.metroUserControl2.TabIndex = 8;
            this.metroUserControl2.UseCustomBackColor = true;
            this.metroUserControl2.UseSelectable = true;
            // 
            // metroUserControl3
            // 
            this.metroUserControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroUserControl3.Location = new System.Drawing.Point(1004, 81);
            this.metroUserControl3.Name = "metroUserControl3";
            this.metroUserControl3.Size = new System.Drawing.Size(449, 373);
            this.metroUserControl3.TabIndex = 8;
            this.metroUserControl3.UseCustomBackColor = true;
            this.metroUserControl3.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.metroLabel3.Location = new System.Drawing.Point(550, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "재생 목록 장바구니";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.metroLabel4.Location = new System.Drawing.Point(1038, 108);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "개별 재생";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroListView1
            // 
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playListName,
            this.listCount});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(550, 131);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(392, 271);
            this.metroListView1.TabIndex = 9;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // playListName
            // 
            this.playListName.Text = "재생 목록 이름";
            this.playListName.Width = 300;
            // 
            // listCount
            // 
            this.listCount.Text = "영상 개수";
            this.listCount.Width = 92;
            // 
            // AddListButton
            // 
            this.AddListButton.Location = new System.Drawing.Point(550, 420);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(110, 82);
            this.AddListButton.TabIndex = 10;
            this.AddListButton.Text = "리스트 추가";
            this.AddListButton.UseSelectable = true;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // ListPlayButton
            // 
            this.ListPlayButton.Location = new System.Drawing.Point(832, 418);
            this.ListPlayButton.Name = "ListPlayButton";
            this.ListPlayButton.Size = new System.Drawing.Size(110, 82);
            this.ListPlayButton.TabIndex = 10;
            this.ListPlayButton.Text = "재생";
            this.ListPlayButton.UseSelectable = true;
            // 
            // ListDeleteButton
            // 
            this.ListDeleteButton.Location = new System.Drawing.Point(694, 420);
            this.ListDeleteButton.Name = "ListDeleteButton";
            this.ListDeleteButton.Size = new System.Drawing.Size(110, 82);
            this.ListDeleteButton.TabIndex = 10;
            this.ListDeleteButton.Text = "삭제";
            this.ListDeleteButton.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1501, 557);
            this.Controls.Add(this.ListDeleteButton);
            this.Controls.Add(this.ListPlayButton);
            this.Controls.Add(this.AddListButton);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.RandomVedioCountUpDown);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.RandomFolderPlayButton);
            this.Controls.Add(this.RandomFolderDeleteButton);
            this.Controls.Add(this.RandomFolderSelectButton);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.RandomVideoFolderListView);
            this.Controls.Add(this.metroUserControl1);
            this.Controls.Add(this.metroUserControl2);
            this.Controls.Add(this.metroUserControl3);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "동영상 재생 프로그램";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Khaki;
            ((System.ComponentModel.ISupportInitialize)(this.RandomVedioCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroListView RandomVideoFolderListView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton RandomFolderSelectButton;
        private MetroFramework.Controls.MetroButton RandomFolderDeleteButton;
        private MetroFramework.Controls.MetroButton RandomFolderPlayButton;
        private System.Windows.Forms.ColumnHeader folderName;
        private System.Windows.Forms.ColumnHeader folderCount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown RandomVedioCountUpDown;
        private MetroFramework.Controls.MetroUserControl metroUserControl2;
        private MetroFramework.Controls.MetroUserControl metroUserControl3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader playListName;
        private System.Windows.Forms.ColumnHeader listCount;
        private MetroFramework.Controls.MetroButton AddListButton;
        private MetroFramework.Controls.MetroButton ListPlayButton;
        private MetroFramework.Controls.MetroButton ListDeleteButton;
    }
}

