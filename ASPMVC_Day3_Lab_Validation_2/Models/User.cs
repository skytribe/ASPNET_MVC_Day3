using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//using System.Web.Mvc;

namespace ASPMVC_Day3_Lab_Validation_2.Models
{
    public class User
    {


        // •Username - Must be unique in the database.
        //•FirstName – Required
        //•LastName – Required, Must be more than 5 characters
        //•CreditCard – Must be valid credit card number
        //•Password – Required, Must be the same as ConfirmPassword
        //•ConfirmPassword -- Required
        //•Social Security Number – Must be valid social security number format
        //•Comments - Must be less than 50 characters.

        [System.Web.Mvc.Remote(action :"validateUserName",
                               controller:"users", 
                               ErrorMessage = "UserName is not unique", HttpMethod = "POST")]   //Need to add System.Web.MVC

        [Required(ErrorMessage = "Must be unique in the database")]
        public string Username { get; set; }

        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }

        [MinLength(5, ErrorMessage = "Must be more than 5 characters")]
        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; }

         [DataType(DataType.CreditCard)]
        [CreditCard(ErrorMessage = "Invalid Credit Card entered")]
        public string CreditCard { get; set; }

        [DataType(DataType.Password) ]  //Adds some extra functionality for how it will be displayed
        [Required(ErrorMessage="Must enter a password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }

             [DataType(DataType.Password) ]  //Adds some extra functionality for how it will be displayed
         [Required(ErrorMessage = "Must enter a password")] // Should be needed because of the compare
        [Compare("Password", ErrorMessage = "Passwords did not match")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid SSN entered xxx-xx-xxxx")]
        public string SocialSecurityNumber { get; set; }

        [MaxLength(50, ErrorMessage = "Must be more than 50 characters")]
        public string Comments { get; set; }


       
    }
}