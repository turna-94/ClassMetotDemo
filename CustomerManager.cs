using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomerTracking
{
    class CustomerManager
    {
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id+"-"+customer.FirstName+" "+customer.LastName+"-"+customer.City+"-"+customer.Balance);
            }
        }

        public void Add(Customer customer)
        {
            Console.WriteLine("New customer added : "+customer.Id + "-" + customer.FirstName + " " + customer.LastName + "-" + customer.City + "-" + customer.Balance);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted : "+customer.Id+"-"+customer.FirstName+" "+customer.LastName);
        }
    }
}
