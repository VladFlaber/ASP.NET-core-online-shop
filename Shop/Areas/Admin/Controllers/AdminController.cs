using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Repositories.Interfaces;

namespace Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
       
        //STATISTICA MAGAZA
        public IActionResult Index()
        {
            return View();
        }
        
      
    }
}