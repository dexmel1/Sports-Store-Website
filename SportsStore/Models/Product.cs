﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class Product
    {
        public long? ProductID { get; set; }

        [Required(ErrorMessage ="Please enter a product name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage ="Please enter a description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(.01, double.MaxValue, ErrorMessage ="Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Please specify a description")]
        public string Category { get; set; } = string.Empty;
    }
}
