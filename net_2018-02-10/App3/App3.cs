using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class App3
    {
        static void Main(string[] args)
        {

            IEnumerable<Customer> customers = new[]
{
 new Customer{ FirstName = "Luka", LastName="Abrus", Age = 41, CompanyName = "Contoso"},
 new Customer{ FirstName = "Syed", LastName="Abbas", Age = 23, CompanyName = "Fabrikam"},
 new Customer{ FirstName = "Keith", LastName="Harris", Age = 59, CompanyName = "Contoso"},
 new Customer{ FirstName = "David", LastName="Pelton", Age = 41, CompanyName = "Contoso"},
 new Customer{ FirstName = "John", LastName="Peoples", Age = 23, CompanyName = "Contoso"},
 new Customer{ FirstName = "Toni", LastName="Poe", Age = 29, CompanyName = "Fabrikam"},
 new Customer{ FirstName = "Jeff", LastName="Price", Age = 23, CompanyName = "Fabrikam"}
};
            IEnumerable<Company> companies = new[]
            {
 new Company{CompanyName = "Contoso", Country = "United Kingdom"},
 new Company{CompanyName = "Fabrikam", Country = "United States"}
};
            var customersAndCompanies = customers.Join(companies,
             custs => custs.CompanyName,
             comps => comps.CompanyName,
             (custs, comps) => new { custs.FirstName, custs.LastName, comps.Country });
            foreach (var item in customersAndCompanies)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> customerLastNames =
            customers.Select(cust => cust.LastName);

            /*
             * same
             * IEnumerable<string> customerLastNames = from
            cust in customers select cust.LastName;*/


            var customerNames = customers.Select(cust=>
                new {First = cust.FirstName,
                        Last = cust.LastName});

            /*
             * same
             * var customerNames = from cust in customers
                        select new
                        { cust.FirstName, cust.LastName };*/

            Console.WriteLine("-------------------");
            foreach (var cust in customerNames)
            {
                Console.WriteLine("{0}\t{1}",cust.First,cust.Last);
            }

            var sortedCustomers = customers.OrderBy(cust => cust.FirstName);

            /*
             * same
             * var sortedCustomers = from cust in customers
                    orderby cust.FirstName select cust;*/


            Console.WriteLine("-------------------");
            foreach (var cust in sortedCustomers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", cust.FirstName, cust.LastName, cust.Age);
            }


            var customersGroupedByAge = customers.GroupBy(cust => cust.Age);

            /*
             * same
             * var customersGroupedByAge = from cust in
                                        customers
                                        group cust by cust.Age;
                                        */

            Console.WriteLine("-------------------");
            foreach (var cust in customersGroupedByAge)
            {
                Console.WriteLine("{0}", cust.Key);
            }

            var customersAndCountries = customers.Join(
                companies, cust => cust.CompanyName,
                comp => comp.CompanyName ,(cust, comp) =>
                new { cust.FirstName, cust.LastName, comp.Country });

            /*
             * same
             * var customersAndCountries = from cust in customers
                                         join comp in companies on
                                         cust.CompanyName equals comp.CompanyName
                                         select new
                                         {
                                             cust.FirstName,
                                             cust.LastName,
                                             comp.Country
                                         };*/


            Console.WriteLine("-------------------");
            foreach (var cust in customersAndCountries)
            {
                Console.WriteLine("{0}\t{1}\t{2}", cust.FirstName,cust.LastName,cust.Country);
            }

            Console.Read();
        }
    }
}
