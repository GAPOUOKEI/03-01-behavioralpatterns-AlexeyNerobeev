namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Manager manager = new Manager();
            director.Name = "Иван";
            director.EmployeeSalary = 55000;
            manager.Name = "андрей";
            manager.EmployeeSalary = 10000;

            director.Check(director);
            Console.WriteLine("------------------------");
            manager.Check(manager);
        }
    }
}
