using System;

namespace ConsoleAppDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            someMethod("Good");

        }

        private static void someMethod(string val)
        {
            bool blnWork = true;
            //if (val == "Good")
            //    blnWork = true;
            //else
            //    blnWork = false;
            if (blnWork)
                Console.WriteLine("Good Work");
            else
                Console.WriteLine("Needs Inprovement");

            Console.ReadLine();
        }
    }
}
