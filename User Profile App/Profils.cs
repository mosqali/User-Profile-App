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

        private void ClearTextBoxes()
        {
            tbName.Text = String.Empty;
            tbAge.Text = String.Empty;
            tbGender.Text = String.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(tbName.Text != String.Empty || tbAge.Text != String.Empty || tbGender.Text != String.Empty)
            {
                dgvProfils.Rows.Add(tbName.Text, tbAge.Text, tbGender.Text);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Fill in every Textbox");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
