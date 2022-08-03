using BookRentingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentingUI
{
    public partial class UserControlRegister : UserControl
    {
        DataAccess connection;
        TextBox[] UserInfo;
        System.Timers.Timer timer;
        public UserControlRegister()
        {
            InitializeComponent();
            connection = new DataAccess();
            UserInfo = new TextBox[5]
           {
                textboxFirstName,
                textboxLastName,
                textboxEmail,
                textboxPwd,
                textboxPwdRepeat
           };
           labelWarning.Hide();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if textboxes are filled properly
                foreach (TextBox txt in UserInfo)
                {
                    if (String.IsNullOrEmpty(txt.Text)) AddTextToNotificationLabel($"You must fill {txt.PlaceholderText} box.");
                    else if (txt.Text.Length <= 4) AddTextToNotificationLabel($"Box {txt.PlaceholderText} is not long enough.");
                }
                if (!(textboxPwd.Text == textboxPwdRepeat.Text)) AddTextToNotificationLabel("Passwords do not match.");
                else if (!textboxEmail.Text.Contains("@")) AddTextToNotificationLabel("Email does not contain @.");
                else
                {
                    // get 16 byte salt 
                    byte[] salt = PasswordHasher.GenerateSalt();
                    //Hash password with generated salt
                    string hashedPassword = PasswordHasher.Hash(textboxPwd.Text, salt);
                    //Convert salt to string for storing in database
                    string stringSalt = Convert.ToBase64String(salt);
                    bool success = connection.RegisterPersonToDatabase(textboxFirstName.Text, textboxLastName.Text, textboxEmail.Text, hashedPassword, stringSalt);
                    if (success) AddTextToNotificationLabel("Registration was succesful. You can login now.");
                    else AddTextToNotificationLabel("Couldn't be registered, try different credentials.");
                }
            }
            catch (SqlException ex)
            {
                //If Email is already registered, this exception will occur (Email column in database has UNIQUE constraint)
                if (ex.Message.Contains("Violation of UNIQUE KEY"))
                {
                    AddTextToNotificationLabel("Email is already registered.");
                }
                else
                {
                    AddTextToNotificationLabel(ex.Message);
                }
            }
            catch (Exception ex)
            {
                AddTextToNotificationLabel("Error.");
            }
        }
        public void SetTimer()
        {
            timer = new System.Timers.Timer(5000);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
            timer.AutoReset = false;
            timer.Start();
        }
        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Action hideButton = () => labelWarning.Hide();
            this.Invoke(hideButton);
        }

        //Adds text to label with inputed text and shows it
        private void AddTextToNotificationLabel(string text)
        {
            labelWarning.Text = text;
            labelWarning.Show();
            SetTimer();
        }

        private void UserControlRegister_VisibleChanged(object sender, EventArgs e)
        {
            foreach (var textBox in UserInfo)
            {
                textBox.Clear();
            }
        }
    }
}
