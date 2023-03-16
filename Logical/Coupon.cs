using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Coupon
    {
       
        public static void Generatingnumbers()
        {

                var chars = "ABCDEFGHIJKLMNOPQRSTabcdefghijklmnopqrst1234567890";
                var stringchars = new char[6];
                string[] Couponnumber = new string[6];
                var random = new Random();

                Console.WriteLine("Coupon Numbers Program");

                Console.WriteLine("Enter your 6 digit Coupon Number");
                 
                for (int i = 0; i <= Couponnumber.Length; i++)
                {
                    Couponnumber[0] = Console.ReadLine();

                }

                for (int i = 0; i < stringchars.Length; i++)
                {
                    stringchars[0] = chars[random.Next(chars.Length)];
                }

           
                if (Couponnumber.Length == stringchars.Length)
                {
                    Console.WriteLine("Entered CouponNumber is Correct");
                }
                else
                {
                    Console.WriteLine("Entered CouponNumber is not Correct");
                }



            
        }
    }
}

