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
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OderDate { get; private set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returnts></returnts>
        public bool Validate()
        {
            var isValid = true;

            if (OderDate == null) isValid = false;

            return isValid;
        }

        ///<summary>
        /// Retrieve one product.
        ///</summary>
        public Order Retrieve(int OrderId)
        {
            return new Order();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        public bool Save()
        {
            // Code that Saves the defined product

            return true;
        }
    }
}
