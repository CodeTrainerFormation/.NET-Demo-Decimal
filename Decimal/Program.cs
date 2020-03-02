using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // The problem :
            // bad calculation
            double value = 0.0;

            for (int i = 0; i < 100000; i++)
            {
                value += 0.1;
            }

            for (int i = 0; i < 100000; i++)
            {
                value -= 0.1;
            }


            if (value == 0.0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
                Console.WriteLine(value);
            }


            //// The solution :
            //// IEEE754
            //decimal value = 0.0M;

            //for (int i = 0; i < 100000; i++)
            //{
            //    value += 0.1M;
            //}

            //for (int i = 0; i < 100000; i++)
            //{
            //    value -= 0.1M;
            //}


            //if (value == 0.0M)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //    Console.WriteLine(value);
            //}

            Console.ReadLine();
        }
    }
}
