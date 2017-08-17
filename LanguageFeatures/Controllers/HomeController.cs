using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            long? lenght = await MyAsyncMethods.GetPageLenght();
            return View(new string[] { $"Lenght: {lenght}" });
            
            //Product[] productArray =
            //{
            //    new Product {Name = "Kayak", Price = 275M},
            //    new Product {Name = "Life jacket", Price = 48.95M},
            //    new Product {Name = "Soccer ball", Price = 19.50M},
            //    new Product {Name = "Corner flag", Price = 34.95M}
            //};

            //decimal priceFilterTotal = productArray
            //    .Filter(p => (p?.Price ?? 0) >= 20)
            //    .TotalPrices();

            //decimal nameFilterTotal = productArray
            //    .Filter(p => p?.Name?[0] == 'S')
            //    .TotalPrices();

            //return View("Index", new string[]
            //{
            //    $"Price Total: {priceFilterTotal:C2}",
            //    $"Name Total: {nameFilterTotal:C2}"
            //});
        }
    }
}
