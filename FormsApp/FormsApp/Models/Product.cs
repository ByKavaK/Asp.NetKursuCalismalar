﻿using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }
        [Display(Name = "Urun Adı")]
        [Required]
        public string? Name { get; set; }
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}
