using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountBook
{
    public partial class Account : Form
    {
        // 用户名 
        static string uid;
        // 金额默认值 
        private const String DEFAULT_TEXT = "00.00";
        public Account(string id)
        {
            InitializeComponent();
            uid = id;
            sortbox.SelectedIndex = 0;
            subsortbox.SelectedIndex = 0;
            outsortbox.SelectedIndex = 0;
            outsubsortbox.SelectedIndex = 0;
            SetDefaultTextin();
            SetDefaultTextout();
            indatetime.Value = DateTime.Today;
            outdatetime.Value = DateTime.Today;
        }

        // 第一个分类选择切换 收入
        private void sortbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort = sortbox.SelectedItem.ToString();
            subsortbox_change(sort);
        }

        // 第一个分类选中 影响第二个分类 收入
        private void subsortbox_change(string sort)
        {
            if (sort == "--请选择--")
            {
                subsortbox.Items.Clear();
                subsortbox.Items.Add("--请选择--");
                subsortbox.SelectedIndex = 0;
            }
            else if (sort == "家庭")
            {
                subsortbox.Items.Clear();
                subsortbox.Items.Add("--请选择--");
                subsortbox.Items.Add("生活费");
                subsortbox.Items.Add("压岁钱");
                subsortbox.Items.Add("奖励");
                subsortbox.SelectedIndex = 0;
            }
            else if (sort == "社会")
            {
                subsortbox.Items.Clear();
                subsortbox.Items.Add("--请选择--");
                subsortbox.Items.Add("工资");
                subsortbox.Items.Add("补贴");
                subsortbox.Items.Add("利息");
                subsortbox.Items.Add("彩票");
                subsortbox.SelectedIndex = 0;
            }
            else if (sort == "学校")
            {
                subsortbox.Items.Clear();
                subsortbox.Items.Add("--请选择--");
                subsortbox.Items.Add("勤工俭学");
                subsortbox.Items.Add("助学贷款");
                subsortbox.Items.Add("奖学金");
                subsortbox.Items.Add("助学金");
                subsortbox.SelectedIndex = 0;
            }
            else if (sort == "其他")
            {
                subsortbox.Items.Clear();
                subsortbox.Items.Add("--请选择--");
                subsortbox.Items.Add("其他");
                subsortbox.SelectedIndex = 0;
            }
        }

        private void SetDefaultTextin()
        {
            inmoney.Text = DEFAULT_TEXT;
            inmoney.ForeColor = Color.Gray;
        }

        private void SetDefaultTextout()
        {
            outmoney.Text = DEFAULT_TEXT;
            outmoney.ForeColor = Color.Gray;
        }


        // 获取焦点事件 Enter
        private void inmoney_Enter(object sender, EventArgs e)
        {
            if (inmoney.Text == DEFAULT_TEXT)
            {
                inmoney.Text = "";
                inmoney.ForeColor = Color.Black;
            }
        }
        private void outmoney_Enter(object sender, EventArgs e)
        {
            if (outmoney.Text == DEFAULT_TEXT)
            {
                outmoney.Text = "";
                outmoney.ForeColor = Color.Black;
            }
        }

        // 失去焦点事件 Leave
        private void inmoney_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inmoney.Text))
                SetDefaultTextin();
        }
        private void outmoney_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(outmoney.Text))
                SetDefaultTextout();
        }

        private void inmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && inmoney.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
        private void outmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && outmoney.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        // 提交按钮 收入
        private void inbtn_Click(object sender, EventArgs e)
        {
            // 检查输入是否完整
            // date
            string date = indatetime.Value.ToString("d");

            // sort subsort
            string sort = sortbox.SelectedItem.ToString();
            string subsort = subsortbox.SelectedItem.ToString();
            if (sort == "--请选择--" || subsort == "--请选择--")
            {
                MessageBox.Show("请完成分类选择!");
                return;
            }

            // money
            decimal money;
            money = Decimal.Round(Decimal.Parse(inmoney.Text.Trim()), 2);
            if (money == 0)
            {
                MessageBox.Show("金额不能为零!");
                return;
            }
            // 写入数据库 
            string sql = "insert into income values('"+uid+"','"+date+"','"+sort+"','"+subsort+"','"+money.ToString()+"')";
            if (AccountBook.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("记录收入成功!");
                this.Close();
            }
            else
            {
                MessageBox.Show("记录收入失败!");
            }
        }

    }
}
