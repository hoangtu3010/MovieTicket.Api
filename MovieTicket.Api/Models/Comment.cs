namespace MovieTicket.Api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { set; get; }
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int? ReplyId { get; set; }
        public virtual Comment Reply { get; set; }
    }
}
