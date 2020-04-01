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
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroUserControl1.Location = new System.Drawing.Point(42, 105);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(457, 373);
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
            this.RandomVideoFolderListView.Location = new System.Drawing.Point(73, 150);
            this.RandomVideoFolderListView.Name = "RandomVideoFolderListView";
            this.RandomVideoFolderListView.OwnerDraw = true;
            this.RandomVideoFolderListView.Size = new System.Drawing.Size(392, 200);
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
            this.metroLabel1.Location = new System.Drawing.Point(73, 128);
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
            this.RandomFolderSelectButton.Location = new System.Drawing.Point(73, 410);
            this.RandomFolderSelectButton.Name = "RandomFolderSelectButton";
            this.RandomFolderSelectButton.Size = new System.Drawing.Size(115, 44);
            this.RandomFolderSelectButton.TabIndex = 5;
            this.RandomFolderSelectButton.Text = "폴더 선택";
            this.RandomFolderSelectButton.UseCustomBackColor = true;
            this.RandomFolderSelectButton.UseSelectable = true;
            this.RandomFolderSelectButton.Click += new System.EventHandler(this.RandomFolderSelectButton_Click);
            // 
            // RandomFolderDeleteButton
            // 
            this.RandomFolderDeleteButton.BackColor = System.Drawing.Color.Azure;
            this.RandomFolderDeleteButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RandomFolderDeleteButton.Location = new System.Drawing.Point(213, 410);
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
            this.RandomFolderPlayButton.Location = new System.Drawing.Point(350, 410);
            this.RandomFolderPlayButton.Name = "RandomFolderPlayButton";
            this.RandomFolderPlayButton.Size = new System.Drawing.Size(115, 44);
            this.RandomFolderPlayButton.TabIndex = 5;
            this.RandomFolderPlayButton.Text = "재생";
            this.RandomFolderPlayButton.UseCustomBackColor = true;
            this.RandomFolderPlayButton.UseCustomForeColor = true;
            this.RandomFolderPlayButton.UseSelectable = true;
            this.RandomFolderPlayButton.Click += new System.EventHandler(this.RandomFolderPlayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1219, 682);
            this.Controls.Add(this.RandomFolderPlayButton);
            this.Controls.Add(this.RandomFolderDeleteButton);
            this.Controls.Add(this.RandomFolderSelectButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.RandomVideoFolderListView);
            this.Controls.Add(this.metroUserControl1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "동영상 재생 프로그램";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Khaki;
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
    }
}

