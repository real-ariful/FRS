namespace WindowsFormsApplication3
{
    partial class register
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.faceDatabaseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reset = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.email_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.vehicleRegistrationMenu.Click += new System.EventHandler(this.vehicleRegistrationMenu_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // vehicleListToolStripMenuItem
            // 
            this.vehicleListToolStripMenuItem.Name = "vehicleListToolStripMenuItem";
            this.vehicleListToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.vehicleListToolStripMenuItem.Text = "Vehicle List";
            this.vehicleListToolStripMenuItem.Click += new System.EventHandler(this.vehicleListToolStripMenuItem_Click);
            // 
            // imageRegistrationToolStripMenuItem
            // 
            this.imageRegistrationToolStripMenuItem.Name = "imageRegistrationToolStripMenuItem";
            this.imageRegistrationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.imageRegistrationToolStripMenuItem.Text = "Image Registration";
            this.imageRegistrationToolStripMenuItem.Click += new System.EventHandler(this.imageRegistrationToolStripMenuItem_Click);
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
            // cameraDashboardToolStripMenuItem
            // 
            this.cameraDashboardToolStripMenuItem.Name = "cameraDashboardToolStripMenuItem";
            this.cameraDashboardToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cameraDashboardToolStripMenuItem.Text = "Camera Dashboard";
            this.cameraDashboardToolStripMenuItem.Click += new System.EventHandler(this.cameraDashboardToolStripMenuItem_Click);
            // 
            // cameraListToolStripMenuItem
            // 
            this.cameraListToolStripMenuItem.Name = "cameraListToolStripMenuItem";
            this.cameraListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cameraListToolStripMenuItem.Text = "Camera List";
            this.cameraListToolStripMenuItem.Click += new System.EventHandler(this.cameraListToolStripMenuItem_Click);
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
            this.databaseListToolStripMenuItem.Click += new System.EventHandler(this.databaseListToolStripMenuItem_Click);
            // 
            // faceMatchToolStripMenuItem
            // 
            this.faceMatchToolStripMenuItem.Name = "faceMatchToolStripMenuItem";
            this.faceMatchToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.faceMatchToolStripMenuItem.Text = "Face Match";
            this.faceMatchToolStripMenuItem.Click += new System.EventHandler(this.faceMatchToolStripMenuItem_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(572, 496);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(123, 23);
            this.reset.TabIndex = 62;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(383, 496);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(126, 23);
            this.submit.TabIndex = 61;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Phone Number";
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(513, 373);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(182, 20);
            this.phone_number.TabIndex = 55;
            // 
            // email_address
            // 
            this.email_address.Location = new System.Drawing.Point(513, 317);
            this.email_address.Name = "email_address";
            this.email_address.Size = new System.Drawing.Size(182, 20);
            this.email_address.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Full Name";
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(513, 203);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(182, 20);
            this.fullname.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "User Name";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(513, 154);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(182, 20);
            this.username.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "New User Registration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(526, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(513, 430);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(182, 20);
            this.password.TabIndex = 64;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(513, 260);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(182, 20);
            this.address.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Address";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 691);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.email_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "register";
            this.Text = "Register New User";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox email_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label6;
    }
}