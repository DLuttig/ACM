using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }


        /// <summary>
        /// Validates the Address data.
        /// </summary>
        /// <returnts></returnts>
        public bool Validate()
        {
            var isValid = true;

            // if (AddressId <= 0) isValid = false;
            // if (string.IsNullOrEmpty(StreetLine1)) isValid = false;
            // if (string.IsNullOrEmpty(StreetLine2)) isValid = false;
            // if (string.IsNullOrEmpty(City)) isValid = false;
            //if (string.IsNullOrEmpty(State)) isValid = false;
            if (string.IsNullOrEmpty(PostalCode)) isValid = false;
            //if (string.IsNullOrEmpty(Country)) isValid = false;


            return isValid;
        }
    }
}
