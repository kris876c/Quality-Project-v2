using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    class CustomerRepo
    {
        private List<Customer> customerList = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }
       

        public Customer GetCustomer(int customerId)
        {
            Customer tempCustomer = null;
            foreach(Customer customer in customerList)
            {
                if(customer.ID == customerId)
                {
                    tempCustomer = customer;
                }
            }
            return tempCustomer;
        }
        public int GetCountOfCustommers()
        {
            return customerList.Count();
        }
    }
}
