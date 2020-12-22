namespace fast_food_management_system
{
    partial class AddIteam
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submmitBtn = new System.Windows.Forms.Button();
            this.catagory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FoodName = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submmitBtn
            // 
            this.submmitBtn.Location = new System.Drawing.Point(286, 261);
            this.submmitBtn.Name = "submmitBtn";
            this.submmitBtn.Size = new System.Drawing.Size(75, 23);
            this.submmitBtn.TabIndex = 1;
            this.submmitBtn.Text = "ADD";
            this.submmitBtn.UseVisualStyleBackColor = true;
            this.submmitBtn.Click += new System.EventHandler(this.submmitBtn_Click);
            // 
            // catagory
            // 
            this.catagory.FormattingEnabled = true;
            this.catagory.Items.AddRange(new object[] {
            "Drink",
            "Lunch",
            "Dinner ",
            "Snack"});
            this.catagory.Location = new System.Drawing.Point(330, 159);
            this.catagory.Name = "catagory";
            this.catagory.Size = new System.Drawing.Size(121, 21);
            this.catagory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(238, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catagory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(238, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(238, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // FoodName
            // 
            this.FoodName.Location = new System.Drawing.Point(330, 104);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(121, 20);
            this.FoodName.TabIndex = 6;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(330, 211);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(121, 20);
            this.price.TabIndex = 7;
            // 
            // AddIteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.price);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catagory);
            this.Controls.Add(this.submmitBtn);
            this.Name = "AddIteam";
            this.Size = new System.Drawing.Size(690, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submmitBtn;
        private System.Windows.Forms.ComboBox catagory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FoodName;
        private System.Windows.Forms.TextBox price;
    }
}
