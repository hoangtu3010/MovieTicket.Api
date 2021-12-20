namespace MovieTicket.Api.Models
{
    public class Room
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int BranchId { get; set; }
        public virtual Branch Branch { set; get; }

    }
}
