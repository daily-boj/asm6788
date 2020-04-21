using System;

namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            string Data = @"`1234567890-=QWERTYUIOP[]\ASDFGHJKL;'ZXCVBNM,./";
            while (true)
            {
                string Buffer = "";
                String input = Console.ReadLine();
                foreach (char one in input)
                {
                    int index = Data.IndexOf(one);
                    if (index != -1)
                    {
                        Buffer += Data[index - 1];
                    }
                    else
                    {
                        Buffer += one;
                    }
                }
                Console.WriteLine(Buffer);
            }
        }
    }
}
