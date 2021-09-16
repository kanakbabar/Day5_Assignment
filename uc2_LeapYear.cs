using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class uc2_LeapYear
    {
       public static void MainLY()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (Year % 4 == 0) 
            { 
                Console.WriteLine("This year is leap year"); 
            } 
            else
            {
                Console.WriteLine("This year is not leap year"); 
            }
            Console.ReadLine();
       }
    }
}
