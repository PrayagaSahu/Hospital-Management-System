using System;
//using DatabaseLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Hospital
{
    public partial class Doctor : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-647A8MH;Initial Catalog=Hospital;Integrated Security=True");
        SqlCommand cmnd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
       
        SqlCommandBuilder builder;
        string id;
        string query;
        string did = "";
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public Doctor()
        {
            InitializeComponent();
            populate();
            TxtMob.MaxLength = 10;
        }

        public void populate()
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select * from doctor";
            //cmnd = new SqlCommand(query, conn);
            //reader = cmnd.ExecuteReader();
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            DoctorView.DataSource = dt;
            conn.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        //Insert
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtMob.TextLength == 10)
            {
                if (Regex.IsMatch(TxtEmail.Text, pattern) == true)
                {
                    if (TxtName.Text == "" || TxtSpe.Text == "" || TxtExp.Text == "" || TxtMob.Text == "" || TxtEmail.Text == "" || TxtPass.Text == "")
                    {
                        MessageBox.Show("No Empty Fills Allowed");
                    }
                    else
                    {
                        conn.Open();
                        query = "insert into doctor values (@doctor_name, @specialist, @experince, @doctor_mobile, @doctor_email, @password)";
                        cmnd = new SqlCommand(query, conn);
                        cmnd.Parameters.AddWithValue("doctor_name", TxtName.Text);
                        cmnd.Parameters.AddWithValue("specialist", TxtSpe.Text);
                        cmnd.Parameters.AddWithValue("experince", TxtExp.Text);
                        cmnd.Parameters.AddWithValue("doctor_mobile", TxtMob.Text);
                        cmnd.Parameters.AddWithValue("doctor_email", TxtEmail.Text);
                        cmnd.Parameters.AddWithValue("password", TxtPass.Text);
                        cmnd.CommandType = CommandType.Text;
                        int i = cmnd.ExecuteNonQuery();

                        TxtName.Clear();
                        TxtSpe.Clear();
                        TxtExp.Clear();
                        TxtMob.Clear();
                        TxtEmail.Clear();
                        TxtPass.Clear();
                        //MessageBox.Show("Doctor Successfuklly Added");
                        conn.Close();
                        MessageBox.Show(i + " Row(s) Inserted ");
                        //ClearData();
                        populate();
                    }
                }
                else
                {
                    MessageBox.Show("Error ! Please Enter Valid Email-ID");
                }
            }
            else
            {
                MessageBox.Show("Error ! Mobile No should be 10 digits");
            }
        }

        //Delete 
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM doctor WHERE doctor_id = '"+did+"'", conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
            populate();
            MessageBox.Show("Record Deleted Successfully!");
            TxtName.Clear();
            TxtSpe.Clear();
            TxtExp.Clear();
            TxtMob.Clear();
            TxtEmail.Clear();
            TxtPass.Clear();
        }

        private void DoctorView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoctorView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            did = DoctorView.SelectedRows[0].Cells[0].Value.ToString();
            TxtName.Text = DoctorView.SelectedRows[0].Cells[1].Value.ToString();
            TxtSpe.Text = DoctorView.SelectedRows[0].Cells[2].Value.ToString();
            TxtExp.Text = DoctorView.SelectedRows[0].Cells[3].Value.ToString();
            TxtMob.Text = DoctorView.SelectedRows[0].Cells[4].Value.ToString();
            TxtEmail.Text = DoctorView.SelectedRows[0].Cells[5].Value.ToString();
            TxtPass.Text = DoctorView.SelectedRows[0].Cells[6].Value.ToString();
        }


        //Update
        private void BtnUdt_Click_1(object sender, EventArgs e)
        {
            if (TxtMob.TextLength == 10)
            {
                if (Regex.IsMatch(TxtEmail.Text, pattern) == true)
                {
                    string Name = TxtName.Text;
                    string Specialist = TxtSpe.Text;
                    string Experience = TxtExp.Text;
                    string Mobile = TxtMob.Text;
                    string Email = TxtEmail.Text;
                    string Password = TxtPass.Text;
                    if (TxtName.Text != "" && TxtSpe.Text != "" && TxtExp.Text != "" && TxtMob.Text != "" && TxtEmail.Text != "" && TxtPass.Text != "")
                    {
                        cmnd = new SqlCommand("UPDATE doctor SET doctor_name = '" + Name + "',specialist = '" + Specialist + "' ,experince = '" + Experience + "', doctor_mobile = '" + Mobile + "',doctor_email = '" + Email + "' ,password = '" + Password + "' WHERE doctor_id= " + did + " ", conn);
                        conn.Open();
                        cmnd.Parameters.AddWithValue("doctor_id", did);
                        cmnd.Parameters.AddWithValue("doctor_name", Name);
                        cmnd.Parameters.AddWithValue("specialist", Specialist);
                        cmnd.Parameters.AddWithValue("experince", Experience);
                        cmnd.Parameters.AddWithValue("doctor_mobile", Mobile);
                        cmnd.Parameters.AddWithValue("doctor_email", Email);
                        cmnd.Parameters.AddWithValue("password", Password);
                        cmnd.ExecuteNonQuery();
                        conn.Close();
                        populate();
                        MessageBox.Show("Record Updated Successfully");

                        TxtName.Clear();
                        TxtSpe.Clear();
                        TxtExp.Clear();
                        TxtMob.Clear();
                        TxtEmail.Clear();
                        TxtPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Record to Update");
                    }
                }
                else
                {
                    MessageBox.Show("Error ! Please Enter valid Email-id");
                }
            }
            else
            {
                MessageBox.Show("Error ! Mobile No should be 10 digits");
            }
        }

        private void TxtMob_TextChanged(object sender, EventArgs e)
        { 
            if (TxtMob.TextLength == 10)
            {
                TxtMob.ForeColor = Color.Black;
            }
            else
            {
                TxtMob.ForeColor = Color.Red;
            }
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TxtEmail.Text, pattern) == true)
            {
                TxtEmail.ForeColor = Color.Black;
            }
            else
            {
                TxtEmail.ForeColor = Color.Red;
            }
        }
    }
}
