﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }


        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        ///<summary>
        /// Retrieve one customer.
        ///</summary>
        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the dfined customer

            return new Customer();
        }

        /// <summery>
        /// Retrive all custers.
        /// </summery>
        public List<Customer> Retrive()
        {
            //Code that retrieves ass of the customers

            return new List<Customer>();
        }
        /// <summary>
        /// Saves the current custermer.
        /// </summary>
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }
        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returnts></returnts>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
