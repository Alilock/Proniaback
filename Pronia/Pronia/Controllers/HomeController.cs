using Microsoft.AspNetCore.Mvc;
using Pronia.DAL;
using Pronia.Models;
using Pronia.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {   

         ProniaContext _proniaContext;
        public HomeController(ProniaContext context)
        {
           _proniaContext = context;
        }
        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.Sliders = _proniaContext.Sliders.OrderBy(x=>x.Order);
            vm.Settings = _proniaContext.Settings.Where(x => x.IsDisabled == false);
                

            return View(vm);
        }
    }
}
