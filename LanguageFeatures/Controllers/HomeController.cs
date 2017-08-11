using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //List<string> result = new List<string>();

            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    string category = p?.Category;
            //    decimal? price = p?.Price ?? 0;
            //    string related = p?.Related?.Name ?? "<None>";
            //    bool? inStock = p?.InStock;
            //    result.Add($"Name: {name}, Category: {category}, Price: {price:C2}, Related: {related}, In stock: {inStock}");
            //}

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product {Name = "Kayak", Price = 275M} ,
            //    ["Life jacket"] = new Product {Name = "Life jacket", Price = 48.95M}
            //};

            //decimal cartTotal = cart.TotalPrices();

            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Life jacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

            return View("Index", new string[]
            {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"
            });
        }
    }
}
