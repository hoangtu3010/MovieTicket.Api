namespace MovieTicket.Api.Models
{
    public class UserRoleMapping
    {
        public int Id { set; get; }
        public int UserId { set; get; }
        public virtual User Users { set; get; }
        public int RoleId { set; get; }
        public virtual Role Roles { set; get; }
    }
}
