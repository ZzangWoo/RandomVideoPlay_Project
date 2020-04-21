namespace ForMom.ServeForm.PlayList
{
    partial class ConfirmListForm
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
            this.PlayVideoListView = new MetroFramework.Controls.MetroListView();
            this.VideoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // PlayVideoListView
            // 
            this.PlayVideoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VideoName});
            this.PlayVideoListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlayVideoListView.FullRowSelect = true;
            this.PlayVideoListView.Location = new System.Drawing.Point(24, 64);
            this.PlayVideoListView.Name = "PlayVideoListView";
            this.PlayVideoListView.OwnerDraw = true;
            this.PlayVideoListView.Size = new System.Drawing.Size(243, 312);
            this.PlayVideoListView.TabIndex = 0;
            this.PlayVideoListView.UseCompatibleStateImageBehavior = false;
            this.PlayVideoListView.UseSelectable = true;
            this.PlayVideoListView.View = System.Windows.Forms.View.Details;
            // 
            // VideoName
            // 
            this.VideoName.Text = "동영상 이름";
            this.VideoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VideoName.Width = 243;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(24, 383);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(243, 44);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "닫기";
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ConfirmListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PlayVideoListView);
            this.Name = "ConfirmListForm";
            this.Text = "동영상 재생 리스트";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView PlayVideoListView;
        private System.Windows.Forms.ColumnHeader VideoName;
        private MetroFramework.Controls.MetroButton CloseButton;
    }
}