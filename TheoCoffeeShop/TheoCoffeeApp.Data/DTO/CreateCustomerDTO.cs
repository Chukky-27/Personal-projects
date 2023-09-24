﻿using System.ComponentModel.DataAnnotations;

namespace TheoCoffeeApp.Data.DTO
{
    public class CreateCustomerDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
