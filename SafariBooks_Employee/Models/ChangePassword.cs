using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SafariBooks_Employee.Models
{
    public class ChangePassword 
    {
        [Key]
        public string EmployeeID { get; set; }

        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter your old password.")]
        [Display(Name = "Please enter your old password")]
        [Compare("Password")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter your new password.")]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }


        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be a minimum of 6", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        [Display(Name = "Confirm New Password")]
        public string ConfirmNewPassword { get; set; }

        public virtual Employee Password { get; set; }
    }
}