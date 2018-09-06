using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int otherNumber = number++;

           // Console.WriteLine(number);// =6

            int thirdNumber = ++number;

            Console.WriteLine(number); //7
            Console.WriteLine(otherNumber);//5
            Console.WriteLine(thirdNumber);//7

            string name = "Natasha Love";
            string prof = "Greg Morris";

            Console.WriteLine("The numbers are {0} and {1}.", number, otherNumber);
            Console.WriteLine($"The numbers are {number} and {otherNumber}."); // $ - сообщает программе, что использует такой формат и что в {} - variables, not string/words.
            Console.WriteLine($"The numbers are {number,5} and {otherNumber, 5}."); 
            Console.WriteLine($"The numbers are {number, -5} and {otherNumber}."); 
            Console.WriteLine("The numbers are {0,-5} and {1}.", number, otherNumber);// second digit (-5) in {} - number of spaces before(+) or after (-) the variable.

            //two ways to make int look like CURRENCY:
            Console.WriteLine("The number is {0, 7}.", number.ToString("C"));// 7 - number of spaces
            Console.WriteLine($"The number is {number.ToString("C"),7}.");// $ - сообщает программе, что использует такой формат и что в {} - variables, not string/words.

            Console.WriteLine("{0,4}+{1,-4}={2,-4}", number, otherNumber, number+otherNumber);
            Console.WriteLine($"{number,4}+{otherNumber,4}={number+otherNumber,4}", number, otherNumber, number + otherNumber);// 4 - number of spaces

            Console.WriteLine("Does {0} equal {1}? {2}", name, prof, String.Equals(name, prof));// method String.Equals - compares strings - if equal = true, not - false
            Console.WriteLine("How does {0} compare to {1}? {2}", name, prof, String.Compare(name, prof));// method String.Comapre - compares strings - if 1st alphabetically less -produces= -1,
            //if 1st alphabetically more= +1. If the same = 0.
            // "Is {0} alphabetically before {1}? {2}", name .... etc variables

            Console.WriteLine("The length of my name is {0}", name.Length);//returns a number of characters - INCLUDING SPACES!
            Console.WriteLine("The second and third characters of my name are {0}.", name.Substring(1,2)); // counts from 0 

            // to get input from users: Console.ReadLine () -method - stores user's input in a variable 
            Console.Write("Enter some input : ");
            string input = Console.ReadLine();
            int newNumber = Int32.Parse(input); // Int32 - class to convert string into int with method .Parse()
            Console.WriteLine(newNumber);


            //WriteLine - adds a new line; Write - stays in the same line.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
