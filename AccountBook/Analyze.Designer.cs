namespace AccountBook
{
    partial class Analyze
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cost_7days = new System.Windows.Forms.Button();
            this.cost_1month = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clothing = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.total_out = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.other_out = new System.Windows.Forms.TextBox();
            this.transport = new System.Windows.Forms.TextBox();
            this.housing = new System.Windows.Forms.TextBox();
            this.food = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.total_in = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.other_in = new System.Windows.Forms.TextBox();
            this.school = new System.Windows.Forms.TextBox();
            this.social = new System.Windows.Forms.TextBox();
            this.family = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.income_7days = new System.Windows.Forms.Button();
            this.income_1month = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 13F);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 50);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1020, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "支出";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cost_7days);
            this.groupBox2.Controls.Add(this.cost_1month);
            this.groupBox2.Location = new System.Drawing.Point(56, 347);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(912, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账单分析";
            // 
            // cost_7days
            // 
            this.cost_7days.Font = new System.Drawing.Font("宋体", 12F);
            this.cost_7days.Location = new System.Drawing.Point(186, 50);
            this.cost_7days.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cost_7days.Name = "cost_7days";
            this.cost_7days.Size = new System.Drawing.Size(195, 64);
            this.cost_7days.TabIndex = 1;
            this.cost_7days.Text = "七日支出";
            this.cost_7days.UseVisualStyleBackColor = true;
            this.cost_7days.Click += new System.EventHandler(this.cost_7days_Click);
            // 
            // cost_1month
            // 
            this.cost_1month.Font = new System.Drawing.Font("宋体", 12F);
            this.cost_1month.Location = new System.Drawing.Point(520, 50);
            this.cost_1month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cost_1month.Name = "cost_1month";
            this.cost_1month.Size = new System.Drawing.Size(195, 64);
            this.cost_1month.TabIndex = 2;
            this.cost_1month.Text = "一月支出";
            this.cost_1month.UseVisualStyleBackColor = true;
            this.cost_1month.Click += new System.EventHandler(this.cost_1month_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clothing);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.total_out);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.other_out);
            this.groupBox1.Controls.Add(this.transport);
            this.groupBox1.Controls.Add(this.housing);
            this.groupBox1.Controls.Add(this.food);
            this.groupBox1.Location = new System.Drawing.Point(56, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(912, 293);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账单总览";
            // 
            // clothing
            // 
            this.clothing.BackColor = System.Drawing.SystemColors.Window;
            this.clothing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clothing.Location = new System.Drawing.Point(660, 67);
            this.clothing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clothing.Name = "clothing";
            this.clothing.ReadOnly = true;
            this.clothing.Size = new System.Drawing.Size(150, 40);
            this.clothing.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 35);
            this.label11.TabIndex = 12;
            this.label11.Text = "[衣]支出：";
            // 
            // total_out
            // 
            this.total_out.BackColor = System.Drawing.SystemColors.Window;
            this.total_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_out.Location = new System.Drawing.Point(282, 67);
            this.total_out.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.total_out.Name = "total_out";
            this.total_out.ReadOnly = true;
            this.total_out.Size = new System.Drawing.Size(150, 40);
            this.total_out.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "其他支出：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "[住]支出：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "[行]支出：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "[食]支出：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "本月支出：";
            // 
            // other_out
            // 
            this.other_out.BackColor = System.Drawing.SystemColors.Window;
            this.other_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.other_out.Location = new System.Drawing.Point(660, 219);
            this.other_out.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.other_out.Name = "other_out";
            this.other_out.ReadOnly = true;
            this.other_out.Size = new System.Drawing.Size(150, 40);
            this.other_out.TabIndex = 4;
            // 
            // transport
            // 
            this.transport.BackColor = System.Drawing.SystemColors.Window;
            this.transport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transport.Location = new System.Drawing.Point(282, 219);
            this.transport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transport.Name = "transport";
            this.transport.ReadOnly = true;
            this.transport.Size = new System.Drawing.Size(150, 40);
            this.transport.TabIndex = 3;
            // 
            // housing
            // 
            this.housing.BackColor = System.Drawing.SystemColors.Window;
            this.housing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.housing.Location = new System.Drawing.Point(658, 142);
            this.housing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.housing.Name = "housing";
            this.housing.ReadOnly = true;
            this.housing.Size = new System.Drawing.Size(150, 40);
            this.housing.TabIndex = 2;
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.SystemColors.Window;
            this.food.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.food.Location = new System.Drawing.Point(282, 142);
            this.food.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.food.Name = "food";
            this.food.ReadOnly = true;
            this.food.Size = new System.Drawing.Size(150, 40);
            this.food.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(8, 50);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1020, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "收入";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.total_in);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.other_in);
            this.groupBox3.Controls.Add(this.school);
            this.groupBox3.Controls.Add(this.social);
            this.groupBox3.Controls.Add(this.family);
            this.groupBox3.Location = new System.Drawing.Point(56, 37);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(912, 293);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "账单总览";
            // 
            // total_in
            // 
            this.total_in.BackColor = System.Drawing.SystemColors.Window;
            this.total_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_in.Location = new System.Drawing.Point(290, 67);
            this.total_in.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.total_in.Name = "total_in";
            this.total_in.ReadOnly = true;
            this.total_in.Size = new System.Drawing.Size(150, 40);
            this.total_in.TabIndex = 21;
            this.total_in.Text = "金额";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 35);
            this.label6.TabIndex = 20;
            this.label6.Text = "其他收入：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "社会收入：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 35);
            this.label8.TabIndex = 18;
            this.label8.Text = "学校收入：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 35);
            this.label9.TabIndex = 17;
            this.label9.Text = "家庭收入：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 35);
            this.label10.TabIndex = 16;
            this.label10.Text = "本月收入：";
            // 
            // other_in
            // 
            this.other_in.BackColor = System.Drawing.SystemColors.Window;
            this.other_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.other_in.Location = new System.Drawing.Point(668, 219);
            this.other_in.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.other_in.Name = "other_in";
            this.other_in.ReadOnly = true;
            this.other_in.Size = new System.Drawing.Size(150, 40);
            this.other_in.TabIndex = 15;
            this.other_in.Text = "其他金额";
            // 
            // school
            // 
            this.school.BackColor = System.Drawing.SystemColors.Window;
            this.school.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.school.Location = new System.Drawing.Point(290, 219);
            this.school.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.school.Name = "school";
            this.school.ReadOnly = true;
            this.school.Size = new System.Drawing.Size(150, 40);
            this.school.TabIndex = 14;
            this.school.Text = "学校金";
            // 
            // social
            // 
            this.social.BackColor = System.Drawing.SystemColors.Window;
            this.social.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.social.Location = new System.Drawing.Point(666, 142);
            this.social.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.social.Name = "social";
            this.social.ReadOnly = true;
            this.social.Size = new System.Drawing.Size(150, 40);
            this.social.TabIndex = 13;
            this.social.Text = "社会金额";
            // 
            // family
            // 
            this.family.BackColor = System.Drawing.SystemColors.Window;
            this.family.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.family.Location = new System.Drawing.Point(290, 142);
            this.family.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.family.Name = "family";
            this.family.ReadOnly = true;
            this.family.Size = new System.Drawing.Size(150, 40);
            this.family.TabIndex = 12;
            this.family.Text = "家庭金额";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.income_7days);
            this.groupBox4.Controls.Add(this.income_1month);
            this.groupBox4.Location = new System.Drawing.Point(56, 350);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(912, 149);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "账单分析";
            // 
            // income_7days
            // 
            this.income_7days.Font = new System.Drawing.Font("宋体", 12F);
            this.income_7days.Location = new System.Drawing.Point(189, 51);
            this.income_7days.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.income_7days.Name = "income_7days";
            this.income_7days.Size = new System.Drawing.Size(195, 64);
            this.income_7days.TabIndex = 3;
            this.income_7days.Text = "七日收入";
            this.income_7days.UseVisualStyleBackColor = true;
            this.income_7days.Click += new System.EventHandler(this.income_7days_Click);
            // 
            // income_1month
            // 
            this.income_1month.Font = new System.Drawing.Font("宋体", 12F);
            this.income_1month.Location = new System.Drawing.Point(524, 51);
            this.income_1month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.income_1month.Name = "income_1month";
            this.income_1month.Size = new System.Drawing.Size(195, 64);
            this.income_1month.TabIndex = 4;
            this.income_1month.Text = "一月收入";
            this.income_1month.UseVisualStyleBackColor = true;
            this.income_1month.Click += new System.EventHandler(this.income_1month_Click);
            // 
            // Analyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 592);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Analyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账单分析";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cost_7days;
        private System.Windows.Forms.Button cost_1month;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button income_7days;
        private System.Windows.Forms.Button income_1month;
        private System.Windows.Forms.TextBox other_out;
        private System.Windows.Forms.TextBox transport;
        private System.Windows.Forms.TextBox housing;
        private System.Windows.Forms.TextBox food;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total_out;
        private System.Windows.Forms.TextBox total_in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox other_in;
        private System.Windows.Forms.TextBox school;
        private System.Windows.Forms.TextBox social;
        private System.Windows.Forms.TextBox family;
        private System.Windows.Forms.TextBox clothing;
        private System.Windows.Forms.Label label11;
    }
}