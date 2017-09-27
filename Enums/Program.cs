using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favourite car?");

            var answer = Console.ReadLine();
            if (answer.ToLower() == CarType.Skoda.ToString().ToLower()) //to lower because user might use small letters
            {
                Console.WriteLine("Me too, you rock!");
            }
            else
            {
                Console.WriteLine("Buy a " + CarType.Skoda);
            }

            Console.ReadLine();
        }
    }
    public enum CarType
    {
        Toyota,
        Honda,
        Ford,
        Skoda,
        Audi
    }
}
