namespace WindowsFormsApplication3
{
    partial class Form4
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
            this.show_employee_table = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_employee_table = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.emp_id = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.show_image = new System.Windows.Forms.Button();
            this.showImageGrid = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showImageGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // show_employee_table
            // 
            this.show_employee_table.Location = new System.Drawing.Point(15, 174);
            this.show_employee_table.Name = "show_employee_table";
            this.show_employee_table.Size = new System.Drawing.Size(187, 28);
            this.show_employee_table.TabIndex = 1;
            this.show_employee_table.Text = "Show Employee Table";
            this.show_employee_table.UseVisualStyleBackColor = true;
            this.show_employee_table.Click += new System.EventHandler(this.show_employee_table_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 95);
            this.dataGridView1.TabIndex = 2;
            // 
            // update_employee_table
            // 
            this.update_employee_table.Location = new System.Drawing.Point(15, 208);
            this.update_employee_table.Name = "update_employee_table";
            this.update_employee_table.Size = new System.Drawing.Size(186, 24);
            this.update_employee_table.TabIndex = 3;
            this.update_employee_table.Text = "Update Employee Table";
            this.update_employee_table.UseVisualStyleBackColor = true;
            this.update_employee_table.Click += new System.EventHandler(this.update_employee_table_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(262, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(386, 95);
            this.dataGridView2.TabIndex = 4;
            // 
            // emp_id
            // 
            this.emp_id.AutoSize = true;
            this.emp_id.Location = new System.Drawing.Point(12, 16);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(41, 13);
            this.emp_id.TabIndex = 5;
            this.emp_id.Text = "emp_id";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(11, 47);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(57, 13);
            this.first_name.TabIndex = 6;
            this.first_name.Text = "First Name";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(11, 78);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(58, 13);
            this.last_name.TabIndex = 7;
            this.last_name.Text = "Last Name";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(12, 104);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(26, 13);
            this.age.TabIndex = 8;
            this.age.Text = "Age";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(14, 137);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(187, 28);
            this.update.TabIndex = 13;
            this.update.Text = "Updatee";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // show_image
            // 
            this.show_image.Location = new System.Drawing.Point(15, 264);
            this.show_image.Name = "show_image";
            this.show_image.Size = new System.Drawing.Size(186, 23);
            this.show_image.TabIndex = 14;
            this.show_image.Text = "Show Image";
            this.show_image.UseVisualStyleBackColor = true;
            this.show_image.Click += new System.EventHandler(this.show_image_Click);
            // 
            // showImageGrid
            // 
            this.showImageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showImageGrid.Location = new System.Drawing.Point(262, 240);
            this.showImageGrid.Name = "showImageGrid";
            this.showImageGrid.Size = new System.Drawing.Size(519, 139);
            this.showImageGrid.TabIndex = 15;
            this.showImageGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showImageGrid_CellContentClick);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(710, 126);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 95);
            this.textBox5.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 375);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.showImageGrid);
            this.Controls.Add(this.show_image);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.emp_id);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.update_employee_table);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.show_employee_table);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showImageGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button show_employee_table;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_employee_table;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label emp_id;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button show_image;
        private System.Windows.Forms.DataGridView showImageGrid;
        private System.Windows.Forms.TextBox textBox5;
    }
}