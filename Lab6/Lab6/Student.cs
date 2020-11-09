using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Student
    {
        private Account acc;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private Book[] books;
        public Student()
        { 
            
        }

        public Student(string name,string id,string department,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
            books = new Book[5];
        }
        public void showInfo()
        {

        }
        public void BorrowBook(Book book)
        {

        }
        public void ReturnBook(Book book)
        {

        }

    }
}
