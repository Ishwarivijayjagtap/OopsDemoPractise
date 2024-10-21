using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    public class Product
    {
         private int pid;
        private string name;
        private double price ,disprice;
        public Product( int id,string nm,double pp)
        {
            pid = id;
            name = nm;
            price = pp;

        }
        public void CalDiscountedPrice()
        {
            if (price > 1000)
            {
                disprice = price * 0.10;
            }
            else 
            {
                disprice = 0;
            }
        }
        public String display()
        {
            return $"Id{pid} ,name={name},price={price},discountedprice ={disprice}";
        }

    }
}
