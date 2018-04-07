using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class App2
	{
		static void Main(string[] args)
		{


            IEnumerable<Customer> customers = new[]
            {
                 new Customer {FirstName = "Luka", LastName = "Abrus", Age =
                41,CompanyName = "Contoso"},
                 new Customer {FirstName = "Syed", LastName = "Abbas", Age =
                23,CompanyName = "Contoso"},
                 new Customer {FirstName = "Keith", LastName = "Harris", Age =
                59,CompanyName = "Fabrikam"},
                 new Customer {FirstName = "Keith", LastName = "Harris", Age =
                59,CompanyName = "Fabrikam"},
                 new Customer {FirstName = "David", LastName = "Pelton", Age =
                25,CompanyName = "Contoso"},
                 new Customer {FirstName = "John", LastName = "Peoples", Age =
                37,CompanyName = "Fabrikam"},
                 new Customer {FirstName = "Toni", LastName = "Poe", Age =
                29,CompanyName = "Fabrikam"},
                 new Customer {FirstName = "Jeff", LastName = "Price", Age =
                74,CompanyName = "Contoso"}
            };

            List<string> customerLastNames = new List<string>();
            foreach (Customer customer in customers)
            {
                customerLastNames.Add(customer.LastName);
            }

            IEnumerable<string> customerLastNamesLambda =
            customers.Where(cust =>
            {
                if (cust.Age > 50) return true;
                else return false;
            }).Select(cust => cust.LastName);

           
            foreach (string name in customerLastNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---- over 50 -----");

            foreach (string name in customerLastNamesLambda)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------");

            Console.WriteLine("{0}", customers.Select(cust => cust.Age).Count());
            Console.WriteLine("{0}", customers.Select(cust => cust.Age).Distinct().Count());

            Console.WriteLine("--------------");

            Console.WriteLine("Count: {0}\tAverage age: {1}\tLowest: {2}\tHighest: {3}",
                    customers.Count(), customers.Average(cust => cust.Age),
                    customers.Min(cust => cust.Age), customers.Max(cust =>
                    cust.Age));

            Console.WriteLine("--------------");

            var customersGroupedByAgeRange = customers.GroupBy(cust =>
            {
                if (cust.Age < 20)
                    return "age < 20";
                if (cust.Age >= 20 && cust.Age < 40)
                    return "age >= 20 and < 40";
                if (cust.Age >= 40 && cust.Age < 60)
                    return "age >= 40 and < 60";
                if (cust.Age >= 60)
                    return "age >= 60";
                return "Error";
            });

            foreach (var cust in customersGroupedByAgeRange.OrderBy(cust =>
            cust.Key))
            {
                Console.WriteLine("{0}\t\t{1}", cust.Key, cust.Count());
            }

            Console.Read();
        }
	}
}
