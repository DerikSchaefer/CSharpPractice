using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6Demo1
{


    struct Address
    {
        public int StreetNumber { get; set; }   
        public int HouseNumber { get; set; }    
        public string City { get; set; }    
        public string State { get; set; }       
        public string PostalCode { get; set; }  

        // We haven't allocated any private fields here but the compilier does this for us. This seems to be the normal now. 


    }

    // Structures: It's a value type user defined complex data structure
    struct Book
    {

        // member fields. 

        // We are writing these as private because we are never going to give access to the member fields to people. 
        //Private is a key word which makes that particular function accessible only within that type.

        // Because these are private the scope of these are only going to be within this structure only.

        // Because a structure is a value type it is always allocated on the stack

        //declared private it's accessible only within the opening and closing bracket within that type. 
        private int bookId;
        private string bookName;
        private string bookAuthor;

        public int BookId
        {
            get
            {
                return this.bookId;
            }
            set
            {
                {
                    this.bookId = value;
                }
            }
        }
        public string BookName
        {

            get
            {
                return this.bookName;
            }
            set
            {
                this.bookName = value;
            }
        }
        //validation. This helps control and make sure that the data is in the proper format.

        // if we don't write the set block this property will be read only. If we write both get and set it will be read/write. 
        // access specifiers control access and keep data secure. 
        public string BookAuthor
        {
            get
            {
                return this.bookAuthor;
            }
            set
            {
                this.bookAuthor = value;
            }
        } // constructor: is a special method with the same name as that of struct/class
          //and is public and is written to initialze and allocate memory
        public Book(int bkid, string bkname, string author)
        {
            this.bookAuthor = author;
            this.bookId = bkid;
            this.bookName = bkname;

        }
    }
}