using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Profile_App
{
    public partial class Profils : Form
    {
        public Profils()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateProfil createProfil = new CreateProfil();
            createProfil.Show();
        }
    }
}
