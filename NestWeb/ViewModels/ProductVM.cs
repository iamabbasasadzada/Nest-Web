using NestWeb.Models;

namespace NestWeb.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category{ get; set; }
        public bool IsDeleted { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
