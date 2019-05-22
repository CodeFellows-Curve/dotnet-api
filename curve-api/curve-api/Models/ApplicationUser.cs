using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace curve_api.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int IndividualID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // Nav Props

        [ForeignKey("IndividualID")]
        public Individual Individual { get; set; }
    }

    public static class ApplicationRoles
    {
        public const string User = "User";
        public const string Manager = "Manager";
        public const string Admin = "Admin";
        public const string SuperUser = "SuperUser";
    }
}
