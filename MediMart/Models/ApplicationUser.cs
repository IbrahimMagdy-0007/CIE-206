using Microsoft.AspNetCore.Identity;

namespace MediMart.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add custom properties here if needed
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
