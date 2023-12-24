namespace AccountBook
{
    partial class Mainwindow
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
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_chgpwd = new System.Windows.Forms.Button();
            this.btn_analyze = new System.Windows.Forms.Button();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.welcome_str = new System.Windows.Forms.TextBox();
            this.annual_report = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_account
            // 
            this.btn_account.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_account.Location = new System.Drawing.Point(263, 204);
            this.btn_account.Margin = new System.Windows.Forms.Padding(4);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(200, 67);
            this.btn_account.TabIndex = 0;
            this.btn_account.Text = "我要记账";
            this.btn_account.UseVisualStyleBackColor = true;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_chgpwd
            // 
            this.btn_chgpwd.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_chgpwd.Location = new System.Drawing.Point(263, 315);
            this.btn_chgpwd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chgpwd.Name = "btn_chgpwd";
            this.btn_chgpwd.Size = new System.Drawing.Size(200, 67);
            this.btn_chgpwd.TabIndex = 1;
            this.btn_chgpwd.Text = "修改密码";
            this.btn_chgpwd.UseVisualStyleBackColor = true;
            this.btn_chgpwd.Click += new System.EventHandler(this.btn_chgpwd_Click);
            // 
            // btn_analyze
            // 
            this.btn_analyze.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_analyze.Location = new System.Drawing.Point(587, 315);
            this.btn_analyze.Margin = new System.Windows.Forms.Padding(4);
            this.btn_analyze.Name = "btn_analyze";
            this.btn_analyze.Size = new System.Drawing.Size(200, 67);
            this.btn_analyze.TabIndex = 2;
            this.btn_analyze.Text = "账单分析";
            this.btn_analyze.UseVisualStyleBackColor = true;
            this.btn_analyze.Click += new System.EventHandler(this.btn_analyze_Click);
            // 
            // btn_statistics
            // 
            this.btn_statistics.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_statistics.Location = new System.Drawing.Point(587, 204);
            this.btn_statistics.Margin = new System.Windows.Forms.Padding(4);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(200, 67);
            this.btn_statistics.TabIndex = 3;
            this.btn_statistics.Text = "账目一览";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(425, 428);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(200, 67);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "退出登录";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // welcome_str
            // 
            this.welcome_str.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome_str.Location = new System.Drawing.Point(263, 72);
            this.welcome_str.Margin = new System.Windows.Forms.Padding(4);
            this.welcome_str.Name = "welcome_str";
            this.welcome_str.ReadOnly = true;
            this.welcome_str.Size = new System.Drawing.Size(523, 50);
            this.welcome_str.TabIndex = 5;
            this.welcome_str.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // annual_report
            // 
            this.annual_report.AutoSize = true;
            this.annual_report.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.annual_report.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.annual_report.Location = new System.Drawing.Point(411, 525);
            this.annual_report.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.annual_report.Name = "annual_report";
            this.annual_report.Size = new System.Drawing.Size(236, 28);
            this.annual_report.TabIndex = 6;
            this.annual_report.Text = "点击生成年度报告";
            this.annual_report.Click += new System.EventHandler(this.annual_report_Click);
            // 
            // Mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.annual_report);
            this.Controls.Add(this.welcome_str);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_statistics);
            this.Controls.Add(this.btn_analyze);
            this.Controls.Add(this.btn_chgpwd);
            this.Controls.Add(this.btn_account);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "钱包不空空";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_chgpwd;
        private System.Windows.Forms.Button btn_analyze;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox welcome_str;
        private System.Windows.Forms.Label annual_report;
    }
}