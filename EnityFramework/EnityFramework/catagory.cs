using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EnityFramework
{
    public partial class catagory : UserControl
    {
        public catagory()
        {
            InitializeComponent();
        }

        int catagory_id;
        fastfoodEntities fe = new fastfoodEntities();

        private void clear()
        {
            tb_catagory.Clear();
            btn_save.Text = "Save";
            btn_delete.Enabled = false;
        }

        private void populatedatagrid()
        {
            dataGridView_catagory.Rows.Clear();
            var catagory = fe.categories.ToList();
            foreach(var data in catagory)
            {
                dataGridView_catagory.Rows.Add(data.id, data.catagory_name);
            }
        }

        public void load()
        {
            clear();
            populatedatagrid();
        }

        private void catagory_Load(object sender, EventArgs e)
        {
            if (Site != null && Site.DesignMode) return;
            load();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            category catagorymodel = fe.categories.Find(catagory_id);
            if(catagorymodel == null)
            {
                catagorymodel = new category();
                catagorymodel.catagory_name = tb_catagory.Text;
                fe.categories.Add(catagorymodel);
            }

            else
            {
                catagorymodel.catagory_name = tb_catagory.Text;
                fe.Entry(catagorymodel).State = EntityState.Modified;
            }
            fe.SaveChanges();
            clear();
            populatedatagrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("do you want to delete this record", "delete record", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                category category = fe.categories.Find(catagory_id);
                fe.categories.Remove(category);
                fe.SaveChanges();
                clear();
                populatedatagrid();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView_catagory_DoubleClick(object sender, EventArgs e)
        {
            catagory_id = Convert.ToInt32(dataGridView_catagory.CurrentRow.Cells["id"].Value);
            tb_catagory.Text =Convert.ToString( dataGridView_catagory.CurrentRow.Cells["name"].Value);
            btn_delete.Enabled = true;
            btn_save.Text = "Update";
        }
    }
}
