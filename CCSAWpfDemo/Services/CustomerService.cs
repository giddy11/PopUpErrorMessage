using CCSAWpfDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSAWpfDemo.Services
{
    public class CustomerService
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer { FirstName = "Murphy", LastName = "Ochuba", Gender = Gender.Male, IsAdmin = true });
            customers.Add(new Customer { FirstName = "Ciroma", LastName = "Samuel", Gender = Gender.Male, IsAdmin = false });
            customers.Add(new Customer { FirstName = "Simbi", LastName = "Alao", Gender = Gender.Female, IsAdmin = true });

            return customers;
        }
    }
}
