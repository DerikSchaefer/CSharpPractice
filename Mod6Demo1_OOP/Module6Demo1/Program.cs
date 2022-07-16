using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book(100, "prog in C3", "wrox"); // We are invoking something called a constructor here. 

            Console.WriteLine($"Book1 details are {book.BookId}, {book.BookName}, {book.BookAuthor}");

            Console.WriteLine("Please enter book2 details:");

            Book book2 = new Book();
            book2.BookId = Int32.Parse(Console.ReadLine());
            book2.BookName = Console.ReadLine();
            book2.BookAuthor = Console.ReadLine();
            Console.WriteLine($"Book2 details are {book2.BookId}, {book2.BookName}, {book2.BookAuthor}");
            Console.ReadLine();


            Address myAddress = new Address();
            myAddress.StreetNumber = 22; //set block

        }
    }
}




