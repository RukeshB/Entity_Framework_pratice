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
            var res = dbentity.Foods.Where(x => x.isDeleted == false).ToList();
            return View(res);
        }

        [HttpPost]
        public ActionResult AddFood(Food fmodel)
        {
            try
            {
                Food fobj = dbentity.Foods.Find(fmodel.id);
                size sobj = dbentity.sizes.FirstOrDefault(x => x.food_id == fmodel.id);
                if(fobj == null)
                //if (fmodel.id == 0)
                {
                    fobj = new Food();
                    
                    fobj.name = fmodel.name;
                    fobj.catagory_id = fmodel.catagory_id;
                    foreach (var sizedata in fmodel.sizes)
                    //foreach(var sizedata in Request["Food.sizes"])
                    {
                        sobj = new size();
                        sobj.size1 = sizedata.size1;
                        sobj.price = sizedata.price;
                        dbentity.sizes.Add(sobj);
                    }
                    dbentity.Foods.Add(fobj);
                    dbentity.SaveChanges();
                }

                else
                {
                    int i = 0;
                    var s = dbentity.sizes.Where(x => x.food_id == fmodel.id && x.isDeleted == false).ToList();

                        fobj.name = fmodel.name;
                        fobj.catagory_id = fmodel.catagory_id;
                        dbentity.Entry(fobj).State = EntityState.Modified;

                        foreach (var sizedata in fmodel.sizes)
                        {
                            if (i > s.Count() - 1)//add new size while update
                            {
                                sobj = new size();
                                sobj.food_id = fmodel.id;
                                sobj.size1 = sizedata.size1;
                                sobj.price = sizedata.price;
                                dbentity.sizes.Add(sobj);
                            }
                            else// update current size
                            {
                                s[i].size1 = sizedata.size1;
                                s[i].price = sizedata.price;
                            }

                            i++;
                        }
                        dbentity.SaveChanges();
                    
                    
                }
                return RedirectToAction("Index");

            }

            catch (Exception ex)
            {
                ViewBag.errormessage = ex;
                return View("ErrorPage");
            }

            //ViewBag.category = new SelectList(dbentity.categories.ToList(), "id", "catagory_name", fmodel?.catagory_id);
            //return View("AddFood", fmodel);
        }

        public ActionResult Food(int foodid = 0)
        {
            try
            {
                var food = dbentity.Foods.Where(x => x.id == foodid).FirstOrDefault();
                ViewBag.category = new SelectList(dbentity.categories.ToList(), "id", "catagory_name", food?.catagory_id);

                if (foodid != 0)
                {
                    return View("AddFood", food);
                }


                else
                {
                    return View("AddFood");
                }

            }
            catch (Exception ex)
            {
                ViewBag.errormessage = ex;
                return View("ErrorPage");
            }

        }

        public ActionResult Deleteall(int foodid)
        {
            try
            {

                Food delfood = dbentity.Foods.Where(x => x.id == foodid && x.isDeleted == false).FirstOrDefault();
                delfood.isDeleted = true;
                //dbentity.Foods.Remove(delfood);


                foreach (var delsize in dbentity.sizes.Where(x => x.food_id == foodid && x.isDeleted == false).ToList())
                {
                    delsize.isDeleted = true;
                }

                //dbentity.sizes.Remove(delsize);
                //dbentity.Entry(delsize).State = EntityState.Modified;
                dbentity.Entry(delfood).State = EntityState.Modified;
                dbentity.SaveChanges();
            }
            catch (Exception ex)
            {
                ViewBag.errormessage = ex;
                return View("ErrorPage");
            }
            return RedirectToAction("Index");
        }

    }
}