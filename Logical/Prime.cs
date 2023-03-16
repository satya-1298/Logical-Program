using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Prime
    {
        public static void number()
        {
            Console.WriteLine("Enter a value");
            int n=int.Parse(Console.ReadLine());
            for(int i = 2; i < n/2; i++)
            {
                if (n%i!=0)
                {
                    Console.WriteLine("prime");
                }
                else
                {
                    Console.WriteLine("not prime");
                }
            }
        }
    }
}
