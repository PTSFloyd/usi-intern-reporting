﻿namespace Database_Entery
{
    partial class AddEmployer
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
            this.Header = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Employer = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.ZIP = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(204, 56);
            this.Header.TabIndex = 0;
            this.Header.Text = "Add Employer";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(475, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Employer
            // 
            this.Employer.AutoSize = true;
            this.Employer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employer.Location = new System.Drawing.Point(37, 88);
            this.Employer.Name = "Employer";
            this.Employer.Size = new System.Drawing.Size(63, 16);
            this.Employer.TabIndex = 20;
            this.Employer.Text = "Employer";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(27, 127);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(75, 16);
            this.Department.TabIndex = 21;
            this.Department.Text = "Department";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(44, 205);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(56, 16);
            this.Address.TabIndex = 22;
            this.Address.Text = "Address";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(69, 166);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(31, 16);
            this.City.TabIndex = 23;
            this.City.Text = "City";
            this.City.Click += new System.EventHandler(this.City_Click);
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(336, 166);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(39, 16);
            this.State.TabIndex = 24;
            this.State.Text = "State";
            // 
            // ZIP
            // 
            this.ZIP.AutoSize = true;
            this.ZIP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZIP.Location = new System.Drawing.Point(444, 166);
            this.ZIP.Name = "ZIP";
            this.ZIP.Size = new System.Drawing.Size(25, 16);
            this.ZIP.TabIndex = 25;
            this.ZIP.Text = "Zip";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(336, 127);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(45, 16);
            this.Phone.TabIndex = 26;
            this.Phone.Text = "Phone";
            this.Phone.Click += new System.EventHandler(this.Phone_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 162);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(213, 20);
            this.textBox6.TabIndex = 51;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(108, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(448, 20);
            this.textBox7.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 53;
            this.button1.Text = "<<< Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(214, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 54;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(113, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 36);
            this.button3.TabIndex = 55;
            this.button3.Text = "Continue >>>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(381, 161);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(47, 21);
            this.comboBox3.TabIndex = 61;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 20);
            this.textBox4.TabIndex = 62;
            // 
            // AddEmployer
            // 
            this.ClientSize = new System.Drawing.Size(754, 522);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.ZIP);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Employer);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Header);
            this.Name = "AddEmployer";
            this.Text = "Internship Report System";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Employer;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label ZIP;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

