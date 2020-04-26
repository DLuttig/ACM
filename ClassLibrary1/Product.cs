using System;
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
        public int ProductId { get; private set; }
        public string Description { get; private set; }
        public decimal? CurrentPrice { get; set; }


        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returnts></returnts>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        ///<summary>
        /// Retrieve one product.
        ///</summary>
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        /// <summary>
        /// Saves the current custermer.
        /// </summary>
        public bool Save()
        {
            // Code that Saves the defined product

            return true;
        }
    }
}
