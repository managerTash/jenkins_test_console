using System;

namespace TEST_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! And What is your name");
            string username = Console.ReadLine();
            Console.WriteLine("hello " + username + " how are you doing " + DateTime.Now.DayOfWeek);


        }
    }
}
