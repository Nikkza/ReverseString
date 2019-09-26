using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string value = Console.ReadLine();
                if (value.ToLower() == "q") break;
                if (Extension.CheckforNumbers(value))
                    Console.WriteLine("Value can only be from A-Ö");
                else
                {
                    string result = RevereString(value);
                    Console.WriteLine($"REVERS STRING: {result} ");
                }
            }
        }

        static string RevereString(string value)
        {
            string result = string.Join(" ", value
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));

            return result;
        }
    }
}
