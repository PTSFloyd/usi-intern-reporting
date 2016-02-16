namespace InternshipApplication
{
    partial class StudentSearch
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
            this.txt_SearchByStudentID = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.lbl_StudentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_SearchByStudentID
            // 
            this.txt_SearchByStudentID.Location = new System.Drawing.Point(154, 12);
            this.txt_SearchByStudentID.Name = "txt_SearchByStudentID";
            this.txt_SearchByStudentID.Size = new System.Drawing.Size(117, 20);
            this.txt_SearchByStudentID.TabIndex = 1;
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Location = new System.Drawing.Point(70, 43);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(130, 30);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            // 
            // lbl_StudentID
            // 
            this.lbl_StudentID.AutoSize = true;
            this.lbl_StudentID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentID.Location = new System.Drawing.Point(12, 14);
            this.lbl_StudentID.Name = "lbl_StudentID";
            this.lbl_StudentID.Size = new System.Drawing.Size(136, 16);
            this.lbl_StudentID.TabIndex = 4;
            this.lbl_StudentID.Text = "Search by Student ID:";
            // 
            // StudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 85);
            this.Controls.Add(this.lbl_StudentID);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_SearchByStudentID);
            this.Name = "StudentSearch";
            this.Text = "Internship Report System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_SearchByStudentID;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lbl_StudentID;
    }
}