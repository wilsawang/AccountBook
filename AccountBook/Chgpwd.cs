using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public partial class Chgpwd : Form
    {
        public Chgpwd(string id)
        {
            InitializeComponent();
            txt_uid.Text = id;
            DataSet ds = AccountBook.Query("select upwd from users where uid = '" + id + "'");
            txt_pre_pwd.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        //返回个人信息页
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //修改密码，确定修改，返回登录页面重新登陆
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string uid = txt_uid.Text.Trim();
            string new_pwd = txt_new_pwd.Text.Trim();
            string confirm_pwd = txt_pwd_confirm.Text.Trim();
            if (new_pwd == "")
            {
                MessageBox.Show("新密码不能为空");
            }
            else if (new_pwd.Length < 8)
            {
                MessageBox.Show("新密码长度不能少于8位，请重新输入！");
            }
            else
            {
                //判断两次密码是否一致
                if (new_pwd == confirm_pwd)
                {
                    string sql = "update users set upwd='" + confirm_pwd + "'where uid='" + uid + "'";
                    if (AccountBook.ExecuteSql(sql) > 0)
                    {
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else
                {
                    MessageBox.Show("两次输入密码不一致，请重新输入");
                }
            }
        }
    }
}
