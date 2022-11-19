using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestWeb.DAL;
using NestWeb.Models;
using NestWeb.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
namespace NestWeb.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            
            ViewBag.Categories = _context.Categories.Where(p => p.IsDeleted == false).Include(c=>c.Products);
            ViewBag.Page = page;
            return View(_context.Products.Where(p=>p.IsDeleted==false).OrderByDescending(p=>p.Id).Take(10).Include(p=>p.ProductImages).Include(p=>p.Category));
        }
        public IActionResult LoadMore(int skip)
        {
            IQueryable<Product> p = _context.Products.Where(p => p.IsDeleted == false);
            int productCount = p.Count();
            if (productCount <= skip)
            {
                return Json(new
                {
                    message="Agilli ol"
                });
            }
            return PartialView("_ProductPartial", p
                                    .OrderByDescending(p => p.Id)
                                    .Skip(skip)
                                    .Take(10)
                                    .Include(p => p.ProductImages)
                                    .Include(p => p.Category));
        }
        public IActionResult CategoryFilter(int CategoryId)
        {
            if (_context.Categories.Find(CategoryId) == null) return NotFound();
            return PartialView("_ProductPartial", _context.Products.Where(p => p.IsDeleted == false && p.CategoryId == CategoryId)
                                .OrderByDescending(p => p.Id)
                                .Include(p => p.ProductImages)
                                .Include(p => p.Category));
        }
        public IActionResult Cart()
        {
            List<BasketVM> basketItems = new List<BasketVM>();
            List<BasketItemVm> basketItemVms=new List<BasketItemVm>();
            if (Request.Cookies["Basket"] != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["Basket"]);
            }
            foreach(var item in basketItems)
            {
                Product product= _context.Products.Include(p=>p.ProductImages).FirstOrDefault(pa=>pa.Id==item.ProductId);
                if (product == null) continue;
                BasketItemVm basketIt = new BasketItemVm()
                {
                    ProdId=product.Id,
                    Name = product.Name,
                    Image = product.ProductImages.FirstOrDefault(pi=>pi.IsFront==true).Image,
                    Price=product.Price,
                    Count=item.count,
                    Raiting=product.Raiting,
                    IsAviable=product.StockCount>0?true:false
                };
                basketItemVms.Add(basketIt);
            }
            decimal totalPrice = 0;
            if (basketItemVms.Count > 0)
            {
                foreach (BasketItemVm item in basketItemVms)
                {
                    totalPrice += (item.Count * item.Price);
                }
            }
            ViewBag.TotalPrice = totalPrice;
            return View(basketItemVms);
        }
        //public IActionResult DeteleAllCart()
        //{
        //    // HttpCookie problemi oldu

        //    if (Request.Cookies["Basket"] != null)
        //    {
        //        Response.Cookies["Basket"].Expires = DateTime.Now.AddDays(-1);

        //    }
        //    return RedirectToAction(nameof(Cart));
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeteleCart(int id)
        {
            List<BasketVM> basketItems = new List<BasketVM>();
            if (Request.Cookies["Basket"] != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["Basket"]);
            }
            BasketVM removeItemBasket = basketItems.Find(bi => bi.ProductId == id);
            if (removeItemBasket == null) return NotFound();
            basketItems.Remove(removeItemBasket);
            Response.Cookies.Append("Basket", JsonConvert.SerializeObject(basketItems));
            return RedirectToAction(nameof(Cart));
        }
        public IActionResult Basket()
        {
            List<BasketVM> basketVMs= JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["Basket"]);
            return Json(basketVMs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBasket(int? Id)
        {
            if (Id == null) return BadRequest();
            Product product = await _context.Products.FindAsync(Id);
            if(product == null) return NotFound();
            List<BasketVM> basketItems = new List<BasketVM>();
            if (Request.Cookies["Basket"] != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["Basket"]);
            }
            BasketVM extingItem = basketItems.Find(bi=> bi.ProductId==Id);
            if (extingItem != null)
            {
                extingItem.count += 1;
            }
            else
            {
                BasketVM basketItem = new BasketVM()
                {
                    ProductId = product.Id,
                    count = 1
                };
                basketItems.Add(basketItem);
            }
            Response.Cookies.Append("Basket", JsonConvert.SerializeObject(basketItems));
            return RedirectToAction(nameof(Index));
        }
    }
}
