using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everyone");
            greetBlack();
        }

        public static void greetWhite()
        {
            Console.WriteLine("Hello white");
        }

        public static void greetBlack()
        {
            Console.WriteLine("Hello black");
        }
    }
}