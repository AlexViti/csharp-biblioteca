using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBiblioteca
{
    internal abstract class Document
    {
        public string Code { get; protected set; }
        public string Title { get; set; }
        public string Sector { get; set; }
        public int NumberOfCopies { get; set; }
        public int RentedCopies { get; }
        public int Rack { get; set; }
        public Author Author { get; set; }

        protected Document(string code, string title, string sector, int numberOfCopies, int rack, Author author)
        {
            Code = code;
            Title = title;
            Sector = sector;
            NumberOfCopies = numberOfCopies;
            RentedCopies = 0;
            Rack = rack;
            Author = author;
        }
    }

    internal class Book : Document
    {
        public long ISBN { get; set; }
        public int Pages { get; set; }
        
        public Book(long isbn, string title, string sector, int numberOfCopies, int rack, Author author, int pages)
            : base(isbn.ToString(), title, sector, numberOfCopies, rack, author)
        {
            ISBN = isbn;
            Pages = pages;
        }
    }

    internal class DVD : Document
    {
        public long SerialNumber { get; set; }
        public int Runtime { get; set; }

        public DVD(long serialNumber, string title, string sector, int numberOfCopies int rack, Author author, int runtime)
            : base(serialNumber.ToString(), title, sector, numberOfCopies, rack, author)
        {
            SerialNumber = serialNumber;
            Runtime = runtime;
        }
    }
}
