namespace StudentApp.UI
{
    partial class Form_Cour
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
            this.View_Cour = new System.Windows.Forms.DataGridView();
            this.Display = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.TextBox();
            this.Cid = new System.Windows.Forms.TextBox();
            this.Cname = new System.Windows.Forms.TextBox();
            this.Credit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Prop = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.Val = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LineNum = new System.Windows.Forms.TextBox();
            this.FirstPage = new System.Windows.Forms.Button();
            this.UpPage = new System.Windows.Forms.Button();
            this.DownPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_Cour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // View_Cour
            // 
            this.View_Cour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Cour.Location = new System.Drawing.Point(26, 25);
            this.View_Cour.Name = "View_Cour";
            this.View_Cour.RowTemplate.Height = 27;
            this.View_Cour.Size = new System.Drawing.Size(651, 253);
            this.View_Cour.TabIndex = 0;
            this.View_Cour.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_Cour_RowPostPaint);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(26, 300);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(132, 44);
            this.Display.TabIndex = 1;
            this.Display.Text = "显示全部课程";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(199, 300);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(103, 44);
            this.Update.TabIndex = 2;
            this.Update.Text = "更改信息";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(796, 59);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(138, 25);
            this.No.TabIndex = 3;
            // 
            // Cid
            // 
            this.Cid.Location = new System.Drawing.Point(796, 121);
            this.Cid.Name = "Cid";
            this.Cid.Size = new System.Drawing.Size(138, 25);
            this.Cid.TabIndex = 4;
            // 
            // Cname
            // 
            this.Cname.Location = new System.Drawing.Point(796, 187);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(138, 25);
            this.Cname.TabIndex = 5;
            // 
            // Credit
            // 
            this.Credit.Location = new System.Drawing.Point(796, 253);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(138, 25);
            this.Credit.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "课程号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "课程名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "学分";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(736, 330);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(163, 44);
            this.Insert.TabIndex = 11;
            this.Insert.Text = "添加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Prop);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Select);
            this.groupBox1.Controls.Add(this.Val);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(357, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 211);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找/删除";
            // 
            // Prop
            // 
            this.Prop.FormattingEnabled = true;
            this.Prop.Location = new System.Drawing.Point(122, 29);
            this.Prop.Name = "Prop";
            this.Prop.Size = new System.Drawing.Size(149, 23);
            this.Prop.TabIndex = 6;
            this.Prop.Click += new System.EventHandler(this.Prop_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(73, 161);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(156, 32);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(73, 108);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(156, 35);
            this.Select.TabIndex = 4;
            this.Select.Text = "查找";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Val
            // 
            this.Val.Location = new System.Drawing.Point(122, 63);
            this.Val.Name = "Val";
            this.Val.Size = new System.Drawing.Size(149, 25);
            this.Val.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "请输入";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "选择查找方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DownPage);
            this.groupBox2.Controls.Add(this.UpPage);
            this.groupBox2.Controls.Add(this.FirstPage);
            this.groupBox2.Controls.Add(this.LineNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(26, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 193);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分页显示";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "每页显示的行数";
            // 
            // LineNum
            // 
            this.LineNum.Location = new System.Drawing.Point(134, 31);
            this.LineNum.Name = "LineNum";
            this.LineNum.Size = new System.Drawing.Size(100, 25);
            this.LineNum.TabIndex = 1;
            // 
            // FirstPage
            // 
            this.FirstPage.Location = new System.Drawing.Point(52, 66);
            this.FirstPage.Name = "FirstPage";
            this.FirstPage.Size = new System.Drawing.Size(135, 33);
            this.FirstPage.TabIndex = 2;
            this.FirstPage.Text = "显示第一页";
            this.FirstPage.UseVisualStyleBackColor = true;
            this.FirstPage.Click += new System.EventHandler(this.FirstPage_Click);
            // 
            // UpPage
            // 
            this.UpPage.Location = new System.Drawing.Point(52, 110);
            this.UpPage.Name = "UpPage";
            this.UpPage.Size = new System.Drawing.Size(135, 35);
            this.UpPage.TabIndex = 3;
            this.UpPage.Text = "上一页";
            this.UpPage.UseVisualStyleBackColor = true;
            this.UpPage.Click += new System.EventHandler(this.UpPage_Click);
            // 
            // DownPage
            // 
            this.DownPage.Location = new System.Drawing.Point(52, 151);
            this.DownPage.Name = "DownPage";
            this.DownPage.Size = new System.Drawing.Size(135, 31);
            this.DownPage.TabIndex = 4;
            this.DownPage.Text = "下一页";
            this.DownPage.UseVisualStyleBackColor = true;
            this.DownPage.Click += new System.EventHandler(this.DownPage_Click);
            // 
            // Form_Cour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.Cid);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.View_Cour);
            this.Name = "Form_Cour";
            this.Text = "Form_Cour";
            this.Load += new System.EventHandler(this.Form_Cour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Cour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView View_Cour;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox No;
        private System.Windows.Forms.TextBox Cid;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.TextBox Credit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.TextBox Val;
        private System.Windows.Forms.ComboBox Prop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LineNum;
        private System.Windows.Forms.Button DownPage;
        private System.Windows.Forms.Button UpPage;
        private System.Windows.Forms.Button FirstPage;
    }
}