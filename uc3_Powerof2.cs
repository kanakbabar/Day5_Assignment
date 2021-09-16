using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class uc3_Powerof2
    {
        public static void Power()
        {
            int N;
            int result;
            int counter = 1;

            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());

            if (N > 31)
                Console.WriteLine("Invalid input (N should be less than 31)");
            else
                while (counter <= N)
                {
                    result = counter * 2;
                    counter++;
                    Console.WriteLine(result);
                }
        }
    }
}
