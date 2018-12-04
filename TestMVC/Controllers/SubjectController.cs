using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Context;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class SubjectController : Controller
    {
        private SubjectContext db = new SubjectContext();
        // GET: Subject
        public ActionResult Index()
        {
            return View(db.Subjects.ToList());
        }

     
        // GET: Subject/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subject/Create
        [HttpPost]
        public ActionResult Create(Subject subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Subjects.Add(subject);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(subject);

            }
            catch
            {
                return View();
            }
        }

     
    }
}
