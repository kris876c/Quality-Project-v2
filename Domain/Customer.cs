using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Town { get; set; }
        public string Telephone { get; set; }

        public Customer (int id, string name, string address, string zip, string town, string telephone)
        {
            ID = id;
            Name = name;
            Address = address;
            Zip = zip;
            Town = town;
            Telephone = telephone;
        }


    }
}
