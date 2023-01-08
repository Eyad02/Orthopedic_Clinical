using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical
{
    public partial class DoctorProfile : Form
    {
        public DoctorProfile()
        {
            InitializeComponent();
        }

        private void DoctorView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorViewApp f2 = new DoctorViewApp();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoctorLogin lg = new DoctorLogin();
            lg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FollowUp fp = new FollowUp();
            fp.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MedicalRecord mr = new MedicalRecord();
            mr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doc_Integrated_View di = new Doc_Integrated_View();
            di.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prescription pr = new Prescription();
            pr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Xray_Zoom xz = new Xray_Zoom();
            xz.Show();
            this.Hide();
        }
    }
}
