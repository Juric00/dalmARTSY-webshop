using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace dalmARTSY_Test.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    [Required]
    [StringLength(70)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(70)]
    public string LastName { get; set; }

}

