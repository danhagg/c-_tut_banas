using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpTut1.cs
{
    class Program
    {

        // main function, code starts executing here
        // static, this function belongs to class and can be executed without object
        // void, doesnt return a value after executing (may be int 0 or -1)
        static void Main(string[] args)
        {
            Console.WriteLine("hello");

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Arg {0}", i);
            }

            SayHello();

            Console.ReadLine();
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}: ", name);
        }

    }
}
