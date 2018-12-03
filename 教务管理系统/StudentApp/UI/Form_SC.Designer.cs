namespace StudentApp
{
    partial class Form_SC
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
            this.Scores = new System.Windows.Forms.TextBox();
            this.Sid = new System.Windows.Forms.TextBox();
            this.Val = new System.Windows.Forms.TextBox();
            this.Prop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Select = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.View_SC = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LineNum = new System.Windows.Forms.TextBox();
            this.FirstPage = new System.Windows.Forms.Button();
            this.UpPage = new System.Windows.Forms.Button();
            this.DownPage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_SC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scores
            // 
            this.Scores.Location = new System.Drawing.Point(734, 215);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(131, 25);
            this.Scores.TabIndex = 23;
            // 
            // Sid
            // 
            this.Sid.Location = new System.Drawing.Point(734, 48);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(131, 25);
            this.Sid.TabIndex = 21;
            // 
            // Val
            // 
            this.Val.Location = new System.Drawing.Point(107, 56);
            this.Val.Name = "Val";
            this.Val.Size = new System.Drawing.Size(152, 25);
            this.Val.TabIndex = 7;
            // 
            // Prop
            // 
            this.Prop.FormattingEnabled = true;
            this.Prop.Location = new System.Drawing.Point(107, 24);
            this.Prop.Name = "Prop";
            this.Prop.Size = new System.Drawing.Size(152, 23);
            this.Prop.TabIndex = 6;
            this.Prop.Click += new System.EventHandler(this.Prop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "请输入：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "选择查找类型";
            // 
            // Cid
            // 
            this.Cid.Location = new System.Drawing.Point(734, 135);
            this.Cid.Name = "Cid";
            this.Cid.Size = new System.Drawing.Size(131, 25);
            this.Cid.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Val);
            this.groupBox1.Controls.Add(this.Prop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Select);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Location = new System.Drawing.Point(334, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 184);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找/删除";
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(55, 97);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(152, 38);
            this.Select.TabIndex = 4;
            this.Select.Text = "查找";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(55, 141);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(152, 37);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "分数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "课程号";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(690, 302);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(135, 47);
            this.Insert.TabIndex = 16;
            this.Insert.Text = "添加";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(176, 287);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(120, 47);
            this.Update.TabIndex = 15;
            this.Update.Text = "更改信息";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(30, 287);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(116, 47);
            this.Display.TabIndex = 14;
            this.Display.Text = "显示所有成绩";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // View_SC
            // 
            this.View_SC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_SC.Location = new System.Drawing.Point(30, 32);
            this.View_SC.Name = "View_SC";
            this.View_SC.RowTemplate.Height = 27;
            this.View_SC.Size = new System.Drawing.Size(603, 229);
            this.View_SC.TabIndex = 13;
            this.View_SC.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.View_SC_RowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DownPage);
            this.groupBox2.Controls.Add(this.UpPage);
            this.groupBox2.Controls.Add(this.FirstPage);
            this.groupBox2.Controls.Add(this.LineNum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(30, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 176);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分页显示";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "每页显示的行数";
            // 
            // LineNum
            // 
            this.LineNum.Location = new System.Drawing.Point(131, 35);
            this.LineNum.Name = "LineNum";
            this.LineNum.Size = new System.Drawing.Size(100, 25);
            this.LineNum.TabIndex = 1;
            // 
            // FirstPage
            // 
            this.FirstPage.Location = new System.Drawing.Point(70, 66);
            this.FirstPage.Name = "FirstPage";
            this.FirstPage.Size = new System.Drawing.Size(112, 36);
            this.FirstPage.TabIndex = 2;
            this.FirstPage.Text = "显示第一页";
            this.FirstPage.UseVisualStyleBackColor = true;
            this.FirstPage.Click += new System.EventHandler(this.FirstPage_Click);
            // 
            // UpPage
            // 
            this.UpPage.Location = new System.Drawing.Point(70, 108);
            this.UpPage.Name = "UpPage";
            this.UpPage.Size = new System.Drawing.Size(112, 30);
            this.UpPage.TabIndex = 3;
            this.UpPage.Text = "上一页";
            this.UpPage.UseVisualStyleBackColor = true;
            this.UpPage.Click += new System.EventHandler(this.UpPage_Click);
            // 
            // DownPage
            // 
            this.DownPage.Location = new System.Drawing.Point(71, 144);
            this.DownPage.Name = "DownPage";
            this.DownPage.Size = new System.Drawing.Size(111, 32);
            this.DownPage.TabIndex = 4;
            this.DownPage.Text = "下一页";
            this.DownPage.UseVisualStyleBackColor = true;
            this.DownPage.Click += new System.EventHandler(this.DownPage_Click);
            // 
            // Form_SC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.Sid);
            this.Controls.Add(this.Cid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.View_SC);
            this.Name = "Form_SC";
            this.Text = "Form_SC";
            this.Load += new System.EventHandler(this.Form_SC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_SC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Scores;
        private System.Windows.Forms.TextBox Sid;
        private System.Windows.Forms.TextBox Val;
        private System.Windows.Forms.ComboBox Prop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.DataGridView View_SC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DownPage;
        private System.Windows.Forms.Button UpPage;
        private System.Windows.Forms.Button FirstPage;
        private System.Windows.Forms.TextBox LineNum;
        private System.Windows.Forms.Label label6;
    }
}