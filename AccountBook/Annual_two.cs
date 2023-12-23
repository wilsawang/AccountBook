using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AccountBook
{
    public partial class Annual_two : Form
    {
        static string uid;
        private int count = 0;
        static int nowyear = DateTime.Now.Year;
        static DateTime begindate = Convert.ToDateTime(nowyear.ToString() + "-01-01");
        static DateTime enddate = Convert.ToDateTime(nowyear.ToString() + "-12-31");
        DataTable dtin = new DataTable();
        DataTable dtout = new DataTable();
        decimal sumin = 0;
        decimal sumout = 0;

        public Annual_two(string id)
        {
            uid = id;
            string sqlin = "select * from income where uid = '" + uid + "' and date>='" + begindate + "' and date<='" + enddate + "'";
            string sqlout = "select * from disburse where uid = '" + uid + "' and date>='" + begindate + "' and date<='" + enddate + "'";
            dtin = AccountBook.Query(sqlin).Tables[0];
            dtout = AccountBook.Query(sqlout).Tables[0];
            InitializeComponent();
        }

        private void Annual_two_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            switch (count)
            {
                case 1:
                    show_1();
                    break;
                case 2:
                    show_2();
                    break;
                case 3:
                    show_3();
                    break;
                case 4:
                    show_4();
                    break;
                case 5:
                    show_5();
                    break;
                case 6:
                    show_6();
                    break;
                case 7:
                    MessageBox.Show("您的年度总结报告已完成! 即将返回!");
                    show_7();
                    break;
            }
        }

        // 共计收入 支出
        private void show_1()
        {
            for (int i = 0; i < dtin.Rows.Count; i++)
            {
                sumin += Decimal.Round(Decimal.Parse(dtin.Rows[i]["money"].ToString()), 2);
            }
            for (int i = 0; i < dtout.Rows.Count; i++)
            {
                sumout += Decimal.Round(Decimal.Parse(dtout.Rows[i]["money"].ToString()), 2);
            }
            text11.Visible = true;
            text12.Visible = true;
            text13.Visible = true;
            text14.Visible = true;
            text11.Text = nowyear.ToString() + "年，你累计收入";
            text12.Text = sumin.ToString() + "元!";
            text13.Text = nowyear.ToString() + "年，你累计支出";
            text14.Text = sumout.ToString() + "元!";
        }


        // 收入最多的天 项
        private void show_2()
        {
            string sql = "select * from income where uid = '" + uid + "' and date>='" + begindate + "' and date<='" + enddate + "' order by money desc";
            DataTable dt = new DataTable();
            dt = AccountBook.Query(sql).Tables[0];
            decimal money = Decimal.Round(Decimal.Parse(dt.Rows[0]["money"].ToString()), 2);
            DateTime thatday = Convert.ToDateTime(dt.Rows[0]["date"]);
            int month = thatday.Month;
            int day = thatday.Day;
            string sort = dt.Rows[0]["sort"].ToString();
            string subsort = dt.Rows[0]["subsort"].ToString();
            text21.Visible = true;
            text22.Visible = true;
            text23.Visible = true;
            text24.Visible = true;
            text21.Text = "这一年中，你在" + month.ToString() + "月" + day.ToString() + "日这天";
            text22.Text = "通过" + sort.ToString() + "获得" + subsort.ToString();
            text23.Text = money.ToString() + "元!";
            text24.Text = "这一天，你一定非常开心叭!";
        }

        // 支出最多的天 项
        private void show_3()
        {
            string sql = "select * from disburse where uid = '" + uid + "' and date>='" + begindate + "' and date<='" + enddate + "' order by money desc";
            DataTable dt = new DataTable();
            dt = AccountBook.Query(sql).Tables[0];
            decimal money = Decimal.Round(Decimal.Parse(dt.Rows[0]["money"].ToString()), 2);
            DateTime thatday = Convert.ToDateTime(dt.Rows[0]["date"]);
            int month = thatday.Month;
            int day = thatday.Day;
            string sort = dt.Rows[0]["sort"].ToString();
            string subsort = dt.Rows[0]["subsort"].ToString();
            text31.Visible = true;
            text32.Visible = true;
            text33.Visible = true;
            text34.Visible = true;
            text31.Text = month.ToString() + "月" + day.ToString() + "日这天对你来说一定很难忘叭。";
            text32.Text = "你在" + subsort.ToString() + "上花了";
            text33.Text = money.ToString() + "元!";
            text34.Text = "存钱不易，仍需努力!";
        }

        // 收入占比最大 项 
        private void show_4()
        {
            text11.Visible = false;
            text12.Visible = false;
            text13.Visible = false;
            text14.Visible = false;
            string sql = "select subsort, sum(money) as allmoney, count(*) as count from income where uid = '" + uid + "' and date>='" + begindate + "' and date<='" + enddate + "' group by subsort order by sum(money) desc";
            DataTable dt = new DataTable();
            dt = AccountBook.Query(sql).Tables[0];
            string subsort = dt.Rows[0]["subsort"].ToString();
            int count = int.Parse(dt.Rows[0]["count"].ToString());
            decimal money = Decimal.Round(Decimal.Parse(dt.Rows[0]["allmoney"].ToString()), 2);
            decimal percent = Decimal.Round(money / sumin * 100, 2);
            text41.Visible = true;
            text42.Visible = true;
            text43.Visible = true;
            text41.Text = subsort.ToString() + "是你最大的收入来源!";
            text42.Text = "累计" + count.ToString() + "笔，占比高达";
            text43.Text = percent.ToString() + "%";
        }

        // 支出占比最大 项 
        private void show_5()
        {
            text21.Visible = false;
            text22.Visible = false;
            text23.Visible = false;
            text24.Visible = false;
            string sql = "select subsort, sum(money) as allmoney, count(*) as count from disburse where uid = '" + uid + "' and date>='" + begindate + "' and date<='" + enddate + "' group by subsort order by sum(money) desc";
            DataTable dt = new DataTable();
            dt = AccountBook.Query(sql).Tables[0];
            string subsort = dt.Rows[0]["subsort"].ToString();
            int count = int.Parse(dt.Rows[0]["count"].ToString());
            decimal money = Decimal.Round(Decimal.Parse(dt.Rows[0]["allmoney"].ToString()), 2);
            decimal percent = Decimal.Round(money / sumout * 100, 2);
            text51.Visible = true;
            text52.Visible = true;
            text53.Visible = true;
            text51.Text = "你将大部分钱花于" + subsort.ToString()+"。";
            text52.Text = "累计" + count.ToString() + "笔，占比可达";
            text53.Text = percent.ToString() + "%";
        }

        // 美好祝愿
        private void show_6()
        {
            text31.Visible = false;
            text32.Visible = false;
            text33.Visible = false;
            text34.Visible = false;
            text61.Visible = true;
            text62.Visible = true;
            text61.Text = "新的一年，祝愿财源滚滚!";
            text62.Text = "身体健康! 阖家幸福!";
        }

        // 返回
        private void show_7()
        {
            this.Close();
        }
    }
}

