using System;

namespace helloapp_black
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from everyone, Ivan Domashnikh!!");
            greetBlack();
            greetWhite();
        }

        public static void greetWhite()
        {
            Console.WriteLine("Hello from white, Ivan Domashnikh!!");
        }
        
        public static void greetBlack()
        {
            Console.WriteLine("Hello from black, Ivan Domashnikh!!");
        }
    }
}