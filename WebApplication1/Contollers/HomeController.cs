using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(SimpleRepository.SharedRepository.Products);
        }
    }
}