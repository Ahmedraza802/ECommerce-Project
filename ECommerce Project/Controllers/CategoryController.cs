using ClassEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce_Project.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Cate
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category categoty)
        {
            if (ModelState.IsValid)
            {
                return View(categoty);
            }
            return View();
        }
    }
}