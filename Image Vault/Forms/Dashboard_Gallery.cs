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
            var filesss = fileController.GetAllImagesGUID();
            foreach (string GUID in filesss)
            { 
                try
                {
                    string path =   fileController.VaultFolderPath()   + GUID;
                    // Image bmp = Image.FromFile(path);
                    Bitmap bmp = new Bitmap(path);
                    il.Images.Add(bmp); 
                    names.Add(GUID);
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

            int i = 0;
            foreach (string s in names)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = "Image "+ ++i;
                lst.Name = s; 
                lst.ImageIndex = count++;
                listView1.Items.Add(lst);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData==(Keys.Control | Keys.A))
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].Selected = true;
                }
               
            }
            return base.ProcessCmdKey(ref msg, keyData);
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

        private void btnRestore_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
                new FileController().RestoreFile(item.Name); 
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
                new FileController().DeleteFile(item.Name);
            } 
            MessageBox.Show("Files Permanently Deleted!","File Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
