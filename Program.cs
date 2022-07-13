using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05Example
{
    class Book
    {   //Q(a) declare two private variables
        private string strTitle;
        //Q(b) write R&W accessor for strTitle
        public string Title
        {
            get { return strTitle; }
            set { strTitle = value; }
        }
        private float fltPrice;
        //Q(c) write R&W accessor for fltPrice
        public float Price
        {
            get { return fltPrice; }
            set { fltPrice = value; }
        }
        public Book()   //empty construtor
        {
        }
        public Book(string strTitle, float fltPrice)
        {
            this.strTitle = strTitle;
            this.fltPrice = fltPrice;
        }
        public Book(string strTitle)
        {
            this.strTitle = strTitle;
            this.fltPrice = 2.0f;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book objBook1, objBook2;    //Q(f)
            objBook1 = new Book();
            Console.Write("Enter title of book1: ");
            string title1 = Console.ReadLine();
            Console.Write("Enter price of book1: ");
            float price1 = float.Parse(Console.ReadLine());
            objBook1.Title = title1;
            objBook1.Price = price1;

            Console.Write("Enter title of book2: ");
            string title2 = Console.ReadLine();
            Console.Write("Enter price of book2: ");
            float price2 = float.Parse(Console.ReadLine());
            objBook2 = new Book(title2, price2);
            Console.WriteLine("Book1: Title is {0}, price is {1}",
                objBook1.Title, objBook1.Price);
            Console.WriteLine("Book2: Title is {0}, price is {1}",
                objBook2.Title, objBook2.Price);

            Book objBook3 = new Book("Hunger Gaems Number 2");
            Console.WriteLine("Book3: Title is {0}, price is {1}",
                objBook3.Title, objBook3.Price);
        }
    }
}