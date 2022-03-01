using Microsoft.AspNetCore.Identity;

namespace PersonApi.Models
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
    }
}
