namespace WindowsFormsApplication3
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signin = new System.Windows.Forms.Button();
            this.newuserregister = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.min = new MetroFramework.Controls.MetroButton();
            this.cross = new MetroFramework.Controls.MetroButton();
            this.max = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "School";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "FRS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.signin);
            this.panel1.Controls.Add(this.newuserregister);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(402, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 340);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(54, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Forget Password";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(54, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(54, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 15;
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signin.Location = new System.Drawing.Point(54, 198);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(206, 30);
            this.signin.TabIndex = 12;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // newuserregister
            // 
            this.newuserregister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.newuserregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newuserregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newuserregister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuserregister.Location = new System.Drawing.Point(54, 240);
            this.newuserregister.Name = "newuserregister";
            this.newuserregister.Size = new System.Drawing.Size(206, 30);
            this.newuserregister.TabIndex = 11;
            this.newuserregister.Text = "Register";
            this.newuserregister.UseVisualStyleBackColor = false;
            this.newuserregister.Click += new System.EventHandler(this.newuserregister_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Control;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(81, 139);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(173, 19);
            this.Password.TabIndex = 10;
            this.Password.TabStop = false;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Control;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(81, 95);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(173, 19);
            this.Username.TabIndex = 9;
            this.Username.TabStop = false;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Signin to start your session";
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.minusn;
            this.min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.min.Location = new System.Drawing.Point(1056, 16);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(20, 20);
            this.min.TabIndex = 22;
            this.min.UseSelectable = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // cross
            // 
            this.cross.BackColor = System.Drawing.Color.Transparent;
            this.cross.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.close_circled;
            this.cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cross.Location = new System.Drawing.Point(1102, 16);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(20, 20);
            this.cross.TabIndex = 21;
            this.cross.UseSelectable = true;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.max.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.maxcur;
            this.max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.max.Location = new System.Drawing.Point(1080, 16);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(20, 20);
            this.max.TabIndex = 20;
            this.max.UseSelectable = true;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.ios7_locked;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(53, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 22);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(53, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1134, 691);
            this.Controls.Add(this.min);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.max);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button newuserregister;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroButton max;
        private MetroFramework.Controls.MetroButton cross;
        private MetroFramework.Controls.MetroButton min;
    }
}