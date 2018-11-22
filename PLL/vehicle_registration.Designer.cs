namespace WindowsFormsApplication3
{
    partial class vehicle_registration
    /// <summary>
    /// Required designer variable.
    /// </summary>
    {
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
            this.label1 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vehicle_brand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vehicle_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vehicle_model = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vehicle_color = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.vehicle_owner = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.select_image = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Registration Form";
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(185, 92);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(182, 20);
            this.student_name.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(184, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student ID";
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(588, 92);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(182, 20);
            this.student_id.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vehicle Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vehicle Brand";
            // 
            // vehicle_brand
            // 
            this.vehicle_brand.Location = new System.Drawing.Point(587, 133);
            this.vehicle_brand.Name = "vehicle_brand";
            this.vehicle_brand.Size = new System.Drawing.Size(182, 20);
            this.vehicle_brand.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vehicle Number Plate";
            // 
            // vehicle_no
            // 
            this.vehicle_no.Location = new System.Drawing.Point(587, 226);
            this.vehicle_no.Name = "vehicle_no";
            this.vehicle_no.Size = new System.Drawing.Size(182, 20);
            this.vehicle_no.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vehicle Model";
            // 
            // vehicle_model
            // 
            this.vehicle_model.Location = new System.Drawing.Point(588, 183);
            this.vehicle_model.Name = "vehicle_model";
            this.vehicle_model.Size = new System.Drawing.Size(182, 20);
            this.vehicle_model.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vehicle Color";
            // 
            // vehicle_color
            // 
            this.vehicle_color.Location = new System.Drawing.Point(588, 268);
            this.vehicle_color.Name = "vehicle_color";
            this.vehicle_color.Size = new System.Drawing.Size(182, 20);
            this.vehicle_color.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(465, 320);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Vehicle Owner";
            // 
            // vehicle_owner
            // 
            this.vehicle_owner.Location = new System.Drawing.Point(588, 320);
            this.vehicle_owner.Name = "vehicle_owner";
            this.vehicle_owner.Size = new System.Drawing.Size(182, 20);
            this.vehicle_owner.TabIndex = 33;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(186, 548);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(126, 23);
            this.submit.TabIndex = 35;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(375, 548);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(123, 23);
            this.reset.TabIndex = 36;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // select_image
            // 
            this.select_image.Location = new System.Drawing.Point(186, 307);
            this.select_image.Name = "select_image";
            this.select_image.Size = new System.Drawing.Size(128, 26);
            this.select_image.TabIndex = 37;
            this.select_image.Text = "Select Image";
            this.select_image.UseVisualStyleBackColor = true;
            this.select_image.Click += new System.EventHandler(this.select_image_Click);
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
            this.menuStrip1.TabIndex = 38;
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
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // 
            // cameraListToolStripMenuItem
            // 
            this.cameraListToolStripMenuItem.Name = "cameraListToolStripMenuItem";
            this.cameraListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cameraListToolStripMenuItem.Text = "Camera List";
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
            // vehicle_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 691);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.select_image);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.vehicle_owner);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vehicle_color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vehicle_no);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vehicle_model);
            this.Controls.Add(this.vehicle_brand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label1);
            this.Name = "vehicle_registration";
            this.Text = "student_reg_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox student_name;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox student_id;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox vehicle_brand;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox vehicle_no;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox vehicle_model;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox vehicle_color;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.TextBox vehicle_owner;
    private System.Windows.Forms.Button submit;
    private System.Windows.Forms.Button reset;
    private System.Windows.Forms.Button select_image;
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
    }
}