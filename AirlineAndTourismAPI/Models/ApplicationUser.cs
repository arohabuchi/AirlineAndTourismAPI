using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AirlineAndTourismAPI.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public string CompayName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

    }
}
