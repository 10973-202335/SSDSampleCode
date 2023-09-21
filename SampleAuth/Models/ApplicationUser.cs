using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SampleAuth.Models
{
public class ApplicationUser : IdentityUser
{
[Display(Name = "First Name")]
public string FirstName { get; set; } = String.Empty;
#nullable disable
[Display(Name = "Last Name")]
public string LastName { get; set; }
}
}
