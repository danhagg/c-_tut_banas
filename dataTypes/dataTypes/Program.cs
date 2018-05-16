using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            decimal decPi = 3.163516725476154726547615472547625467521M;
            decimal decBigNum = 3.00000000000000000000000000000011M;
            Console.WriteLine("dec {0}", decPi + decBigNum);
            Console.WriteLine("Biggest integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest long : {0}", long.MinValue);

            DateTime awesomeDate = new DateTime(1976, 03, 13);
            Console.WriteLine("Day: {0} ", awesomeDate.DayOfWeek);
            */

            /*
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(0, 57, 0));
            Console.WriteLine(lunchTime.GetType());
            */

            Console.WriteLine("Currency : {0:c}", 23.4555);

            string randString = "This is a string";
            Console.WriteLine("String Length : {0}", randString.Length);
            Console.WriteLine("String contains is : {0}", randString.Contains("is"));
            Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));

            Console.WriteLine("Remove String : {0}", randString.Remove(0, 6));
            Console.WriteLine("Insert String : {0}", randString.Insert(0, "jibber jabber"));
            Console.WriteLine("Replace String : {0}", randString.Replace("i", "jibber jabber"));
            Console.WriteLine("Compare A to B : {0}",
                              String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Equals A to a : {0}",
                              String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            string newString = String.Format("{0} is a {1}", "Dan", "Prat");
            Console.WriteLine(newString);
        }
    }
}
