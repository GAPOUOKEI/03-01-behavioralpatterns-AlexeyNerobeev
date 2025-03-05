using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Director: Salary
    {
        public override void PrintInfo()
        {
            Console.WriteLine($"Должность: {Name}, зарплата: {EmployeeSalary}");
        }

        public override void CheckName(Salary salary)
        {
            if (!salary.Name.Any(char.IsUpper))
            {
                Console.WriteLine("Имя должно начинаться с заглавной буквы");
            }
        }

        public override void CheckSalary(Salary salary)
        {
            if(salary.EmployeeSalary < 0)
            {
                Console.WriteLine("Зарплата не может быть отрицательной");
            }
            else if(salary.EmployeeSalary < 50000 || salary.EmployeeSalary > 100000)
            {
                Console.WriteLine("Зарплата не входит в требуемый диапазон");
            }
        }
    }
}
