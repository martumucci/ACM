using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
              
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; } // propg snippet
        public string EmailAddress { get; set; } // prop snippet
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName;
            }
        }
        public string FirstName { get; set; } // Auto-Implemented Property - Behind the scenes the code is still creating a backing field
                                              // This is used when there is no need for extra code in the getter or setter of the property
        private string _LastName; // Private Backing Field - it holds the data and no code outside of this class can access it

        public string LastName // this C# property makes the data accessible to other parts of the application
        {
            get
            {
                // ...
                return _LastName;
            }
            set
            {
                // ...
                _LastName = value;
            }
        }

        public static int InstanceCount { get; set; } // Static member, belongs to the class itself

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        { 
            //...

            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // ...

            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current Customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // ...

            return true;
        }

        /// <summary>
        /// Validates customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
