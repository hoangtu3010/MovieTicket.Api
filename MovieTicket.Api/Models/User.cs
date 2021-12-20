using System;

namespace MovieTicket.Api.Models
{
    public class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public Image Image { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string Two_factor_code { set; get; }
        public DateTime Two_factor_expires_at { set; get; }
    }
}
