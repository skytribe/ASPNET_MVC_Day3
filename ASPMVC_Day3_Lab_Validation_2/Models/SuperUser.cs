using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC_Day3_Lab_Validation_2.Models
{
    public class SuperUser: IValidatableObject
    {




        [System.Web.Mvc.Remote(action: "validateUserName",
                               controller: "users",
                               ErrorMessage = "UserName is not unique", HttpMethod = "POST")]   //Need to add System.Web.MVC
        public string Username { get; set; }


        [Required(ErrorMessage = "Must enter a password")]
        public string Password { get; set; }

 

 
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            //Validate username
            if (this.Username != null)
            {
                if (this.Username.Length <= 1)
                {
                    results.Add(new ValidationResult("Invalid username must be more than 1 character!", new string[] { "Username" }));
                }
                //validate password
                if (this.Password != null)
                {
                    if (this.Password.Length <= this.Username.Length)
                    {
                        results.Add(new ValidationResult("Invalid Password must be longer than username!", new string[] { "Password" }));
                    }
                }
                else
                {
                    results.Add(new ValidationResult("Password is null", new string[] { "Password" }));

                }
            }
            else
            {
                results.Add(new ValidationResult("Username is null", new string[] { "Username" }));                
            }

            
            return results;
            //throw new NotImplementedException();
        }
    }
}