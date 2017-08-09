using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> result = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                string category = p?.Category;
                decimal? price = p?.Price ?? 0;
                string related = p?.Related?.Name ?? "<None>";
                bool? inStock = p?.InStock;
                result.Add(string.Format("Name: {0}, Category: {1}, Price: {2}, Related: {3}, In stock: {4}", name, category, price, related, inStock));
            }

            return View(result);
        }
    }
}
