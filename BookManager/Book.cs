using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_17_06_LinkedList
{

    internal class Book
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string BookGenre { get; set; }
        public DateTime _releaseDate;
        public int ReleaseDate
        {
            get { return _releaseDate.Year; }
            set { _releaseDate = new DateTime(value, 1, 1); }
        }

        public Book(string bookName, string authorName, string authorSurname, string bookGenre, int year)
        {
            BookName = bookName;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            BookGenre = bookGenre;
            _releaseDate = new DateTime(year,1,1);
        }
        public override string ToString()
        {
            return $"Name: {BookName}, Genre: {BookGenre}\nAuthorName: {AuthorName}, Surname: {AuthorSurname}\nRelease date: {ReleaseDate}\n";
        }

    }
}
