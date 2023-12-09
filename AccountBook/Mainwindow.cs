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
        public Mainwindow()
        {
            InitializeComponent();
        }

        // 退出登录
        private void btn_exit_Click(object sender, EventArgs e)
        {
            AccountBook ab= new AccountBook();
            ab.Show();
            this.Hide();
        }

        // 进入我要记账页面 
        private void btn_account_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.ShowDialog();
        }

        // 进入修改密码界面 
        private void btn_chgpwd_Click(object sender, EventArgs e)
        {
            Chgpwd c = new Chgpwd();
            c.ShowDialog();
        }

        // 进入统计页面 
        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            s.ShowDialog();
        }

        // 进入分析页面
        private void btn_analyze_Click(object sender, EventArgs e)
        {
            Analyze a = new Analyze();
            a.ShowDialog();
        }
    }
}
