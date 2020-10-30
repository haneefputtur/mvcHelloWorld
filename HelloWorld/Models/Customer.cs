using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
        [DisplayName("Customer Name")]
        public string customer_name { get; set; }
        [DisplayName("Customer Email")]
        public string customer_email { get; set; }
        [DisplayName("Customer Address")]
        public string customer_address { get; set; }
    }
}