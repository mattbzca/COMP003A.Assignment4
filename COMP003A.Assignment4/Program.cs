/*
 * Author: Matthew Tan
 * Course: COMP003A
 * Purpose: Week 4 Assingment
 *
*/
using System.Xml;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));
            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in the array");
            Console.WriteLine("".PadRight(50, '*'));
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            foreach (var item in friends)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);

            Console.WriteLine("\n");

            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }
        }
    }
}