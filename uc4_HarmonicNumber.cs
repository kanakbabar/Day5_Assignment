using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class uc4_HarmonicNumber
    {
        public static void HarmonicNum()
        {
            int Hn;
            float harmonic = 1;

            Console.WriteLine("Enter a nth of harmonic number");
            Hn = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < Hn; i++)
            {
                harmonic += (float)1 / i;
            }
            Console.WriteLine(harmonic);
        }
    }
}
