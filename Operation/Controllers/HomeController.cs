using Operation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Operation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperationModel model, string command)
        {
            if(command == "add")
            {
                model.Result = model.A + model.B;
            }
            if(command == "sub")
            {
                model.Result = model.A - model.B;
            }
            if(command == "mul")
            {
                model.Result = model.A * model.B;
            }
            if(command == "div")
            {
                model.Result = model.A / model.B;
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}