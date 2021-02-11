﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }

        /// <summary>
        /// Validates the Product
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieves a product
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // ...

            return new Product();
        }

        /// <summary>
        /// Saves the Product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // ...

            return true;
        }

    }
}