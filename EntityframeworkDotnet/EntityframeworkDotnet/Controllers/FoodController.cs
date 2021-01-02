using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityframeworkDotnet.Context;

namespace EntityframeworkDotnet.Controllers
{
    public class FoodController : Controller
    {
        fastfoodEntities dbentity = new fastfoodEntities();

        // GET: Food
        public ActionResult Index()
        {
            var res = dbentity.sizes.Where(x=>x.isDeleted == false).ToList();
            return View(res);
        }

        [HttpPost]
        public ActionResult AddFood(size smodel)
        {
            try
            {
                Food fobj = dbentity.Foods.Find(smodel.food_id);
                size sobj = dbentity.sizes.Find(smodel.id);
                //if(fobj == null || sobj == null)
                if (smodel.food_id == 0 || smodel.id == 0)
                {
                    fobj = new Food();
                    sobj = new size();

                    fobj.name = smodel.Food.name;
                    fobj.catagory_id = smodel.Food.catagory_id;
                    sobj.size1 = smodel.size1;
                    sobj.price = smodel.price;

                    dbentity.Foods.Add(fobj);
                    dbentity.sizes.Add(sobj);
                    dbentity.SaveChanges();
                }

                else
                {
                    fobj.name = smodel.Food.name;
                    fobj.catagory_id = smodel.Food.catagory_id;
                    sobj.size1 = smodel.size1;
                    sobj.price = smodel.price;

                    dbentity.Entry(fobj).State = EntityState.Modified;
                    dbentity.Entry(sobj).State = EntityState.Modified;
                    dbentity.SaveChanges();
                }
            }
            
            catch(Exception ex)
            {
                ViewBag.errormessage = ex;
                return View("ErrorPage");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Food(int sizeid = 0)
        {
            try
            {
                var size = dbentity.sizes.Where(x => x.id == sizeid).FirstOrDefault();
                var category = dbentity.categories.ToList();
                SelectList list = new SelectList(category, "id", "catagory_name");
                ViewBag.category = list;
                if (sizeid != 0)

                    return View("AddFood", size);

                else
                    return View("AddFood");
            }
            catch (Exception ex)
            {
                ViewBag.errormessage = ex;
                return View("ErrorPage");
            }

        }

        public ActionResult Delete(int sizeid, int foodid)
        {
            try
            {
                if (dbentity.sizes.Where(x => x.food_id == foodid && x.isDeleted == false).ToList().Count() == 1)
                {
                    Food delfood = dbentity.Foods.Where(x => x.id == foodid && x.isDeleted == false).FirstOrDefault();
                    delfood.isDeleted = true;
                    //dbentity.Foods.Remove(delfood);
                    dbentity.Entry(delfood).State = EntityState.Modified;
                }
                size delsize = dbentity.sizes.Where(x => x.id == sizeid && x.isDeleted == false).FirstOrDefault();
                delsize.isDeleted = true;
                //dbentity.sizes.Remove(delsize);
                dbentity.Entry(delsize).State = EntityState.Modified;

                dbentity.SaveChanges();
            }
            catch(Exception ex)
            {
                ViewBag.errormessage = ex;
                return View("ErrorPage");
            }
            return RedirectToAction("Index");
        }

    }
}