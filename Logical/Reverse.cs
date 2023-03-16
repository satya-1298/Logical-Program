using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Reverse
    {
        public static void number()
        {
            int r,reverse=0;
            Console.WriteLine("Enter a number:");
            int n=int.Parse(Console.ReadLine());
            while(n!=0)
            {
                r = n % 10;
                reverse = reverse * 10 + r;
                n =n/ 10;

            }
            Console.WriteLine(reverse);
        }
    }
}
