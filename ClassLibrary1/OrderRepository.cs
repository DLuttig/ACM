using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one Order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // created thie instance of the of order Class
            //Pass in the requested ID.
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14,10,00,00, new TimeSpan(7,0,0));

            }

            return order;
        }

        ///<summary>
        /// Saves the current order.
        /// </summary>
        public bool Save(Order order)
        {
            // Code that saves the passed in order
            return true;
        }
    }
}
