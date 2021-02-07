using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
         
            return View();
        }

        public IActionResult Food(string food)
        {
            
            return View();
        }
        public IActionResult Tech(string tech)
        {

            return View();
        }
        public IActionResult Sports(string sports)
        {

            return View();
        }
        
    }
}
