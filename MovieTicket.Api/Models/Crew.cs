namespace MovieTicket.Api.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public string Role { get; set; }
    }
}
