using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._4
{
    interface CRUD
    {


        void AddRecord(Book book);

        void DeleteRecord(Book book);

        ICollection<Book> GetAllRecords();

        Book FindBook(int BookId);

        void UpdateRecord(int BookId, Book book);


        ICollection<Book> GetAllBooks();


    }

    class BookRepository : CRUD
    {
        PCAD7BooksEntities entities;

        public BookRepository()
        {
            entities = new PCAD7BooksEntities();
        }

        public void AddRecord(Book book)
        {
            entities.Books.Add(book);
            entities.SaveChanges();
        }

        public void DeleteRecord(Book book)
        {
            entities.Books.Remove(book);
            entities.SaveChanges();
        }

        public Book FindBook(int BookId)
        {
            return entities.Books.Find(BookId);
        }

        public ICollection<Book> GetAllBooks()
        {
            return entities.Books.ToList();
        }

 

        public int GetMaxId ()
        {
            return entities.Books.Max(p => p.BookId);
        }

        public ICollection<Book> GetAllRecords()
        {
            return entities.Books.ToList();
        }

    

        public void UpdateRecord(int BookId, Book book)
        {
            var bookToUpdate = entities.Books.Find(BookId);
            bookToUpdate.BookId = book.BookId;
            bookToUpdate.ISBN = book.ISBN;
            bookToUpdate.BookName = book.BookName;
            bookToUpdate.Author = book.Author;
            bookToUpdate.ReleaseDate = book.ReleaseDate;
            bookToUpdate.Copies = book.Copies;
            entities.SaveChanges();
        }
    }

}
