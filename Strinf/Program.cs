using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strinf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string work;
            string age;
            string zodiak;

            Console.WriteLine("Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Где вы работаете?");
            work = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Console.ReadLine();
            Console.WriteLine("Какой у вас знак зодиака?");
            zodiak = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age}, по задиаку вы {zodiak} и работаете {work}");
            Console.ReadKey();
        }
    }
}
