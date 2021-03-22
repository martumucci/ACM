using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }

        /// <summary>
        /// Validates the Order
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
