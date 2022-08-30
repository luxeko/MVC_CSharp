using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["name"] = "Lê Khả Đức Anh";
            TempData["age"] = "22";
            TempData["address"] = "Hà Nội";
            return View("ShowData");
        }

        public ActionResult ShowData()
        {
            return View();
        }
    }
}