using AspNetMongoDB.Data;
using AspNetMongoDB.Models;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMongoDB.Controllers
{
    public class RoupaController : Controller
    {
        private readonly LojaBD Context = new LojaBD();

        // GET: Home
        public ActionResult Index()
        {
            var Roupas = Context.Roupas.FindAll();
            return View(Roupas);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Roupa _roupa)
        {
            if (ModelState.IsValid)
            {
                Context.Roupas.Insert(_roupa);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string Id)
        {
            var roupa = Context.Roupas.FindOneById(new ObjectId(Id));
            return View(roupa);
        }
        [HttpPost]
        public ActionResult Edit(Roupa _roupa)
        {
            if (ModelState.IsValid)
            {
                Context.Roupas.Save(_roupa);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(string Id)
        {
            var del = Context.Roupas.FindOneById(new ObjectId(Id));
            return View(del);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string Id)
        {
            var del = Context.Roupas.Remove(Query.EQ("_id", new ObjectId(Id)));
            return RedirectToAction("Index");
        }
    }
}