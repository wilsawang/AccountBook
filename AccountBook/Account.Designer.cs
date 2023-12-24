namespace AccountBook
{
    partial class Account
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.subsortbox = new System.Windows.Forms.ComboBox();
            this.inbtn = new System.Windows.Forms.Button();
            this.inmoney = new System.Windows.Forms.TextBox();
            this.sortbox = new System.Windows.Forms.ComboBox();
            this.indatetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outbtn = new System.Windows.Forms.Button();
            this.outmoney = new System.Windows.Forms.TextBox();
            this.outsubsortbox = new System.Windows.Forms.ComboBox();
            this.outsortbox = new System.Windows.Forms.ComboBox();
            this.outdatetime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(16, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.subsortbox);
            this.tabPage1.Controls.Add(this.inbtn);
            this.tabPage1.Controls.Add(this.inmoney);
            this.tabPage1.Controls.Add(this.sortbox);
            this.tabPage1.Controls.Add(this.indatetime);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(8, 52);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(989, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "收入";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // subsortbox
            // 
            this.subsortbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subsortbox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.subsortbox.FormattingEnabled = true;
            this.subsortbox.Items.AddRange(new object[] {
            "--请选择--"});
            this.subsortbox.Location = new System.Drawing.Point(511, 205);
            this.subsortbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subsortbox.Name = "subsortbox";
            this.subsortbox.Size = new System.Drawing.Size(184, 36);
            this.subsortbox.TabIndex = 8;
            // 
            // inbtn
            // 
            this.inbtn.Location = new System.Drawing.Point(520, 388);
            this.inbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inbtn.Name = "inbtn";
            this.inbtn.Size = new System.Drawing.Size(176, 68);
            this.inbtn.TabIndex = 7;
            this.inbtn.Text = "确认";
            this.inbtn.UseVisualStyleBackColor = true;
            this.inbtn.Click += new System.EventHandler(this.inbtn_Click);
            // 
            // inmoney
            // 
            this.inmoney.Location = new System.Drawing.Point(316, 297);
            this.inmoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inmoney.Name = "inmoney";
            this.inmoney.Size = new System.Drawing.Size(184, 50);
            this.inmoney.TabIndex = 6;
            this.inmoney.Enter += new System.EventHandler(this.inmoney_Enter);
            this.inmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inmoney_KeyPress);
            this.inmoney.Leave += new System.EventHandler(this.inmoney_Leave);
            // 
            // sortbox
            // 
            this.sortbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortbox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sortbox.FormattingEnabled = true;
            this.sortbox.Items.AddRange(new object[] {
            "--请选择--",
            "家庭",
            "社会",
            "学校",
            "其他"});
            this.sortbox.Location = new System.Drawing.Point(316, 205);
            this.sortbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortbox.Name = "sortbox";
            this.sortbox.Size = new System.Drawing.Size(184, 36);
            this.sortbox.TabIndex = 4;
            this.sortbox.SelectedIndexChanged += new System.EventHandler(this.sortbox_SelectedIndexChanged);
            // 
            // indatetime
            // 
            this.indatetime.CustomFormat = "yyyy-MM-dd";
            this.indatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.indatetime.Location = new System.Drawing.Point(316, 93);
            this.indatetime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.indatetime.Name = "indatetime";
            this.indatetime.Size = new System.Drawing.Size(379, 50);
            this.indatetime.TabIndex = 3;
            this.indatetime.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "金额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "类别：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outbtn);
            this.tabPage2.Controls.Add(this.outmoney);
            this.tabPage2.Controls.Add(this.outsubsortbox);
            this.tabPage2.Controls.Add(this.outsortbox);
            this.tabPage2.Controls.Add(this.outdatetime);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(8, 52);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(989, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "支出";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outbtn
            // 
            this.outbtn.Location = new System.Drawing.Point(520, 388);
            this.outbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outbtn.Name = "outbtn";
            this.outbtn.Size = new System.Drawing.Size(176, 68);
            this.outbtn.TabIndex = 8;
            this.outbtn.Text = "确认";
            this.outbtn.UseVisualStyleBackColor = true;
            this.outbtn.Click += new System.EventHandler(this.outbtn_Click);
            // 
            // outmoney
            // 
            this.outmoney.Location = new System.Drawing.Point(316, 297);
            this.outmoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outmoney.Name = "outmoney";
            this.outmoney.Size = new System.Drawing.Size(184, 50);
            this.outmoney.TabIndex = 7;
            this.outmoney.Enter += new System.EventHandler(this.outmoney_Enter);
            this.outmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outmoney_KeyPress);
            this.outmoney.Leave += new System.EventHandler(this.outmoney_Leave);
            // 
            // outsubsortbox
            // 
            this.outsubsortbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outsubsortbox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outsubsortbox.FormattingEnabled = true;
            this.outsubsortbox.Items.AddRange(new object[] {
            "--请选择--",
            "家庭",
            "社会",
            "学校",
            "其他"});
            this.outsubsortbox.Location = new System.Drawing.Point(511, 205);
            this.outsubsortbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outsubsortbox.Name = "outsubsortbox";
            this.outsubsortbox.Size = new System.Drawing.Size(184, 36);
            this.outsubsortbox.TabIndex = 6;
            // 
            // outsortbox
            // 
            this.outsortbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outsortbox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outsortbox.FormattingEnabled = true;
            this.outsortbox.Items.AddRange(new object[] {
            "--请选择--",
            "衣",
            "食",
            "住",
            "行",
            "其他"});
            this.outsortbox.Location = new System.Drawing.Point(316, 205);
            this.outsortbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outsortbox.Name = "outsortbox";
            this.outsortbox.Size = new System.Drawing.Size(184, 36);
            this.outsortbox.TabIndex = 5;
            this.outsortbox.SelectedIndexChanged += new System.EventHandler(this.outsortbox_SelectedIndexChanged);
            // 
            // outdatetime
            // 
            this.outdatetime.CustomFormat = "yyyy-MM-dd";
            this.outdatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.outdatetime.Location = new System.Drawing.Point(316, 93);
            this.outdatetime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outdatetime.Name = "outdatetime";
            this.outdatetime.Size = new System.Drawing.Size(379, 50);
            this.outdatetime.TabIndex = 4;
            this.outdatetime.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "类别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "日期：";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我要记账";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker indatetime;
        private System.Windows.Forms.ComboBox subsortbox;
        private System.Windows.Forms.Button inbtn;
        private System.Windows.Forms.TextBox inmoney;
        private System.Windows.Forms.ComboBox sortbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button outbtn;
        private System.Windows.Forms.TextBox outmoney;
        private System.Windows.Forms.ComboBox outsubsortbox;
        private System.Windows.Forms.ComboBox outsortbox;
        private System.Windows.Forms.DateTimePicker outdatetime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}