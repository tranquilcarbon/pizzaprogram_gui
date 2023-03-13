namespace Pizza_Program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GRP_Pizza_Size = new System.Windows.Forms.GroupBox();
            this.RDO_Pizza_Size_Large = new System.Windows.Forms.RadioButton();
            this.RDO_Pizza_Size_Medium = new System.Windows.Forms.RadioButton();
            this.RDO_Pizza_Size_Small = new System.Windows.Forms.RadioButton();
            this.GRP_Toppings = new System.Windows.Forms.GroupBox();
            this.CHK_Olives_Topping = new System.Windows.Forms.CheckBox();
            this.CHK_Sausage_Topping = new System.Windows.Forms.CheckBox();
            this.CHK_Pineapple_Topping = new System.Windows.Forms.CheckBox();
            this.CHK_Mushrooms_Topping = new System.Windows.Forms.CheckBox();
            this.CHK_Pepperoni_Topping = new System.Windows.Forms.CheckBox();
            this.CHK_Beef_Topping = new System.Windows.Forms.CheckBox();
            this.GRP_Pizza_Type = new System.Windows.Forms.GroupBox();
            this.RDO_Neapolitan_Type = new System.Windows.Forms.RadioButton();
            this.RDO_NewYork_Type = new System.Windows.Forms.RadioButton();
            this.RDO_Deep_Dish_Type = new System.Windows.Forms.RadioButton();
            this.GRP_Sides = new System.Windows.Forms.GroupBox();
            this.CHK_Onion_Rings_Side = new System.Windows.Forms.CheckBox();
            this.CHK_Bread_Sticks_Side = new System.Windows.Forms.CheckBox();
            this.CHK_Potato_Wedges_Side = new System.Windows.Forms.CheckBox();
            this.CHK_GarlicBread_Side = new System.Windows.Forms.CheckBox();
            this.CHK_FrenchFries_Side = new System.Windows.Forms.CheckBox();
            this.CHK_Salad_Side = new System.Windows.Forms.CheckBox();
            this.LIS_Orders = new System.Windows.Forms.ListBox();
            this.TXT_Cost = new System.Windows.Forms.TextBox();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GRP_Pizza_Size.SuspendLayout();
            this.GRP_Toppings.SuspendLayout();
            this.GRP_Pizza_Type.SuspendLayout();
            this.GRP_Sides.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GRP_Pizza_Size
            // 
            this.GRP_Pizza_Size.Controls.Add(this.RDO_Pizza_Size_Large);
            this.GRP_Pizza_Size.Controls.Add(this.RDO_Pizza_Size_Medium);
            this.GRP_Pizza_Size.Controls.Add(this.RDO_Pizza_Size_Small);
            this.GRP_Pizza_Size.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GRP_Pizza_Size.Location = new System.Drawing.Point(12, 143);
            this.GRP_Pizza_Size.Name = "GRP_Pizza_Size";
            this.GRP_Pizza_Size.Size = new System.Drawing.Size(282, 46);
            this.GRP_Pizza_Size.TabIndex = 0;
            this.GRP_Pizza_Size.TabStop = false;
            this.GRP_Pizza_Size.Text = "Pizza Size";
            // 
            // RDO_Pizza_Size_Large
            // 
            this.RDO_Pizza_Size_Large.AutoSize = true;
            this.RDO_Pizza_Size_Large.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RDO_Pizza_Size_Large.Location = new System.Drawing.Point(163, 21);
            this.RDO_Pizza_Size_Large.Name = "RDO_Pizza_Size_Large";
            this.RDO_Pizza_Size_Large.Size = new System.Drawing.Size(61, 18);
            this.RDO_Pizza_Size_Large.TabIndex = 2;
            this.RDO_Pizza_Size_Large.TabStop = true;
            this.RDO_Pizza_Size_Large.Text = "Large";
            this.RDO_Pizza_Size_Large.UseVisualStyleBackColor = true;
            this.RDO_Pizza_Size_Large.CheckedChanged += new System.EventHandler(this.RDO_Pizza_Size_Large_CheckedChanged);
            // 
            // RDO_Pizza_Size_Medium
            // 
            this.RDO_Pizza_Size_Medium.AutoSize = true;
            this.RDO_Pizza_Size_Medium.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RDO_Pizza_Size_Medium.Location = new System.Drawing.Point(74, 21);
            this.RDO_Pizza_Size_Medium.Name = "RDO_Pizza_Size_Medium";
            this.RDO_Pizza_Size_Medium.Size = new System.Drawing.Size(73, 18);
            this.RDO_Pizza_Size_Medium.TabIndex = 1;
            this.RDO_Pizza_Size_Medium.TabStop = true;
            this.RDO_Pizza_Size_Medium.Text = "Medium";
            this.RDO_Pizza_Size_Medium.UseVisualStyleBackColor = true;
            // 
            // RDO_Pizza_Size_Small
            // 
            this.RDO_Pizza_Size_Small.AutoSize = true;
            this.RDO_Pizza_Size_Small.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RDO_Pizza_Size_Small.Location = new System.Drawing.Point(10, 20);
            this.RDO_Pizza_Size_Small.Name = "RDO_Pizza_Size_Small";
            this.RDO_Pizza_Size_Small.Size = new System.Drawing.Size(58, 18);
            this.RDO_Pizza_Size_Small.TabIndex = 0;
            this.RDO_Pizza_Size_Small.TabStop = true;
            this.RDO_Pizza_Size_Small.Text = "Small";
            this.RDO_Pizza_Size_Small.UseVisualStyleBackColor = true;
            // 
            // GRP_Toppings
            // 
            this.GRP_Toppings.Controls.Add(this.CHK_Olives_Topping);
            this.GRP_Toppings.Controls.Add(this.CHK_Sausage_Topping);
            this.GRP_Toppings.Controls.Add(this.CHK_Pineapple_Topping);
            this.GRP_Toppings.Controls.Add(this.CHK_Mushrooms_Topping);
            this.GRP_Toppings.Controls.Add(this.CHK_Pepperoni_Topping);
            this.GRP_Toppings.Controls.Add(this.CHK_Beef_Topping);
            this.GRP_Toppings.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GRP_Toppings.Location = new System.Drawing.Point(12, 301);
            this.GRP_Toppings.Name = "GRP_Toppings";
            this.GRP_Toppings.Size = new System.Drawing.Size(282, 100);
            this.GRP_Toppings.TabIndex = 1;
            this.GRP_Toppings.TabStop = false;
            this.GRP_Toppings.Text = "Pizza Toppings";
            // 
            // CHK_Olives_Topping
            // 
            this.CHK_Olives_Topping.AutoSize = true;
            this.CHK_Olives_Topping.Location = new System.Drawing.Point(123, 71);
            this.CHK_Olives_Topping.Name = "CHK_Olives_Topping";
            this.CHK_Olives_Topping.Size = new System.Drawing.Size(64, 18);
            this.CHK_Olives_Topping.TabIndex = 5;
            this.CHK_Olives_Topping.Text = "Olives";
            this.CHK_Olives_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Sausage_Topping
            // 
            this.CHK_Sausage_Topping.AutoSize = true;
            this.CHK_Sausage_Topping.Location = new System.Drawing.Point(123, 47);
            this.CHK_Sausage_Topping.Name = "CHK_Sausage_Topping";
            this.CHK_Sausage_Topping.Size = new System.Drawing.Size(81, 18);
            this.CHK_Sausage_Topping.TabIndex = 4;
            this.CHK_Sausage_Topping.Text = "Sausage";
            this.CHK_Sausage_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Pineapple_Topping
            // 
            this.CHK_Pineapple_Topping.AutoSize = true;
            this.CHK_Pineapple_Topping.Location = new System.Drawing.Point(123, 23);
            this.CHK_Pineapple_Topping.Name = "CHK_Pineapple_Topping";
            this.CHK_Pineapple_Topping.Size = new System.Drawing.Size(88, 18);
            this.CHK_Pineapple_Topping.TabIndex = 3;
            this.CHK_Pineapple_Topping.Text = "Pineapple";
            this.CHK_Pineapple_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Mushrooms_Topping
            // 
            this.CHK_Mushrooms_Topping.AutoSize = true;
            this.CHK_Mushrooms_Topping.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CHK_Mushrooms_Topping.Location = new System.Drawing.Point(5, 71);
            this.CHK_Mushrooms_Topping.Name = "CHK_Mushrooms_Topping";
            this.CHK_Mushrooms_Topping.Size = new System.Drawing.Size(98, 18);
            this.CHK_Mushrooms_Topping.TabIndex = 2;
            this.CHK_Mushrooms_Topping.Text = "Mushrooms";
            this.CHK_Mushrooms_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Pepperoni_Topping
            // 
            this.CHK_Pepperoni_Topping.AutoSize = true;
            this.CHK_Pepperoni_Topping.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CHK_Pepperoni_Topping.Location = new System.Drawing.Point(6, 47);
            this.CHK_Pepperoni_Topping.Name = "CHK_Pepperoni_Topping";
            this.CHK_Pepperoni_Topping.Size = new System.Drawing.Size(90, 18);
            this.CHK_Pepperoni_Topping.TabIndex = 1;
            this.CHK_Pepperoni_Topping.Text = "Pepperoni";
            this.CHK_Pepperoni_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Beef_Topping
            // 
            this.CHK_Beef_Topping.AutoSize = true;
            this.CHK_Beef_Topping.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CHK_Beef_Topping.Location = new System.Drawing.Point(6, 23);
            this.CHK_Beef_Topping.Name = "CHK_Beef_Topping";
            this.CHK_Beef_Topping.Size = new System.Drawing.Size(54, 18);
            this.CHK_Beef_Topping.TabIndex = 0;
            this.CHK_Beef_Topping.Text = "Beef";
            this.CHK_Beef_Topping.UseVisualStyleBackColor = true;
            // 
            // GRP_Pizza_Type
            // 
            this.GRP_Pizza_Type.Controls.Add(this.RDO_Neapolitan_Type);
            this.GRP_Pizza_Type.Controls.Add(this.RDO_NewYork_Type);
            this.GRP_Pizza_Type.Controls.Add(this.RDO_Deep_Dish_Type);
            this.GRP_Pizza_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GRP_Pizza_Type.Location = new System.Drawing.Point(12, 195);
            this.GRP_Pizza_Type.Name = "GRP_Pizza_Type";
            this.GRP_Pizza_Type.Size = new System.Drawing.Size(282, 100);
            this.GRP_Pizza_Type.TabIndex = 2;
            this.GRP_Pizza_Type.TabStop = false;
            this.GRP_Pizza_Type.Text = "Pizza Type";
            // 
            // RDO_Neapolitan_Type
            // 
            this.RDO_Neapolitan_Type.AutoSize = true;
            this.RDO_Neapolitan_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RDO_Neapolitan_Type.Location = new System.Drawing.Point(5, 70);
            this.RDO_Neapolitan_Type.Name = "RDO_Neapolitan_Type";
            this.RDO_Neapolitan_Type.Size = new System.Drawing.Size(128, 18);
            this.RDO_Neapolitan_Type.TabIndex = 2;
            this.RDO_Neapolitan_Type.TabStop = true;
            this.RDO_Neapolitan_Type.Text = "Neapolitan Style";
            this.RDO_Neapolitan_Type.UseVisualStyleBackColor = true;
            // 
            // RDO_NewYork_Type
            // 
            this.RDO_NewYork_Type.AutoSize = true;
            this.RDO_NewYork_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RDO_NewYork_Type.Location = new System.Drawing.Point(6, 45);
            this.RDO_NewYork_Type.Name = "RDO_NewYork_Type";
            this.RDO_NewYork_Type.Size = new System.Drawing.Size(118, 18);
            this.RDO_NewYork_Type.TabIndex = 1;
            this.RDO_NewYork_Type.TabStop = true;
            this.RDO_NewYork_Type.Text = "New-York Style";
            this.RDO_NewYork_Type.UseVisualStyleBackColor = true;
            // 
            // RDO_Deep_Dish_Type
            // 
            this.RDO_Deep_Dish_Type.AutoSize = true;
            this.RDO_Deep_Dish_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RDO_Deep_Dish_Type.Location = new System.Drawing.Point(7, 20);
            this.RDO_Deep_Dish_Type.Name = "RDO_Deep_Dish_Type";
            this.RDO_Deep_Dish_Type.Size = new System.Drawing.Size(89, 18);
            this.RDO_Deep_Dish_Type.TabIndex = 0;
            this.RDO_Deep_Dish_Type.TabStop = true;
            this.RDO_Deep_Dish_Type.Text = "Deep Dish";
            this.RDO_Deep_Dish_Type.UseVisualStyleBackColor = true;
            // 
            // GRP_Sides
            // 
            this.GRP_Sides.Controls.Add(this.CHK_Onion_Rings_Side);
            this.GRP_Sides.Controls.Add(this.CHK_Bread_Sticks_Side);
            this.GRP_Sides.Controls.Add(this.CHK_Potato_Wedges_Side);
            this.GRP_Sides.Controls.Add(this.CHK_GarlicBread_Side);
            this.GRP_Sides.Controls.Add(this.CHK_FrenchFries_Side);
            this.GRP_Sides.Controls.Add(this.CHK_Salad_Side);
            this.GRP_Sides.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GRP_Sides.Location = new System.Drawing.Point(12, 411);
            this.GRP_Sides.Name = "GRP_Sides";
            this.GRP_Sides.Size = new System.Drawing.Size(282, 100);
            this.GRP_Sides.TabIndex = 3;
            this.GRP_Sides.TabStop = false;
            this.GRP_Sides.Text = "Side Orders";
            // 
            // CHK_Onion_Rings_Side
            // 
            this.CHK_Onion_Rings_Side.AutoSize = true;
            this.CHK_Onion_Rings_Side.Location = new System.Drawing.Point(123, 70);
            this.CHK_Onion_Rings_Side.Name = "CHK_Onion_Rings_Side";
            this.CHK_Onion_Rings_Side.Size = new System.Drawing.Size(101, 18);
            this.CHK_Onion_Rings_Side.TabIndex = 5;
            this.CHK_Onion_Rings_Side.Text = "Onion Rings";
            this.CHK_Onion_Rings_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_Bread_Sticks_Side
            // 
            this.CHK_Bread_Sticks_Side.AutoSize = true;
            this.CHK_Bread_Sticks_Side.Location = new System.Drawing.Point(123, 46);
            this.CHK_Bread_Sticks_Side.Name = "CHK_Bread_Sticks_Side";
            this.CHK_Bread_Sticks_Side.Size = new System.Drawing.Size(103, 18);
            this.CHK_Bread_Sticks_Side.TabIndex = 4;
            this.CHK_Bread_Sticks_Side.Text = "Bread Sticks";
            this.CHK_Bread_Sticks_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_Potato_Wedges_Side
            // 
            this.CHK_Potato_Wedges_Side.AutoSize = true;
            this.CHK_Potato_Wedges_Side.Location = new System.Drawing.Point(123, 22);
            this.CHK_Potato_Wedges_Side.Name = "CHK_Potato_Wedges_Side";
            this.CHK_Potato_Wedges_Side.Size = new System.Drawing.Size(123, 18);
            this.CHK_Potato_Wedges_Side.TabIndex = 3;
            this.CHK_Potato_Wedges_Side.Text = "Potato Wedges";
            this.CHK_Potato_Wedges_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_GarlicBread_Side
            // 
            this.CHK_GarlicBread_Side.AutoSize = true;
            this.CHK_GarlicBread_Side.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CHK_GarlicBread_Side.Location = new System.Drawing.Point(4, 70);
            this.CHK_GarlicBread_Side.Name = "CHK_GarlicBread_Side";
            this.CHK_GarlicBread_Side.Size = new System.Drawing.Size(101, 18);
            this.CHK_GarlicBread_Side.TabIndex = 2;
            this.CHK_GarlicBread_Side.Text = "Garlic Bread";
            this.CHK_GarlicBread_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_FrenchFries_Side
            // 
            this.CHK_FrenchFries_Side.AutoSize = true;
            this.CHK_FrenchFries_Side.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CHK_FrenchFries_Side.Location = new System.Drawing.Point(4, 46);
            this.CHK_FrenchFries_Side.Name = "CHK_FrenchFries_Side";
            this.CHK_FrenchFries_Side.Size = new System.Drawing.Size(102, 18);
            this.CHK_FrenchFries_Side.TabIndex = 1;
            this.CHK_FrenchFries_Side.Text = "French Fries";
            this.CHK_FrenchFries_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_Salad_Side
            // 
            this.CHK_Salad_Side.AutoSize = true;
            this.CHK_Salad_Side.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CHK_Salad_Side.Location = new System.Drawing.Point(4, 22);
            this.CHK_Salad_Side.Name = "CHK_Salad_Side";
            this.CHK_Salad_Side.Size = new System.Drawing.Size(61, 18);
            this.CHK_Salad_Side.TabIndex = 0;
            this.CHK_Salad_Side.Text = "Salad";
            this.CHK_Salad_Side.UseVisualStyleBackColor = true;
            // 
            // LIS_Orders
            // 
            this.LIS_Orders.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LIS_Orders.FormattingEnabled = true;
            this.LIS_Orders.ItemHeight = 14;
            this.LIS_Orders.Location = new System.Drawing.Point(339, 23);
            this.LIS_Orders.Name = "LIS_Orders";
            this.LIS_Orders.Size = new System.Drawing.Size(333, 452);
            this.LIS_Orders.TabIndex = 4;
            // 
            // TXT_Cost
            // 
            this.TXT_Cost.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Cost.Location = new System.Drawing.Point(339, 495);
            this.TXT_Cost.Name = "TXT_Cost";
            this.TXT_Cost.Size = new System.Drawing.Size(193, 22);
            this.TXT_Cost.TabIndex = 5;
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Submit.Location = new System.Drawing.Point(538, 481);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(134, 49);
            this.BTN_Submit.TabIndex = 6;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Price.Location = new System.Drawing.Point(301, 498);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(37, 14);
            this.LBL_Price.TabIndex = 7;
            this.LBL_Price.Text = "Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_Program.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(696, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL_Price);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.TXT_Cost);
            this.Controls.Add(this.LIS_Orders);
            this.Controls.Add(this.GRP_Sides);
            this.Controls.Add(this.GRP_Pizza_Type);
            this.Controls.Add(this.GRP_Toppings);
            this.Controls.Add(this.GRP_Pizza_Size);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GRP_Pizza_Size.ResumeLayout(false);
            this.GRP_Pizza_Size.PerformLayout();
            this.GRP_Toppings.ResumeLayout(false);
            this.GRP_Toppings.PerformLayout();
            this.GRP_Pizza_Type.ResumeLayout(false);
            this.GRP_Pizza_Type.PerformLayout();
            this.GRP_Sides.ResumeLayout(false);
            this.GRP_Sides.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox GRP_Pizza_Size;
        private GroupBox GRP_Toppings;
        private GroupBox GRP_Pizza_Type;
        private GroupBox GRP_Sides;
        private ListBox LIS_Orders;
        private TextBox TXT_Cost;
        private Button BTN_Submit;
        private RadioButton RDO_Pizza_Size_Small;
        private RadioButton RDO_Pizza_Size_Medium;
        private RadioButton RDO_Pizza_Size_Large;
        private RadioButton RDO_Neapolitan_Type;
        private RadioButton RDO_NewYork_Type;
        private RadioButton RDO_Deep_Dish_Type;
        private CheckBox CHK_Beef_Topping;
        private CheckBox CHK_Pepperoni_Topping;
        private CheckBox CHK_Mushrooms_Topping;
        private CheckBox CHK_Salad_Side;
        private CheckBox CHK_FrenchFries_Side;
        private CheckBox CHK_GarlicBread_Side;
        private Label LBL_Price;
        private CheckBox CHK_Pineapple_Topping;
        private CheckBox CHK_Sausage_Topping;
        private CheckBox CHK_Olives_Topping;
        private CheckBox CHK_Potato_Wedges_Side;
        private CheckBox CHK_Bread_Sticks_Side;
        private CheckBox CHK_Onion_Rings_Side;
        private PictureBox pictureBox1;
    }
}