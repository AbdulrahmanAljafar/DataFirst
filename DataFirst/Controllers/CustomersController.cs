using DataFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFirst.Controllers
{
    public class CustomersController : Controller
    {
        private readonly logisticContext _db; 
        public CustomersController(logisticContext context) { 
            _db = context; 
        }
        public IActionResult Index()
        {
            var _Join = from shipment in _db.Shipments
                        join customer in _db.Customers on shipment.Id equals customer.Id
                        join product in _db.Products on shipment.Id equals product.Id
                        select new Join(){ DateOfDelivery = shipment.DateOfDelivery, LocationOfDelivery = shipment.LocationOfDelivery, customer_name = customer.FirstName, product_name = product.Name };

            /*  return Json(_Join);*/


            ViewData["Customers"] = _Join.ToList();
            return View();
        }
    }

}
