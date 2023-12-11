using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AccountBook
{
    public partial class Cost_7days : Form
    {
        static string uid;
        public Cost_7days(string id)
        {
            InitializeComponent();
            uid = id;
            

            // 默认显示当天为结束日期的七天汇总
            DateTime startday = DateTime.Today.AddDays(-6);
            dateTimePicker1.Value = startday;

            date_7days(startday);
        }

        private void date_7days(DateTime startday)
        {
            DateTime endday = startday.AddDays(6);
            string endd = endday.Year.ToString() + '-' + endday.Month.ToString() + '-' + endday.Day.ToString();
            string startd = startday.Year.ToString() + '-' + startday.Month.ToString() + '-' + startday.Day.ToString();
            
            // 从数据库获取数据
            string sql = "select date as date , sum(money) from disburse " +
                "where uid = '" + uid + "' and date between '" + startd + "' and '" + endd + "'group by date";
            DataSet ds = AccountBook.Query(sql);
            
            string[] x = new string[7];
            double[] y = new double[7];

            // 初始化从起始日期到结束日期的每日支出
            for (int i = 0; i < 7; i++)
            {
                DateTime day = startday.AddDays(i);
                x[i] = day.Year.ToString() + '-' + day.Month.ToString() + '-' + day.Day.ToString();
                DataRow[] dro = ds.Tables[0].Select("(date='" + x[i] +"')");
                if(dro.Length > 0)
                {
                    y[i] = double.Parse(dro[0][1].ToString());
                }
                else 
                    y[i] = 0; 
            }

            // 柱状图
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.Series["Series1"].Points.DataBindXY(x, y);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // 日期改变
            DateTime startd = dateTimePicker1.Value;
            date_7days(startd);
        }
    }
}
