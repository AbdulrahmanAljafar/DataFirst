using DataFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFirst.Controllers
{
    public class ProductsController : Controller
    {
        private readonly logisticContext _db;
        public ProductsController(logisticContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            ViewData["Products"] = _db.Products.ToList();
            return View();
        }
    }
}
