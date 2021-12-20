using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Api.Models
{
    public class Film
    {
        public int Id { set; get; }
        public IEnumerable<Image> Images { set; get; }
        public string Trailer { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public float Rate { set; get; }
        [DataType(DataType.Time)]
        public DateTime MovieDuration { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
