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
                result.Add($"Name: {name}, Category: {category}, Price: {price}, Related: {related}, In stock: {inStock}");
            }

            return View(result);
        }
    }
}
