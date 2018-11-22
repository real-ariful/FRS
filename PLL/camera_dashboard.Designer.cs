namespace WindowsFormsApplication3
{
    partial class camera_dashboard
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
            this.stop = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pause = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuRegMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleRegistrationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceDatabaseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentLocationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(676, 27);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(48, 29);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(846, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 287);
            this.dataGridView1.TabIndex = 8;
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(608, 27);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(48, 29);
            this.pause.TabIndex = 9;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(538, 27);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(48, 29);
            this.Play.TabIndex = 12;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.videoManagementToolStripMenuItem,
            this.faceDatabaseManagementToolStripMenuItem,
            this.studentLocationToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stuRegMenu,
            this.vehicleRegistrationMenu,
            this.studentListToolStripMenuItem,
            this.vehicleListToolStripMenuItem,
            this.imageRegistrationToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // stuRegMenu
            // 
            this.stuRegMenu.Name = "stuRegMenu";
            this.stuRegMenu.Size = new System.Drawing.Size(181, 22);
            this.stuRegMenu.Text = "Student Registration";
            this.stuRegMenu.Click += new System.EventHandler(this.stuRegMenu_Click);
            // 
            // vehicleRegistrationMenu
            // 
            this.vehicleRegistrationMenu.Name = "vehicleRegistrationMenu";
            this.vehicleRegistrationMenu.Size = new System.Drawing.Size(181, 22);
            this.vehicleRegistrationMenu.Text = "Vehicle Registration";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentListToolStripMenuItem.Text = "Student List";
            // 
            // vehicleListToolStripMenuItem
            // 
            this.vehicleListToolStripMenuItem.Name = "vehicleListToolStripMenuItem";
            this.vehicleListToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.vehicleListToolStripMenuItem.Text = "Vehicle List";
            // 
            // imageRegistrationToolStripMenuItem
            // 
            this.imageRegistrationToolStripMenuItem.Name = "imageRegistrationToolStripMenuItem";
            this.imageRegistrationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.imageRegistrationToolStripMenuItem.Text = "Image Registration";
            // 
            // videoManagementToolStripMenuItem
            // 
            this.videoManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraDashboardToolStripMenuItem,
            this.cameraListToolStripMenuItem,
            this.studentAttendanceToolStripMenuItem});
            this.videoManagementToolStripMenuItem.Name = "videoManagementToolStripMenuItem";
            this.videoManagementToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.videoManagementToolStripMenuItem.Text = "Video Management";
            // 
            // cameraDashboardToolStripMenuItem
            // 
            this.cameraDashboardToolStripMenuItem.Name = "cameraDashboardToolStripMenuItem";
            this.cameraDashboardToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cameraDashboardToolStripMenuItem.Text = "Camera Dashboard";
            this.cameraDashboardToolStripMenuItem.Click += new System.EventHandler(this.cameraDashboardToolStripMenuItem_Click_1);
            // 
            // cameraListToolStripMenuItem
            // 
            this.cameraListToolStripMenuItem.Name = "cameraListToolStripMenuItem";
            this.cameraListToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cameraListToolStripMenuItem.Text = "Camera List";
            // 
            // studentAttendanceToolStripMenuItem
            // 
            this.studentAttendanceToolStripMenuItem.Name = "studentAttendanceToolStripMenuItem";
            this.studentAttendanceToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.studentAttendanceToolStripMenuItem.Text = "Student Attendance";
            this.studentAttendanceToolStripMenuItem.Click += new System.EventHandler(this.studentAttendanceToolStripMenuItem_Click);
            // 
            // faceDatabaseManagementToolStripMenuItem
            // 
            this.faceDatabaseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseListToolStripMenuItem,
            this.faceMatchToolStripMenuItem});
            this.faceDatabaseManagementToolStripMenuItem.Name = "faceDatabaseManagementToolStripMenuItem";
            this.faceDatabaseManagementToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.faceDatabaseManagementToolStripMenuItem.Text = "Face Database Management";
            // 
            // databaseListToolStripMenuItem
            // 
            this.databaseListToolStripMenuItem.Name = "databaseListToolStripMenuItem";
            this.databaseListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.databaseListToolStripMenuItem.Text = "Database List";
            this.databaseListToolStripMenuItem.Click += new System.EventHandler(this.databaseListToolStripMenuItem_Click);
            // 
            // faceMatchToolStripMenuItem
            // 
            this.faceMatchToolStripMenuItem.Name = "faceMatchToolStripMenuItem";
            this.faceMatchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.faceMatchToolStripMenuItem.Text = "Face Match";
            this.faceMatchToolStripMenuItem.Click += new System.EventHandler(this.faceMatchToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(846, 380);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(261, 287);
            this.dataGridView2.TabIndex = 22;
            // 
            // studentLocationToolStripMenuItem
            // 
            this.studentLocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentLocationToolStripMenuItem1});
            this.studentLocationToolStripMenuItem.Name = "studentLocationToolStripMenuItem";
            this.studentLocationToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentLocationToolStripMenuItem.Text = "Location";
            this.studentLocationToolStripMenuItem.Click += new System.EventHandler(this.studentLocationToolStripMenuItem_Click);
            // 
            // studentLocationToolStripMenuItem1
            // 
            this.studentLocationToolStripMenuItem1.Name = "studentLocationToolStripMenuItem1";
            this.studentLocationToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.studentLocationToolStripMenuItem1.Text = "Student Location";
            this.studentLocationToolStripMenuItem1.Click += new System.EventHandler(this.studentLocationToolStripMenuItem1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(448, 380);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(375, 287);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(20, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(375, 287);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 287);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(448, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 287);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // camera_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 691);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pictureBox2);
            this.Name = "camera_dashboard";
            this.Text = "Camera Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuRegMenu;
        private System.Windows.Forms.ToolStripMenuItem vehicleRegistrationMenu;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceDatabaseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceMatchToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem studentAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentLocationToolStripMenuItem1;
    }
}
