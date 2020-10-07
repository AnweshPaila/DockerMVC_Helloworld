using DockerMVC_Helloworld.Models.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DockerMVC_Helloworld.Controllers
{
    public class HomeController : Controller
    {
        DockerDBEntities db = new DockerDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Names = db.DockerTables.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            var obj = new DockerTable() { Name = name };
            db.DockerTables.Add(obj);
            db.SaveChanges();
            ViewBag.Names = db.DockerTables.ToList();
            return View();
        }

    }
}