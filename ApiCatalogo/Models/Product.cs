using System;
using System.ComponentModel.DataAnnotations;

namespace ApiCatalogo.Models
{
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }

        [Required]
        [MaxLength(300)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int Stock { get; set; }

        public DateTime DateCadastro { get; set; } = DateTime.Now;

        [Required]
        public Category Category { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Product()
        {
        }

        public Product(int productId, string productName, string description, double price, string imageUrl, int stock, DateTime dateCadastro, Category category, int categoryId)
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            Stock = stock;
            DateCadastro = dateCadastro;
            Category = category;
            CategoryId = categoryId;
        }
    }
}
