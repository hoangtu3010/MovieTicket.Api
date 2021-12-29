namespace MovieTicket.Api.Models
{
    public enum TypeOptions
    {
        Snack = 0,
        Drink = 1
    }
    public class Food
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public decimal Price { get; set; }
        public TypeOptions Type { get; set; }
        public int Amount { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
