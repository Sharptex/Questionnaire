using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("Enter your birthdate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Your birthdate is {0}", birthDate.ToString("dd.MM.yyyy"));

            Console.ReadKey();
        }
    }
}
