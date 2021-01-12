using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityframeworkWebForm
{
    public partial class _Default : Page
    {
        fastfoodEntities entity = new fastfoodEntities();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            loadcategory();
            loadFood();
        }
        public void loadFood()
        {
            var query = from s in entity.sizes
                        join f in entity.Foods on s.food_id equals f.id
                        join c in entity.categories on f.catagory_id equals c.id
                        select new
                        {
                            id = f.id,
                            name = f.name,
                            size_name = s.size1,
                            price = s.price,
                            category_name = c.catagory_name
                        };
            FoodList.DataSource = query.ToList();
            FoodList.DataBind();
        }

        public void loadcategory()
        {
            catagory.DataSource = entity.categories.ToList();
            catagory.DataValueField = "id";
            catagory.DataTextField = "catagory_name";
            catagory.DataBind();
        }

        protected void save_Click(object sender, EventArgs e)
        {
            Food fmodel = new Food();
            size smodel = new size();

            fmodel.catagory_id = Convert.ToInt32(catagory.SelectedValue);
            fmodel.name = name.Text;
            smodel.size1 = sizeList.SelectedValue;
            smodel.price = Convert.ToInt32(price.Text);
            fmodel.sizes.Add(smodel);
            entity.Foods.Add(fmodel);
            entity.SaveChanges();
        }
    }
}