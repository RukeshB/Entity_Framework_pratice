using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityframeworkWebForm
{
    public partial class List : System.Web.UI.Page
    {
        fastfoodEntities entity = new fastfoodEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            catagory.DataSource = entity.categories.ToList();
            catagory.DataValueField = "id";
            catagory.DataTextField = "catagory_name";
            catagory.DataBind();
            //clear();
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            //clear();
        }

        //void clear()
        //{
        //    name.Text = "";
        //    catagory.Text = "";
        //    sizeList.Text = "";
        //    price.Text = "";
        //}

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
            Response.Redirect("Default.aspx");
        }
    }
}