﻿using EntityframeworkDotnet.Context;
using EntityframeworkDotnet.Context.DAL;
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
        private _IAllRepo<category> interfaceobj;

        public CategoryController()
        {
            this.interfaceobj = new AllRepo<category>();
        }

        // GET: Category
        public ActionResult Index()
        {
            
            return View(interfaceobj.GetModel().Where(x => x.isDeleted == false));
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

                //using interface and repo
                interfaceobj.InsertModel(cmodel);
                interfaceobj.save();

                //using entity
                //dbentity.categories.Add(cmodel);
                //dbentity.SaveChanges();
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
            var CatById = interfaceobj.GetModelById(id);
            return View(CatById);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, category collection)
        {
            try
            {
                // TODO: Add update logic here
                interfaceobj.UpdateModel(collection);
                interfaceobj.save();
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
            var CatById = interfaceobj.GetModelById(id);
            return View(CatById);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, category collection)
        {
            try
            {
                collection.isDeleted = true;
                //category catmodel = new category();
                //catmodel.id = collection.id;

                interfaceobj.UpdateModel(collection);
                interfaceobj.save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult pratice()
        {
            return View();
        }

        public PartialViewResult parialview1()
        {
            return PartialView("_TryPartialView");
        }

        public PartialViewResult parialview2()
        {
            return PartialView("_partialview2");
        }
    }
}
