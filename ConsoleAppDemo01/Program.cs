using System;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleAppDemo01
{
    class Program
    {
        private static readonly Stream fs;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
      
            SomeMethod("Good");
            DoSomething();
            Console.ReadLine();
        }

        public static void  DoSomething()
        {
            // Do nothing because of X and Y.
            //Console.WriteLine("Do Work");
        }

        public static void GetGuid(byte[] bytes)
        {
            //var g1 = Guid.Empty;
            //var g2 = Guid.NewGuid();
            //var g3 = new Guid(bytes);

            var g = new Guid();
        }
        private static void SomeMethod(string val)
        {

            bool blnWork = true;

            if (val == "Good")
                blnWork = true;
            else
                blnWork = false;
            if (blnWork)
                Console.WriteLine("Good Work");
            else
                Console.WriteLine("Needs Inprovement");

            
        }

        public static void unsecuredeserialization(string typeName)
        {
            // ....
            ExpectedType obj = null;
            Type t = Type.GetType(typeName); // typeName is user-controlled
            XmlSerializer serializer = new XmlSerializer(t); // Noncompliant
            obj = (ExpectedType)serializer.Deserialize(fs);
            // ....

            //// ....
            //ExpectedType obj = null;
            //XmlSerializer serializer = new XmlSerializer(typeof(ExpectedType)); // Compliant
            //obj = (ExpectedType)serializer.Deserialize(fs);
            //// ....
        }
    }

    internal class ExpectedType
    {
    }
}
