using System.Collections.Generic;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            if (customerId != 1) return customer;
            customer.EmailAddress = "fbaggins@hobbiton.me";
            customer.FirstName = "Frodo";
            customer.LastName = "Baggins";

            return customer;
        }

        /// <summary>
        /// Retrieve
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
