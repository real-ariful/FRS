namespace WindowsFormsApplication3
{
    partial class garment_mainpage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.faceDatabaseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonBrokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1019, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // faceDatabaseManagementToolStripMenuItem
            // 
            this.faceDatabaseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseListToolStripMenuItem});
            this.faceDatabaseManagementToolStripMenuItem.Name = "faceDatabaseManagementToolStripMenuItem";
            this.faceDatabaseManagementToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.faceDatabaseManagementToolStripMenuItem.Text = "Notification";
            // 
            // databaseListToolStripMenuItem
            // 
            this.databaseListToolStripMenuItem.Name = "databaseListToolStripMenuItem";
            this.databaseListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.databaseListToolStripMenuItem.Text = "Needle Notification";
            this.databaseListToolStripMenuItem.Click += new System.EventHandler(this.databaseListToolStripMenuItem_Click);
            // 
            // cameraListToolStripMenuItem
            // 
            this.cameraListToolStripMenuItem.Name = "cameraListToolStripMenuItem";
            this.cameraListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cameraListToolStripMenuItem.Text = "Camera List";
            // 
            // cameraDashboardToolStripMenuItem
            // 
            this.cameraDashboardToolStripMenuItem.Name = "cameraDashboardToolStripMenuItem";
            this.cameraDashboardToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cameraDashboardToolStripMenuItem.Text = "Camera Dashboard";
            // 
            // videoManagementToolStripMenuItem
            // 
            this.videoManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraDashboardToolStripMenuItem,
            this.cameraListToolStripMenuItem});
            this.videoManagementToolStripMenuItem.Name = "videoManagementToolStripMenuItem";
            this.videoManagementToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.videoManagementToolStripMenuItem.Text = "Video Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1051, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "User";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nonBrokenToolStripMenuItem,
            this.brokenToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.registrationToolStripMenuItem.Text = "Needle";
            // 
            // nonBrokenToolStripMenuItem
            // 
            this.nonBrokenToolStripMenuItem.Name = "nonBrokenToolStripMenuItem";
            this.nonBrokenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nonBrokenToolStripMenuItem.Text = "Non-Broken";
            this.nonBrokenToolStripMenuItem.Click += new System.EventHandler(this.nonBrokenToolStripMenuItem_Click);
            // 
            // brokenToolStripMenuItem
            // 
            this.brokenToolStripMenuItem.Name = "brokenToolStripMenuItem";
            this.brokenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brokenToolStripMenuItem.Text = "Broken";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.videoManagementToolStripMenuItem,
            this.faceDatabaseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // garment_mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "garment_mainpage";
            this.Text = "DMA Garment Mainpage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem faceDatabaseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoManagementToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonBrokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brokenToolStripMenuItem;
    }
}