using Microsoft.AspNetCore.Identity;

namespace UserApp.Models
{
    public class Users : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
