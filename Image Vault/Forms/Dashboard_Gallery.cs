using Image_Vault.Controllers;
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
    public partial class Dashboard_Gallery : Form
    {
        public Dashboard_Gallery()
        {
            InitializeComponent();
        }

        private void Dashboard_Gallery_Load(object sender, EventArgs e)
        {
             
            ImageList il = new ImageList();
            FileController fileController = new FileController();
            List<string> names = new List<string>();
            foreach (string GUID in fileController.GetAllImagesGUID())
            { 
                try
                {
                    string path =   fileController.VaultFolderPath()   + GUID;
                    Bitmap bmp = new Bitmap(path);
                    il.Images.Add(bmp);
                    names.Add("" );
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                    fileController.RestoreFile(GUID);
                } 
            }

            il.ImageSize = new Size(135, 150);
            int count = 0;
            listView1.LargeImageList = il;
            

            foreach (string s in names)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = s;
                lst.ImageIndex = count++;
                listView1.Items.Add(lst);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
