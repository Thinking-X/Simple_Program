namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textpassword_ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_X = new System.Windows.Forms.RadioButton();
            this.radio_Y = new System.Windows.Forms.RadioButton();
            this.dTP_birthday = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.comboList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.move = new System.Windows.Forms.Button();
            this.moveAll = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(110, 22);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(159, 25);
            this.textID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(110, 66);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(159, 25);
            this.textpassword.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "确认密码";
            // 
            // textpassword_
            // 
            this.textpassword_.Location = new System.Drawing.Point(110, 113);
            this.textpassword_.Name = "textpassword_";
            this.textpassword_.Size = new System.Drawing.Size(158, 25);
            this.textpassword_.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "生日";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(110, 151);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(159, 25);
            this.textTel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "手机号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "密码";
            // 
            // textDisplay
            // 
            this.textDisplay.Location = new System.Drawing.Point(498, 316);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(315, 233);
            this.textDisplay.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "显示所有";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 31);
            this.button3.TabIndex = 19;
            this.button3.Text = "显示最新用户";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(357, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 49);
            this.button4.TabIndex = 20;
            this.button4.Text = "打开文件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "性别";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_X);
            this.groupBox1.Controls.Add(this.radio_Y);
            this.groupBox1.Location = new System.Drawing.Point(110, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 57);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // radio_X
            // 
            this.radio_X.AutoSize = true;
            this.radio_X.Location = new System.Drawing.Point(97, 21);
            this.radio_X.Name = "radio_X";
            this.radio_X.Size = new System.Drawing.Size(43, 19);
            this.radio_X.TabIndex = 22;
            this.radio_X.TabStop = true;
            this.radio_X.Text = "女";
            this.radio_X.UseVisualStyleBackColor = true;
            // 
            // radio_Y
            // 
            this.radio_Y.AutoSize = true;
            this.radio_Y.Location = new System.Drawing.Point(26, 21);
            this.radio_Y.Name = "radio_Y";
            this.radio_Y.Size = new System.Drawing.Size(43, 19);
            this.radio_Y.TabIndex = 21;
            this.radio_Y.TabStop = true;
            this.radio_Y.Text = "男";
            this.radio_Y.UseVisualStyleBackColor = true;
            // 
            // dTP_birthday
            // 
            this.dTP_birthday.Location = new System.Drawing.Point(110, 197);
            this.dTP_birthday.Name = "dTP_birthday";
            this.dTP_birthday.Size = new System.Drawing.Size(159, 25);
            this.dTP_birthday.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 471);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 31);
            this.button5.TabIndex = 27;
            this.button5.Text = "显示上一用户";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 518);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 31);
            this.button6.TabIndex = 28;
            this.button6.Text = "显示下一用户";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 230);
            this.dataGridView1.TabIndex = 29;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(357, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 36);
            this.button7.TabIndex = 30;
            this.button7.Text = "显示性别";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboList
            // 
            this.comboList.FormattingEnabled = true;
            this.comboList.Location = new System.Drawing.Point(110, 380);
            this.comboList.Name = "comboList";
            this.comboList.Size = new System.Drawing.Size(159, 23);
            this.comboList.TabIndex = 31;
            this.comboList.TextChanged += new System.EventHandler(this.comboList_TextChanged);
            this.comboList.Click += new System.EventHandler(this.comboList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "ID列表";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.listBox1.Location = new System.Drawing.Point(856, 316);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(83, 229);
            this.listBox1.TabIndex = 34;
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(964, 350);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(85, 26);
            this.move.TabIndex = 35;
            this.move.Text = ">";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // moveAll
            // 
            this.moveAll.Location = new System.Drawing.Point(964, 397);
            this.moveAll.Name = "moveAll";
            this.moveAll.Size = new System.Drawing.Size(85, 25);
            this.moveAll.TabIndex = 36;
            this.moveAll.Text = ">>";
            this.moveAll.UseVisualStyleBackColor = true;
            this.moveAll.Click += new System.EventHandler(this.moveAll_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(964, 442);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(85, 30);
            this.clear.TabIndex = 37;
            this.clear.Text = "清除当前";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(964, 487);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(85, 33);
            this.clearAll.TabIndex = 38;
            this.clearAll.Text = "清除所有";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(1075, 316);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(82, 229);
            this.listBox2.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 577);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.moveAll);
            this.Controls.Add(this.move);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboList);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dTP_birthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textpassword_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpassword_;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_X;
        private System.Windows.Forms.RadioButton radio_Y;
        private System.Windows.Forms.DateTimePicker dTP_birthday;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button moveAll;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.ListBox listBox2;
    }
}

