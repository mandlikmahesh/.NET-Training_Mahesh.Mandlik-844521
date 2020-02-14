using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string un,string pass)
        {

            harshalEntities ctx = new harshalEntities();

            LoginInfo ln = new LoginInfo();
            UserDetail ud = new UserDetail();
            var rec = ctx.LoginInfoes.Where(d => d.UserName == un && d.Passwrd == pass).FirstOrDefault();
            if(rec!=null)
            {
                var res = from e in ctx.LoginInfoes where e.UserName == "un" select new { id = e.UserId };
                foreach(var d in res)
                {
                    var obj = from a in ctx.UserDetails where a.UserId == d.id select a;
                    foreach(var z in obj)
                    {
                        Console.WriteLine(z.DetId + " " + z.UserId + " " + z.Age + " " + z.City);
                    }

                }
                return Redirect("/User/Details?Id="+rec.UserId);


            }
            ViewBag.Msg = "Error in signin....";


            return View();
        }
        public ActionResult Details()
        {
            int id = int.Parse(Request["Id"]);
            harshalEntities ctx = new harshalEntities();
            var obj = ctx.UserDetails.Where(u => u.UserId == id).FirstOrDefault();
            if(obj!=null)
            {
                ViewBag.age = obj.Age;
                ViewBag.city = obj.City;
                ViewBag.rep = obj.ReportingTo;
            }
            return View();

        }
    }
}