﻿using System.ComponentModel.DataAnnotations;

namespace PastryShopProductManagementSystem.Models
{
    public class Dessert
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public Recipe Recipe { get; set; }
    }
}
