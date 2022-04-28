using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFcore2.Models;

namespace EFcore2.Controllers
{
    public class ProductController1 : Controller
    {
        [Route("Product/Index")]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        [Route("Product/Create")]
        public IActionResult Create(Product p)
        {
            if(ModelState.IsValid)
                {
                ProductDBcontext dBcontext = new ProductDBcontext();
                dBcontext.Add(p);
                dBcontext.SaveChanges();
                return Content("Saved");
            }
            return View("Index");
        }
    }
}
