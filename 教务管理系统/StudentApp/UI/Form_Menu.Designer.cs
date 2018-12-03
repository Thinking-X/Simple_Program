namespace StudentApp
{
    partial class Form_Menu
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
            this.Student = new System.Windows.Forms.Button();
            this.Course = new System.Windows.Forms.Button();
            this.SC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(74, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择要操作的表：";
            // 
            // Student
            // 
            this.Student.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Student.Location = new System.Drawing.Point(79, 164);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(182, 83);
            this.Student.TabIndex = 1;
            this.Student.Text = "学生信息表";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Course
            // 
            this.Course.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Course.Location = new System.Drawing.Point(302, 164);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(182, 83);
            this.Course.TabIndex = 2;
            this.Course.Text = "课程信息表";
            this.Course.UseVisualStyleBackColor = true;
            this.Course.Click += new System.EventHandler(this.Course_Click);
            // 
            // SC
            // 
            this.SC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SC.Location = new System.Drawing.Point(526, 164);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(172, 83);
            this.SC.TabIndex = 3;
            this.SC.Text = "成绩信息表";
            this.SC.UseVisualStyleBackColor = true;
            this.SC.Click += new System.EventHandler(this.SC_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 471);
            this.Controls.Add(this.SC);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.label1);
            this.Name = "Form_Menu";
            this.Text = "Form_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Course;
        private System.Windows.Forms.Button SC;
    }
}