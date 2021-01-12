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

            //var foods = entity.Foods.ToList();
            //int index = 0;
            //foreach (var food in foods)
            //{
            //    int index = FoodList.Rows.
            //    FoodList.RowCreated row;
            //    FoodList.Rows[index].Cells[1].Text = food.name;
            //    FoodList.Rows[index].Cells[2].Text = food.category.catagory_name;
            //    foreach (var sizedata in food.sizes)
            //    {
            //        FoodList.Rows[index].Cells[3].Text = FoodList.Rows[index].Cells[2].Text + "," + sizedata.size1;
            //        FoodList.Rows[index].Cells[4].Text = FoodList.Rows[index].Cells[3].Text + "," + sizedata.size1;

            //    }
            //    index++;
            //}
            //
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


            //DataTable dt = new DataTable("food");
            //dt.Columns.Add("id", typeof(Int32));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("Category_Name", typeof(string));
            //dt.Columns.Add("Size", typeof(string));
            //dt.Columns.Add("Price", typeof(string));

            //var foods = entity.Foods.ToList();
            //var newrow = dt.Rows.Add();
            //string size_list = "";
            //string price_list = "";
            //foreach (var food in foods)
            //{
            //    newrow["id"] = food.id;
            //    newrow["Name"] = food.name;
            //    newrow["Category_Name"] = food.category.catagory_name;
            //    foreach(var sizedata in food.sizes)
            //    {
            //        size_list = size_list + " , " + sizedata.size1;
            //        price_list = price_list + " , " + sizedata.price;
            //    }
            //    newrow["Size"] = size_list;
            //    newrow["Size"] = price_list;
            //}
        }
    }
}