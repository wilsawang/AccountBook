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
        public Statistics(string id)
        {
            InitializeComponent();
            uid = id;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            txt_length.Text = "1天";
        }

        private void DateChanged(object sender, DateRangeEventArgs e)
        {
            start_picker.Value = monthCalendar.SelectionStart;
            end_picker.Value = monthCalendar.SelectionEnd;
            TimeSpan timeSpan = e.End - e.Start;
            int day = timeSpan.Days + 1;
            txt_length.Text = day + "天";
        }

        private void start_text_Changed(object sender, EventArgs e)
        {
            monthCalendar.SelectionStart = start_picker.Value;
            TimeSpan timeSpan = end_picker.Value - start_picker.Value;
            int day = timeSpan.Days + 1;
            txt_length.Text = day + "天";
        }

        private void end_text_Changed(object sender, EventArgs e)
        {
            monthCalendar.SelectionEnd = end_picker.Value;
            TimeSpan timeSpan = end_picker.Value - start_picker.Value;
            int day = timeSpan.Days + 1;
            txt_length.Text = day + "天";
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string start = start_picker.Value.ToString("d");
            string end = end_picker.Value.ToString("d");
            query_list childrenForm = new query_list(start, end, uid);
            childrenForm.Show();
        }

    }
}
