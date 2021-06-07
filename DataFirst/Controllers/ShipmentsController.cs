using DataFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFirst.Controllers
{
    public class ShipmentsController : Controller
    {
        private readonly logisticContext _db;
        public ShipmentsController(logisticContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            ViewData["Shipments"] = _db.Shipments.ToList();
            return View();
        }
    }
}
