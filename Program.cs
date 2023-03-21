using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonCell TopCell = new PersonCell("<sentinel>", null);

            int x = 0;
            while (x != 5)
            {
                Console.Clear();
                Console.WriteLine("Enter 0 to display the stack.");
                Console.WriteLine("Enter 1 to push a string to the stack.");
                Console.WriteLine("Enter 2 to pop the string from the stack.");
                Console.WriteLine(":");
                Console.WriteLine("Enter any other number to exit.\n\n");

                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Display the stack:");
                    for (PersonCell cell = TopCell; cell != null; cell = cell.Next)
                    {
                        Console.WriteLine(cell.Name);
                    }
                }
                else if (x == 1)
                {
                    Console.Write("Enter a name of the string to be pushed onto the stack: ");
                    string NewName = Console.ReadLine();

                    TopCell.push(NewName); //TopCell is the head of linklist
                }
                else if (x == 2)
                {
                    TopCell.pop();

                }

                else break;
                Console.WriteLine("Press space bar to continue.");
                Console.ReadKey();
            }
            //Console.ReadKey();
        }
    }
}