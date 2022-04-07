using System.Collections.Generic;
using System.Linq;

namespace Topic_10_Classes.Repositories
{
    public class CustomerRepository
    {
        private List<Customer> Customers { get; set; }

        public CustomerRepository()
        {

        }

        public CustomerRepository(List<Customer> customers)
        {
            Customers = customers;
        }

        public Customer Save(Customer customer)
        {
            Customers.Add(customer);
            return customer;
        }

        public Customer RetrieveById(int id)
        {
            foreach (var customer in Customers)
            {
                if (customer.Id == id) 
                {
                    return customer;
                }

            }

            return Customers.SingleOrDefault(q => q.Id == id);
        }

        public List<Customer> Retrieve()
        {
            return Customers;
        }
    }
}
