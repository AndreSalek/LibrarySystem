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
    public partial class UserControlRentedBooks : UserControl
    {
        DataAccess connection;
        public Person LoggedPerson { get; set; }
        public UserControlRentedBooks()
        {
            InitializeComponent();
            connection = new DataAccess();
        }

        private void UserControlRentedBooks_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            ListRentedBooks();
            
        }
        private void ListRentedBooks()
        {
            foreach (var book in connection.GetRentedBooks(LoggedPerson))
            {
                if(book.ReturnDate > DateTime.Now)
                {
                    book.ReturnDate = null;
                    book.PersonId = null;
                    connection.UpdateBook(book, LoggedPerson);
                    continue;
                }

                int rowId = dgvRentedBooks.Rows.Add();
                DataGridViewRow row = dgvRentedBooks.Rows[rowId];
                row.Cells["Title"].Value = book.Title;
                row.Cells["Author"].Value = book.Author;
                row.Cells["Language"].Value = book.Language;
                row.Cells["Description"].Value = book.Description;
                row.Cells["Return date"].Value = book.ReturnDate;
            }
        }

        private void SetupDataGridView()
        {
            dgvRentedBooks.RowHeadersVisible = false;
            dgvRentedBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvRentedBooks.AllowUserToResizeRows = false;
            DataGridViewColumn titleColumn = new DataGridViewTextBoxColumn();
            {
                titleColumn.Name = "Title";
                titleColumn.HeaderText = "Title";
                titleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRentedBooks.Columns.Add(titleColumn);
            }
            DataGridViewColumn authorColumn = new DataGridViewTextBoxColumn();
            {
                authorColumn.Name = "Author";
                authorColumn.HeaderText = "Author";
                authorColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRentedBooks.Columns.Add(authorColumn);
            }
            DataGridViewColumn languageColumn = new DataGridViewTextBoxColumn();
            {
                languageColumn.Name = "Language";
                languageColumn.HeaderText = "Language";
                languageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRentedBooks.Columns.Add(languageColumn);
            }
            DataGridViewColumn descColumn = new DataGridViewTextBoxColumn();
            {
                descColumn.Name = "Description";
                descColumn.HeaderText = "Description";
                descColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRentedBooks.Columns.Add(descColumn);
            }
            DataGridViewColumn returnDateColumn = new DataGridViewTextBoxColumn();
            {
                returnDateColumn.Name = "Return date";
                returnDateColumn.HeaderText = "Return date";
                returnDateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRentedBooks.Columns.Add(returnDateColumn);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dgvRentedBooks.CurrentCell = null;                                                  
        }

        private void dgvRentedBooks_VisibleChanged(object sender, EventArgs e)
        {
            dgvRentedBooks.Rows.Clear();
            ListRentedBooks();
        }
    }
}
