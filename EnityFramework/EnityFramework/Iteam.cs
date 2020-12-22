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
using System.Text.RegularExpressions;

namespace EnityFramework
{
    public partial class Iteam : UserControl
    {
        public Iteam()
        {
            InitializeComponent();
        }


        int y = 80;
        int num = 0;
        int dgvsize_y = 213;
        int food_id;
        int addflag = 0;
        int btn_num=0;
        fastfoodEntities fe = new fastfoodEntities();

        private void clear()
        {
            tb_name.Text = "";
            cb_catagory.Text = "";
            cb_size10.Text = "";
            nud_price10.Value = 0;
            btn_save.Text = "Save";
            btn_delete.Enabled = false;
            food_id = 0;

            num = 0;
            btn_num = 0;
            y = 80;
            dgvsize_y = 213;
            for (int i = 1; i <= 3; i++)
            {
                removecontrol(i);
            }

            addcontrol();

            btn_save.Location = new Point(101, 124);
            btn_delete.Location = new Point(210, 124);
            btn_reset.Location = new Point(319, 124);
            btn_print.Location = new Point(428, 124);
            dataGridView_Iteam.Location = new Point(0, 172);
            dataGridView_Iteam.Size = new Size(651, 213);

            btn_add.Enabled = true;
        }

        private void addcontrol()
        {
            dgvsize_y = dgvsize_y - 40;
            num++;
            

            Label newlabel = new Label();
            newlabel.Text = "Size";
            newlabel.Location = new Point(40, y);
            newlabel.Size = new Size(35, 17);
            newlabel.Name = "sizelabel" + Convert.ToString(num);
            newlabel.ForeColor = Color.FromArgb(0, 150, 136);
            this.Controls.Add(newlabel);

            ComboBox new_cb = new ComboBox();
            new_cb.Size = new Size(148, 21);
            new_cb.Location = new Point(110, y);
            //new_cb.Location.Offset(110, y);
            new_cb.Items.Add("small");
            new_cb.Items.Add("midium");
            new_cb.Items.Add("large");
            new_cb.Name = "cb_size" + Convert.ToString(num);
            Controls.Add(new_cb);

            Label newlabel2 = new Label();
            newlabel2.Text = "Price";
            newlabel2.Location = new Point(289, y);
            newlabel2.Size = new Size(40, 17);
            newlabel2.Name = "pricelabel" + Convert.ToString(num);
            newlabel2.ForeColor = Color.FromArgb(0, 150, 136);
            this.Controls.Add(newlabel2);

            NumericUpDown newnud = new NumericUpDown();
            newnud.Location = new Point(360, y);
            newnud.Size = new Size(148, 20);
            newnud.Name = "nud_price" + Convert.ToString(num);
            newnud.Maximum = 1000000;
            this.Controls.Add(newnud);

            Button newbtn = new Button();
            newbtn.Location = new Point(533, y);
            newbtn.Size = new Size(96, 21);
            newbtn.Name = "btn_remove"+ Convert.ToString(num);
            newbtn.Text = "Remove";
            newbtn.BackColor = Color.FromArgb(0, 150, 136);
            newbtn.ForeColor = Color.White;
            newbtn.FlatStyle = FlatStyle.Flat;
            newbtn.FlatAppearance.BorderSize = 0;
            newbtn.Hide();
            newbtn.Click += (s, e) => { btn_remove(newbtn.Name); };
            this.Controls.Add(newbtn);

            y = y + 40;
            

            btn_save.Location = new Point(btn_save.Location.X, btn_save.Location.Y + 40);
            btn_delete.Location = new Point(btn_delete.Location.X, btn_delete.Location.Y + 40);
            btn_reset.Location = new Point(btn_reset.Location.X, btn_reset.Location.Y + 40);
            btn_print.Location = new Point(btn_print.Location.X, btn_print.Location.Y + 40);
            dataGridView_Iteam.Location = new Point(dataGridView_Iteam.Location.X, dataGridView_Iteam.Location.Y + 40);
            dataGridView_Iteam.Size = new Size(651, dgvsize_y);

            if (num >= 3)
            {
                btn_add.Enabled = false;
            }
        }

        private void removecontrol(int i)
        {
            if (this.Controls["cb_size" + i] is ComboBox) this.Controls["cb_size" + i].Dispose();

            if (this.Controls["sizelabel" + i] is Label) this.Controls["sizelabel" + i].Dispose();

            if (this.Controls["pricelabel" + i] is Label) this.Controls["pricelabel" + i].Dispose();

            if (this.Controls["nud_price" + i] is NumericUpDown) this.Controls["nud_price" + i].Dispose();

            if (this.Controls["btn_remove" + i] is Button) this.Controls["btn_remove" + i].Dispose();
        }

        private void btn_remove(String name)
        {
            var numbers = Regex.Match(name, @"\d+").Value;
            btn_num = int.Parse(numbers);

            removecontrol(btn_num);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addcontrol();
            addflag ++;
        }

        public void load()
        {
            clear();
            populatedatagrid();

            cb_catagory.DataSource = fe.categories.ToList();
            cb_catagory.DisplayMember = "catagory_name";
            cb_catagory.ValueMember = "id";
        }

        private void Iteam_Load(object sender, EventArgs e)
        {
            if (Site != null && Site.DesignMode) return;

            load();
        }

        private void populatedatagrid()
        {
            dataGridView_Iteam.Rows.Clear();
            //dataGridView_Iteam.DataSource = fe.Food_Iteam.ToList<Food_Iteam>();
            var foods = fe.Foods.ToList();
            foreach (var data in foods)
            {
                foreach (var sizedata in data.sizes)
                {
                    //var category = data.category.catagory_name;
                    int index = dataGridView_Iteam.Rows.Add();
                    dataGridView_Iteam.Rows[index].Cells["name"].Value = data.name;
                    dataGridView_Iteam.Rows[index].Cells["id"].Value = data.id;
                    dataGridView_Iteam.Rows[index].Cells["catagory_id"].Value = data.catagory_id;
                    dataGridView_Iteam.Rows[index].Cells["catagory_name"].Value = data.category.catagory_name;

                    dataGridView_Iteam.Rows[index].Cells["price"].Value = sizedata.price;
                    dataGridView_Iteam.Rows[index].Cells["size"].Value = sizedata.size1;
                    dataGridView_Iteam.Rows[index].Cells["size_id"].Value = sizedata.id;
                }


                //dataGridView_Iteam.Rows.Add(data.id, data.name, data.catagory_id, data.category.catagory_name, data.price);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Food foodmodel = fe.Foods.Find(food_id);
            size sizemodel = fe.sizes.FirstOrDefault(x => x.food_id == food_id);
            if (foodmodel == null && sizemodel == null)
            {
                foodmodel = new Food();

                foodmodel.name = tb_name.Text;
                foodmodel.catagory_id = Convert.ToInt32(cb_catagory.SelectedValue);

                //sizemodel.price = Convert.ToInt32(nud_price1.Value);
                //sizemodel.size1 = cb_size1.Text;
                //fe.sizes.Add(sizemodel);


                for (int i = 1; i <= num; i++)
                {
                    sizemodel = new size();
                    if (this.Controls["cb_size" + i] is ComboBox)
                        sizemodel.size1 = this.Controls["cb_size" + i].Text;

                    if (this.Controls["nud_price" + i] is NumericUpDown)
                        // NumericUpDown numericUpDown=this.contro
                        sizemodel.price = Convert.ToInt32(this.Controls["nud_price" + i].Text);

                    foodmodel.sizes.Add(sizemodel);
                }

                fe.Foods.Add(foodmodel);
            }
            else
            {

                int i = 1;
                foodmodel.name = tb_name.Text;
                foodmodel.catagory_id = Convert.ToInt32(cb_catagory.SelectedValue);

                //sizemodel.price = Convert.ToInt32(nud_price1.Value);
                //sizemodel.size1 = cb_size1.Text;

                foreach (var sizedata in fe.sizes.Where(x => x.food_id.Equals(food_id)).ToList())
                {
                    
                        
                        if (this.Controls["cb_size" + i] is ComboBox)
                            sizedata.size1 = this.Controls["cb_size" + i].Text;

                        if (this.Controls["nud_price" + i] is NumericUpDown)
                            
                            sizedata.price = Convert.ToInt32(this.Controls["nud_price" + i].Text);

                    if(i==btn_num)
                    {
                        fe.sizes.RemoveRange(fe.sizes.Where(x => x.food_id == food_id && x.size1 == sizedata.size1 && x.price == sizedata.price));
                    }
                    i++;
                }

                if(addflag > 0)
                {
                    for (int j = i; j <= num; j++)
                    {
                        sizemodel = new size();

                        sizemodel.food_id = food_id;

                        if (this.Controls["cb_size" + j] is ComboBox)
                            sizemodel.size1 = this.Controls["cb_size" + i].Text;

                        if (this.Controls["nud_price" + j] is NumericUpDown)
                            // NumericUpDown numericUpDown=this.contro
                            sizemodel.price = Convert.ToInt32(this.Controls["nud_price" + j].Text);
                        if (sizemodel.size1 != null)
                        {
                            foodmodel.sizes.Add(sizemodel);
                        }
                    }
                }
                
                //fe.Entry(sizemodel).State = EntityState.Modified;
                fe.Entry(foodmodel).State = EntityState.Modified;
            }
            fe.SaveChanges();

            clear();
            populatedatagrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ??", "delete operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                Food foodmodel = fe.Foods.Find(food_id);
                
                //size sizemodel = fe.sizes.FirstOrDefault(x => x.food_id == food_id);

                //fe.sizes.RemoveRange(fe.sizes.Where(x => x.food_id == food_id));
                fe.sizes.RemoveRange(foodmodel.sizes);
                fe.Foods.Remove(foodmodel);
                //fe.sizes.Remove(sizemodel);

                fe.SaveChanges();
                populatedatagrid();
                clear();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView_Iteam_DoubleClick(object sender, EventArgs e)
        {
            clear();
            food_id = Convert.ToInt32(dataGridView_Iteam.CurrentRow.Cells["id"].Value);
            tb_name.Text = Convert.ToString(dataGridView_Iteam.CurrentRow.Cells["name"].Value);
            cb_catagory.Text = Convert.ToString(dataGridView_Iteam.CurrentRow.Cells["catagory_name"].Value);

            //cb_size1.Text = Convert.ToString(dataGridView_Iteam.CurrentRow.Cells["size"].Value);
            //nud_price1.Value = Convert.ToInt32(dataGridView_Iteam.CurrentRow.Cells["price"].Value);
            var sizes = fe.sizes.ToList();
            int i = 1;
            foreach(var data in sizes)
            {
                if(data.food_id == food_id)
                {
                    if(i>1)
                    {
                        addcontrol();
                    }
                    //addcontrol();
                    if (this.Controls["cb_size" + i] is ComboBox)
                        this.Controls["cb_size" + i].Text = data.size1;

                    if (this.Controls["nud_price" + i] is NumericUpDown)
                        // NumericUpDown numericUpDown=this.contro
                        this.Controls["nud_price" + i].Text = data.price.ToString();

                    if(this.Controls["btn_remove"+i] is Button)
                        this.Controls["btn_remove" + i].Show();
                    
                    i++;
                }
            }

            btn_save.Text = "Update";
            btn_delete.Enabled = true;
        }

        Bitmap bmp;

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bmp = new Bitmap(this.dataGridView_Iteam.Width, this.dataGridView_Iteam.Height);
            dataGridView_Iteam.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView_Iteam.Width, this.dataGridView_Iteam.Height));
           // printPreviewDialog1.ShowDialog();
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
