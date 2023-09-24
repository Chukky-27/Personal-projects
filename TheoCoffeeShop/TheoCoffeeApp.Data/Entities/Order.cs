using TheoCoffeeApp.Data.Enums;

namespace TheoCoffeeApp.Data.Entities
{
    public class Order : BaseEntity
    {
        public OrderType OrderType { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public CoffeeType CoffeeType { get; set; }
        public int OrderId { get; set; }
    }
}
