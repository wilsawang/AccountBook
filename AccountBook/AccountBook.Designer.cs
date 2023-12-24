namespace AccountBook
{
    partial class AccountBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uidbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upwdbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(431, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "请先登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(253, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // uidbox
            // 
            this.uidbox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uidbox.Location = new System.Drawing.Point(439, 203);
            this.uidbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uidbox.Name = "uidbox";
            this.uidbox.Size = new System.Drawing.Size(307, 39);
            this.uidbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(253, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "密  码：";
            // 
            // upwdbox
            // 
            this.upwdbox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upwdbox.Location = new System.Drawing.Point(439, 293);
            this.upwdbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upwdbox.Name = "upwdbox";
            this.upwdbox.Size = new System.Drawing.Size(307, 39);
            this.upwdbox.TabIndex = 4;
            this.upwdbox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(433, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "立即注册";
            this.label4.Click += new System.EventHandler(this.btn_register_click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.Location = new System.Drawing.Point(597, 384);
            this.submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(149, 68);
            this.submit.TabIndex = 7;
            this.submit.Text = "确认";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // AccountBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upwdbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uidbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uidbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox upwdbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit;
    }
}