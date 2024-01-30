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
    public partial class UserControlProfile : UserControl
    {
        public UserControlProfile()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return lblName.Text;  }
            set { lblName.Text = value; }
        }

        public string Surname
        {
            get { return lblSurname.Text; }
            set { lblSurname.Text = value; }
        }

        public string Age
        {
            get { return lblAge.Text; }
            set { lblAge.Text = value; }
        }

        public string Gender
        {
            get { return lblGender.Text; }
            set { lblGender.Text = value; }
        }

    }
}
