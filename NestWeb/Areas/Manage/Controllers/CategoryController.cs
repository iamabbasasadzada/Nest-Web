using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestWeb.DAL;
using NestWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestWeb.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        private AppDbContext _context { get; }
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.Include(c=>c.Products).ToListAsync();
            return View(categories);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (_context.Categories.FirstOrDefault(c => c.Name.ToLower().Trim() == category.Name.ToLower().Trim()) != null) return RedirectToAction(nameof(Index));
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int Id)
        {
            Category category = _context.Categories.Find(Id);
            if (category == null) return NotFound();
            category.IsDeleted=true;
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public  IActionResult DeletePer(int Id)
        {
            Category category = _context.Categories.Find(Id);
            if (category == null) return NotFound();
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //public IActionResult UpdateGet(int Id)
        //{
        //    Category category1 = _context.Categories.Find(Id);
        //    if (category1 == null) return NotFound();
        //    ViewBag.UpGetCat = category1;
        //    return View();
        //}
        [HttpPost]
        public  IActionResult Update(int Id, Category category)
        {
            Category category1 = _context.Categories.Find(Id);

            if (category1 == null || category == null) return NotFound();
            category1.Name = category.Name;
            category1.Logo = category.Logo;
            _context.Categories.Update(category1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
