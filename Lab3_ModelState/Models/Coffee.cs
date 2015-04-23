using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_ModelState.Models
{
    public class Coffee
    {
        public string TypeOfCoffee { get; set; }
        public decimal Price { get; set; }
        public int Temperature { get; set; }
        public string Milk { get; set; }
    }
}