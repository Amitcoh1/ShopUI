using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }

        public Vendor()
        {
            Commission = 0.5;
        }
        public string Disply
        {
            get { return string.Format("{0} {1} - ${2}", FirstName,LastName,PaymentDue); }
        }
    }
}
