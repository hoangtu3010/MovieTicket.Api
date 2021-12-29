using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Api.Models
{
    public class Film
    {
        public Film()
        {
            this.Categories = new HashSet<Category>();
        }
        public int Id { set; get; }
        public int ImageId { set; get; }
        public virtual Image Images { set; get; }
        public string Trailer { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public float Rate { set; get; }
        [DataType(DataType.Time)]
        public DateTime MovieDuration { get; set; }
        public int CategoryId { set; get; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
