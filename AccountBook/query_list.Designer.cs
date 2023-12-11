
namespace AccountBook
{
    partial class query_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.expen_list = new System.Windows.Forms.DataGridView();
            this.expen_query = new System.Windows.Forms.Button();
            this.expen_box2 = new System.Windows.Forms.ComboBox();
            this.expen_box1 = new System.Windows.Forms.ComboBox();
            this.type_label1 = new System.Windows.Forms.Label();
            this.txt_end1 = new System.Windows.Forms.TextBox();
            this.end_label1 = new System.Windows.Forms.Label();
            this.txt_start1 = new System.Windows.Forms.TextBox();
            this.start_label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.income_list = new System.Windows.Forms.DataGridView();
            this.income_query = new System.Windows.Forms.Button();
            this.income_box2 = new System.Windows.Forms.ComboBox();
            this.income_box1 = new System.Windows.Forms.ComboBox();
            this.type_label2 = new System.Windows.Forms.Label();
            this.txt_end2 = new System.Windows.Forms.TextBox();
            this.end_label2 = new System.Windows.Forms.Label();
            this.txt_start2 = new System.Windows.Forms.TextBox();
            this.start_label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expen_list)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.income_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("宋体", 14F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1283, 787);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.expen_list);
            this.tabPage1.Controls.Add(this.expen_query);
            this.tabPage1.Controls.Add(this.expen_box2);
            this.tabPage1.Controls.Add(this.expen_box1);
            this.tabPage1.Controls.Add(this.type_label1);
            this.tabPage1.Controls.Add(this.txt_end1);
            this.tabPage1.Controls.Add(this.end_label1);
            this.tabPage1.Controls.Add(this.txt_start1);
            this.tabPage1.Controls.Add(this.start_label1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 14F);
            this.tabPage1.Location = new System.Drawing.Point(8, 52);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1267, 727);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " 支出一览 ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // expen_list
            // 
            this.expen_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.expen_list.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expen_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.expen_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expen_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.expen_list.Location = new System.Drawing.Point(36, 139);
            this.expen_list.Name = "expen_list";
            this.expen_list.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expen_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.expen_list.RowHeadersWidth = 82;
            this.expen_list.RowTemplate.Height = 37;
            this.expen_list.Size = new System.Drawing.Size(1188, 555);
            this.expen_list.TabIndex = 13;
            this.expen_list.TabStop = false;
            // 
            // expen_query
            // 
            this.expen_query.Location = new System.Drawing.Point(1084, 35);
            this.expen_query.Name = "expen_query";
            this.expen_query.Size = new System.Drawing.Size(146, 68);
            this.expen_query.TabIndex = 12;
            this.expen_query.Text = "查询";
            this.expen_query.UseVisualStyleBackColor = true;
            this.expen_query.Click += new System.EventHandler(this.btn_expen_Query);
            // 
            // expen_box2
            // 
            this.expen_box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expen_box2.FormattingEnabled = true;
            this.expen_box2.Items.AddRange(new object[] {
            "全部"});
            this.expen_box2.Location = new System.Drawing.Point(911, 48);
            this.expen_box2.Name = "expen_box2";
            this.expen_box2.Size = new System.Drawing.Size(140, 45);
            this.expen_box2.TabIndex = 11;
            // 
            // expen_box1
            // 
            this.expen_box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expen_box1.FormattingEnabled = true;
            this.expen_box1.Items.AddRange(new object[] {
            "全部",
            "衣",
            "食",
            "住",
            "行",
            "其他"});
            this.expen_box1.Location = new System.Drawing.Point(753, 48);
            this.expen_box1.Name = "expen_box1";
            this.expen_box1.Size = new System.Drawing.Size(140, 45);
            this.expen_box1.TabIndex = 10;
            this.expen_box1.SelectedIndexChanged += new System.EventHandler(this.expenbox_SelectedChanged);
            // 
            // type_label1
            // 
            this.type_label1.AutoSize = true;
            this.type_label1.Font = new System.Drawing.Font("宋体", 14F);
            this.type_label1.Location = new System.Drawing.Point(554, 51);
            this.type_label1.Name = "type_label1";
            this.type_label1.Size = new System.Drawing.Size(207, 38);
            this.type_label1.TabIndex = 9;
            this.type_label1.Text = "支出类别：";
            // 
            // txt_end1
            // 
            this.txt_end1.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_end1.Location = new System.Drawing.Point(225, 74);
            this.txt_end1.Name = "txt_end1";
            this.txt_end1.ReadOnly = true;
            this.txt_end1.Size = new System.Drawing.Size(294, 50);
            this.txt_end1.TabIndex = 8;
            // 
            // end_label1
            // 
            this.end_label1.AutoSize = true;
            this.end_label1.Font = new System.Drawing.Font("宋体", 14F);
            this.end_label1.Location = new System.Drawing.Point(29, 77);
            this.end_label1.Name = "end_label1";
            this.end_label1.Size = new System.Drawing.Size(207, 38);
            this.end_label1.TabIndex = 7;
            this.end_label1.Text = "终止日期：";
            // 
            // txt_start1
            // 
            this.txt_start1.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_start1.Location = new System.Drawing.Point(225, 18);
            this.txt_start1.Name = "txt_start1";
            this.txt_start1.ReadOnly = true;
            this.txt_start1.Size = new System.Drawing.Size(294, 50);
            this.txt_start1.TabIndex = 6;
            // 
            // start_label1
            // 
            this.start_label1.AutoSize = true;
            this.start_label1.Font = new System.Drawing.Font("宋体", 14F);
            this.start_label1.Location = new System.Drawing.Point(29, 21);
            this.start_label1.Name = "start_label1";
            this.start_label1.Size = new System.Drawing.Size(207, 38);
            this.start_label1.TabIndex = 5;
            this.start_label1.Text = "起始日期：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.income_list);
            this.tabPage2.Controls.Add(this.income_query);
            this.tabPage2.Controls.Add(this.income_box2);
            this.tabPage2.Controls.Add(this.income_box1);
            this.tabPage2.Controls.Add(this.type_label2);
            this.tabPage2.Controls.Add(this.txt_end2);
            this.tabPage2.Controls.Add(this.end_label2);
            this.tabPage2.Controls.Add(this.txt_start2);
            this.tabPage2.Controls.Add(this.start_label2);
            this.tabPage2.Font = new System.Drawing.Font("宋体", 14F);
            this.tabPage2.Location = new System.Drawing.Point(8, 52);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1267, 727);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " 收入一览 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // income_list
            // 
            this.income_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.income_list.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.income_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.income_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.income_list.DefaultCellStyle = dataGridViewCellStyle5;
            this.income_list.Location = new System.Drawing.Point(36, 139);
            this.income_list.Name = "income_list";
            this.income_list.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.income_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.income_list.RowHeadersWidth = 82;
            this.income_list.RowTemplate.Height = 37;
            this.income_list.Size = new System.Drawing.Size(1188, 555);
            this.income_list.TabIndex = 21;
            this.income_list.TabStop = false;
            // 
            // income_query
            // 
            this.income_query.Location = new System.Drawing.Point(1084, 35);
            this.income_query.Name = "income_query";
            this.income_query.Size = new System.Drawing.Size(146, 68);
            this.income_query.TabIndex = 20;
            this.income_query.Text = "查询";
            this.income_query.UseVisualStyleBackColor = true;
            this.income_query.Click += new System.EventHandler(this.btn_income_Query);
            // 
            // income_box2
            // 
            this.income_box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.income_box2.FormattingEnabled = true;
            this.income_box2.Location = new System.Drawing.Point(911, 48);
            this.income_box2.Name = "income_box2";
            this.income_box2.Size = new System.Drawing.Size(140, 45);
            this.income_box2.TabIndex = 19;
            // 
            // income_box1
            // 
            this.income_box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.income_box1.FormattingEnabled = true;
            this.income_box1.Items.AddRange(new object[] {
            "全部",
            "家庭",
            "社会",
            "学校",
            "其他"});
            this.income_box1.Location = new System.Drawing.Point(753, 48);
            this.income_box1.Name = "income_box1";
            this.income_box1.Size = new System.Drawing.Size(140, 45);
            this.income_box1.TabIndex = 18;
            this.income_box1.SelectedIndexChanged += new System.EventHandler(this.incomebox_SelectedChanged);
            // 
            // type_label2
            // 
            this.type_label2.AutoSize = true;
            this.type_label2.Font = new System.Drawing.Font("宋体", 14F);
            this.type_label2.Location = new System.Drawing.Point(554, 51);
            this.type_label2.Name = "type_label2";
            this.type_label2.Size = new System.Drawing.Size(207, 38);
            this.type_label2.TabIndex = 17;
            this.type_label2.Text = "收入类别：";
            // 
            // txt_end2
            // 
            this.txt_end2.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_end2.Location = new System.Drawing.Point(225, 74);
            this.txt_end2.Name = "txt_end2";
            this.txt_end2.ReadOnly = true;
            this.txt_end2.Size = new System.Drawing.Size(294, 50);
            this.txt_end2.TabIndex = 16;
            // 
            // end_label2
            // 
            this.end_label2.AutoSize = true;
            this.end_label2.Font = new System.Drawing.Font("宋体", 14F);
            this.end_label2.Location = new System.Drawing.Point(29, 77);
            this.end_label2.Name = "end_label2";
            this.end_label2.Size = new System.Drawing.Size(207, 38);
            this.end_label2.TabIndex = 15;
            this.end_label2.Text = "终止日期：";
            // 
            // txt_start2
            // 
            this.txt_start2.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_start2.Location = new System.Drawing.Point(225, 18);
            this.txt_start2.Name = "txt_start2";
            this.txt_start2.ReadOnly = true;
            this.txt_start2.Size = new System.Drawing.Size(294, 50);
            this.txt_start2.TabIndex = 14;
            // 
            // start_label2
            // 
            this.start_label2.AutoSize = true;
            this.start_label2.Font = new System.Drawing.Font("宋体", 14F);
            this.start_label2.Location = new System.Drawing.Point(29, 21);
            this.start_label2.Name = "start_label2";
            this.start_label2.Size = new System.Drawing.Size(207, 38);
            this.start_label2.TabIndex = 13;
            this.start_label2.Text = "起始日期：";
            // 
            // query_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 779);
            this.Controls.Add(this.tabControl);
            this.Name = "query_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支出一览";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expen_list)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.income_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button expen_query;
        private System.Windows.Forms.ComboBox expen_box2;
        private System.Windows.Forms.ComboBox expen_box1;
        private System.Windows.Forms.Label type_label1;
        private System.Windows.Forms.TextBox txt_end1;
        private System.Windows.Forms.Label end_label1;
        private System.Windows.Forms.TextBox txt_start1;
        private System.Windows.Forms.Label start_label1;
        private System.Windows.Forms.Button income_query;
        private System.Windows.Forms.ComboBox income_box2;
        private System.Windows.Forms.ComboBox income_box1;
        private System.Windows.Forms.Label type_label2;
        private System.Windows.Forms.TextBox txt_end2;
        private System.Windows.Forms.Label end_label2;
        private System.Windows.Forms.TextBox txt_start2;
        private System.Windows.Forms.Label start_label2;
        private System.Windows.Forms.DataGridView expen_list;
        private System.Windows.Forms.DataGridView income_list;
    }
}