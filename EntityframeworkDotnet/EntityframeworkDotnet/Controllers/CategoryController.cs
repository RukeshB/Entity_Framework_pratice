using EntityframeworkDotnet.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityframeworkDotnet.Controllers
{
    public class CategoryController : Controller
    {
        fastfoodEntities dbentity = new fastfoodEntities();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public JsonResult Create(category cat)
        {
            try
            {
                category cmodel = new category();
                cmodel.catagory_name = cat.catagory_name;

                dbentity.categories.Add(cmodel);
                dbentity.SaveChanges();
                return Json(new { status = true, msg = "Saved successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { status = true, msg = ex.Message.ToString() });
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
