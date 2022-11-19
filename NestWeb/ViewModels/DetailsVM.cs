using NestWeb.Models;
using System.Collections.Generic;

namespace NestWeb.ViewModels
{
    public class DetailsVM
    {
        public List<Category> Categories { get; set; }
        public Product Products { get; set; }
    }
}
