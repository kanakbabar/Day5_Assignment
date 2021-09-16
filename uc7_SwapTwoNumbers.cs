using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class uc7_SwapTwoNumbers
    {
        public static void MainSTN()
        {
            int number1, number2, temp;
            Console.Write("Input the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + number1);
            Console.WriteLine("Second Number : " + number2);
            Console.ReadLine();
        }
    }
}
