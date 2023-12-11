namespace AccountBook
{
    partial class Statistics
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.end_picker = new System.Windows.Forms.DateTimePicker();
            this.start_picker = new System.Windows.Forms.DateTimePicker();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.length_label = new System.Windows.Forms.Label();
            this.end_label = new System.Windows.Forms.Label();
            this.start_label = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日期选择";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("宋体", 13F);
            this.monthCalendar.Location = new System.Drawing.Point(25, 46);
            this.monthCalendar.MaxSelectionCount = 99999;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.TitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.end_picker);
            this.groupBox2.Controls.Add(this.start_picker);
            this.groupBox2.Controls.Add(this.txt_length);
            this.groupBox2.Controls.Add(this.length_label);
            this.groupBox2.Controls.Add(this.end_label);
            this.groupBox2.Controls.Add(this.start_label);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox2.Location = new System.Drawing.Point(516, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细信息";
            // 
            // end_picker
            // 
            this.end_picker.CustomFormat = "yyyy-MM-dd";
            this.end_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_picker.Location = new System.Drawing.Point(195, 115);
            this.end_picker.Name = "end_picker";
            this.end_picker.Size = new System.Drawing.Size(294, 50);
            this.end_picker.TabIndex = 7;
            this.end_picker.Value = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
            this.end_picker.ValueChanged += new System.EventHandler(this.end_text_Changed);
            // 
            // start_picker
            // 
            this.start_picker.CustomFormat = "yyyy-MM-dd";
            this.start_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_picker.Location = new System.Drawing.Point(195, 37);
            this.start_picker.Name = "start_picker";
            this.start_picker.Size = new System.Drawing.Size(294, 50);
            this.start_picker.TabIndex = 6;
            this.start_picker.Value = new System.DateTime(2023, 12, 10, 0, 0, 0, 0);
            this.start_picker.ValueChanged += new System.EventHandler(this.start_text_Changed);
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(195, 199);
            this.txt_length.Name = "txt_length";
            this.txt_length.ReadOnly = true;
            this.txt_length.Size = new System.Drawing.Size(294, 50);
            this.txt_length.TabIndex = 5;
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Location = new System.Drawing.Point(6, 202);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(207, 38);
            this.length_label.TabIndex = 2;
            this.length_label.Text = "时    长：";
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(6, 124);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(207, 38);
            this.end_label.TabIndex = 1;
            this.end_label.Text = "终止日期：";
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(6, 46);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(207, 38);
            this.start_label.TabIndex = 0;
            this.start_label.Text = "起始日期：";
            // 
            // query
            // 
            this.query.Font = new System.Drawing.Font("宋体", 14F);
            this.query.Location = new System.Drawing.Point(594, 367);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(146, 68);
            this.query.TabIndex = 2;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("宋体", 14F);
            this.back.Location = new System.Drawing.Point(805, 367);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(146, 68);
            this.back.TabIndex = 3;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.back);
            this.Controls.Add(this.query);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账目一览";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.DateTimePicker end_picker;
        private System.Windows.Forms.DateTimePicker start_picker;
        private System.Windows.Forms.Button back;
    }
}