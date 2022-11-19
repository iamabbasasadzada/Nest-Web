using Microsoft.AspNetCore.Mvc;
using NestWeb.DAL;
using System.Threading.Tasks;

namespace NestWeb.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

        }
}
