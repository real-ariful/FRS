﻿namespace WindowsFormsApplication3
{
    partial class student_attendance
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
            this.label6 = new System.Windows.Forms.Label();
            this.studentAttGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.videoManagementToolStripMenuItem,
            this.faceDatabaseManagementToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip2.TabIndex = 22;
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
            this.databaseListToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.databaseListToolStripMenuItem.Text = "Database List";
            // 
            // faceMatchToolStripMenuItem
            // 
            this.faceMatchToolStripMenuItem.Name = "faceMatchToolStripMenuItem";
            this.faceMatchToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.faceMatchToolStripMenuItem.Text = "Face Match";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Student Attendance";
            // 
            // studentAttGrid
            // 
            this.studentAttGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentAttGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentAttGrid.Location = new System.Drawing.Point(51, 56);
            this.studentAttGrid.Name = "studentAttGrid";
            this.studentAttGrid.Size = new System.Drawing.Size(1030, 600);
            this.studentAttGrid.TabIndex = 24;
            // 
            // student_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 691);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentAttGrid);
            this.Controls.Add(this.menuStrip2);
            this.Name = "student_attendance";
            this.Text = "student_attendance";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripMenuItem studentAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceDatabaseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceMatchToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView studentAttGrid;
    }
}