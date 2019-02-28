using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendingOrderDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] randomDoubles = new double[1000];

            Console.WriteLine("******* 1000 Random Doubles, Sorted Ascending *******");

            for (int i = 0; i < randomDoubles.Length; i++)
            {
                randomDoubles[i] = random.NextDouble() * 10;
            }

            Array.Sort(randomDoubles);

            foreach (double randomDouble in randomDoubles)
            {
                Console.WriteLine(" " + randomDouble + " ");
            }

            Console.ReadLine();
        }
    }
}
