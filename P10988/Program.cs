using System;

namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            if(input == new string(charArray))
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}
