using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
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

        /// <summary>
        /// Return all Orders for specified date
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // ...
            return new Order();
        }

        /// <summary>
        /// Saves the Order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // ...

            return true;
        }
    }
}
