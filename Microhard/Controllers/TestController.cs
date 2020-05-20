using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microhard.Models;
using String = System.String;

namespace Microhard.Controllers
{
    public class TestController : Controller
    {
        // GET: Test/Bamba
        public ActionResult Bamba()
        {
            //return View();
            //return Content("ASD Hagever");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
            return View();
        }

        public ActionResult Edit(int? id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        
        [Route("y")]
        public ActionResult y()
        {
            return Content("<img src='https://media.giphy.com/media/NcE2q0J7sfgl2/giphy.gif'>" +
                           "<h1> This is ASD</h1>");
        }

        [Route("y/so")]
        public ActionResult so()
        {
            return View();
        }

        [Route("y/so/serious")]
        public ActionResult serious()
        {
            if (User.IsInRole(RoleName.Admin))
                return Content("<h1>SERIOUSS</h1>");

            return Content("<h1>This Page is For Admin Only.</h1>");
        }
    }
}