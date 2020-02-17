using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mail.Controllers
{
    public class mailController : Controller
    {
        // GET: mail
        public ActionResult Index()
        {
            return View();
        }
    }
}