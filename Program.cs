using System;
using System.Linq;

namespace DingDongDitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nq = Console.ReadLine().Split(' ');
            int n = int.Parse(nq[0]);
            int q = int.Parse(nq[1]);

            int[] angerValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] ambitions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(angerValues);

            for (int i = 0; i < q; i++)
            {
                long sum = 0;
                for (int j = 0; j < ambitions[i]; j++)
                {
                    sum += angerValues[j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
