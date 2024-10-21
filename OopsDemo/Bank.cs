using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    public class Bank

    {
        double balance ,amount;

        public Bank()
        {
         balance=25000;   
        }
        
        public void Deposit( int amt)
        {
            balance = balance + amt;
            Console.WriteLine("Deposit amount="+amt);
            Console.WriteLine("Total balance="+balance);
        }
        public void Withdraw( int amt)
        {
            if (amt < balance)
            {
                balance = balance - amt;
                Console.WriteLine("WithDraw amout=" + amt);
                Console.WriteLine("Total balance=" + balance);
            }
            else 
            {
                Console.WriteLine("Less balance");
            }
            
        }
        public string Display()
        {
            return $"balance is {balance}";
        }

    }
}
