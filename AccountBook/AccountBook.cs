﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AccountBook
{
    public partial class AccountBook : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        
        public AccountBook()
        {
            InitializeComponent();
        }

        // 连接数据库 查询 
        public static DataSet Query(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds);
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                con.Close();
            }
        }


        private void submit_Click(object sender, EventArgs e)
        {
            string uid = uidbox.Text.Trim();
            string upwd = upwdbox.Text.Trim();
            string sql = "select * from users where uid='" + uid + "'and upwd='" + upwd + "'";
            DataTable dt = new DataTable();
            dt = AccountBook.Query(sql).Tables[0];
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Yes!");
                return;
            }
            else
            {
                MessageBox.Show("No!");
                return;
            }
        }

        private void btn_register_click(object sender, EventArgs e)
        {
            Register childrenForm = new Register(this);
            childrenForm.Show();
            this.Hide();
        }
    }
}