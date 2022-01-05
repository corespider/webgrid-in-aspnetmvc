using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XML_WebGrid_aspnetmvc.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
    }
}