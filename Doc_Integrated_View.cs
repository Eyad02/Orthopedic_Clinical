using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinical
{
    public partial class Doc_Integrated_View : Form
    {
        public Doc_Integrated_View()
        {
            InitializeComponent();
        }

        private void Doc_Integrated_View_Load(object sender, EventArgs e)
        {

        }
        public void populatepersonal()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select * from patientinfo where national_id = " + maskedTextBox2.Text + ";";
            DataSet ds = ad.showdata(query);
            patp.DataSource = ds.Tables[0];
        }
        public void populatemedical()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select pid, age, bloodtype, bloodpressure, vitaminD, Anemia, bodytemp, insulin, additionalinfo, did_a_surgery, allergic_to_any_medicine, breathingdisorder, taking_any_medicie, visit_orthopedic, Asthma, cholesterol, bloodglucose, national_id ,patientname  from patientmedicalinfo where national_id = " + maskedTextBox2.Text + ";";
            DataSet ds = ad.showdata(query);
            patm.DataSource = ds.Tables[0];
        }
        /*public void populateXray()
        {

            string cs = ConfigurationManager.ConnectionStrings["db"].ToString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select Xray from patientmedicalinfo where national_id = "+textBox1.Text+";";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {
                MemoryStream stream = new MemoryStream(reader.GetSqlBytes(19).Buffer);
                pictureBox3.Image = Image.FromStream(stream);
            
            
            }
            con.Close();

        }*/
    
    
        /*public void populateLab()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select labresults from patientmedicalinfo where national_id = " + textBox1.Text + ";";
            DataSet ds = ad.showdata(query);
            labr.DataSource = ds.Tables[0];
        }
        public void populatepatim()
        {
            adddoctorclass ad = new adddoctorclass();
            string query = "select patim from patientinfo where national_id = " + textBox1.Text + ";";
            DataSet ds = ad.showdata(query);
            patim.DataSource = ds.Tables[0];
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            populatepersonal();
            populatemedical();
            /*populateXray();*/
            /*populateLab();
            populatepatim();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xray_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populatepersonal();
            populatemedical();
            /*populateXray();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorProfile dp = new DoctorProfile();
            dp.Show();
            this.Hide();
        }
    }
}
