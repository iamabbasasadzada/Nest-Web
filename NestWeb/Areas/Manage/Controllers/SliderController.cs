using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NestWeb.DAL;
using NestWeb.Models;
using NestWeb.Utilies.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NestWeb.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }

        private  IWebHostEnvironment _envo { get; }

        public SliderController(AppDbContext context, IWebHostEnvironment envo)
        {
            _context = context;
            _envo = envo;
        }
        public IActionResult Index()
        {
            List<Slider> slider = _context.Sliders.ToList();
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.Sliders.Any(p => p.Title.ToLower().Trim() == slider.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", "This title already in db");
                return View();
            }
            if (slider.Photo.CheckSize(500))
            {
                ModelState.AddModelError("Photo", "Image size cant be higher than 500kb");
                return View();
            }
            if (!slider.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "File must be image");
                return View();
            }
            slider.Image = await slider.Photo.SaveFileAsync(Path.Combine(_envo.WebRootPath, "assets", "imgs", "slider"));
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Slider slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();
            if (System.IO.File.Exists(Path.Combine(_envo.WebRootPath, "assets", "imgs", "slider", slider.Image)))
            {
                System.IO.File.Delete(Path.Combine(_envo.WebRootPath, "assets", "imgs", "slider", slider.Image));
            }
            _context.Sliders.Remove(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int Id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(s => s.Id == Id);
            if(slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Slider slider)
        {
            Slider slidertoupdate = _context.Sliders.FirstOrDefault(s => s.Id == slider.Id);
            if (slidertoupdate == null) return NotFound();
            slidertoupdate.Title=slider.Title;
            slidertoupdate.Description = slider.Description;
            if (slider.Photo != null)
            {
                if (slider.Photo.CheckSize(500))
                {
                    ModelState.AddModelError("Photo", "Image size cant be higher than 500kb");
                    return RedirectToAction(nameof(Edit));
                }
                if (!slider.Photo.CheckType("image/"))
                {
                    ModelState.AddModelError("Photo", "File must be image");
                    return RedirectToAction(nameof(Edit));
                }
                slider.Image = await slider.Photo.SaveFileAsync(Path.Combine(_envo.WebRootPath, "assets", "imgs", "slider"));
                slidertoupdate.Image = slider.Image;
            }
            if (slider.Image!=null) slidertoupdate.Image = slider.Image;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
