using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_CompanyHierarchy;

namespace _03_CompanyHierarchy
{
    class MainProgram
    {
        static void Main(string[] args)
        {

            Sale firstSale = new Sale("Ime", new DateTime(2011-11-11), 1222m);
            Sale secondSale = new Sale("Saleee", new DateTime(2012 - 12 - 12), 200.2m);

            Project project1 = new Project("HomePro", new DateTime(2012 - 01 - 01), "some details");
            Project project2 = new Project("ProProject", new DateTime(2002 - 02 - 02), "project detils here");
            project2.CloseProject();

            Manager manager1 = new Manager("12345", "Marco", "Polo", Departament.Sales, 1000.1m);
            Manager manager2 = new Manager("00001", "Manager2", "Manager2 Last name", Departament.Accounting, 123m);

            SalesEmployee saler1 = new SalesEmployee("99999", "Prodavach", "Prodavalnik", 12.34m, Departament.Sales);
            SalesEmployee saler2 = new SalesEmployee("88889", "Pazar", "Seller", 4321m, Departament.Sales);
            SalesEmployee saler3 = new SalesEmployee("88988", "Best", "Sellerman", 432.1m, Departament.Sales);


            Developer developer1 = new Developer("12321", "Razrabotchik", "Codov", 999.9m, Departament.Production);
            Developer developer2 = new Developer("32123", "Kolyo", "Hakera", 999.9m, Departament.Production);
            Developer developer3 = new Developer("32123", "Cody-Mnogo", "Harchi-Malko", 111.111m, Departament.Production);


            manager1.AddEmployee(saler1);
            manager1.AddEmployee(saler3);
            manager1.AddEmployee(developer2);

            manager2.AddEmployee(developer1);
            manager2.AddEmployee(developer3);
            manager2.AddEmployee(saler2);

            saler1.AddSale(firstSale);
            saler2.AddSale(secondSale);

            developer1.AddProject(project1);
            developer2.AddProject(project2);




            IList<Employee> employees = new List<Employee>
            {
                manager1,
                manager2,
                saler1,
                saler2,
                saler3,
                developer1,
                developer2,
                developer3
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

            Customer customer1 = new Customer("00000", "Mnogo", "Para");
            customer1.BueProduct(firstSale);
            customer1.BueProduct(secondSale);

            Console.WriteLine(customer1.NetPurchaseAmount);
        }
    }
}
