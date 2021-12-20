using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Api.Models
{
    public class ListFood
    {
        public int Id { get; set; }
        public List<FoodInfo> Foods { get; set; }
        public List<ComboInfo> ComboInfos { get; set; }
    }
    public class Booking
    {
        public int Id { get; set; }
        public ListFood ListFood { get; set; }
        public decimal Total { get; set; }
        [DataType(DataType.Time)]
        public DateTime BookingDate { get; set; }
        public int? FilmId { get; set; }
        public virtual Film Film { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int? BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
