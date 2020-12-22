using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide_usercontrol()
        {
            iteam1.Hide();
            catagory1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            hide_usercontrol();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            hide_usercontrol();
            label1.Text = "Food";
            iteam1.Show();
            iteam1.load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hide_usercontrol();
            label1.Text = "Catagory";
            catagory1.Show();
            catagory1.load();
        }
    }
}
