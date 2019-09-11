using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            String age = "";
            String address = "";

            Console.WriteLine("Plz enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("Plz enter your age ");
            age = Console.ReadLine();
            Console.WriteLine("Plz enter your address ");
            address = Console.ReadLine();
            Console.WriteLine("Hello:" + name  );
            Console.WriteLine("your age is:" + age);
            Console.WriteLine("your address is:" + address);
            Console.ReadKey();
        }
    }
}
