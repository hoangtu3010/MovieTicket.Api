using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Api.Models.DTOs.Requests
{
    public class UserRegistrationDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Passwork { get; set; }
    }
}
