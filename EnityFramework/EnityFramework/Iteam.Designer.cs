namespace EnityFramework
{
    partial class Iteam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iteam));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_catagory = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dataGridView_Iteam = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagory_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nud_price10 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pricelabel10 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.sizelabel10 = new System.Windows.Forms.Label();
            this.cb_size10 = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove10 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Iteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // cb_catagory
            // 
            this.cb_catagory.FormattingEnabled = true;
            this.cb_catagory.Items.AddRange(new object[] {
            "Drink",
            "Snack",
            "Lunch",
            "Dinner "});
            this.cb_catagory.Location = new System.Drawing.Point(419, 18);
            this.cb_catagory.Name = "cb_catagory";
            this.cb_catagory.Size = new System.Drawing.Size(148, 21);
            this.cb_catagory.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(110, 19);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(148, 20);
            this.tb_name.TabIndex = 2;
            // 
            // dataGridView_Iteam
            // 
            this.dataGridView_Iteam.AllowUserToAddRows = false;
            this.dataGridView_Iteam.AllowUserToDeleteRows = false;
            this.dataGridView_Iteam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Iteam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.catagory_id,
            this.catagory_name,
            this.size_id,
            this.size,
            this.price});
            this.dataGridView_Iteam.Location = new System.Drawing.Point(0, 172);
            this.dataGridView_Iteam.Name = "dataGridView_Iteam";
            this.dataGridView_Iteam.ReadOnly = true;
            this.dataGridView_Iteam.Size = new System.Drawing.Size(651, 213);
            this.dataGridView_Iteam.TabIndex = 3;
            this.dataGridView_Iteam.DoubleClick += new System.EventHandler(this.dataGridView_Iteam_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 158;
            // 
            // catagory_id
            // 
            this.catagory_id.DataPropertyName = "catagory_id";
            this.catagory_id.HeaderText = "Catagory Id";
            this.catagory_id.Name = "catagory_id";
            this.catagory_id.ReadOnly = true;
            this.catagory_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.catagory_id.Visible = false;
            this.catagory_id.Width = 200;
            // 
            // catagory_name
            // 
            this.catagory_name.DataPropertyName = "catagory_name";
            this.catagory_name.HeaderText = "Catagory";
            this.catagory_name.Name = "catagory_name";
            this.catagory_name.ReadOnly = true;
            this.catagory_name.Width = 200;
            // 
            // size_id
            // 
            this.size_id.HeaderText = "size_id";
            this.size_id.Name = "size_id";
            this.size_id.ReadOnly = true;
            this.size_id.Visible = false;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 120;
            // 
            // nud_price10
            // 
            this.nud_price10.Location = new System.Drawing.Point(360, 80);
            this.nud_price10.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_price10.Name = "nud_price10";
            this.nud_price10.Size = new System.Drawing.Size(148, 20);
            this.nud_price10.TabIndex = 4;
            this.nud_price10.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(348, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Catagory";
            // 
            // pricelabel10
            // 
            this.pricelabel10.AutoSize = true;
            this.pricelabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pricelabel10.Location = new System.Drawing.Point(289, 80);
            this.pricelabel10.Name = "pricelabel10";
            this.pricelabel10.Size = new System.Drawing.Size(40, 17);
            this.pricelabel10.TabIndex = 6;
            this.pricelabel10.Text = "Price";
            this.pricelabel10.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(101, 124);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 30);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(210, 124);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 30);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete All";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(319, 124);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(103, 30);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // sizelabel10
            // 
            this.sizelabel10.AutoSize = true;
            this.sizelabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizelabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.sizelabel10.Location = new System.Drawing.Point(40, 80);
            this.sizelabel10.Name = "sizelabel10";
            this.sizelabel10.Size = new System.Drawing.Size(35, 17);
            this.sizelabel10.TabIndex = 11;
            this.sizelabel10.Text = "Size";
            this.sizelabel10.Visible = false;
            // 
            // cb_size10
            // 
            this.cb_size10.FormattingEnabled = true;
            this.cb_size10.Items.AddRange(new object[] {
            "small",
            "midium",
            "large"});
            this.cb_size10.Location = new System.Drawing.Point(110, 80);
            this.cb_size10.Name = "cb_size10";
            this.cb_size10.Size = new System.Drawing.Size(148, 21);
            this.cb_size10.TabIndex = 10;
            this.cb_size10.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(262, 43);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 30);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove10
            // 
            this.btn_remove10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_remove10.FlatAppearance.BorderSize = 0;
            this.btn_remove10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove10.ForeColor = System.Drawing.Color.White;
            this.btn_remove10.Location = new System.Drawing.Point(533, 80);
            this.btn_remove10.Name = "btn_remove10";
            this.btn_remove10.Size = new System.Drawing.Size(96, 21);
            this.btn_remove10.TabIndex = 13;
            this.btn_remove10.Text = "Remove";
            this.btn_remove10.UseVisualStyleBackColor = false;
            this.btn_remove10.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(428, 124);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(103, 30);
            this.btn_print.TabIndex = 14;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Iteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_remove10);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.sizelabel10);
            this.Controls.Add(this.cb_size10);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pricelabel10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_price10);
            this.Controls.Add(this.dataGridView_Iteam);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.cb_catagory);
            this.Controls.Add(this.label1);
            this.Name = "Iteam";
            this.Size = new System.Drawing.Size(651, 385);
            this.Load += new System.EventHandler(this.Iteam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Iteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_catagory;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DataGridView dataGridView_Iteam;
        private System.Windows.Forms.NumericUpDown nud_price10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pricelabel10;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label sizelabel10;
        private System.Windows.Forms.ComboBox cb_size10;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagory_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagory_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_print;
    }
}
