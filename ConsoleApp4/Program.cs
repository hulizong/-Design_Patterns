using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        { 
          var Get= Singleton4.Instance.GetString();
            Console.WriteLine(Get);
            Console.ReadLine();
        }
    }
}
