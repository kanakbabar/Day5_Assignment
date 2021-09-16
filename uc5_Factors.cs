using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class uc5_Factors
    {
        public static void Factors()
        {
            int num;
            int x;

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The factors of the entered number are :");

            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }

        }
}