
namespace AccountBook
{
    partial class Register
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
            this.code_pic = new System.Windows.Forms.PictureBox();
            this.return_1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.code_label = new System.Windows.Forms.Label();
            this.txt_upwd = new System.Windows.Forms.TextBox();
            this.psd_label = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.uid_label = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.conf_psd_label = new System.Windows.Forms.Label();
            this.txt_psd = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.code_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // code_pic
            // 
            this.code_pic.Location = new System.Drawing.Point(664, 464);
            this.code_pic.Margin = new System.Windows.Forms.Padding(0);
            this.code_pic.Name = "code_pic";
            this.code_pic.Size = new System.Drawing.Size(160, 51);
            this.code_pic.TabIndex = 30;
            this.code_pic.TabStop = false;
            this.code_pic.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // return_1
            // 
            this.return_1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.return_1.Location = new System.Drawing.Point(665, 550);
            this.return_1.Name = "return_1";
            this.return_1.Size = new System.Drawing.Size(160, 69);
            this.return_1.TabIndex = 29;
            this.return_1.TabStop = false;
            this.return_1.Text = "返回";
            this.return_1.UseVisualStyleBackColor = true;
            this.return_1.Click += new System.EventHandler(this.btn_back_click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(277, 550);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(160, 69);
            this.login.TabIndex = 28;
            this.login.TabStop = false;
            this.login.Text = "注册";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.btn_click);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_code.Location = new System.Drawing.Point(385, 465);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(255, 50);
            this.txt_code.TabIndex = 27;
            this.txt_code.TabStop = false;
            this.txt_code.GotFocus += new System.EventHandler(this.code_gotfocus);
            this.txt_code.LostFocus += new System.EventHandler(this.code_lostfocus);
            // 
            // code_label
            // 
            this.code_label.AutoSize = true;
            this.code_label.Font = new System.Drawing.Font("宋体", 14F);
            this.code_label.Location = new System.Drawing.Point(172, 469);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(207, 38);
            this.code_label.TabIndex = 26;
            this.code_label.Text = "验 证 码：";
            // 
            // txt_upwd
            // 
            this.txt_upwd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_upwd.Location = new System.Drawing.Point(385, 285);
            this.txt_upwd.MaxLength = 20;
            this.txt_upwd.Name = "txt_upwd";
            this.txt_upwd.PasswordChar = '*';
            this.txt_upwd.Size = new System.Drawing.Size(439, 50);
            this.txt_upwd.TabIndex = 25;
            this.txt_upwd.TabStop = false;
            this.txt_upwd.UseSystemPasswordChar = true;
            // 
            // psd_label
            // 
            this.psd_label.AutoSize = true;
            this.psd_label.Font = new System.Drawing.Font("宋体", 14F);
            this.psd_label.Location = new System.Drawing.Point(172, 289);
            this.psd_label.Name = "psd_label";
            this.psd_label.Size = new System.Drawing.Size(207, 38);
            this.psd_label.TabIndex = 24;
            this.psd_label.Text = "密    码：";
            // 
            // txt_uid
            // 
            this.txt_uid.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_uid.Location = new System.Drawing.Point(385, 202);
            this.txt_uid.MaxLength = 10;
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(439, 50);
            this.txt_uid.TabIndex = 23;
            this.txt_uid.TabStop = false;
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.Font = new System.Drawing.Font("宋体", 14F);
            this.uid_label.Location = new System.Drawing.Point(172, 206);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(207, 38);
            this.uid_label.TabIndex = 22;
            this.uid_label.Text = "用 户 名：";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(417, 116);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(191, 43);
            this.title.TabIndex = 21;
            this.title.Text = "用户注册";
            // 
            // conf_psd_label
            // 
            this.conf_psd_label.AutoSize = true;
            this.conf_psd_label.Font = new System.Drawing.Font("宋体", 14F);
            this.conf_psd_label.Location = new System.Drawing.Point(172, 378);
            this.conf_psd_label.Name = "conf_psd_label";
            this.conf_psd_label.Size = new System.Drawing.Size(207, 38);
            this.conf_psd_label.TabIndex = 31;
            this.conf_psd_label.Text = "确认密码：";
            // 
            // txt_psd
            // 
            this.txt_psd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_psd.Location = new System.Drawing.Point(385, 374);
            this.txt_psd.Name = "txt_psd";
            this.txt_psd.PasswordChar = '*';
            this.txt_psd.Size = new System.Drawing.Size(439, 50);
            this.txt_psd.TabIndex = 32;
            this.txt_psd.TabStop = false;
            this.txt_psd.UseSystemPasswordChar = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("新宋体", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox.Location = new System.Drawing.Point(846, 385);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(156, 31);
            this.checkBox.TabIndex = 33;
            this.checkBox.Text = "显示密码";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.btn_change_psd);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(389, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "用户名不能超过10个字符";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(389, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "密码由8-20位长度的数字、字母、特殊符号组成";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 725);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.txt_psd);
            this.Controls.Add(this.conf_psd_label);
            this.Controls.Add(this.code_pic);
            this.Controls.Add(this.return_1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.code_label);
            this.Controls.Add(this.txt_upwd);
            this.Controls.Add(this.psd_label);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.uid_label);
            this.Controls.Add(this.title);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.Load += new System.EventHandler(this.login_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.code_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox code_pic;
        private System.Windows.Forms.Button return_1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label code_label;
        private System.Windows.Forms.TextBox txt_upwd;
        private System.Windows.Forms.Label psd_label;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label uid_label;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label conf_psd_label;
        private System.Windows.Forms.TextBox txt_psd;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}