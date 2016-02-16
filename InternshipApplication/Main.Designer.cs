namespace InternshipApplication
{
    partial class Main
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
            this.btn_NewStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewStudent
            // 
            this.btn_NewStudent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewStudent.Location = new System.Drawing.Point(12, 12);
            this.btn_NewStudent.Name = "btn_NewStudent";
            this.btn_NewStudent.Size = new System.Drawing.Size(130, 30);
            this.btn_NewStudent.TabIndex = 0;
            this.btn_NewStudent.Text = "New Internship";
            this.btn_NewStudent.UseVisualStyleBackColor = true;
            this.btn_NewStudent.Click += new System.EventHandler(this.btn_NewStudent_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit Internship";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_NewStudent);
            this.Name = "Main";
            this.Text = "Internship Report System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewStudent;
        private System.Windows.Forms.Button button1;
    }
}

