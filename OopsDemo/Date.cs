using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    public class Date
    {
        private int day, year;
         private  string month;
        public void AcceptData(int dd, int yy, string mm)
        {
             day=dd;
            year = yy;
            month = mm;
        }

    }
}
