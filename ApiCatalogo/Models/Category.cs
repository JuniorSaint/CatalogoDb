using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ApiCatalogo.Models
{
    
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(80)]
        public string CategoryName { get; set; }

        [Required]
        [MaxLength(300)]
        public string ImageUrl { get; set; }

        public ICollection<Product> Products { get; set; } = new Collection<Product>();
     


        public Category()
        {
        }

        public Category(int categoryId, string categoryName, string imageUrl)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            ImageUrl = imageUrl;
        }
    }
}
