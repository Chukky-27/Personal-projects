﻿namespace TheoCoffeeApp.Data.Entities
{
    public class BaseEntity
    {
        public string CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } 
    }
}