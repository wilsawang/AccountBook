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
    public partial class Income_1month : Form
    {
        static string uid;
        public Income_1month(string id)
        {
            InitializeComponent();
            uid = id;

            // 默认起始计算时间为：当天的前30天
            DateTime startday = DateTime.Now.AddDays(-29);
            dateTimePicker1.Value = startday;
            date_month(startday);
        }

        private void date_month(DateTime startday)
        {
            // 起始日期和结束日期
            DateTime endday = startday.AddDays(29);
            string endd = endday.Year.ToString() + '-' + endday.Month.ToString() + '-' + endday.Day.ToString();
            string startd = startday.Year.ToString() + '-' + startday.Month.ToString() + '-' + startday.Day.ToString();

            // 数据库查询
            // 该用户在一个月中的收入中各个部分的金额
            string sql = "select sort, sum(money) from income " +
                "where uid = '" + uid + "' and date between '" + startd + "' and '" + endd + "' group by sort";
            DataSet ds = AccountBook.Query(sql);

            // 数据处理——转为字典格式存储
            Dictionary<string, double> result = new Dictionary<string, double>();

            int rows = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                double a = double.Parse(ds.Tables[0].Rows[i][1].ToString());
                result[ds.Tables[0].Rows[i][0].ToString()] = a;
            }


            if (result.Count() > 0)
            {
                // 若该时间范围内有支出，则标签显示在饼图外部
                pie.Series["Series1"].Label = "#VALX:#PERCENT";
                pie.Series["Series1"]["PieLineColor"] = "Black";        //连线颜色
                pie.Series["Series1"]["PieLabelStyle"] = "Outside";     //标签位置                                                                                     
            }
            else
            {
                // 否则在图中显示暂无支出数据
                pie.Series["Series1"].Label = "#VALX";
                pie.Series["Series1"]["PieLabelStyle"] = "Inside";
                result.Add("暂无收入数据", 1);

            }
            pie.Series["Series1"].Points.DataBindXY(result.Keys.ToArray(), result.Values.ToArray());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime startd = dateTimePicker1.Value;
            date_month(startd);
        }
    }
}
