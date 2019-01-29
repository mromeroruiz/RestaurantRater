using HumaneSociety.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumaneSociety.Controllers
{
    public class PetsController : Controller
    {
        private PetDBContext db = new PetDBContext();
        // GET: Pets
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Pets.Add(pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pet);
        }
    }
}