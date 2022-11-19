using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestWeb.DAL;
using NestWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestWeb.ViewComponents
{
    public class ProductCateViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public ProductCateViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync( int categoryId)
        {
            List<Product> products = await _context.Products.Where(p => p.CategoryId == categoryId)
                                                            .Where(p => p.IsDeleted == false)
                                                            .OrderByDescending(p => p.Id)
                                                            .Take(10)
                                                            .Include(p => p.ProductImages)
                                                            .Include(p => p.Category)
                                                            .ToListAsync();

            return View(await Task.FromResult(products));
        }
    }
}
