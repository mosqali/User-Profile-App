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
    public partial class CreateProfil : Form
    {
        public CreateProfil()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserControlProfile ucprofile = new UserControlProfile();

            ucprofile.Name = tbName.Text;
            ucprofile.Surname = tbSurname.Text;
            ucprofile.Age = tbAge.Text;
            ucprofile.Gender = tbGender.Text;

            Profils profils = new Profils();
            profils.flpProfils.Controls.Add(ucprofile);

            this.Close();
        }
    }
}
