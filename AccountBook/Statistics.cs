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
    public partial class Statistics : Form
    {
        static string uid;
        Mainwindow _mainwindow;
        public Statistics(Mainwindow mainwindow , string id)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            uid = id;
        }
        //初始化
        private void Statistics_Load(object sender, EventArgs e)
        {
            txt_length.Text = "1天";
        }
        //日历选中日期更改函数
        private void DateChanged(object sender, DateRangeEventArgs e)
        {
            start_picker.Value = monthCalendar.SelectionStart;
            end_picker.Value = monthCalendar.SelectionEnd;
        }
        //起始日期更改函数
        private void start_text_Changed(object sender, EventArgs e)
        {
            monthCalendar.SelectionStart = start_picker.Value;
            TimeSpan timeSpan = end_picker.Value - start_picker.Value;
            int day = timeSpan.Days + 1;
            txt_length.Text = day + "天";
        }
        //终止日期更改函数
        private void end_text_Changed(object sender, EventArgs e)
        {
            monthCalendar.SelectionEnd = end_picker.Value;
            TimeSpan timeSpan = end_picker.Value - start_picker.Value;
            int day = timeSpan.Days + 1;
            txt_length.Text = day + "天";
        }
        //查找函数，跳转至query_list页面
        private void btn_query_Click(object sender, EventArgs e)
        {
            string start = start_picker.Value.ToString("d");
            string end = end_picker.Value.ToString("d");
            query_list childrenForm = new query_list(start, end, uid);
            childrenForm.ShowDialog();
        }
        //返回上一页面
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainwindow.Show();
        }
    }
}
