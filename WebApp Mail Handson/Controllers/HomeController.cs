
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mail.Models;

namespace mail.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult mailinfo(string un, string ps)
        {
            harshalEntities jd = new harshalEntities();
            csmodel mode = new csmodel();
            List<csmodel> l = new List<csmodel>();
            int ui = jd.UserInfoes.Where(i => i.Username == un && i.Password == ps).Select(i => i.UserID).FirstOrDefault();
            if (ui != 0)
            {

                var m = jd.MailDetails.Where(i => i.UserID == ui).Select(i => i);
                foreach (var i in m)
                {
                    l.Add(new csmodel() { mailid = i.MailID, sub = i.Subject });
                }
                /*mode.MailID = i.mailid;
                 mode.Name = i.mailform;
                 mode.Date = (DateTime)(i.recieveddate);
                 mode.Message = i.mes;*/
            }

            return View(l);
        }
        public ActionResult info(int id)
        {
            harshalEntities jd = new harshalEntities();
            csmodel mode = new csmodel();
            var m = jd.MailDetails.Where(i => i.MailID == id).Select(i => i).FirstOrDefault();
            mode.mes = m.Message;
            return View(mode);

        }


    }
}
