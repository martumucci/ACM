using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
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
    }
}
