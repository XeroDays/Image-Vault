using Image_Vault.Controllers;
using Image_Vault.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Vault
{
    public partial class Dashboard_Main : Form
    {
        public Dashboard_Main()
        {
            InitializeComponent();
        }


        #region Method_Procedures

        /// <summary>
        /// This Function is used to Add Form inside the Dashboard Panel.
        /// </summary>
        /// <param name="myform">Form you want to insert inside the Dashboard Panel</param>
        private void uploadForm(Form myform)
        { 
            if (myform == null)
            {
                return;
            } 
            PanelDashboard.Controls.Clear(); 
            myform.TopLevel = false;
            PanelDashboard.Controls.Add(myform);
            myform.Dock = DockStyle.Fill;
            myform.Show(); 
        }

        #endregion

         

        private void btnLockImages_Click(object sender, EventArgs e)
        {
            uploadForm(new Dashboard_LockImages());
        }




        #region Form_Moving

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BorderLessForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void Dashboard_Main_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version : " + dataController.Version;
            btnLockImages.PerformClick();
            sysController.DeleteOldFiles();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            uploadForm(new AboutUs());
        }

        private void btnMyGallary_Click(object sender, EventArgs e)
        {
            uploadForm(new Dashboard_Gallery());
            // new Dashboard_Gallery().Show();
        }
 
    }



}
