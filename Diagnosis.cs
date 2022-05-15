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
    public partial class Diagnosis : Form
    {

        SqlConnection conn=new SqlConnection("Data Source=DESKTOP-647A8MH;Initial Catalog=Hospital;Integrated Security=True");
        SqlCommand cmnd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        string id;
        string query;
        int dia_id = 0;
        


        public void combo()
        {
            comboBox1.Items.Clear();
            conn.Open();
            cmnd = conn.CreateCommand();
            cmnd.CommandType = CommandType.Text;
            cmnd.CommandText = "SELECT patient_id FROM patient";
            cmnd.ExecuteNonQuery();
            DataTable dt = new DataTable();


            adapter = new SqlDataAdapter(cmnd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["patient_id"].ToString());
            }
            conn.Close();

            //string sql = "select * from patient";
            //try
            //{

            //}
        }
        string Name;
        public void fetchName()
        {
            conn.Open();
            //string cb = comboBox1.SelectedValue.ToString();
            string query = "select patient_name from patient where patient_id= '"+comboBox1.Text.ToString()+"'";
            cmnd = new SqlCommand(query,conn);
           
            SqlDataAdapter adapter = new SqlDataAdapter(cmnd);
             DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Name=dr["patient_name"].ToString();
                txtPatientName.Text= Name;
            }
            conn.Close();

        }

        public Diagnosis()
        {
            InitializeComponent();
            show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO diagnosis (patient_id,patient_name,Symotom,diagnosis,medicine) VALUES ('"+ comboBox1.Text+ "', '"+ txtPatientName.Text + "','"+ textBox4.Text + "','"+ textBox3.Text + "', '"+ textBox2.Text + "')";
            cmnd = new SqlCommand(query, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Successfully Added");
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //conn.Open(0);
            //string mysql="select patient_name from patient where patient_id="comboBox1.se""
            fetchName();
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            combo();
            fetchName();

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchName();
        }

        public void show()
        {
            conn.Open();
            //DataTable dt = new DataTable();
            string query = "select * from diagnosis";
            //cmnd = new SqlCommand(query, conn);
            //reader = cmnd.ExecuteReader();
            adapter = new SqlDataAdapter(query, conn);
            builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PSym.Text=dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PDiag.Text=dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            PMed.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            dia_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPatientName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            comboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmnd = new SqlCommand("UPDATE diagnosis SET Symotom = '"+textBox4.Text+"',diagnosis = '"+textBox3.Text+"',medicine = '"+textBox2.Text+ "' WHERE Id = "+dia_id+"", conn);
            conn.Open();
            cmnd.ExecuteNonQuery();
            conn.Close();
            show();
            MessageBox.Show("Record Updated Successfully");
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM diagnosis WHERE Id = " + dia_id + "", conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
            show();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(DsLbl.Text + PName.Text + PSym.Text + PDiag.Text + PMed.Text + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n", new Font("Century Gothic", 12,FontStyle.Bold),Brushes.Black, new Point(230));
            //e.Graphics.DrawString(DsLbl.Text + PName.Text + PSym.Text + PDiag.Text + PMed.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130));
        }
    }
}
