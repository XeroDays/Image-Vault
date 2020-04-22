using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Vault.Forms
{
    public partial class Dashboard_LockImages : Form
    {
        public Dashboard_LockImages()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AddImage();
          
        }

        private void Showorhide()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            pictureBox1.Hide();

            flowLayoutPanel1.Show();
        }

        private void AddImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Select Picture";
            ofd.Filter = "Picture(*.jpg;*.png;*.bmp;*.gif)| *.jpg;*.png;*.bmp;*.gif";
            var imagee = imageList1.Images; //later use--
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagee.Add(new Bitmap(ofd.FileName)); //for later use may be --
                foreach (string image in ofd.FileNames)
                {
                    PictureBox pb = new PictureBox();

                    // assign the image
                    pb.Image = new Bitmap(image);

                    // stretch the image
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    // set the size of the picture box
                    pb.Height = pb.Image.Height / 10;
                    pb.Width = pb.Image.Width / 10;

                    // add the control to the container
                    flowLayoutPanel1.Controls.Add(pb);
                    flowLayoutPanel1.Dock = DockStyle.Fill;
                    Showorhide();
                }
            }
        }

        private void Dashboard_LockImages_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Hide();
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
         
            
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            
        }
    }
}
