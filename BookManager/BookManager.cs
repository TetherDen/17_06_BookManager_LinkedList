using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw_17_06_LinkedList
{
    internal class BookManager
    {
        public LinkedList<Book> BooksList;
        public BookManager()
        {
            BooksList = new LinkedList<Book>();
        }
        public BookManager(Book book)
        {
            BooksList = new LinkedList<Book>();
            BooksList.AddLast(book);
        }
        public void AddBook(Book book)
        {
            if (book != null) BooksList.AddLast(book);
        }
        public void RemoveBook(Book book)
        {
            BooksList.Remove(book);
        }
        public void ChangeBookGenre(Book book,string newGenre)
        {
            var node = BooksList.Find(book);
            if (node != null) node.Value.BookGenre = newGenre;
        }
        public void ChangeBookYear(Book book, int newYear)
        {
            if(newYear > 0)
            {
                LinkedListNode<Book> node = BooksList.Find(book);
                if (node != null) node.Value.ReleaseDate = newYear;
            }
        }
        public void ChangeBookName(Book book,string newName)
        {
            var node = BooksList.Find(book);     // заменить на var node
            if (node != null) node.Value.BookName = newName;
        }

        public Book SearchBookByName(string name)
        {
            foreach (var item in BooksList)
            {
                if(item.BookName == name)
                    return item;
            }
            return null;
        }
        public Book SearchBookByAuthorName(string authorName)
        {
            foreach(var item in BooksList)
            {
                if(item.AuthorName == authorName)
                    return item;
            }
            return null;
        }
        public Book SearchByAuthorNameAndYear(string name, int year)
        {
            foreach(var item in BooksList)
            {
                if(item.BookName == name && item.ReleaseDate == year)
                    return item;
            }
            return null;
        }
        public void AddBookFirst(Book book)
        {
            if (book != null) BooksList.AddFirst(book);
        }
        public void AddBookLast(Book book)
        {
            if (book != null) BooksList.AddLast(book);
        }

        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= BooksList.Count)
                {
                    throw new ArgumentOutOfRangeException("Error. Wrong get index");
                }
                var node = BooksList.First;
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }
                return node.Value;
            }
            set
            {
                if (index < 0 )
                {
                    throw new ArgumentOutOfRangeException("Error. Wrong set index");
                }
                if ( index >= BooksList.Count)  // .AddLast if index >= Count
                {
                    BooksList.AddLast((Book)value);
                }
                else if (index < BooksList.Count)
                {
                    var node = BooksList.First;
                    for (int i = 0; i < index; i++)
                    {
                        node = node.Next;
                    }
                    node.Value = value;
                }
            }
        }
        public int GetBookCount()
        {
            return BooksList.Count;
        }
        public void RemoveFirst()
        {
            BooksList.RemoveFirst();
        }
        public void RemoveLast()
        {
            BooksList.RemoveLast();
        }
        public void RemoveByIndex(int index)
        {
            if(index >= 0 && index < BooksList.Count)
            {
                var node = BooksList.First;
                for (int i = 0;i < index;i++)
                {
                    node = node.Next;
                }
                BooksList.Remove(node);
            }
        }
        public override string ToString()
        {
            foreach (var item in BooksList)
            { 
                Console.WriteLine(item);
            }
            return "";
        }
    }
}
