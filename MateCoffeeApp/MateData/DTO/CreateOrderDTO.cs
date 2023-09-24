using MateData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateData.DTO
{
    public class CreateOrderDTO
    {
        [Required]
        public OrderType OrderType { get; set; }
        [Required]
        public FoodType FoodType { get; set; }
        [Required]
        public CoffeeType CoffeeType { get; set; }
        [Required]
        public string Quantity { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public int OrderId { get; set; }
    }
}
