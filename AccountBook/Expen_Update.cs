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
    public partial class Expen_Update : Form
    {
        string _uid, _date, _sort, _subsort, _money;
        public Expen_Update(string uid, string date, string sort, string subsort, decimal money)
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
            exmoney.Text = money.ToString();
        }

        //支出大类更改则修改小类选择框中的值
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
            else if (sort == "衣")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.Items.Add("服饰");
                subsort_box.Items.Add("鞋款");
                subsort_box.Items.Add("耳饰");
                subsort_box.Items.Add("帽类");
                subsort_box.Items.Add("眼镜");
                subsort_box.SelectedIndex = 0;
            }
            else if (sort == "食")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.Items.Add("堂食");
                subsort_box.Items.Add("外卖");
                subsort_box.Items.Add("聚餐");
                subsort_box.Items.Add("水果");
                subsort_box.Items.Add("零食");
                subsort_box.Items.Add("饮品");
                subsort_box.SelectedIndex = 0;
            }
            else if (sort == "住")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.Items.Add("住宿");
                subsort_box.Items.Add("租房");
                subsort_box.Items.Add("酒店");
                subsort_box.Items.Add("民宿");
                subsort_box.SelectedIndex = 0;
            }
            else if (sort == "行")
            {
                subsort_box.Items.Clear();
                subsort_box.Items.Add("--请选择--");
                subsort_box.Items.Add("自行车");
                subsort_box.Items.Add("电动车");
                subsort_box.Items.Add("的士");
                subsort_box.Items.Add("地铁");
                subsort_box.Items.Add("火车");
                subsort_box.Items.Add("动车");
                subsort_box.Items.Add("飞机");
                subsort_box.Items.Add("轮渡");
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
        private void btn_expen_Update(object sender, EventArgs e)
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
            money = Decimal.Round(Decimal.Parse(exmoney.Text.Trim()), 2);
            if (money == 0)
            {
                MessageBox.Show("金额不能为零!");
                return;
            }
            string sql = "update disburse set date='" + date + "',sort='" + sort + "',subsort='" + subsort + "',money=" + money + " where uid='" + _uid + "'and date='" + _date + "'and sort='" + _sort + "'and subsort='" + _subsort + "'and money=" + _money + "";
            if (AccountBook.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("账单更改失败!");
            }
        }
    }
}
