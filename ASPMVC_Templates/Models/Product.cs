using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPMVC_Templates.Models
{
    public class Product
    {
        // For cultural localize messages....

        public String Name { get; set; }


        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public decimal Weight { get; set; }

    }
}