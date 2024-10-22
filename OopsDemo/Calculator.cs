using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    public class Calculator
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }
        public double Sub(int a, double b)
        {
            return a - b;
        }
        public double Sub(double a, int b)
        {
            return a - b;
        }
       
            public int Mult(int a, int b)
            {
                return a * b;
            }
            public int Mult(int a, int b, int c)
            {
                return a *b * c;
            }
            public double Mult(int a, double b)
            {
                return a *b;
            }
            public double Mult(double a, int b)
            {
                return a * b;
            }
            public int Div(int a, int b)
            {
                return a / b;
            }
            public int Div(int a, int b, int c)
            {
                return a / b / c;
            }
            public double Div(int a, double b)
            {
                return a / b;
            }
            public double Div(double a, int b)
            {
                return a / b;
            }

        }
    }





