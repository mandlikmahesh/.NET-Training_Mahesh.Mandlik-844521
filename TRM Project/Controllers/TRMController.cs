
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRMProjectCode.Models;
using System.Data;
using System.Data.SqlClient;


namespace TRMProjectCode.Controllers
{
    public class TRMController : Controller
    {
        // GET: Login
        public ActionResult Loginprocess()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loginprocess(string un, string pass)
        {
            TRM t = new TRM  ();

            var res = t.Logininfos.Where(m => m.User_name == un && m.Password == pass).FirstOrDefault();
            if (res != null)
            {
                Session["rid"] = res.Role_id;
                Session["id"] = res.Id;
                return RedirectToAction("Requestprocess", "Login");
            }
            return View();
        }

        public ActionResult Requestprocess()
        {
            TRM t = new TRM t ();
            var req = (from i in t.Requestinfos
                       join u in t.Logininfos
                       on i.pm_id equals u.Id
                       select new { Skill = i.Skill, startdate = i.Start_date, enddate = i.End_date, Requestname = i.Reqname, PMName = u.User_name, reqid = i.Request_id, status = i.Status }).ToList();
            int rid = int.Parse(Session["rid"].ToString());
            ViewBag.rid = rid;
            List<Requestdata> reqdata = new List<Requestdata>();
            foreach (var i in req)
            {
                Requestdata r = new Requestdata();
                r.skill = i.Skill;
                r.startdate = i.startdate;
                r.enddate = i.enddate;
                r.Requestname = i.Requestname;
                //r.pmid = i.pm_id;
                r.PMName = i.PMName;
                r.reqid = i.reqid;
                r.status = i.status;


                reqdata.Add(r);
            }
            return View(reqdata);
        }
        [HttpPost]
        public ActionResult AddRequest(string sk, DateTime sd, DateTime ed, string rn)
        {
            TRM t = new TRM();
            Requestinfo r = new Requestinfo();
            r.Skill = sk;
            r.Start_date = sd;
            r.End_date = ed;
            r.Status = "Request";
            int id = int.Parse(Session["id"].ToString());
            r.pm_id = id;
            r.Reqname = rn;
            t.Requestinfos.Add(r);
            t.SaveChanges();
            return RedirectToAction("Requestprocess", "Login");

        }
        public ActionResult AddRequest()
        {

            return View();

        }

        public ActionResult Spocsub(int rid)
        {
            Session["Request_id"] = rid;

            TRM t = new TRM();
            var obj = t.Logininfos.Where(i => i.Role_id == 3);
            SelectListItem[] trainers = new SelectListItem[obj.Count()];
            int j = 0;
            foreach (var i in obj)
            {
                trainers[j] = new SelectListItem() { Text = i.Id.ToString(), Value = i.Id.ToString() };
                j++;
            }
            ViewBag.trainers = trainers;
            var obj1 = t.Logininfos.Where(i => i.Role_id == 4);
            SelectListItem[] exicutives = new SelectListItem[obj1.Count()];
            j = 0;
            foreach (var i in obj1)
            {
                exicutives[j] = new SelectListItem() { Text = i.Id.ToString(), Value = i.Id.ToString() };
                j++;
            }
            ViewBag.exicutives = exicutives;


            return View();
        }
        public ActionResult Spocdb(int trainer, int exicutive)
        {
            int rid = int.Parse(Session["Request_id"].ToString());
            TRM t = new TRM();
            var r = (from i in t.Requestinfos where i.Request_id == rid select i).FirstOrDefault();
            r.Exicutive_id = exicutive;
            r.Trainer_id = trainer;
            r.Status = "assigned";
            t.SaveChanges();

            return RedirectToAction("Requestprocess", "Login");

        }
        public ActionResult confirm(int rid)
        {
            TRM t = new TRM();
            var r = (from i in t.Requestinfos where i.Request_id == rid select i).FirstOrDefault();
            r.Status = "confirmed";
            t.SaveChanges();
            return RedirectToAction("Requestprocess", "Login");
        }

    }
}
