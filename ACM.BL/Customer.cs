using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0) // constructor chaining to provide default customer id
        {
              
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; } // propg snippet
        public int CustomerType { get; set; }
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

        //public string Log()
        //{
        //    var logString = CustomerId + ": " 
        //                    + FullName + " " 
        //                    + "Email: " + EmailAddress + " " 
        //                    + "Status: " + EntityState.ToString();
        //    return logString;
        //}

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;

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
        /// Validates customer data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
