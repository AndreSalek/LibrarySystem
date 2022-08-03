using BookRentingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentingUI
{
    public partial class UserControlProfile : UserControl
    {
        public Person LoggedPerson { get; set; }
        public UserControlProfile()
        {
            InitializeComponent();
        }

        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            lblFullName.Text = $"{LoggedPerson.FirstName} {LoggedPerson.LastName}";
            lblEmail.Text = LoggedPerson.Email;
        }
    }
}
