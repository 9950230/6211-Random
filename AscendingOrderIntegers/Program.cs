using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendingOrderIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randomIntegers = new int[1000];

            Console.WriteLine("******* 1000 Random Integers, Sorted Ascending *******");

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = random.Next();
            }

            Array.Sort(randomIntegers);

            foreach (int randomInteger in randomIntegers)
            {
                Console.WriteLine(" " + randomInteger + " ");
            }

            Console.ReadLine();
        }
    }
}
