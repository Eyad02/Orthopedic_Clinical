using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical
{
    public partial class PatientProfile : Form
    {
        public PatientProfile()
        {
            InitializeComponent();
        }

        private void PatientProfile_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new addPatientPersonalHistory();
            f2.Show();
            linkLabel2.LinkVisited = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddElectronicMedicalHistory f2 = new AddElectronicMedicalHistory();
            f2.Show();
            linkLabel3.LinkVisited = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new FollowUp();
            f2.Show();
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new XRays();
            f2.Show();
            linkLabel4.LinkVisited = true;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new LabResult();
            f2.Show();
            linkLabel5.LinkVisited = true;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new MedicalRecord();
            f2.Show();
            linkLabel6.LinkVisited = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new Prescription();
            f2.Show();
            linkLabel7.LinkVisited = true;
        }
    }
}
