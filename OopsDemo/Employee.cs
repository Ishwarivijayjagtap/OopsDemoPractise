using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    public class Employee
    {
        private int eid;
        private string name;
        private double salary;
        public Employee( int eid)
        {
            this.eid = eid;
        }
        public Employee(int eid ,string name,double salary)
        {
            this.eid = eid;
            this.name = name;
            this.salary = salary;
        }
        public string Display()
        {
            return $"ID={eid} ,name={name},salary={salary}";
        }
    }
}
