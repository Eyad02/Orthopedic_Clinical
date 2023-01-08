using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinical
{
    public partial class AddElectronicMedicalHistory : Form
    {
        public AddElectronicMedicalHistory()
        {
            InitializeComponent();
        }

        private void PatientMedicalHistory_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addPatientPersonalHistory f2 = new addPatientPersonalHistory();
            f2.Show();
            linkLabel1.LinkVisited = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPerson f2 = new AddPerson();
            f2.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into patientmedicalinfo values('" + page.Text + "','" + bloodtype.Text + "','" + bloodpressure.Text + "','" + vitamined.Text + "','" + anemia.Text + "','" + bodytemprature.Text + "','" + insulin.Text + "','" + textBox6.Text + "','" + haveyousurgery.Text + "','" + allergic.Text + "','" + breathingdis.Text + "','" + takingMedicatio.Text + "','" + visitedOrthopedist.Text + "','" + comboBox6.Text + "','" + cholesterol.Text + "','" + bloodglucose.Text + "','" + pictureBox1.Image + "','" + pictureBox3.Image + "','"+maskedTextBox1.Text+"','" +pname.Text+"')";
            adddoctorclass add = new adddoctorclass();
            try
            {
                add.adddoctor(query);
                MessageBox.Show("Patient Medical Info Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        Image Ximage;
        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                    Ximage = pictureBox1.Image;

                }
            }
        }
        Image labimage;
        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.Image = Image.FromFile(dialog.FileName);
                    labimage = pictureBox3.Image;

                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
