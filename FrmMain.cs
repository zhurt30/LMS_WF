
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LMS_WindowsForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;


            loginForm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

