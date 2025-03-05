using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal abstract class Salary
    {
        private string _name { get; set; }
        private int _salary { get; set; }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int EmployeeSalary
        {
            get => _salary;
            set => _salary = value;
        }

        public abstract void CheckName(Salary salary);
        public abstract void CheckSalary(Salary salary);
        public abstract void PrintInfo();
        public void Check(Salary salary)
        {
            PrintInfo();
            CheckName(salary);
            CheckSalary(salary);
        }
    }
}
