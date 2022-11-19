using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestWeb.DAL;
using NestWeb.Models;
using NestWeb.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestWeb.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Products = await _context.Products.Include(p=>p.ProductImages).Include(p=>p.Category).OrderByDescending(p=>p.Id).Take(10).ToListAsync()
            };
            
            return View(homeVM);
        }

        public IActionResult Details(int Id)
        {
            DetailsVM detailsVM = new DetailsVM()
            {

                Categories = _context.Categories.ToList(),
                Products = _context.Products.Include(pi => pi.ProductImages).FirstOrDefault(p => p.Id == Id)
                //Products = _context.Products.Find(p => p.Id == Id).Include(p => p.ProductImages).Include(p => p.Category)
            };
            return View(detailsVM);
        }
    }
}
