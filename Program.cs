using System;
using Практика_проект__1.Classes;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ocean myOcean = new Ocean();
            myOcean.Initialize();
            myOcean.Run();
            Console.ReadKey();
        }
    }
}
