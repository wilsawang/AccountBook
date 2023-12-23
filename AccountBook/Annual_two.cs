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
    public partial class Annual_two : Form
    {
        static string uid;
        private int count = 0;
        static int nowyear = DateTime.Now.Year;
        static DateTime begindate = Convert.ToDateTime(nowyear.ToString() + "-01-01");
        static DateTime enddate = Convert.ToDateTime(nowyear.ToString() + "-12-31");
        DataTable dtin = new DataTable();
        DataTable dtout = new DataTable();

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
            switch (count) {
                case 1:
                    show_1();
                    break;
            }
        }

        // 共计收入 支出
        private void show_1()
        {

        }
    }
}
