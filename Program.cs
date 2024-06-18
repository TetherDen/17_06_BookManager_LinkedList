namespace hw_17_06_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager Manager = new BookManager();
            Book bk1 = new Book("bookName1", "authorName1", "authorSName1", "genre1", 1999);
            Book bk2 = new Book("bookName2", "authorName2", "authorSName2", "genre2", 1977);
            Book bk3 = new Book("bookName3", "authorName3", "authorSName3", "genre3", 1566);
            Manager.AddBook(bk1);
            Manager.AddBook(bk2);
            Manager.AddBook(bk3);
            Manager.ChangeBookGenre(bk1, "NewGenre");
            Manager.ChangeBookYear(bk1, 1);
            Manager.ChangeBookName(bk1, "NewName");

            //Console.WriteLine(Manager.SearchBookByName("NewName"));
            //Console.WriteLine(Manager.SearchByAuthorNameAndYear("bookName2",1977));
            //Console.WriteLine(Manager.SearchBookByAuthorName("authorName3"));
            Book bk4 = new Book("newBook4", "authorName4", "authorSName4", "genre4", 1111);

            Manager[3] = bk4;  // set
            Book bk5 = Manager[3]; // get
            //Manager.RemoveFirst();
            //Manager.RemoveLast();
            //Manager.RemoveByIndex(1);

            Console.WriteLine(Manager);
            Console.WriteLine($"GetBookCount(): {Manager.GetBookCount()}");

        }
    }
}
