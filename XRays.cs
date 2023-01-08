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
    public partial class XRays : Form
    {
        public XRays()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new PatientProfile();
            f2.Show();
        }

        private void XRays_Load(object sender, EventArgs e)
        {

        }
    }
}
