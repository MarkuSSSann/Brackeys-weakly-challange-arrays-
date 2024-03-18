using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackeys_weakly_challange__arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class");

            int arrLenght = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[arrLenght];

            for (int i = 0; i < students.Length; i++) {
                students[i] = Console.ReadLine();
            }

            Array.Sort(students);
            Console.WriteLine("\nHere is they alphabetically: \n");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            Console.ReadKey();
        }
    }
}
