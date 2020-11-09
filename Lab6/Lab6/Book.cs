using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Book
    {
        private string  bookName;

        public string  BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }
        public Book()
        {

        }
        public Book(string bookName,string bookAuthor,string bookId,string bookType,int bookCopy  )
        {

        }
        public void ShowInfo()
        {

        }
        public void AddBookCopy(int x)
        {

        }
    }
}
