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
    public class HomeController : Controller
    {
        // GET: Roupa
        public ActionResult Index()
        {
            return View();
        }
    }
}