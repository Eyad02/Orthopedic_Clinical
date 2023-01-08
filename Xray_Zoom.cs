using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Clinical
{
    
    public partial class Xray_Zoom : Form
    {
        Image picimage;
        public Xray_Zoom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                    picimage = pictureBox1.Image;

                }
            }

        }


        Image Zoom(Image im, Size size) 
        {
            Bitmap bmp = new Bitmap(im, im.Width + (im.Width * size.Width / 100), im.Height + (im.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0) 
            {
                pictureBox1.Image = Zoom(picimage, new Size(trackBar1.Value, trackBar1.Value));
            
            
            }
        }

        
    }
}
