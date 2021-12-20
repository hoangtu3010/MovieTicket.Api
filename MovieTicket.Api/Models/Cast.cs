namespace MovieTicket.Api.Models
{
    public class Cast
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public Image Image { set; get; }
        public string Character { set; get; }
        public int FilmId { set; get; }
        public virtual Film Film { get; set; }
    }
}
