using System;

namespace 백준
{
    class Program
    {
        static ulong[] numbers = new ulong[100];
        static void Main(string[] args)
        {
            int test_case = int.Parse(Console.ReadLine());
            for (int i = 0; i != test_case; i++)
            {
                numbers[0] = 1;
                numbers[1] = 1;
                numbers[2] = 1;
                numbers[3] = 2;
                numbers[4] = 2;
                numbers[5] = 3;
                numbers[6] = 4;
                numbers[7] = 5;
                numbers[8] = 7;
                numbers[9] = 9;
                int input = int.Parse(Console.ReadLine());
                수열(input);
                Console.WriteLine(numbers[input - 1]);
            }
            Console.Read();
        }

        static void 수열(int input)
        {
            for (int i = 10; i < input; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 5];
            }
        }
    }
}
