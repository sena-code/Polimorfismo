using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rick rick = new Rick();

            Console.WriteLine("Rick");
            Console.WriteLine("-------------");
            rick.LeituradeMente();
            Console.WriteLine("-------------");
            rick.Telepatia();
            Console.WriteLine("-------------");
            rick.Invisibilidade();
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");


            Steve steve = new Steve();

            Console.WriteLine("Steve");
            Console.WriteLine("-------------");
            steve.LeituradeMente();
            Console.WriteLine("-------------");
            steve.Telepatia();
            Console.WriteLine("-------------");
            steve.Invisibilidade();
        }
    }
}
