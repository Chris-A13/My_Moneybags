﻿using System;

namespace Moneybags
{
    [Serializable]
    class Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ABN { get; set; }
        public string AccountNumber { get; set; }
        public string BSB { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalAddressLine1 { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string path { get; set; }

        public Persona(string firstName, string lastName, string ABN, string addressLine1, string addressLine2, string postalAddressLine1, string postalAddressLine2, string accountNumber, string bsb)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ABN = ABN;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.PostalAddressLine1 = postalAddressLine1;
            this.PostalAddressLine2 = postalAddressLine2;
            this.AccountNumber = accountNumber;
            this.BSB = bsb;
        }

        public void SetPath(string filePath)
        {
            this.path = filePath;
        }
    }
}
