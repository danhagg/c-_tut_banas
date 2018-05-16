using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] favNums = new int[3];
            favNums [0] = 23;
            Console.WriteLine("favNum [0]: {0}", favNums[0]);

            string[] customers = { "bill", "dan", "ste" };

            var employees = new[] { "sara", "Jill", "Liz" };

            object[] randomArray = { "Paul", 45, 1.234 };

            Console.WriteLine(employees.GetType());
            Console.WriteLine(randomArray.GetType());

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array {0} : Value : {1}", i, randomArray[i]);
            }

            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Jacki", "Cahn" } };
            Console.WriteLine("MD Value : {0}", custNames.GetValue(0, 1));

            int[] randNums = { 1, 4, 9, 2 };
            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine("This {0}", randNums);

            randNums.SetValue(100, 3);
            PrintArray(randNums, "For Each");

            Console.WriteLine("1 at index : {0}, ", Array.IndexOf(randNums, 1));


            int[] srcArray = { 1, 2, 3, 4 };
            int[] destArray = new int[2];
            int StartInd = 0;
            int length = 2;
            Array.Copy(srcArray, StartInd, destArray, StartInd, length);
            PrintArray(destArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);

            foreach(int m in anotherArray) 
            {
                Console.WriteLine("CopyTo: {0}", m);
            }



            int[] numArray = { 1, 11, 22 };
            Console.WriteLine("> 10 : {0}", Array.FindIndex(numArray, GT10));



            Console.ReadLine();
        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        private static bool GT10(int val)
        {
            return val > 10;
        }
    }
}
