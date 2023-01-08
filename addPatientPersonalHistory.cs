
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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinical
{
    public partial class addPatientPersonalHistory : Form
    {
        string filename;
        public addPatientPersonalHistory()
        {
            InitializeComponent();
        }

        private void PatientPersonalHistory_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddElectronicMedicalHistory f2 = new AddElectronicMedicalHistory();
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
            string query = "insert into patientinfo values('"+maskedTextBox1.Text+"','"+Pname.Text+"','"+comboBox2.Text+"','"+Page.Text+"','"+dateTimePicker1.Value.Date+"','"+comboBox3.Text+"','"+Occupation.Text+"','"+Height.Text+"','"+weight.Text+"','"+Preligion.Text+"','"+comboBox6.Text+"','"+Habits_important_for_medical.Text+"','"+Salary.Text+"','"+Address.Text+"','"+Pcity.Text+"','"+no_of_children.Text+"','"+maskedTextBox4.Text+"','"+Email.Text+"','"+ParentName.Text+"','"+bloodtypecb.Text+"','"+Pgovernerate.Text+"','"+insurancecompany.Text+"','"+insurancePhone.Text+"','"+insuranceAddress.Text+"','"+pictureBox3.Image+"')";
            adddoctorclass add = new adddoctorclass();
            try
            {
                add.adddoctor(query);
                MessageBox.Show("Patient Info Inserted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void Pname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Page_TextChanged(object sender, EventArgs e)
        {

        }
        Image picimage;
        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filename = dialog.FileName;
                    filen.Text = filename;
                    pictureBox3.Image = Image.FromFile(filename);
                    picimage = pictureBox3.Image;

                }
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
