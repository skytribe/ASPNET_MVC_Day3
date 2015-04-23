using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_ModelState.Models
{
    public class Product
    {
        // For cultural localize messages....
        [Required(ErrorMessage="Product name is Required")]
        [MinLength(3, ErrorMessage="Product Name must be 3+")]
        [MaxLength(10, ErrorMessage = "Product Name must be less than 10")]
        
        public String Name{ get; set; }

        
        [Range(0,10,ErrorMessage="Price must be between 0-10")]
        public decimal Price { get; set; }
    }
}