using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public class Controller
    {
        CustomerRepo customerRepo = new CustomerRepo();
        public bool CheckCustomerID(int customerID)
        {
            if (customerRepo.GetCustomer(customerID) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void CreateCustomer(int id, string name, string address, string zip, string town, string telephone)
        {
            Customer customer = new Customer(id, name, address, zip, town, telephone);
            customerRepo.AddCustomer(customer);
        }
        public int GetCountOfCustomers()
        {
            return customerRepo.GetCountOfCustommers();
        }
        public string GetProducts()
        {
            return ProductRepo.
        }
    }
}
