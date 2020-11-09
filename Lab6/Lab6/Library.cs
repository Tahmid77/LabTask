using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }
        private string libAdress;

        public string LibAdress
        {
            get { return libAdress; }
            set { libAdress = value; }
        }
        private Book[] listOfBook;

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }

        public Library()
        {

        }
        public Library(string libName,string libAdress,int totalBook)
        {
            this.libName = libName;
            this.LibAdress = libAdress;
            this.totalBook = totalBook;
            listOfBook = new Book[1000];
            totalBook = 0;
        }
        public void LibInfo()
        {
            System.Console.WriteLine("Library Name: "+libName);
            System.Console.WriteLine("Library Adress: " + libAdress);
            System.Console.WriteLine("Total Books: " + listOfBook);
        }
        public void ShowAllBooks()
        {

        }
        public void AddNewBook(Book book)
        {

        }
        public void DeleteBook(Book book)
        {

        }
        public void AddNewBookCopy(Book book,int copy)
        {

        }













    }
}
