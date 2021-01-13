using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityframeworkWebForm
{
    public partial class _Default : Page
    {
        fastfoodEntities entity = new fastfoodEntities();
        int fid = 0;
        int sid = 0;
        int textbox_num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            loadcategory();
            loadFood();
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

        public void loadFood()
        {
            var query = from s in entity.sizes
                        join f in entity.Foods on s.food_id equals f.id
                        join c in entity.categories on f.catagory_id equals c.id
                        where s.isDeleted == false && f.isDeleted == false && c.isDeleted == false
                        select new
                        {
                            id = f.id,
                            name = f.name,
                            size_id = s.id,
                            size_name = s.size1,
                            price = s.price,
                            category_name = c.catagory_name
                        };
            FoodList.DataSource = query.ToList();
            FoodList.DataBind();
            int i = query.ToList().Count();
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
            Food fmodel = entity.Foods.Find(fid);
            //size smodel = entity.sizes.FirstOrDefault(x => x.food_id == fid);
            size smodel = entity.sizes.Find(sid);
            if (fmodel == null)
            {
                fmodel = new Food();
                smodel = new size();

                fmodel.catagory_id = Convert.ToInt32(catagory.SelectedValue);
                fmodel.name = name.Text;
                smodel.size1 = sizeList.SelectedValue;
                smodel.price = Convert.ToInt32(price.Text);
                fmodel.sizes.Add(smodel);
                entity.Foods.Add(fmodel);
            }
            
            else
            {
                fmodel.catagory_id = Convert.ToInt32(catagory.SelectedValue);
                fmodel.name = name.Text;
                smodel.size1 = sizeList.SelectedValue;
                smodel.price = Convert.ToInt32(price.Text);

                entity.Entry(smodel).State = EntityState.Modified;
                entity.Entry(fmodel).State = EntityState.Modified;
            }
            entity.SaveChanges();
            loadFood();
        }

        protected void FoodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fid = Convert.ToInt32(FoodList.SelectedRow.Cells[1].Text);
            sid = Convert.ToInt32(FoodList.SelectedRow.Cells[2].Text);
            name.Text = FoodList.SelectedRow.Cells[3].Text;
            //catagory.Text = FoodList.SelectedRow.Cells[4].Text;
            sizeList.Text = FoodList.SelectedRow.Cells[5].Text;
            price.Text = FoodList.SelectedRow.Cells[6].Text;
        }

        protected void btn_size_Click(object sender, EventArgs e)
        {
            add_size();
        }

        private void add_size()
        {
            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();


            cell1.Text = "Size:";
            row.Cells.Add(cell1);

            cell1 = new TableCell();
            row.Cells.Add(cell1);

            DropDownList ddl_size = new DropDownList();
            ddl_size.ID = "SizeList" + textbox_num;
            ddl_size.Items.Add("small");
            ddl_size.Items.Add("medium");
            ddl_size.Items.Add("large");
            cell1.Controls.Add(ddl_size);

            cell1 = new TableCell();
            cell1.Text = "Price:";
            row.Cells.Add(cell1);

            cell1 = new TableCell();
            row.Cells.Add(cell1);

            TextBox tb_price = new TextBox();
            tb_price.ID = "price" + textbox_num;
            cell1.Controls.Add(tb_price);

            myTable.Rows.Add(row);
            textbox_num++;
        }
    }
}