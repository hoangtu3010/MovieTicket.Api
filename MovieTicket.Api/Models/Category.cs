using System.Collections.Generic;

namespace MovieTicket.Api.Models
{
    public class Category
    {
        public Category()
        {
            this.Films = new HashSet<Film>();
        }
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
