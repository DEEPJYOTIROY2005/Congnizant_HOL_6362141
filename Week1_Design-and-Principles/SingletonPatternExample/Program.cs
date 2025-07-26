using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Hello from logger1!");
            logger2.Log("Hello from logger2!");

            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger1 and logger2 are the same instance.");
            }
            else
            {
                Console.WriteLine("Different instances exist!");
            }

            Console.ReadLine(); // Optional, keeps console open
        }
    }
}
