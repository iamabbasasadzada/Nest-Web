using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestWeb.DAL;
using NestWeb.Models;
using NestWeb.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NestWeb.Utilies.Extensions;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace NestWeb.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        private AppDbContext _context{ get; }
        private IWebHostEnvironment _envo { get; }
        public ProductController(AppDbContext context , IWebHostEnvironment envo)
        {
            _context = context;
            _envo = envo;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products= await _context.Products.Include(p=>p.ProductImages).Include(pc=>pc.Category).ToListAsync();
            List<ProductVM> productsVM= new List<ProductVM>();
            foreach (var item in products)
            {
                //defaultprod.png
                ProductVM product = new ProductVM
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Category = item.Category.Name,
                    IsDeleted=item.IsDeleted,
                    Image = item.ProductImages.FirstOrDefault(p => p.IsFront == true).Image 
                };
                productsVM.Add(product);
            }
            return View(productsVM);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.Products.Any(p => p.Name.Trim().ToLower() == product.Name.Trim().ToLower()))
            {
                ModelState.AddModelError("Name", "This name already in db");
                return View();
            }
            if (product.Photos != null)
            {
                foreach (IFormFile file in product.Photos)
                {
                    if (file.CheckSize(5000))
                    {
                        ModelState.AddModelError("Photos", "Photo cant be a higher than 5");
                        return View();
                    }
                    if (!file.CheckType("image/"))
                    {
                        ModelState.AddModelError("Photos", "File must be image");
                        return View();
                    }
                }
                product.ProductImages = new List<ProductImage>();
                foreach (IFormFile file in product.Photos)
                {
                    product.ProductImages.Add(new ProductImage()
                    {
                        Image = await file.SaveFileAsync(Path.Combine(_envo.WebRootPath, "assets", "imgs", "shop")),
                        IsBack = false,
                        IsFront = false,
                        Product = product
                    });
                }
            }

            if (product.PhotoFront.CheckSize(5000))
            {
                ModelState.AddModelError("PhotoFront", "Photo cant be a higher than 5");
                return View();
            }
            if (!product.PhotoFront.CheckType("image/"))
            {
                ModelState.AddModelError("PhotoFront", "File must be image");
                return View();
            }
            if (product.PhotoBack.CheckSize(5000))
            {
                ModelState.AddModelError("PhotoBack", "Photo cant be a higher than 5");
                return View();
            }
            if (!product.PhotoBack.CheckType("image/"))
            {
                ModelState.AddModelError("PhotoBack", "File must be image");
                return View();
            }
            product.ProductImages.Add(new ProductImage()
            {
                Image = await product.PhotoFront.SaveFileAsync(Path.Combine(_envo.WebRootPath, "assets", "imgs", "shop")),
                IsBack = false,
                IsFront = true,
                Product = product
            });
            product.ProductImages.Add(new ProductImage()
            {
                Image = await product.PhotoBack.SaveFileAsync(Path.Combine(_envo.WebRootPath, "assets", "imgs", "shop")),
                IsBack = true,
                IsFront = false,
                Product = product
            });
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == Id);
            if (product.IsDeleted == false)
            {
                product.IsDeleted = true;
                _context.SaveChanges();
            }
            else
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        //public IActionResult Edit(Product product)
        //{
        //    Product productToUpdate = _context.Products.FirstOrDefault(p => p.Id == product.Id);
        //    if (productToUpdate == null) return NotFound();
        //    productToUpdate.Name = product.Name;
        //    productToUpdate.Price = product.Price;
        //    productToUpdate.Description = product.Description;
        //    productToUpdate.Category = product.Category;
        //    productToUpdate.StockCount = product.StockCount;
        //    productToUpdate.Raiting = product.Raiting;
        //    _context.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}
        //public IActionResult Editt()
        //{
        //    return View();
        //}
        public IActionResult Update(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            Product productToUpdate = _context.Products.FirstOrDefault(p => p.Id == product.Id);

            List<ProductImage> productImages = new List<ProductImage>();
            if (productToUpdate == null) return NotFound();
            //if (product.Photos != null)
            //{
            //    foreach (IFormFile file in product.Photos)
            //    {
            //        if (file.CheckSize(5000))
            //        {
            //            ModelState.AddModelError("Photos", "Photo cant be a higher than 5");
            //            return View();
            //        }
            //        if (!file.CheckType("image/"))
            //        {
            //            ModelState.AddModelError("Photos", "File must be image");
            //            return View();
            //        }
            //    }
            //    product.ProductImages = new List<ProductImage>();
            //    foreach (IFormFile file in product.Photos)
            //    {
            //        product.ProductImages.Add(new ProductImage()
            //        {
            //            Image = await file.SaveFileAsync(Path.Combine(_envo.WebRootPath, "assets", "imgs", "shop")),
            //            IsBack = false,
            //            IsFront = false,
            //            Product = product
            //        });
            //    }
            //    if (product.ProductImages.Count != 0) productToUpdate.ProductImages = product.ProductImages;
            //}
            //if (product.PhotoBack != null)
            //{
            //    if (product.PhotoBack.CheckSize(5000))
            //    {
            //        ModelState.AddModelError("PhotoBack", "Photo cant be a higher than 5");
            //        return View();
            //    }
            //    if (!product.PhotoBack.CheckType("image/"))
            //    {
            //        ModelState.AddModelError("PhotoBack", "File must be image");
            //        return View();
            //    }
            //    productImages.Add(new ProductImage()
            //    {
            //        Image = await product.PhotoBack.SaveFileAsync(Path.Combine(_envo.WebRootPath, "assets", "imgs", "shop")),
            //        IsBack = true,
            //        IsFront = false,
            //        Product = product
            //    });
            //    productToUpdate.ProductImages = productImages;
            //}
            //if (product.PhotoFront != null)
            //{
                
            //    if (product.PhotoFront.CheckSize(5000))
            //    {
            //        ModelState.AddModelError("PhotoFront", "Photo cant be a higher than 5");
            //        return View();
            //    }
            //    if (!product.PhotoFront.CheckType("image/"))
            //    {
            //        ModelState.AddModelError("PhotoFront", "File must be image");
            //        return View();
            //    }
            //    productImages.Add(new ProductImage()
            //    {
            //        Image = await product.PhotoFront.SaveFileAsync(Path.Combine(_envo.WebRootPath, "assets", "imgs", "shop")),
            //        IsBack = false,
            //        IsFront = true,
            //        Product = product
            //    });
            //    productToUpdate.ProductImages = productImages;
            //}
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Description = product.Description;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.StockCount = product.StockCount;
            productToUpdate.Raiting = product.Raiting;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
