using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    public class Book
    {
        private int bid;
        private string bname;
        private double price;
        private string author;
        public Book( int id,string name,double bprice,string bauthor)
        {
            bid = id;
            bname = name;
            price = bprice;
            author = bauthor;
            Console.WriteLine($"bookID={ bid} BookName={ name},Price={price} author={bauthor}");
        }

       
    }
}
