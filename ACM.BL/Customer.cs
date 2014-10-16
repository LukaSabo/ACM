using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
            // TODO: Complete member initialization
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                var fullName = LastName;
                if (string.IsNullOrWhiteSpace(FirstName)) return fullName;
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }
                fullName += FirstName;
                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(LastName);

            if (string.IsNullOrWhiteSpace(EmailAddress))
                isValid = false;

            return isValid;
        }
    }
}
