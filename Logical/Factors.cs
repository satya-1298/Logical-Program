using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Factors
    {
        public static void ofnumber()
        {
            Console.WriteLine("Enter a number");
            int n=int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n;i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
