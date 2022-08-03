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
    public partial class UserControlSettings : UserControl
    {
        DataAccess connection;
        TextBox[] textBoxes;
        public Person LoggedPerson { get; set; }
        public UserControlSettings()
        {
            InitializeComponent();
            connection = new DataAccess();
            textBoxes = new TextBox[2]{textboxPassword, textboxPasswordRepeat};
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (textboxPassword.Text == textboxPasswordRepeat.Text)
            {
                var salt = PasswordHasher.GenerateSalt();
                var hashedPwd = PasswordHasher.Hash(textboxPassword.Text, salt);
                connection.ChangePassword(LoggedPerson, hashedPwd, Convert.ToBase64String(salt));
                MessageBox.Show("Password changed successfully.");
            }
            else MessageBox.Show("Passwords do not match");
        }

        private void UserControlSettings_VisibleChanged(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
    }
}
