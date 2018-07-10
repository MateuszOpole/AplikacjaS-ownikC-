using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BazaFilmów.Models;
using System.Data.Entity;

namespace BazaFilmów.Controllers
{
    public class testController : Controller
    {
        
        // GET: Home
        public ActionResult test()
        {
            return View();
        }
    }
}