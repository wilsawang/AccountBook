namespace AccountBook
{
    partial class Chgpwd
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
            this.back = new System.Windows.Forms.Button();
            this.txt_pre_pwd = new System.Windows.Forms.TextBox();
            this.pre_label = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.txt_pwd_confirm = new System.Windows.Forms.TextBox();
            this.confirm_label = new System.Windows.Forms.Label();
            this.txt_new_pwd = new System.Windows.Forms.TextBox();
            this.new_label = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.uid_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("宋体", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back.Location = new System.Drawing.Point(636, 433);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(141, 67);
            this.back.TabIndex = 42;
            this.back.TabStop = false;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.btn_back_click);
            // 
            // txt_pre_pwd
            // 
            this.txt_pre_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pre_pwd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_pre_pwd.Location = new System.Drawing.Point(407, 167);
            this.txt_pre_pwd.Name = "txt_pre_pwd";
            this.txt_pre_pwd.ReadOnly = true;
            this.txt_pre_pwd.Size = new System.Drawing.Size(397, 43);
            this.txt_pre_pwd.TabIndex = 41;
            this.txt_pre_pwd.TabStop = false;
            // 
            // pre_label
            // 
            this.pre_label.AutoSize = true;
            this.pre_label.Font = new System.Drawing.Font("宋体", 14F);
            this.pre_label.Location = new System.Drawing.Point(194, 168);
            this.pre_label.Name = "pre_label";
            this.pre_label.Size = new System.Drawing.Size(207, 38);
            this.pre_label.TabIndex = 40;
            this.pre_label.Text = "原 密 码：";
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("宋体", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Location = new System.Drawing.Point(279, 433);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(141, 67);
            this.confirm.TabIndex = 39;
            this.confirm.TabStop = false;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.btn_confirm_click);
            // 
            // txt_pwd_confirm
            // 
            this.txt_pwd_confirm.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_pwd_confirm.Location = new System.Drawing.Point(407, 330);
            this.txt_pwd_confirm.MaxLength = 20;
            this.txt_pwd_confirm.Name = "txt_pwd_confirm";
            this.txt_pwd_confirm.Size = new System.Drawing.Size(397, 50);
            this.txt_pwd_confirm.TabIndex = 38;
            this.txt_pwd_confirm.TabStop = false;
            // 
            // confirm_label
            // 
            this.confirm_label.AutoSize = true;
            this.confirm_label.Font = new System.Drawing.Font("宋体", 14F);
            this.confirm_label.Location = new System.Drawing.Point(194, 334);
            this.confirm_label.Name = "confirm_label";
            this.confirm_label.Size = new System.Drawing.Size(207, 38);
            this.confirm_label.TabIndex = 37;
            this.confirm_label.Text = "确认密码：";
            // 
            // txt_new_pwd
            // 
            this.txt_new_pwd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_new_pwd.Location = new System.Drawing.Point(407, 247);
            this.txt_new_pwd.MaxLength = 20;
            this.txt_new_pwd.Name = "txt_new_pwd";
            this.txt_new_pwd.Size = new System.Drawing.Size(397, 50);
            this.txt_new_pwd.TabIndex = 36;
            this.txt_new_pwd.TabStop = false;
            // 
            // new_label
            // 
            this.new_label.AutoSize = true;
            this.new_label.Font = new System.Drawing.Font("宋体", 14F);
            this.new_label.Location = new System.Drawing.Point(194, 251);
            this.new_label.Name = "new_label";
            this.new_label.Size = new System.Drawing.Size(207, 38);
            this.new_label.TabIndex = 35;
            this.new_label.Text = "新 密 码：";
            // 
            // txt_uid
            // 
            this.txt_uid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_uid.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_uid.Location = new System.Drawing.Point(407, 84);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.ReadOnly = true;
            this.txt_uid.Size = new System.Drawing.Size(397, 43);
            this.txt_uid.TabIndex = 34;
            this.txt_uid.TabStop = false;
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.Font = new System.Drawing.Font("宋体", 14F);
            this.uid_label.Location = new System.Drawing.Point(194, 85);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(207, 38);
            this.uid_label.TabIndex = 33;
            this.uid_label.Text = "用 户 名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 7F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(405, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "密码由8-20位长度的数字、字母、特殊符号组成";
            // 
            // Chgpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txt_pre_pwd);
            this.Controls.Add(this.pre_label);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.txt_pwd_confirm);
            this.Controls.Add(this.confirm_label);
            this.Controls.Add(this.txt_new_pwd);
            this.Controls.Add(this.new_label);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.uid_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chgpwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox txt_pre_pwd;
        private System.Windows.Forms.Label pre_label;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox txt_pwd_confirm;
        private System.Windows.Forms.Label confirm_label;
        private System.Windows.Forms.TextBox txt_new_pwd;
        private System.Windows.Forms.Label new_label;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label uid_label;
        private System.Windows.Forms.Label label2;
    }
}