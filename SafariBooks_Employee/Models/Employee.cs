using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafariBooks_Employee.Models
{
    public class Employee
    {
        [Display(Name = "Employee ID")]
        public string EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EmpEmail { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        public string EmpFName { get; set; }

        [Display(Name = "MI")]
        public string EmpMI { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        public string EmpLName { get; set; }

        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter your password.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //[Display(Name = "Confirm password")]
        //[DataType(DataType.Password)]
        //[Compare("Password",
        //  ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
        ////htmlAttributes: new { @class = "control-label col-md-2" }




        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be a minimum of 6", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }





        [Required(ErrorMessage = "Please enter your address.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your zip code.")]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [Display(Name = "Phone")]
        [PhoneAttribute]
        public string Phone { get; set; }


        public bool EmpActive { get; set; }
        public bool Managers { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}