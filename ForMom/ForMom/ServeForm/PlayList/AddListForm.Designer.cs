namespace ForMom.ServeForm.PlayList
{
    partial class AddListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ListNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VideoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddVideoButton = new MetroFramework.Controls.MetroButton();
            this.ListUpButton = new System.Windows.Forms.Button();
            this.ListDownButton = new System.Windows.Forms.Button();
            this.MakeListButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(15, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "장바구니 이름";
            // 
            // ListNameTextBox
            // 
            // 
            // 
            // 
            this.ListNameTextBox.CustomButton.Image = null;
            this.ListNameTextBox.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.ListNameTextBox.CustomButton.Name = "";
            this.ListNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ListNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ListNameTextBox.CustomButton.TabIndex = 1;
            this.ListNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ListNameTextBox.CustomButton.UseSelectable = true;
            this.ListNameTextBox.CustomButton.Visible = false;
            this.ListNameTextBox.Lines = new string[] {
        "장바구니 이름을 입력해주세요"};
            this.ListNameTextBox.Location = new System.Drawing.Point(15, 98);
            this.ListNameTextBox.MaxLength = 32767;
            this.ListNameTextBox.Name = "ListNameTextBox";
            this.ListNameTextBox.PasswordChar = '\0';
            this.ListNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ListNameTextBox.SelectedText = "";
            this.ListNameTextBox.SelectionLength = 0;
            this.ListNameTextBox.SelectionStart = 0;
            this.ListNameTextBox.ShortcutsEnabled = true;
            this.ListNameTextBox.Size = new System.Drawing.Size(297, 23);
            this.ListNameTextBox.TabIndex = 1;
            this.ListNameTextBox.Text = "장바구니 이름을 입력해주세요";
            this.ListNameTextBox.UseSelectable = true;
            this.ListNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ListNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(15, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "동영상 추가";
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.VideoName});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(24, 168);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(247, 259);
            this.metroListView1.TabIndex = 3;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "순서";
            // 
            // VideoName
            // 
            this.VideoName.Text = "영상 제목";
            this.VideoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VideoName.Width = 187;
            // 
            // AddVideoButton
            // 
            this.AddVideoButton.BackColor = System.Drawing.Color.Aqua;
            this.AddVideoButton.ForeColor = System.Drawing.Color.Yellow;
            this.AddVideoButton.Location = new System.Drawing.Point(228, 137);
            this.AddVideoButton.Name = "AddVideoButton";
            this.AddVideoButton.Size = new System.Drawing.Size(43, 27);
            this.AddVideoButton.TabIndex = 5;
            this.AddVideoButton.Text = "추가";
            this.AddVideoButton.UseCustomBackColor = true;
            this.AddVideoButton.UseCustomForeColor = true;
            this.AddVideoButton.UseSelectable = true;
            // 
            // ListUpButton
            // 
            this.ListUpButton.Image = global::ForMom.Properties.Resources.UpArrow;
            this.ListUpButton.Location = new System.Drawing.Point(277, 228);
            this.ListUpButton.Name = "ListUpButton";
            this.ListUpButton.Size = new System.Drawing.Size(35, 54);
            this.ListUpButton.TabIndex = 6;
            this.ListUpButton.UseVisualStyleBackColor = true;
            // 
            // ListDownButton
            // 
            this.ListDownButton.Image = global::ForMom.Properties.Resources.DownArrow;
            this.ListDownButton.Location = new System.Drawing.Point(277, 348);
            this.ListDownButton.Name = "ListDownButton";
            this.ListDownButton.Size = new System.Drawing.Size(35, 54);
            this.ListDownButton.TabIndex = 6;
            this.ListDownButton.UseVisualStyleBackColor = true;
            // 
            // MakeListButton
            // 
            this.MakeListButton.Location = new System.Drawing.Point(24, 433);
            this.MakeListButton.Name = "MakeListButton";
            this.MakeListButton.Size = new System.Drawing.Size(247, 48);
            this.MakeListButton.TabIndex = 5;
            this.MakeListButton.Text = "만들기";
            this.MakeListButton.UseSelectable = true;
            // 
            // AddListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 504);
            this.Controls.Add(this.ListDownButton);
            this.Controls.Add(this.ListUpButton);
            this.Controls.Add(this.MakeListButton);
            this.Controls.Add(this.AddVideoButton);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ListNameTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddListForm";
            this.Text = "동영상 장바구니 만들기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox ListNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader VideoName;
        private MetroFramework.Controls.MetroButton AddVideoButton;
        private System.Windows.Forms.Button ListUpButton;
        private System.Windows.Forms.Button ListDownButton;
        private MetroFramework.Controls.MetroButton MakeListButton;
    }
}