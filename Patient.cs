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
    public partial class Patient : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-647A8MH;Initial Catalog=Hospital;Integrated Security=True");
        SqlCommand cmnd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        string id;
        string query;
        string patient_id = "";

        public void load()
        {
            conn.Open();
            //DataTable dt = new DataTable();
            string query = "select * from patient";
            //cmnd = new SqlCommand(query, conn);
            //reader = cmnd.ExecuteReader();
            adapter = new SqlDataAdapter(query, conn);
            builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        public Patient()
        {
            InitializeComponent();
            load();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.doctor' table. You can move, or remove it, as needed.
            //this.doctorTableAdapter.Fill(this.hospitalDataSet.doctor);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void BtnPatAdd_Click(object sender, EventArgs e)
        {
            if (PatMob.TextLength == 10)
            {
                conn.Open();
                string query = "insert into patient (patient_name,Address, Age, Gender, blood,patient_mobile,Disease) values ('" + PatName.Text + "', '" + PAtAddr.Text + "', '" + PatAge.Text + "', '" + PAtSex.Text + "', '" + PatBG.Text + "', '" + PatMob.Text + "', '" + PAtDis.Text + "')";
                cmnd = new SqlCommand(query, conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Patient Successfuklly Added");
                //load();
            }
            else
            {
                MessageBox.Show("Error ! Mobile No should be 10 digits");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load();
        }

        private void hospitalDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        //Update
        private void BtnPatUdt_Click(object sender, EventArgs e)
        {
            if (PatMob.TextLength == 10)
            {
                string Name = PatName.Text;
                string Address = PAtAddr.Text;
                string Age = PatAge.Text;
                string Gender = PAtSex.Text;
                string Blood = PatBG.Text;
                string Mobile = PatMob.Text;
                string Disease = PAtDis.Text;

                cmnd = new SqlCommand("UPDATE patient SET patient_name = '" + Name + "', Address = '" + Address + "', Age = " + Age + ", Gender = '" + Gender + "', blood = '" + Blood + "', patient_mobile = '" + Mobile + "', Disease = '" + Disease + "' WHERE patient_id = " + patient_id + "", conn);
                conn.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Error ! Mobile No should be 10 digits");
            }
        }

        private void PatName_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            patient_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PAtAddr.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PatAge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PAtSex.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            PatBG.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            PatMob.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            PAtDis.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            load();
        }

        //Delete
        private void BtnPatDel_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM patient WHERE patient_id = " + patient_id + "", conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void PatMob_TextChanged(object sender, EventArgs e)
        {
            if (PatMob.TextLength == 10)
            {
                PatMob.ForeColor = Color.Black;
            }
            else
            {
                PatMob.ForeColor = Color.Red;
                //ErrorProvider.setError("")
            }
        }
    }
}
