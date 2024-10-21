using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OopsDemo
{
    public class Student
    {
        private int rollno;
        private string name;
        private double sub1, sub2, sub3 ,total,percentage;

        public Student(int rn, string sname, double m1, double m2, double m3)
        {
            rollno = rn;
            name = sname;
            sub1 = m1;
            sub2 = m2;
            sub3 = m3;


        }
        public void CalculatePercentage()
        {
             total = sub1 + sub2 + sub3;
            percentage = (total / 3) * 100;
        }
        public string display()
        {
            return $"Id={rollno} Name={name} totalmarks={total} percentage={percentage} ";
        }

    }
}
