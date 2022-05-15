using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hospital
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-647A8MH;Initial Catalog=Hospital;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtLoginUID.Text=="" || TxtLoginPwd.Text=="")
            {
                MessageBox.Show("Enter All feilds");
            }
            else
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from doctor where doctor_email ='" + TxtLoginUID.Text+ "' and password = '"+TxtLoginPwd.Text+"' ", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong username or password");
                }
                conn.Close();
            }
            
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            TxtLoginUID.Text = "";
            TxtLoginPwd.Text = "";

        }
    }
}
