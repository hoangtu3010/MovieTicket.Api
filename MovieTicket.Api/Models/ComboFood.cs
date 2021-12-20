using System.Collections.Generic;

namespace MovieTicket.Api.Models
{
    public class FoodInfo
    {
        public int Id { get; set; }
        public Food Food { get; set; }
        public int Qty { get; set; }
    }

    public class ComboInfo
    {
        public int Id { get; set; }
        public ComboFood ComboFood { get; set; }
        public int Qty { get; set; }
    }

    public class ComboFood
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public Image Image { get; set; }
        public decimal Price { get; set; }
        public List<FoodInfo> FoodInfos { get; set; }
        public int Amount { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }

}
