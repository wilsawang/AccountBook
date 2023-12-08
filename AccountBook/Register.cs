using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public partial class Register : Form
    {
        AccountBook _AccountBook;
        public Register(AccountBook accountBook)
        {
            InitializeComponent();
            _AccountBook = accountBook;
        }

        private void login_Register_Load(object sender, EventArgs e)
        {
            strTemp = validCode.UpdateVerifyCode();
            code_pic.Image = validCode.CreateImage(strTemp);
            txt_code.Text = "验证码不区分大小写";
            txt_code.ForeColor = Color.Gray;
            txt_code.Font = new Font("华文楷体", 9F);
        }

        valid_code validCode = new valid_code();
        string strTemp = "";
        //点击按钮，返回登录主页面
        private void btn_back_click(object sender, EventArgs e)
        {
            this.Close();
            _AccountBook.Show();
        }
        //点击按钮，注册，并返回登录页面
        private void btn_click(object sender, EventArgs e)
        {
            string uid = txt_uid.Text.Trim();
            string password = txt_upwd.Text.Trim();
            string conf_psd = txt_psd.Text.Trim();
            if (uid.Equals(""))
            {
                MessageBox.Show("用户名不能为空！");
                strTemp = validCode.UpdateVerifyCode();
                code_pic.Image = validCode.CreateImage(strTemp);
                txt_code.Text = "验证码不区分大小写";
                txt_code.ForeColor = Color.Gray;
                txt_code.Font = new Font("华文楷体", 9F);
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("密码不能为空！");
                strTemp = validCode.UpdateVerifyCode();
                code_pic.Image = validCode.CreateImage(strTemp);
                txt_code.Text = "验证码不区分大小写";
                txt_code.ForeColor = Color.Gray;
                txt_code.Font = new Font("华文楷体", 9F);
            }
            else if (conf_psd!=password)
            {
                MessageBox.Show("两遍密码不一致，请重新确认密码！");
                strTemp = validCode.UpdateVerifyCode();
                code_pic.Image = validCode.CreateImage(strTemp);
                txt_code.Text = "验证码不区分大小写";
                txt_code.ForeColor = Color.Gray;
                txt_code.Font = new Font("华文楷体", 9F);
            }
            else if (txt_code.Text.StartsWith("验"))
            {
                MessageBox.Show("请输入验证码！");
                strTemp = validCode.UpdateVerifyCode();
                code_pic.Image = validCode.CreateImage(strTemp);
            }
            else
            {
                bool t = validCode.CheckCode(txt_code.Text);
                /*if (t)
                {
                    string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
                    SqlConnection con = new SqlConnection(connectionString);
                    try
                    {
                        con.Open();
                        string sql = "select count(*) from user where id = '" + uid + "'";
                        SqlCommand com = new SqlCommand(sql, con);
                        //>0表示有数据
                        if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("用户名重复，请重新输入！");
                            txt_uid.Text = "";
                            strTemp = validCode.UpdateVerifyCode();
                            code_pic.Image = validCode.CreateImage(strTemp);
                            txt_code.Text = "验证码不区分大小写";
                            txt_code.ForeColor = Color.Gray;
                            txt_code.Font = new Font("华文楷体", 9F);
                        }
                        else
                        {
                            string sql = "insert into user values('" + uid + "','" + password + "')";
                            if (login.ExecuteSql(sql) > 0)
                            {
                                MessageBox.Show("注册成功！");
                            }
                            this.Close();
                            _AccountBook.Show();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("打开数据库失败！");
                    }
                }
                //验证失败
                else
                {
                    MessageBox.Show("请输入正确的验证码！");
                    strTemp = validCode.UpdateVerifyCode();
                    code_pic.Image = validCode.CreateImage(strTemp);
                    txt_code.Text = "验证码不区分大小写";
                    txt_code.ForeColor = Color.Gray;
                    txt_code.Font = new Font("华文楷体", 9F);
                }*/
            }
        }
        private void btn_change_psd(object sender, EventArgs e)
        {
            if(checkBox.Checked)
            {
                txt_psd.UseSystemPasswordChar = false;
                txt_psd.PasswordChar = new char();
                txt_upwd.UseSystemPasswordChar = false;
                txt_upwd.PasswordChar = new char();
            }
            else
            {
                txt_psd.UseSystemPasswordChar = true;
                txt_upwd.UseSystemPasswordChar = true;
            }
        }
        //点击图片刷新验证码
        private void picUpdate_Click(object sender, EventArgs e)
        {
            strTemp = validCode.UpdateVerifyCode();
            code_pic.Image = validCode.CreateImage(strTemp);
        }
        //失去焦点，判断是否有输入调整提示语句、字体及颜色
        private void code_lostfocus(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                txt_code.Text = "验证码不区分大小写";
                txt_code.ForeColor = Color.Gray;
                txt_code.Font = new Font("华文楷体", 9F);
            }
            else
            {
                txt_code.ForeColor = Color.Black;
                txt_code.Font = new Font("Times New Roman", 14F);
            }
        }
        //获得焦点，若为提示信息则将格式调整为输入格式
        private void code_gotfocus(object sender, EventArgs e)
        {
            if (txt_code.Text.StartsWith("验"))
            {
                txt_code.Text = "";
                txt_code.ForeColor = Color.Black;
                txt_code.Font = new Font("Times New Roman", 14F);
            }
        }
    }
}
