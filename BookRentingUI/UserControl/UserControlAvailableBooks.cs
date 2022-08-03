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
    public partial class UserControlAvailableBooks : UserControl
    {
        public Person LoggedPerson { get; set; }
        string datePattern = "dd/MM/yyyy";
        DataAccess connection;
        List<Book> books;
        public UserControlAvailableBooks()
        {
            InitializeComponent();
            connection = new DataAccess();
            books = new List<Book>();
        }

        private void UserControlAvailableBooks_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            ListAvailableBooks();
        }

        private void ListAvailableBooks()
        {
            books.Clear();
            foreach (var book in connection.GetAvailableBooks())
            {
                int rowId = dgvAvailableBooks.Rows.Add();
                DataGridViewRow row = dgvAvailableBooks.Rows[rowId];
                books.Add(book);
                row.Cells["Title"].Value = book.Title;
                row.Cells["Author"].Value = book.Author;
                row.Cells["Language"].Value = book.Language;
                row.Cells["Description"].Value = book.Description;
            }
        }

        private void SetupDataGridView()
        {
            dgvAvailableBooks.RowHeadersVisible = false;
            dgvAvailableBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvAvailableBooks.AllowUserToResizeRows = false;
            DataGridViewColumn titleColumn = new DataGridViewTextBoxColumn();
            {
                titleColumn.Name = "Title";
                titleColumn.HeaderText = "Title";
                titleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAvailableBooks.Columns.Add(titleColumn);
            }
            DataGridViewColumn authorColumn = new DataGridViewTextBoxColumn();
            {
                authorColumn.Name = "Author";
                authorColumn.HeaderText = "Author";
                authorColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAvailableBooks.Columns.Add(authorColumn);
            }
            DataGridViewColumn languageColumn = new DataGridViewTextBoxColumn();
            {
                languageColumn.Name = "Language";
                languageColumn.HeaderText = "Language";
                languageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAvailableBooks.Columns.Add(languageColumn);
            }
            DataGridViewColumn descColumn = new DataGridViewTextBoxColumn();
            {
                descColumn.Name = "Description";
                descColumn.HeaderText = "Description";
                descColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAvailableBooks.Columns.Add(descColumn);
            }
            DataGridViewButtonColumn rentButton = new DataGridViewButtonColumn();
            {
                rentButton.UseColumnTextForButtonValue = true;
                rentButton.HeaderText = "Rent book for month";
                rentButton.Name = "Rent book";
                rentButton.Text = "Rent book";
                dgvAvailableBooks.Columns.Add(rentButton);
            }
        }

        private void UserControlAvailableBooks_SizeChanged(object sender, EventArgs e)
        {
            dgvAvailableBooks.Height = (int)(this.Height * 0.75);
        }

        private void dgvAvailableBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //Gets current column position  and checks if the event is type DataGridView and ColumnIndex is last position (button position)
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    //Rent book for month;
                    DateTime rentTime = DateTime.Now.AddMonths(1);
                    string stringFormat = rentTime.ToString(datePattern);
                    connection.UpdateBook(books[e.RowIndex], LoggedPerson, stringFormat);
                    MessageBox.Show("Book rented.");
                    dgvAvailableBooks.Rows.Clear();
                    ListAvailableBooks();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error has occured, try again." + ex.Message);
                }
            }
            else
            {
                //dgvAvailableBooks.CurrentCell = null;
            }
        }

        private void dgvAvailableBooks_VisibleChanged(object sender, EventArgs e)
        {
            dgvAvailableBooks.Rows.Clear();
            ListAvailableBooks();
        }

        private void dgvAvailableBooks_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvAvailableBooks.CurrentCell is DataGridViewTextBoxCell) dgvAvailableBooks.CurrentCell = null;
        }
    }
}
