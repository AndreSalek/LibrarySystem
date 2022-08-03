 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentingLibrary
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public DateTime? ReturnDate { get; set; }        //Can be null
        public int? PersonId { get; set; }               //Stores Id of Person who has that book rented, can be null

        public Book(int id, string title, string author, string language, string description)
        {
            ID = id;
            Title = title;
            Author = author;
            Language = language;
            Description = description;
        }
        public Book(int id, string title, string author, string language, string description, DateTime? date, int? personId)
        {
            ID = id;
            Title = title;
            Author = author;
            Language = language;
            Description = description;
            ReturnDate = date;
            PersonId = personId;
        }
    }
}
