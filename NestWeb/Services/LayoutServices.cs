using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NestWeb.DAL;
using NestWeb.Models;
using NestWeb.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace NestWeb.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _accessor;

        public LayoutServices(AppDbContext context, IHttpContextAccessor accessor )
        {
            
            _context = context;
            _accessor = accessor;
        }
        public Dictionary<string,string> GetSettings()
        {
            return _context.Settings.ToDictionary(p=>p.Key,p=>p.Value);
        }
        public int GetBasketItemCount()
        {
            if (_accessor.HttpContext.Request.Cookies["Basket"] == null) return 0;
            List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["Basket"]);
            return basket.Sum(basketItem => basketItem.count);
        }

        public List<BasketItemVm> GetBasketItems()
        {
            List<BasketVM> basketItems = new List<BasketVM>();
            List<BasketItemVm> basketItemVms=new List<BasketItemVm>();
            if (_accessor.HttpContext.Request.Cookies["Basket"] != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["Basket"]);
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
            return basketItemVms;
        }

        public decimal GetTotalPriceOfBasketItems()
        {
            List<BasketItemVm> basketItemVms = new List<BasketItemVm>();
            basketItemVms = GetBasketItems();
            decimal totalPrice = 0;
            if (basketItemVms.Count > 0)
            {
                foreach (BasketItemVm item in basketItemVms)
                {
                    totalPrice += (item.Count * item.Price);
                }
            }

            return totalPrice;

        }
    }
}
