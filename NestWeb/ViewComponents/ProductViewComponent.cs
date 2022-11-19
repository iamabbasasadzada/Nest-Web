using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestWeb.DAL;
using NestWeb.Models;
using NestWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestWeb.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public ProductViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int page=1)
        {
            int pageCount = (int)Math.Ceiling((double)_context.Products.Count() / 10);
            if(page< 0 || page > pageCount)
            {
                page = 1;
            }
            List<Product> products = await _context.Products.Where(p => p.IsDeleted == false)
                                                            .OrderByDescending(p => p.Id)
                                                            .Skip((page-1)*10)
                                                            .Take(10)
                                                            .Include(p => p.ProductImages)
                                                            .Include(p => p.Category)
                                                            .ToListAsync();
            PaginateVM<Product> paginateVm = new PaginateVM<Product>()
            {
                Items = products,
                ActivePage = page,
                PageCount = pageCount
            };
            return View(await Task.FromResult(paginateVm));
        }
        
    }
    
}