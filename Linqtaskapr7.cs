using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace LINQ
{
    class Linqtaskapr7
    {
       
        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int price { get; set; }
        }
        public static void Main()
        {
            IList<Book> BookData = new List<Book>()
            {
                new Book() { BookId = 1, Title = "Power of your Subconscious Mind", Author ="Dr.Joseph Murphy" , price=99},
                new Book() { BookId = 2, Title = "Thinking fast and slow", Author ="Daniel Kahneman" , price=325},
                new Book() { BookId = 3, Title = "Indian Economy", Author ="Ramesh Singh" , price=550},
                new Book() { BookId = 4, Title = "The Great Gatsby", Author ="Mr.Scott" , price=44},
                new Book() { BookId = 5, Title = "Everyone has a story", Author ="Savi Sharma" , price=97}

            };
            //Display all data
            var qry = from books in BookData
                      select books;
            foreach (var b in qry)
                Console.WriteLine(b.BookId+"  "+b.Title+"  "+b.Author+"  "+b.price);

            Console.WriteLine("********************");

            //Display books by particular author
            Console.WriteLine("Enter the Author name(Dr.Joseph Murphy,Daniel Kahneman,Ramesh Singh,Mr.Scott,Savi Sharma)");
          
             string v = Console.ReadLine(); 
             var qry3 = from books in BookData
                   select books;
             foreach (var d in qry)
                 if (v==d.Author)
                {
                    Console.WriteLine(d.Author);
                 }
            //Price lowest to highest
            var qry1 = from books in BookData
            orderby books.price
                  select books;
             foreach(var a in qry1)
             Console.WriteLine(a.price + "  " + a.Title);

            Console.WriteLine("********************");
            //Author name in ascending order

            var qry2 = from books in BookData
                    orderby books.Author
                    select books;
            foreach (var c in qry)
                Console.WriteLine(c.Author);

        }
    }
}
