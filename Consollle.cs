using System;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string result = "";
            Department department = new Department();
            Console.WriteLine("Salam, zehmet olmasa qurmaq istediyiniz sirkete uygun ad daxil edin");
            department.Department_Name = Console.ReadLine();
            Console.WriteLine("Sirkete ise goturule bilecek max isci sayin  daxil edin");
            department.EmployeeLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Sirketin umumi budcesini daxil edin");
            department.Budget = int.Parse(Console.ReadLine());
            Console.WriteLine("Sirket iscilerinden en az nece il tecrube teleb olunur?");
            department.RequiredExperience = int.Parse(Console.ReadLine());
            do
            {
                if (department.EmployeeLimit > department.Employees.Length)
                {
                    Employee Isci = new Employee();
                    Console.WriteLine("Iscinin adini daxil edin");
                    Isci.Name = Console.ReadLine();
                    Console.WriteLine("Iscinin soyadini daxil edin");
                    Isci.Surname = Console.ReadLine();
                    Console.WriteLine("Maas miqdari");
                    Isci.Salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Icsinin tecrubesi ne qederdir? ");
                    Isci.Experience = int.Parse(Console.ReadLine());
                    if (department.RequiredExperience > Isci.Experience)
                    {
                        Console.WriteLine("Tecrubeniz bes etmir");
                        break;
                    }
                    department.AddEmployee(Isci);
                        Console.WriteLine("Yeni icsi elave etmek isteyirsinizmi? ");
                        result = Console.ReadLine();
                  
                }
                else
                {
                    Console.WriteLine("Max sayda isci var, teesuf ki sizi qebul ede bilmirik, muracietiniz ucun tesekkurler!");
                    break;
                }
                }
                while (result == "yes") ;

                Console.WriteLine("Icsi siyahisi ile tanis olun");
                foreach (var isci in department.Employees)
                {
                    Console.WriteLine($"Iscinin adi:{isci.Name}   Iscinin soyadi: {isci.Surname}   Iscinin is tecrubesi:{isci.Experience}   Isciye ayrilmis maas:{isci.Salary}");

                }
                Console.WriteLine("Sirketin maas ortalamasi: "); department.SalaryAverageOfDepartment();

           






    }
}
}
 
