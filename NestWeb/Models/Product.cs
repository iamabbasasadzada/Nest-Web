using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Raiting { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int StockCount { get; set; }
        public bool IsDeleted { get; set; }
        public Category Category { get; set; }
        public List<ProductImage> ProductImages{ get; set; }
        [NotMapped]
        public IFormFileCollection Photos { get; set; }
        [NotMapped]
        public IFormFile PhotoFront { get; set; }
        [NotMapped]
        public IFormFile PhotoBack{ get; set; }

    }
}
