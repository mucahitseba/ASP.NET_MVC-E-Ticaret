using ASP.NET_MVC_E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_E_Ticaret.Controllers
{
    public class HomeController : Controller
    {
        MyContext _context = new MyContext();
        public ActionResult Index()
        {
            var products = _context.Products.Where(i => i.isApproved == true && i.isHome == true).ToList();
            return View(products);
        }
    }
}