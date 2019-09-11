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
            int age ;
            String address = "";

            Console.WriteLine("Plz enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("Plz enter your age ");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Plz enter your address ");
            address = Console.ReadLine();
            Console.WriteLine(name+","+age+","+address  );
          
            Console.ReadKey();
        }
    }
}
