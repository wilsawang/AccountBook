using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public partial class Annual : Form
    {
        static string uid;
        private int m = 0;
        private int nowyear = DateTime.Now.Year;
        private decimal[] inmoney=new decimal[13];
        private decimal[] outmoney= new decimal[13];
        private decimal sumin = 0;
        private decimal sumout = 0;
        public Annual(string id)
        {
            uid = id;
            InitializeComponent();
        }

        private void Annual_Load(object sender, EventArgs e)
        {
            count_sum();
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
        }

        // 将每个月总和 收入 支出 保存至数组中 以便后续调用
        private void count_sum()
        {
            string sqlin = "select * from income where uid = '" + uid + "'";
            DataTable dtin = new DataTable();
            dtin = AccountBook.Query(sqlin).Tables[0];
            for (int i = 0; i < dtin.Rows.Count; i++) 
            {
                DateTime d = Convert.ToDateTime(dtin.Rows[i]["date"]);
                if (d.Year != nowyear) continue;
                int nowmonth = d.Month;
                inmoney[nowmonth] += Decimal.Round(Decimal.Parse(dtin.Rows[i]["money"].ToString()), 2);
            }
            string sqlout = "select * from disburse where uid = '" + uid + "'";
            DataTable dtout = new DataTable();
            dtout = AccountBook.Query(sqlout).Tables[0];
            for (int i = 0; i < dtout.Rows.Count; i++)
            {
                DateTime d = Convert.ToDateTime(dtout.Rows[i]["date"]);
                if (d.Year != nowyear) continue;
                int nowmonth = d.Month;
                outmoney[nowmonth] += Decimal.Round(Decimal.Parse(dtout.Rows[i]["money"].ToString()), 2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m++;
            switch (m)
            {
                case 1: y1.Visible = false; show_text(m);  break;
                case 2: y2.Visible = false; show_text(m); break;
                case 3: y3.Visible = false; show_text(m); break;
                case 4: y4.Visible = false; show_text(m); break;
                case 5: y5.Visible = false; show_text(m); break;
                case 6: y6.Visible = false; show_text(m); break;
                case 7: y7.Visible = false; show_text(m); break;
                case 8: y8.Visible = false; show_text(m); break;
                case 9: y9.Visible = false; show_text(m); break;
                case 10: y10.Visible = false; show_text(m); break;
                case 11: y11.Visible = false; show_text(m); break;
                case 12: y12.Visible = false; show_text(m); break;
                case 14: 
                    y0.Visible = false;
                    text_single_in.Visible = false;
                    text_single_out.Visible = false;
                    text_sum_in.Visible = false;
                    text_sum_out.Visible = false;
                    btn_next.Visible = true; 
                    btn_next.Enabled = true; 
                    break;
                default: break;
            }
        }
        private void show_text(int month)
        {
            text_single_in.Text = month.ToString() + "月收入: " + inmoney[month].ToString();
            text_single_out.Text = month.ToString() + "月支出: " + outmoney[month].ToString();
            sumin += inmoney[month];
            sumout += outmoney[month];
            text_sum_in.Text = nowyear.ToString() + "年累计收入: " + sumin.ToString();
            text_sum_out.Text = nowyear.ToString() + "年累计支出: " + sumout.ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Annual_two a = new Annual_two(uid);
            a.ShowDialog();
            this.Close();
        }
    }
}
