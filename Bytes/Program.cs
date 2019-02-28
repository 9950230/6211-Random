using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            byte[] randomBytes = new byte[1000];

            random.NextBytes(randomBytes);

            Console.WriteLine("******* 1000 Random Bytes *******");

            foreach (byte randomByte in randomBytes)
            {
                Console.Write(" {0} ", randomByte);
            }

            Console.ReadKey();
        }
    }
}
