using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var res = dbentity.sizes.ToList();
            return View(res);
        }

        [HttpPost]
        public ActionResult AddFood(size smodel)
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

            return RedirectToAction("Index");
        }

        public ActionResult Food(int sizeid = 0)
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

        public ActionResult Delete(int sizeid, int foodid)
        {
            if (dbentity.sizes.Where(x => x.food_id == foodid).ToList().Count() == 1)
            {
                var delfood = dbentity.Foods.Where(x => x.id == foodid).FirstOrDefault();
                dbentity.Foods.Remove(delfood);
            }
            var delsize = dbentity.sizes.Where(x => x.id == sizeid).FirstOrDefault();
            dbentity.sizes.Remove(delsize);
            dbentity.SaveChanges();

            var res = dbentity.sizes.ToList();
            return View("Index", res);
        }

    }
}