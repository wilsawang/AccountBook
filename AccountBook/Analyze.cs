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
    public partial class Analyze : Form
    {
        static string uid;      // 用户名
        public Analyze(string id)
        {
            InitializeComponent();
            uid = id;
            // 获取当前时间和月份
            DateTime thisDay = DateTime.Today;
            string month = thisDay.Month.ToString();

            monthout(month);
            monthin(month); 
        }

        // 获取本月的支出信息并展示
        private void monthout(string month)
        {
            // 从数据库中获取本月各个类别的总支出  返回类别和对应的总支出
            string sql = "select sort, sum(money) from disburse where uid = '" + uid + "' and MONTH(date) = '" + month + "' group by sort";
            DataSet ds = AccountBook.Query(sql);
           
            Dictionary<string, double> result = new Dictionary<string, double>();
            // 初始化字典，防止部分分类金额为0时出现问题
            result.Add("衣", 0.0);
            result.Add("食", 0.0);
            result.Add("住", 0.0);
            result.Add("行", 0.0);
            result.Add("其他", 0.0);

            int rows = ds.Tables[0].Rows.Count;
            double totalout = 0;  
            for (int i = 0; i < rows; i++)
            {
                double a = double.Parse(ds.Tables[0].Rows[i][1].ToString());
                totalout += a;
                result[ds.Tables[0].Rows[i][0].ToString()] = a;
            }

            // 数据展示
            total_out.Text = "¥" + totalout.ToString();
            clothing.Text = "¥" + result["衣"].ToString();
            food.Text = "¥" + result["食"].ToString();
            housing.Text = "¥" + result["住"].ToString();
            transport.Text = "¥" + result["行"].ToString();
            other_out.Text = "¥" + result["其他"].ToString();
        }

        // 获取本月的支出信息并展示
        private void monthin(string month)
        {
            // 从数据库中获取本月各个类别的总支出  返回类别和对应的总支出
            string sql = "select sort, sum(money) from income where uid = '" + uid + "' and MONTH(date) = '" + month + "' group by sort";
            DataSet ds = AccountBook.Query(sql);

            Dictionary<string, double> result = new Dictionary<string, double>();
            // 初始化字典，防止部分分类金额为0时出现问题
            result.Add("家庭", 0.0);
            result.Add("社会", 0.0);
            result.Add("学校", 0.0);
            result.Add("其他", 0.0);

            int rows = ds.Tables[0].Rows.Count;
            double totalout = 0;
            for (int i = 0; i < rows; i++)
            {
                double a = double.Parse(ds.Tables[0].Rows[i][1].ToString());
                totalout += a;
                result[ds.Tables[0].Rows[i][0].ToString()] = a;
            }

            // 数据展示
            total_in.Text = "¥" + totalout.ToString();
            family.Text = "¥" + result["家庭"].ToString();
            social.Text = "¥" + result["社会"].ToString();
            school.Text = "¥" + result["学校"].ToString();
            other_in.Text = "¥" + result["其他"].ToString();
        }

        private void cost_7days_Click(object sender, EventArgs e)
        {
            Cost_7days c7 = new Cost_7days(uid);
            c7.ShowDialog();
        }

        private void cost_1month_Click(object sender, EventArgs e)
        {
            Cost_1month c1 = new Cost_1month(uid);
            c1.ShowDialog();
        }

        private void income_7days_Click(object sender, EventArgs e)
        {
            Income_7days i7 = new Income_7days(uid);
            i7.ShowDialog();
        }

        private void income_1month_Click(object sender, EventArgs e)
        {
            Income_1month i1 = new Income_1month(uid);
            i1.ShowDialog();
        }
    }
}
