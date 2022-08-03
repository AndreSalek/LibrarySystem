using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookRentingLibrary
{
    public class DataAccess
    {
        private SqlDataReader _reader;
        private SqlCommand _command;
        private SqlConnection _connection;
        /* Credentials to premade admin account in database - I write it here because password is salted
         * Email: admin@mail.cz
         * Password: admin
         */
        //change connection string to to your values so you can connect to database
        public string connectionString = "Server = DESKTOP-T4GSJ8V; Database=LibraryDatabase;Trusted_Connection=True";

        
        //Checks if email and password matches any database record
        public Person GetPerson (string email, string pwd)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                _command = new SqlCommand($"SELECT Id,FirstName,LastName,Email,IsAdmin FROM dbo.Person WHERE Email = '{email}' AND Password = '{pwd}'", _connection);
                _reader = _command.ExecuteReader();
                Person person = null;
                while (_reader.Read())
                {
                    person = new Person(_reader.GetInt32(0), _reader.GetString(1), _reader.GetString(2), _reader.GetString(3), _reader.GetBoolean(4));
                }
                _connection.Close();
                return person;
            }
        }
        //Get salt of existing Person, returned in string format
        //Returns null when Person is not registered
        public string GetPersonSalt(string email)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                _command = new SqlCommand($"SELECT Salt FROM dbo.Person WHERE Email = '{email}'", _connection);
                _reader = _command.ExecuteReader();
                string salt= null;
                while (_reader.Read())
                {
                    salt = _reader.GetString(0);
                }
                _connection.Close();
                return salt;
            }
        }
        //Returns books that person has currently rented
        public List<Book> GetRentedBooks(Person person)
        {
            List<Book> books = new List<Book>();
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                _command = new SqlCommand($"SELECT * FROM dbo.Book WHERE PersonID = '{person.ID}'", _connection);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    books.Add(new Book(_reader.GetInt32(0), _reader.GetString(1), _reader.GetString(2), _reader.GetString(3), _reader.GetString(4)));
                    //Checks for null values, prevents NullReferenceException
                    if ((_reader["ReturnDate"] == DBNull.Value) && (_reader["PersonID"] == DBNull.Value))
                    {
                        books.Last().ReturnDate = null;
                        books.Last().PersonId = null;
                    }
                    else
                    {
                        books.Last().ReturnDate = Convert.ToDateTime(_reader.GetString(5));
                        books.Last().PersonId = _reader.GetInt32(6);
                    }
                }
                _connection.Close();
                return books;
            }
        }
        //Returns all books currently available
        public List<Book> GetAvailableBooks()
        {
            List<Book> books = new List<Book>();
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                _command = new SqlCommand($"SELECT * FROM dbo.Book WHERE PersonID IS NULL", _connection);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    books.Add(new Book(_reader.GetInt32(0), _reader.GetString(1), _reader.GetString(2), _reader.GetString(3), _reader.GetString(4)));
                }
                _connection.Close();
                return books;
            }
        }
        //Register new Person in database, returns true if row was inserted successfuly
        public bool RegisterPersonToDatabase(string firstName, string lastName, string email, string pwd, string salt)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                _command = new SqlCommand("INSERT INTO dbo.Person(FirstName, LastName, Email, Password, Salt, IsAdmin) VALUES (@firstName, @lastName, @email, @pwd, @salt, @isAdmin)", _connection);
                _command.Parameters.AddWithValue("@firstName", firstName);
                _command.Parameters.AddWithValue("@lastName", lastName);
                _command.Parameters.AddWithValue("@email", email);
                _command.Parameters.AddWithValue("@pwd", pwd);
                _command.Parameters.AddWithValue("@salt", salt);
                _command.Parameters.AddWithValue("@isAdmin", 0);
                int numberOfRows = _command.ExecuteNonQuery();
                _connection.Close();

                if (numberOfRows > 0) return true;
                else return false;
            }
        }

        //Create new book record in database
        public void AddBookToDatabase(string title, string author, string language, string description)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                _command = new SqlCommand("INSERT INTO dbo.Book(Title, Author, Language, Description) VALUES (@title, @author, @language, @description)", _connection);
                _command.Parameters.AddWithValue("@title", title);
                _command.Parameters.AddWithValue("@author", author);
                _command.Parameters.AddWithValue("@language", language);
                _command.Parameters.AddWithValue("@description", description);

                _command.ExecuteNonQuery();
                _connection.Close();
            }
        }
        //Change Logged person's password
        public void ChangePassword(Person person, string newPwd, string newSalt)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                _command = new SqlCommand($"UPDATE dbo.Person SET Password = @pwd, Salt = @salt Where ID = @id", _connection);
                _command.Parameters.AddWithValue("@pwd", newPwd);
                _command.Parameters.AddWithValue("@salt", newSalt);
                _command.Parameters.AddWithValue("@id", person.ID);
                _command.ExecuteNonQuery();
                _connection.Close();
            }
        }
        //Update book to rented state by changing return date and assigning it to Person ID
        public void UpdateBook(Book book, Person person , string returnDate = null)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                _command = new SqlCommand($"UPDATE dbo.Book SET ReturnDate = @returnDate, PersonID = @personID Where BookID = @bookID", _connection);
                _command.Parameters.AddWithValue("@bookID", book.ID);
                _command.Parameters.AddWithValue("@returnDate", returnDate);
                _command.Parameters.AddWithValue("@personID", person.ID);
                _command.ExecuteNonQuery();
                _connection.Close();
            }
        }
    }
}
