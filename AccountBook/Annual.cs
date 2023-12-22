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
        public Annual(string id)
        {
            uid = id;
            InitializeComponent();
        }
    }
}
