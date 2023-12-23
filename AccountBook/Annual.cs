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
    public partial class Annual : Form
    {
        static string uid;
        private int m = 0;
        private double[] inmoney=new double[13];
        private double[] outmoney= new double[13];
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
            string sql = "select * from income where uid = '" + uid + "'";
            DataTable dt = new DataTable();
            dt = AccountBook.Query(sql).Tables[0];

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m++;
            switch (m)
            {
                case 1: y1.Visible = false; show_text(m);  break;
                case 2: y2.Visible = false; break;
                case 3: y3.Visible = false; break;
                case 4: y4.Visible = false; break;
                case 5: y5.Visible = false; break;
                case 6: y6.Visible = false; break;
                case 7: y7.Visible = false; break;
                case 8: y8.Visible = false; break;
                case 9: y9.Visible = false; break;
                case 10: y10.Visible = false; break;
                case 11: y11.Visible = false; break;
                case 12: y12.Visible = false; break;
                default: break;
            }
        }
        private void show_text(int month)
        {
            
        }
        
    }
}
