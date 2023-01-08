using Clinical.Orthopedic_DBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Internal;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new AddElectronicMedicalHistory();
            f2.Show();
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new addPatientPersonalHistory();
            f2.Show();
            linkLabel2.LinkVisited = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "insert into Doctorinfo values('"+ maskedTextBox2.Text + "','"+ textBox18.Text + "','"+ textBox15.Text + "','"+ textBox14.Text + "','"+ textBox13.Text+"','" +maskedTextBox3.Text+"','"+dateTimePicker3.Value+"','"+comboBox1.Text+"')";
            adddoctorclass add = new adddoctorclass();
            try
            {
                add.adddoctor(query);
                MessageBox.Show("Doctor Inserted");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "insert into Nurseinf values('" + maskedTextBox1.Text + "','" + textBox12.Text + "','" + maskedTextBox4.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + dateTimePicker2.Value + "','" + textBox9.Text + "','" + comboBox2.Text+ "')";
            adddoctorclass add = new adddoctorclass();
            try
            {
                add.adddoctor(query);
                MessageBox.Show("Nurse Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NurseView nv = new NurseView();
            nv.Show();
            this.Hide();
        }
    }
}
