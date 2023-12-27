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
    public partial class Query_list : Form
    {
        private static string uid, _start, _end;

        public Query_list(string start, string end, string id)
        {
            InitializeComponent();
            uid = id;
            _start = start;
            _end = end;
            txt_start1.Text = start;
            txt_start2.Text = start;
            txt_end1.Text = end;
            txt_end2.Text = end;
            expen_box1.SelectedIndex = 0;
            expen_box2.SelectedIndex = 0;
            income_box1.SelectedIndex = 0;
            income_box2.SelectedIndex = 0;
        }

        //支出大类更改则修改小类选择框中的值
        private void expenbox_SelectedChanged(object sender, EventArgs e)
        {
            string sort;
            sort = expen_box1.SelectedItem.ToString();
            if (sort == "全部")
            {
                expen_box2.Items.Clear();
                expen_box2.Items.Add("全部");
                expen_box2.SelectedIndex = 0;
            }
            else if (sort == "衣")
            {
                expen_box2.Items.Clear();
                expen_box2.Items.Add("全部");
                expen_box2.Items.Add("服饰");
                expen_box2.Items.Add("鞋款");
                expen_box2.Items.Add("耳饰");
                expen_box2.Items.Add("帽类");
                expen_box2.Items.Add("眼镜");
                expen_box2.SelectedIndex = 0;
            }
            else if (sort == "食")
            {
                expen_box2.Items.Clear();
                expen_box2.Items.Add("全部");
                expen_box2.Items.Add("堂食");
                expen_box2.Items.Add("外卖");
                expen_box2.Items.Add("聚餐");
                expen_box2.Items.Add("水果");
                expen_box2.Items.Add("零食");
                expen_box2.Items.Add("饮品");
                expen_box2.SelectedIndex = 0;
            }
            else if (sort == "住")
            {
                expen_box2.Items.Clear();
                expen_box2.Items.Add("全部");
                expen_box2.Items.Add("住宿");
                expen_box2.Items.Add("租房");
                expen_box2.Items.Add("酒店");
                expen_box2.Items.Add("民宿");
                expen_box2.SelectedIndex = 0;
            }
            else if (sort == "行")
            {
                expen_box2.Items.Clear();
                expen_box2.Items.Add("全部");
                expen_box2.Items.Add("自行车");
                expen_box2.Items.Add("电动车");
                expen_box2.Items.Add("的士");
                expen_box2.Items.Add("地铁");
                expen_box2.Items.Add("火车");
                expen_box2.Items.Add("动车");
                expen_box2.Items.Add("飞机");
                expen_box2.Items.Add("轮渡");
                expen_box2.SelectedIndex = 0;
            }
            else if (sort == "其他")
            {
                expen_box2.Items.Clear();
                expen_box2.Items.Add("全部");
                expen_box2.Items.Add("其他");
                expen_box2.SelectedIndex = 0;
            }
        }

        //收入大类修改则更改小类选择框中的值
        private void incomebox_SelectedChanged(object sender, EventArgs e)
        {
            string sort;
            sort = income_box1.SelectedItem.ToString();
            if (sort == "全部")
            {
                income_box2.Items.Clear();
                income_box2.Items.Add("全部");
                income_box2.SelectedIndex = 0;
            }
            else if (sort == "家庭")
            {
                income_box2.Items.Clear();
                income_box2.Items.Add("全部");
                income_box2.Items.Add("生活费");
                income_box2.Items.Add("压岁钱");
                income_box2.Items.Add("奖励");
                income_box2.SelectedIndex = 0;
            }
            else if (sort == "社会")
            {
                income_box2.Items.Clear();
                income_box2.Items.Add("全部");
                income_box2.Items.Add("工资");
                income_box2.Items.Add("补贴");
                income_box2.Items.Add("利息");
                income_box2.Items.Add("彩票");
                income_box2.SelectedIndex = 0;
            }
            else if (sort == "学校")
            {
                income_box2.Items.Clear();
                income_box2.Items.Add("全部");
                income_box2.Items.Add("勤工俭学");
                income_box2.Items.Add("助学贷款");
                income_box2.Items.Add("奖学金");
                income_box2.Items.Add("助学金");
                income_box2.SelectedIndex = 0;
            }
            else if (sort == "其他")
            {
                income_box2.Items.Clear();
                income_box2.Items.Add("全部");
                income_box2.Items.Add("其他");
                income_box2.SelectedIndex = 0;
            }
        }

        //查找支出账单并展示
        private void btn_expen_Query(object sender, EventArgs e)
        {
            string sort = expen_box1.SelectedItem.ToString();
            string subsort = expen_box2.SelectedItem.ToString();
            if (sort.Equals("全部"))
            {
                expen_list.DataSource = AccountBook.Query("select * from disburse where uid = '" + uid + "' and date between '" + _start + "' and '" + _end + "' order by date").Tables["atable"];
            }
            else if (subsort.Equals("全部"))
            {
                expen_list.DataSource = AccountBook.Query("select * from disburse where uid =  '" + uid + "' and date between '" + _start + "' and '" + _end + "' and sort = '" + sort + "' order by date").Tables["atable"];
            }
            else
            {
                expen_list.DataSource = AccountBook.Query("select * from disburse where uid =  '" + uid + "' and date between '" + _start + "' and '" + _end + "' and sort = '" + sort + "' and subsort = '" + subsort + "' order by date").Tables["atable"];
            }
            if (expen_list.Rows.Count == 1)
            {
                MessageBox.Show("您在选中日期内无本类别的支出记录喔！");
            }
        }

        //查找收入账单并展示
        private void btn_income_Query(object sender, EventArgs e)
        {
            string sort = income_box1.SelectedItem.ToString();
            string subsort = income_box2.SelectedItem.ToString();
            if (sort.Equals("全部"))
            {
                income_list.DataSource = AccountBook.Query("select * from income where uid = '" + uid + "' and date between '" + _start + "' and '" + _end + "' order by date").Tables["atable"];
            }
            else if (subsort.Equals("全部"))
            {
                income_list.DataSource = AccountBook.Query("select * from income where uid =  '" + uid + "' and date between '" + _start + "' and '" + _end + "' and sort = '" + sort + "' order by date").Tables["atable"];
            }
            else
            {
                income_list.DataSource = AccountBook.Query("select * from income where uid =  '" + uid + "' and date between '" + _start + "' and '" + _end + "' and sort = '" + sort + "' and subsort = '" + subsort + "' order by date").Tables["atable"];
            }
            if (income_list.Rows.Count == 1)
            {
                MessageBox.Show("您在选中日期内无本类别的收入记录喔！");
            }
        }

        //跳转修改选中的支出账单
        private void btn_expen_Update(object sender, EventArgs e)
        {
            if (expen_list.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中您需修改的行！");
            }
            else if (expen_list.SelectedRows.Count == 1)
            {
                int a = expen_list.CurrentRow.Index;
                string date = expen_list.Rows[a].Cells[1].Value.ToString().Trim();
                string sort = expen_list.Rows[a].Cells[2].Value.ToString().Trim();
                string subsort = expen_list.Rows[a].Cells[3].Value.ToString().Trim();
                decimal money = Decimal.Round(Decimal.Parse(expen_list.Rows[a].Cells[4].Value.ToString().Trim()), 2);
                Expen_Update childrenForm = new Expen_Update(uid, date, sort, subsort, money);
                childrenForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请仅选中需要修改的一行，暂不支持批量修改！");
            }
        }

        //跳转修改选中的收入账单
        private void btn_income_Update(object sender, EventArgs e)
        {
            if (income_list.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中您需修改的行！");
            }
            else if (income_list.SelectedRows.Count == 1)
            {
                int a = income_list.CurrentRow.Index;
                string date = income_list.Rows[a].Cells[1].Value.ToString().Trim();
                string sort = income_list.Rows[a].Cells[2].Value.ToString().Trim();
                string subsort = income_list.Rows[a].Cells[3].Value.ToString().Trim();
                decimal money = Decimal.Round(Decimal.Parse(income_list.Rows[a].Cells[4].Value.ToString().Trim()), 2);
                Income_Update childrenForm = new Income_Update(uid, date, sort, subsort, money);
                childrenForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请仅选中需要修改的一行，暂不支持批量修改");
            }
        }

        //点击按钮，删除支出信息
        private void btn_Del_Expen(object sender, EventArgs e)
        {
            if (expen_list.SelectedRows.Count > 0)
            {
                bool flag = true;
                var dataselect = expen_list.SelectedRows;
                foreach (DataGridViewRow row in dataselect)
                {
                    string date = Convert.ToString(row.Cells["date"].Value);
                    string sort = Convert.ToString(row.Cells["sort"].Value);
                    string subsort = Convert.ToString(row.Cells["subsort"].Value);
                    decimal money = Decimal.Round(Decimal.Parse(Convert.ToString(row.Cells["money"].Value)), 2);
                    string sql = "delete from disburse where uid='" + uid + "'and date='" + date + "'and sort='" + sort + "'and subsort='" + subsort + "'and money=" + money + "";
                    if (AccountBook.ExecuteSql(sql) == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {
                MessageBox.Show("请选中您需删除的行！");
            }
        }

        //点击按钮，删除收入信息
        private void btn_Del_Income(object sender, EventArgs e)
        {
            if (income_list.SelectedRows.Count > 0)
            {
                bool flag = true;
                var dataselect = income_list.SelectedRows;
                foreach (DataGridViewRow row in dataselect)
                {
                    string date = Convert.ToString(row.Cells["date"].Value);
                    string sort = Convert.ToString(row.Cells["sort"].Value);
                    string subsort = Convert.ToString(row.Cells["subsort"].Value);
                    decimal money = Decimal.Round(Decimal.Parse(Convert.ToString(row.Cells["money"].Value)), 2);
                    string sql = "delete from income where uid='" + uid + "'and date='" + date + "'and sort='" + sort + "'and subsort='" + subsort + "'and money=" + money + "";
                    if (AccountBook.ExecuteSql(sql) == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {
                MessageBox.Show("请选中您需删除的行！");
            }
        }
    }
}
