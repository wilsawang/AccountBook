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
            this.SuspendLayout();
            // 
            // btn_account
            // 
            this.btn_account.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_account.Location = new System.Drawing.Point(197, 153);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(150, 50);
            this.btn_account.TabIndex = 0;
            this.btn_account.Text = "我要记账";
            this.btn_account.UseVisualStyleBackColor = true;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_chgpwd
            // 
            this.btn_chgpwd.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_chgpwd.Location = new System.Drawing.Point(197, 236);
            this.btn_chgpwd.Name = "btn_chgpwd";
            this.btn_chgpwd.Size = new System.Drawing.Size(150, 50);
            this.btn_chgpwd.TabIndex = 1;
            this.btn_chgpwd.Text = "修改密码";
            this.btn_chgpwd.UseVisualStyleBackColor = true;
            this.btn_chgpwd.Click += new System.EventHandler(this.btn_chgpwd_Click);
            // 
            // btn_analyze
            // 
            this.btn_analyze.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_analyze.Location = new System.Drawing.Point(440, 236);
            this.btn_analyze.Name = "btn_analyze";
            this.btn_analyze.Size = new System.Drawing.Size(150, 50);
            this.btn_analyze.TabIndex = 2;
            this.btn_analyze.Text = "分  析";
            this.btn_analyze.UseVisualStyleBackColor = true;
            this.btn_analyze.Click += new System.EventHandler(this.btn_analyze_Click);
            // 
            // btn_statistics
            // 
            this.btn_statistics.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_statistics.Location = new System.Drawing.Point(440, 153);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(150, 50);
            this.btn_statistics.TabIndex = 3;
            this.btn_statistics.Text = "统  计";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(319, 321);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(150, 50);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "退出登录";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_statistics);
            this.Controls.Add(this.btn_analyze);
            this.Controls.Add(this.btn_chgpwd);
            this.Controls.Add(this.btn_account);
            this.Name = "Mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainwindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_chgpwd;
        private System.Windows.Forms.Button btn_analyze;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Button btn_exit;
    }
}