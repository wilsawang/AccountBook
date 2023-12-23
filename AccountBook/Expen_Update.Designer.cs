
namespace AccountBook
{
    partial class Expen_Update
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
            this.subsort_box = new System.Windows.Forms.ComboBox();
            this.inbtn = new System.Windows.Forms.Button();
            this.exmoney = new System.Windows.Forms.TextBox();
            this.sort_box = new System.Windows.Forms.ComboBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.money_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subsort_box
            // 
            this.subsort_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subsort_box.Font = new System.Drawing.Font("宋体", 14F);
            this.subsort_box.FormattingEnabled = true;
            this.subsort_box.Items.AddRange(new object[] {
            "--请选择--"});
            this.subsort_box.Location = new System.Drawing.Point(592, 224);
            this.subsort_box.Margin = new System.Windows.Forms.Padding(4);
            this.subsort_box.Name = "subsort_box";
            this.subsort_box.Size = new System.Drawing.Size(184, 45);
            this.subsort_box.TabIndex = 16;
            // 
            // inbtn
            // 
            this.inbtn.Font = new System.Drawing.Font("宋体", 14F);
            this.inbtn.Location = new System.Drawing.Point(600, 410);
            this.inbtn.Margin = new System.Windows.Forms.Padding(4);
            this.inbtn.Name = "inbtn";
            this.inbtn.Size = new System.Drawing.Size(176, 68);
            this.inbtn.TabIndex = 15;
            this.inbtn.Text = "确认";
            this.inbtn.UseVisualStyleBackColor = true;
            this.inbtn.Click += new System.EventHandler(this.btn_expen_Update);
            // 
            // exmoney
            // 
            this.exmoney.Font = new System.Drawing.Font("宋体", 14F);
            this.exmoney.Location = new System.Drawing.Point(396, 327);
            this.exmoney.Margin = new System.Windows.Forms.Padding(4);
            this.exmoney.Name = "exmoney";
            this.exmoney.Size = new System.Drawing.Size(184, 50);
            this.exmoney.TabIndex = 14;
            // 
            // sort_box
            // 
            this.sort_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort_box.Font = new System.Drawing.Font("宋体", 14F);
            this.sort_box.FormattingEnabled = true;
            this.sort_box.Items.AddRange(new object[] {
            "--请选择--",
            "衣",
            "食",
            "住",
            "行",
            "其他"});
            this.sort_box.Location = new System.Drawing.Point(396, 224);
            this.sort_box.Margin = new System.Windows.Forms.Padding(4);
            this.sort_box.Name = "sort_box";
            this.sort_box.Size = new System.Drawing.Size(184, 45);
            this.sort_box.TabIndex = 13;
            this.sort_box.SelectedIndexChanged += new System.EventHandler(this.sortbox_SelectedChanged);
            // 
            // date_picker
            // 
            this.date_picker.CustomFormat = "yyyy-MM-dd";
            this.date_picker.Font = new System.Drawing.Font("宋体", 14F);
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(396, 115);
            this.date_picker.Margin = new System.Windows.Forms.Padding(4);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(379, 50);
            this.date_picker.TabIndex = 12;
            this.date_picker.Value = new System.DateTime(2023, 12, 23, 0, 0, 0, 0);
            // 
            // money_label
            // 
            this.money_label.AutoSize = true;
            this.money_label.Font = new System.Drawing.Font("宋体", 14F);
            this.money_label.Location = new System.Drawing.Point(242, 330);
            this.money_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.money_label.Name = "money_label";
            this.money_label.Size = new System.Drawing.Size(131, 38);
            this.money_label.TabIndex = 11;
            this.money_label.Text = "金额：";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("宋体", 14F);
            this.date_label.Location = new System.Drawing.Point(242, 124);
            this.date_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(131, 38);
            this.date_label.TabIndex = 9;
            this.date_label.Text = "日期：";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("宋体", 14F);
            this.type_label.Location = new System.Drawing.Point(242, 227);
            this.type_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(131, 38);
            this.type_label.TabIndex = 10;
            this.type_label.Text = "类别：";
            // 
            // Expen_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.subsort_box);
            this.Controls.Add(this.inbtn);
            this.Controls.Add(this.exmoney);
            this.Controls.Add(this.sort_box);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.money_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.type_label);
            this.Name = "Expen_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支出账单修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subsort_box;
        private System.Windows.Forms.Button inbtn;
        private System.Windows.Forms.TextBox exmoney;
        private System.Windows.Forms.ComboBox sort_box;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Label money_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label type_label;
    }
}