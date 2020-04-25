using Image_Vault.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void Form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form_DragDrop(object sender, DragEventArgs e)
        { 
            string[] dropped = ((string[])e.Data.GetData(DataFormats.FileDrop));
            List<string> DraggedGFiles = dropped.ToList();

            if (!DraggedGFiles.Any())
                return;

            foreach (string drop in dropped)
                if (Directory.Exists(drop))
                    DraggedGFiles.AddRange(Directory.GetFiles(drop, "*.jpg", SearchOption.AllDirectories));
            int count = 0;
            foreach (var item in DraggedGFiles)
            {
                count++;
            }
            lockFiles(DraggedGFiles);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ss = new FolderBrowserDialog();
            if (ss.ShowDialog() == DialogResult.OK)
            {  
                List<string> DraggedGFiles = new List<string>(); 
                if (Directory.Exists(ss.SelectedPath))
                DraggedGFiles.AddRange(Directory.GetFiles(ss.SelectedPath, "*.jpg", SearchOption.AllDirectories));
                int count = 0;
                foreach (var item in DraggedGFiles)
                {
                    count++;
                }
                lockFiles(DraggedGFiles);
            }
        }

        private void lockFiles(List<string> list_imageFiles)
        {
            FileController  fileController = new FileController();
            foreach (string filePath in list_imageFiles)
            {
                FileInfo file = new FileInfo(filePath);
                string GUID = fileController.Move_To_Vault(file);
                sysController.AddRecord(file.FullName, GUID);
            }
        } 
    }
}
