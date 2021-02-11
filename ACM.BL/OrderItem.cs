using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Validates the Order Item
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false; 

            return isValid;
        }

        /// <summary>
        /// Retrieves all Order Items
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // ...

            return new OrderItem();
        }

        /// <summary>
        /// Saves the Order Item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // ...

            return true;
        }

    }
}
