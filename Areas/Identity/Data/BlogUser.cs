using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Blogging_App_Core.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BlogUser class
public class BlogUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName ="nvarchar(100)")]
    public string FullName { get; set; }

    public string ProfilePicPath { get; set; } = "";

}

