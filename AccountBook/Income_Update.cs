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
    public partial class Income_Update : Form
    {
        string _uid, _date, _sort, _subsort, _money;
        public Income_Update(string uid, string date, string sort, string subsort, decimal money)
        {
            InitializeComponent();
            _uid = uid;
            _date = date;
            _sort = sort;
            _subsort = subsort;
            _money = money.ToString();
            date_picker.Value = Convert.ToDateTime(date);
            sort_box.Text = sort;
            subsort_box.Text = subsort;
            inmoney.Text = money.ToString();
        }

        //收入大类更改则修改小类选择框中的值
        private void sortbox_SelectedChanged(object sender, EventArgs e)
        {
            string sort;
            sort = sort_box.SelectedItem.ToString();
            if (sort == "--请选择--")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.SelectedIndex = 0;
            }
            else if (sort == "家庭")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.Items.Add("生活费");
                subsort_box.Items.Add("压岁钱");
                subsort_box.Items.Add("奖励");
                subsort_box.SelectedIndex = 0;
            }
            else if (sort == "社会")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.Items.Add("工资");
                subsort_box.Items.Add("补贴");
                subsort_box.Items.Add("利息");
                subsort_box.Items.Add("彩票");
                subsort_box.SelectedIndex = 0;
            }
            else if (sort == "学校")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.Items.Add("勤工俭学");
                subsort_box.Items.Add("助学贷款");
                subsort_box.Items.Add("奖学金");
                subsort_box.Items.Add("助学金");
                subsort_box.SelectedIndex = 0;
            }
            else if (sort == "其他")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.Items.Add("其他");
                subsort_box.SelectedIndex = 0;
            }
        }

        //修改支出账单
        private void btn_income_Update(object sender, EventArgs e)
        {
            string date = date_picker.Value.ToString("d");
            string sort = sort_box.SelectedItem.ToString();
            string subsort = subsort_box.SelectedItem.ToString();
            if (sort == "--请选择--" || subsort == "--请选择--")
            {
                MessageBox.Show("请完成分类选择!");
                return;
            }
            decimal money;
            money = Decimal.Round(Decimal.Parse(inmoney.Text.Trim()), 2);
            if (money == 0)
            {
                MessageBox.Show("金额不能为零!");
                return;
            }
            string sql = "update income set date='" + date + "',sort='" + sort + "',subsort='" + subsort + "',money=" + money + "where uid='" + _uid + "'and date='" + _date + "'and sort='" + _sort + "'and subsort='" + _subsort + "'and money=" + _money + "";
            if (AccountBook.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("记录支出失败!");
            }
        }
    }
}
