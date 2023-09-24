using MateData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateData.Models
{
    public class Order : BaseEntity
    {
        public OrderType OrderType { get; set; }
        public FoodType FoodType { get; set; }
        public int Quantity { get; set; }
        public CoffeeType CoffeeType { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }

    }
}
