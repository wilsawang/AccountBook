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
    public partial class Mainwindow : Form
    {
        static string uid;
        public Mainwindow(string id)
        {
            InitializeComponent();
            uid = id;
            welcome_str.Text = "欢迎您, " + uid + "用户!";
        }

        // 退出登录
        private void btn_exit_Click(object sender, EventArgs e)
        {
            AccountBook ab = new AccountBook();
            ab.Show();
            this.Hide();
        }

        // 进入我要记账页面 
        private void btn_account_Click(object sender, EventArgs e)
        {
            Account a = new Account(uid);
            a.ShowDialog();
        }

        // 进入修改密码界面 
        private void btn_chgpwd_Click(object sender, EventArgs e)
        {
            Chgpwd c = new Chgpwd(uid);
            c.Show();
        }

        // 进入统计页面 
        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics(uid);
            s.ShowDialog();
        }

        // 进入分析页面
        private void btn_analyze_Click(object sender, EventArgs e)
        {
            Analyze a = new Analyze(uid);
            a.ShowDialog();
        }

        // 进入年度总结报告页面
        private void annual_report_Click(object sender, EventArgs e)
        {
            Annual annual = new Annual(uid);
            annual.ShowDialog();
        }
    }
}
