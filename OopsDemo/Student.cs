using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        private static int count;
        static Student()
        {
            count = 0;
        }

        public Student()
        {
            
        }
       
        public Student( string sname, double m1, double m2, double m3)
        {
            count++;
            rollno = count;
            name = sname;
            sub1 = m1;
            sub2 = m2;
            sub3 = m3;


        }
        public int Rollno
        {
            set { rollno = value; }
            get { return rollno; }

        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Sub1
        {
            set { sub1 = value; }
            get { return sub1; }
        }
        public double Sub2
        {
            set { sub2 = value; }
            get { return sub2; }
        }
        public double Sub3
        {
            set { sub3 = value; }
            get { return sub3; }
        }
        public void CalculatePercentage()
        {
             total = sub1 + sub2 + sub3;
            percentage = (float)(total / 3) * 100;
        }
        public string display()
        {
            return $"Id={rollno} Name={name} totalmarks={total} percentage={percentage} ";
        }

    }
}
