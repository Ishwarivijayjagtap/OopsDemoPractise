using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    public class Payment
    {
        public static void PayBill( double amt)
        {
            Console.WriteLine($"PAyment by cash {amt}");
        }
        public static void PayBill(double amt, string mode)
        {
            double discount = amt * 0.15;
            amt = amt - discount;
            Console.WriteLine($"Payment by {mode} dicount={discount}  amount={amt}");
        }
    }
}
