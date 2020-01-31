using System;

namespace UserInputKellyDuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Kelly Duong");
            Console.WriteLine("Type good evening and hit enter!");
            string greeting;
            greeting = Console.ReadLine();
            Console.WriteLine("You typed: " + greeting);
        }
    }
}
