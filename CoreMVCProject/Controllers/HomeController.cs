using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreMVCProject.Models;
using CoreMVCProject.Data;

namespace CoreMVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //pulls in the dbContext 
        private readonly MVCContext _DataContext;
        
        //Connects your dbContext to this controller 
        public HomeController(ILogger<HomeController> logger, MVCContext Context)
        {
            _logger = logger;
            _DataContext = Context;
            
        }

        

   

        public IActionResult Index()
        {
            //Adds your context to a object and sends the object to the view.
            var products = _DataContext.Products;


            return View(products);
        }

        public IActionResult Create()
        {
            var products = _DataContext.Products;


            return View(products);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
