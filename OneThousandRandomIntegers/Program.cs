using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneThousandRandomIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randomIntegers = new int[1000];

            Console.WriteLine("******* 1000 Random Integers *******");

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = random.Next();
                Console.WriteLine(randomIntegers[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
