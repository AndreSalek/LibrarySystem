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
    public partial class UserControlLogin : UserControl
    {
        public event EventHandler<LoginEventArgs> LoginCompleted;
        DataAccess connection;
        System.Timers.Timer timer;
        TextBox[] textBoxes;

        public UserControlLogin()
        {
            InitializeComponent();
            connection = new DataAccess();
            textBoxes = new TextBox[2] { textboxEmail, textboxPassword };
            labelWarning.Hide();
        }
        protected virtual void OnLoginCompleted(object? sender, LoginEventArgs e)
        {
            LoginCompleted?.Invoke(sender, e);
        }

            private void buttonLogin_Click(object sender, EventArgs e)
            {
            try
            {
                //Check if boxes are filled properly
                if (String.IsNullOrEmpty(textboxEmail.Text) || String.IsNullOrEmpty(textboxPassword.Text)) AddTextToNotificationLabel("Fill the boxes to login.");
                else if (textboxEmail.Text.Length < 4 && textboxPassword.Text.Length < 4) AddTextToNotificationLabel("Email or password is incorrect.");
                else
                {
                    //Look for database record of given email, returns salt if it exists
                    var salt = connection.GetPersonSalt(textboxEmail.Text);
                    if (salt == null) AddTextToNotificationLabel("Email or password is incorrect.");
                    else
                    {
                        //Convert salt from string to byte array
                        var hashedPwd = PasswordHasher.Hash(textboxPassword.Text, Convert.FromBase64String(salt));
                        //Try to login if credentials are correct
                        Person person = connection.GetPerson(textboxEmail.Text, hashedPwd);
                        if (person == null) AddTextToNotificationLabel("Email or password is incorrect.");
                        else
                        {
                            //If Login is successful, invoke event
                            var args = new LoginEventArgs();
                            args.Person = person;
                            OnLoginCompleted(this, args);
                        }
                    }
                }
            }
            catch (Exception ex)  //add different catch
            {
                MessageBox.Show(ex.Message);
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

        private void UserControlLogin_VisibleChanged(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
    }

    public class LoginEventArgs
    {
        public Person Person { get; set; }
    }
    
}
