using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinical
{
    public partial class Prescription : Form
    {
        SqlConnection con = new SqlConnection("Data Source=EYAD-EL-HAWARY\\SQLEXPRESS;Initial Catalog=Orthopedic_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Prescription()
        {
            InitializeComponent();
         
            GetDocid();
            GetDocname();
            GetPatid();
            GetPatname();
        }

        private void Prescription_Load(object sender, EventArgs e)
        { 
        }
        private void GetPatid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select national_id from patientinfo", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("national_id", typeof(int));
            dt.Load(rdr);
            comboBox2.ValueMember = "national_id";
            comboBox2.DataSource = dt;
            con.Close();

        }
        private void GetDocid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select doctor_id from Doctorinfo", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("doctor_id", typeof(int));
            dt.Load(rdr);
            comboBox3.ValueMember = "doctor_id";
            comboBox3.DataSource = dt;
            con.Close();

        }

        private void GetDocname()
        {
            con.Open();
            string query = "select * from Doctorinfo where doctor_id=" + comboBox3.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox4.Text = dr["dname"].ToString();
            }
            con.Close();
        }
        private void GetPatname()
        {
            con.Open();
            string query = "select * from patientinfo where national_id=" + comboBox2.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox3.Text = dr["patientname"].ToString();
            }
            con.Close();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorProfile f2 = new DoctorProfile();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into prescription values('" + comboBox2.Text + "','" + comboBox3.Text + "','" +textBox4.Text + "','" + textBox3.Text + "','" +dateTimePicker1.Value.Date+"','"+textBox1.Text+"','"+comboBox1.Text+"','"+textBox2.Text+"')";
            adddoctorclass ad = new adddoctorclass();
            try
            {
                ad.adddoctor(query);
                MessageBox.Show("Prescription Added Successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
