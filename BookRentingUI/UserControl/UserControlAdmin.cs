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
    public partial class UserControlAdmin : UserControl
    {
        DataAccess connection;
        TextBox[] textBoxes;
        public UserControlAdmin()
        {
            InitializeComponent();
            connection = new DataAccess();
            textBoxes = new TextBox[4] { textboxTitle, textboxAuthor, textboxLanguage, textboxDescription };
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            connection.AddBookToDatabase(textboxTitle.Text, textboxAuthor.Text, textboxLanguage.Text, textboxDescription.Text);
            MessageBox.Show("Book added.");
        }

        private void UserControlAdmin_VisibleChanged(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
    }
}
