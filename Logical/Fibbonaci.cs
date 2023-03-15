using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fibbonaci
    {
        public static void series()
        {
            int n = 0, n1 = 1,n2;
            Console.WriteLine("Enter a number:");
            int v=int.Parse(Console.ReadLine());
            Console.Write(n + " " + n1+" ");
            for(int i = 0; i < v; i++) 
            {
                n2 = n + n1;
                Console.Write(n2 + " ");
                n = n1;
                n1 = n2;
            }
        }
    }
}
