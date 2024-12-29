using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learns.Stacks
{
    public class BookStacks
    {
        Stack<Book> books = new Stack<Book>();

        public void Add(Book newBook)
        {
            if (books.Contains(newBook))
            {
                Console.WriteLine("El libro ya está en la pila");
                return;
            }

            books.Push(newBook);
        }


        public void Read()
        {
            if (books.Count <= 0)
            {
                Console.WriteLine("NO  hay libros en la pila");
                return;
            }

            books.Pop();
        }

        public void PrintTitules()
        {
            foreach (var book in books) Console.WriteLine(book.Name);
        }

        public void GetMain()
        {
            var books = new BookStacks();
            books.Add(new Book()
            {
                Name = "El principe"
            });
            books.Add(new Book()
            {
                Name = "The code",
                PublicateDay = DateTime.Now
            });

            Console.WriteLine("Ver todos los libros");
            books.PrintTitules();

            books.Read();
            Console.WriteLine("Ver todos los libros");
            books.PrintTitules();

            books.Read();
            books.Read();
            
            books.Add(new Book()
            {
                Name = "El principe"
            });
            books.PrintTitules();


        }
    }
}
