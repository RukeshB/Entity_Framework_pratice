using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fast_food_management_system
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FPMC18B;Initial Catalog=fastfood;Integrated Security=true");
        SqlCommand cmd;
        public int id;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_Load(object sender, EventArgs e)
        {
            GetFoodRecord();
        }

        private void clear()
        {
            FoodName.Clear();
            catagory.Text = "";
            price.Value = 0;
            this.id = 0;
        }

        private void GetFoodRecord()
        {
            //DataTable dt = new DataTable();
            FoodDataGridView.Rows.Clear();
            int sn = 1;
            conn.Open();
            cmd = new SqlCommand("select * from Food_Iteam", conn);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    FoodDataGridView.Rows.Add(sn, reader.GetString(1), reader.GetString(2),
                            reader.GetInt32(3));
                    sn++;
                }
            }
            conn.Close();

           // FoodDataGridView.DataSource = dt;
        }

        private void submmitBtn_Click(object sender, EventArgs e)
        {
           
            cmd = new SqlCommand("INSERT INTO Food_Iteam VALUES(@name, @catagory, @price)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", FoodName.Text);
            cmd.Parameters.AddWithValue("@catagory", catagory.Text);
            cmd.Parameters.AddWithValue("@price", price.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetFoodRecord();
            clear();
        }

        private void FoodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32( FoodDataGridView.SelectedRows[0].Cells[0].Value);
            FoodName.Text = FoodDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            catagory.Text = FoodDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            price.Value = Convert.ToDecimal(FoodDataGridView.SelectedRows[0].Cells[3].Value);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(id > 0)
            {
                cmd = new SqlCommand("UPDATE Food_Iteam SET name=@Name, catagory=@Catagory, price=@Price WHERE id=@Id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", FoodName.Text);
                cmd.Parameters.AddWithValue("@Catagory", catagory.Text);
                cmd.Parameters.AddWithValue("@Price", price.Value);
                cmd.Parameters.AddWithValue("@Id", this.id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                GetFoodRecord();
                clear();
            }
            else
            {
                MessageBox.Show("please select any food iteam to update");
            }
            
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                cmd = new SqlCommand("DELETE FROM Food_Iteam where id=@Id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                GetFoodRecord();
                clear();
            }
            else
            {
                MessageBox.Show("please select any food iteam to delete");
            }
        }
    }
}
