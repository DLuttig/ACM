using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one Product
        /// </summary>
        public Product Retrieve(int productId)
        {
            // created thie instance of the of Product Class
            //Pass in the requested ID.
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Assorted Size Set of 4 Bright Yello Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }
        /// <summary>
        /// Saves the current Product
        /// </summary>
        public bool Save(Product customer)
        {
            // Code that saves the passed in customer

            return true;
        }

    }
}
