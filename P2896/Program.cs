using System;

namespace 백준
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] 주스양 = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            double[] 주스비율 = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            double Min = Math.Min(주스양[0] / 주스비율[0], Math.Min(주스양[1] / 주스비율[1], 주스양[2] / 주스비율[2]));
            Console.WriteLine("{0:F10} {1:F10} {2:F10}", 주스양[0] - 주스비율[0] * Min, 주스양[1] - 주스비율[1] * Min, 주스양[2] - 주스비율[2] * Min);
            Console.ReadLine();
        }
    }
}
