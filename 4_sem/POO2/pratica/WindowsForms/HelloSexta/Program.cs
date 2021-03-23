using System;
using System.Data;

namespace HelloSexta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name??");
            string nome = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"Hello {nome} on {date:d} at {date:t}");
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }
    }
}
