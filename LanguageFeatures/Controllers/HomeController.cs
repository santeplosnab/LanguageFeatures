using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
           bool FilterByPrice(Product p)
            {
                return (p?.Price ?? 0) >= 20;
            }


            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Life jacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            Func<Product, bool> nameFilter = delegate (Product prod)
            {
                return prod?.Name?[0] == 'S';
            };

            decimal priceFilterTotal = productArray
                .FilterByPrice(FilterByPrice)
                .TotalPrices();

            decimal nameFilterTotal = productArray
                .FilterByPrice(nameFilter)
                .TotalPrices();

            return View("Index", new string[]
            {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"
            });
        }
    }
}
