using HRAdministrationAPI;

namespace SchoolHRAministration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            //foreach (IEmployee employee in employees)
            //{
            //    totalSalaries += employee.Salary;
            //}
            //Console.WriteLine($"Total Annul Salaries (including bonus): {totalSalaries}");
            Console.WriteLine($"Total Annul Salaries (including bonus): {employees.Sum(e => e.Salary)}");

            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher 
            { 
                Id = 1, 
                Firstname = "Bob", 
                LastName = "Fisher", 
                Salary = 40000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                Firstname = "Jenny",
                LastName = "Thomas",
                Salary = 40000
            };
            employees.Add(teacher2);

            IEmployee headOfDepartament = new HeadOfDepartament
            {
                Id = 3,
                Firstname = "Brenda",
                LastName = "Mullins",
                Salary = 50000
            };
            employees.Add(headOfDepartament);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                Firstname = "Devlin",
                LastName = "Brown",
                Salary = 60000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                Firstname = "Damien",
                LastName = "Jones",
                Salary = 80000
            };
            employees.Add(headMaster);
        }
    }

    public class Teacher:EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m);}
    }

    public class HeadOfDepartament : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }

    }

    public class DeputyHeadMaster : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }

    }

}