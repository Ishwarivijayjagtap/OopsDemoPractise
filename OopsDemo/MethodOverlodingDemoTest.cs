using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    public class MethodOverlodingDemoTest
    {
        static void Main(string[] args)
        {
            /* Calculator c1 = new Calculator();
             Console.WriteLine($"result={c1.Sub(23,20)}");
             Console.WriteLine($"result={c1.Sub(23.34, 20)}");
             Console.WriteLine($"result={c1.Mult(23, 20)}");
             Console.WriteLine($"result={c1.Mult(23.7, 20)}");
             Console.WriteLine($"result={c1.Div(23, 20)}");*/
            /*  Add a1 = new Add();
              Console.WriteLine($"Result={a1.Addition(23, 56)}");
              Console.WriteLine($"Result={ a1.Addition(23, 56, 5)}");*/
            /*  Employee e1 = new Employee(1);
              Employee e2 = new Employee(2, "Priya", 34000);
              Console.WriteLine(e1.Display());
              Console.WriteLine(e2.Display());*/
            Payment.PayBill(200);
            Payment.PayBill(2000, "Online");


        }
    }
}
