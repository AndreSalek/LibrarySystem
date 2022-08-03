using BookRentingLibrary;

namespace BookRentingUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            HideAllButtons();
            HideAllUserControls();

            btnRegisterForm.Show();
            userControlLogin1.Show();
            userControlLogin1.LoginCompleted += UserControlLogin1_LoginCompleted;
        }

        private void UserControlLogin1_LoginCompleted(object? sender, LoginEventArgs e)
        {
            HideAllUserControls();
            btnRegisterForm.Hide();
            btnProfile.Show();
            btnRentedBooks.Show();
            btnAvailableBooks.Show();
            btnSettings.Show();
            btnLogout.Show();

            if(e.Person.IsAdmin) btnAdminPanel.Show();
            ChangeLoggedPerson(e.Person);
            //userControlSettings1.LoggedPerson = e.Person;
            BtnProfile_Click(this, EventArgs.Empty);
            
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(46, 51, 73);
            HideAllUserControls();
            userControlProfile1.Show();
        }

        private void BtnRentedBooks_Click(object sender, EventArgs e)
        {
            btnRentedBooks.BackColor = Color.FromArgb(46, 51, 73);
            HideAllUserControls();
            userControlRentedBooks1.Show();
        }

        private void BtnAvailableBooks_Click(object sender, EventArgs e)
        {
            btnAvailableBooks.BackColor = Color.FromArgb(46, 51, 73);
            HideAllUserControls();
            userControlAvailableBooks1.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            HideAllUserControls();
            userControlSettings1.Show();
            
        }

        private void BtnAdminPanel_Click(object sender, EventArgs e)
        {
            btnAdminPanel.BackColor = Color.FromArgb(46, 51, 73);
            HideAllUserControls();
            userControlAdmin1.Show();
        }

        private void BtnLoginForm_Click(object sender, EventArgs e)
        {
            btnLoginForm.BackColor = Color.FromArgb(46, 51, 73);
            HideAllUserControls();
            HideAllButtons();
            btnRegisterForm.Show();
            userControlLogin1.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
            ChangeLoggedPerson(null);
            BtnLoginForm_Click(this, EventArgs.Empty);
        }

        private void BtnRegisterForm_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            HideAllButtons();
            btnLoginForm.Show();
            userControlRegister1.Show();
            btnRegisterForm.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnRentedBooks_Leave(object sender, EventArgs e)
        {
            btnRentedBooks.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAvailableBooks_Leave(object sender, EventArgs e)
        {
            btnAvailableBooks.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAdminPanel_Leave(object sender, EventArgs e)
        {
            btnAdminPanel.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnLoginForm_Leave(object sender, EventArgs e)
        {
            btnLoginForm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnRegisterForm_Leave(object sender, EventArgs e)
        {
            btnRegisterForm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }
        //Hide all user controls
        private void HideAllUserControls()
        {
            userControlLogin1.Hide();
            userControlRegister1.Hide();
            userControlAvailableBooks1.Hide();
            userControlRentedBooks1.Hide();
            userControlProfile1.Hide();
            userControlSettings1.Hide();
            userControlAdmin1.Hide();
        }

        //Hide all buttons 
        private void HideAllButtons()
        {
            btnProfile.Hide();
            btnRentedBooks.Hide();
            btnAvailableBooks.Hide();
            btnSettings.Hide();
            btnAdminPanel.Hide();
            btnLoginForm.Hide();
            btnLogout.Hide();
            btnRegisterForm.Hide();
        }

        public void ChangeLoggedPerson(Person person)
        {
            userControlProfile1.LoggedPerson = person;
            userControlRentedBooks1.LoggedPerson = person;
            userControlSettings1.LoggedPerson = person;
            userControlAvailableBooks1.LoggedPerson = person;
        }
    }
}