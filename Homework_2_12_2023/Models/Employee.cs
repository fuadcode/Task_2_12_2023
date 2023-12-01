
namespace Homework_2_12_2023.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Salary { get; set; }

        public DateTime Birthday { get; set; }

        public Employee()
        {

        }
        public Employee(string name, string surname, int salary, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Birthday = birthday;
        }

        public static Employee[] EmployeeInfoData()
        {
            Employee employee = new Employee { Name = "Fuad", Surname = "Iskenderov",  Salary = 2500, Birthday = new DateTime(1998, 05, 25) };
            Employee employee1 = new Employee { Name = "Islam", Surname = "Aliyev",  Salary = 350, Birthday = new DateTime(2003, 12, 15) };
            Employee employee2 = new Employee { Name = "Nazim", Surname = "Memmedov", Salary = 2400, Birthday = new DateTime(1994, 09, 12) };

            Employee[] arr = { employee, employee1, employee2 };
            return arr;
        }

        public int FilteredEmployeeAge(DateTime date1, DateTime date2, int salary)
        {
            int stage = 0;
            Employee[] EmployeeInformation = EmployeeInfoData();
            foreach (Employee employee in EmployeeInformation)
            {
                if (employee.Birthday >= date1 && employee.Birthday <= date2 && employee.Salary > salary)
                {
                    stage++;
                }
            }
            return stage;
        }
    }
}