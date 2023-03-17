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
            GRP_Pizza_Size = new GroupBox();
            RDO_Pizza_Size_Large = new RadioButton();
            RDO_Pizza_Size_Medium = new RadioButton();
            RDO_Pizza_Size_Small = new RadioButton();
            GRP_Toppings = new GroupBox();
            CHK_Olives_Topping = new CheckBox();
            CHK_Sausage_Topping = new CheckBox();
            CHK_Pineapple_Topping = new CheckBox();
            CHK_Mushrooms_Topping = new CheckBox();
            CHK_Pepperoni_Topping = new CheckBox();
            CHK_Beef_Topping = new CheckBox();
            GRP_Pizza_Type = new GroupBox();
            RDO_Neapolitan_Type = new RadioButton();
            RDO_NewYork_Type = new RadioButton();
            RDO_Deep_Dish_Type = new RadioButton();
            GRP_Sides = new GroupBox();
            CHK_Onion_Rings_Side = new CheckBox();
            CHK_Bread_Sticks_Side = new CheckBox();
            CHK_Potato_Wedges_Side = new CheckBox();
            CHK_GarlicBread_Side = new CheckBox();
            CHK_FrenchFries_Side = new CheckBox();
            CHK_Salad_Side = new CheckBox();
            LIS_Orders = new ListBox();
            TXT_Cost = new TextBox();
            BTN_Submit = new Button();
            LBL_Price = new Label();
            pictureBox1 = new PictureBox();
            GRP_Pizza_Size.SuspendLayout();
            GRP_Toppings.SuspendLayout();
            GRP_Pizza_Type.SuspendLayout();
            GRP_Sides.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GRP_Pizza_Size
            // 
            GRP_Pizza_Size.Controls.Add(RDO_Pizza_Size_Large);
            GRP_Pizza_Size.Controls.Add(RDO_Pizza_Size_Medium);
            GRP_Pizza_Size.Controls.Add(RDO_Pizza_Size_Small);
            GRP_Pizza_Size.Location = new Point(12, 143);
            GRP_Pizza_Size.Margin = new Padding(4, 4, 4, 4);
            GRP_Pizza_Size.Name = "GRP_Pizza_Size";
            GRP_Pizza_Size.Padding = new Padding(4, 4, 4, 4);
            GRP_Pizza_Size.Size = new Size(282, 46);
            GRP_Pizza_Size.TabIndex = 0;
            GRP_Pizza_Size.TabStop = false;
            GRP_Pizza_Size.Text = "Pizza Size";
            // 
            // RDO_Pizza_Size_Large
            // 
            RDO_Pizza_Size_Large.AutoSize = true;
            RDO_Pizza_Size_Large.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RDO_Pizza_Size_Large.Location = new Point(163, 21);
            RDO_Pizza_Size_Large.Margin = new Padding(4, 4, 4, 4);
            RDO_Pizza_Size_Large.Name = "RDO_Pizza_Size_Large";
            RDO_Pizza_Size_Large.Size = new Size(61, 18);
            RDO_Pizza_Size_Large.TabIndex = 2;
            RDO_Pizza_Size_Large.TabStop = true;
            RDO_Pizza_Size_Large.Text = "Large";
            RDO_Pizza_Size_Large.UseVisualStyleBackColor = true;
            RDO_Pizza_Size_Large.CheckedChanged += RDO_Pizza_Size_Large_CheckedChanged;
            // 
            // RDO_Pizza_Size_Medium
            // 
            RDO_Pizza_Size_Medium.AutoSize = true;
            RDO_Pizza_Size_Medium.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RDO_Pizza_Size_Medium.Location = new Point(74, 21);
            RDO_Pizza_Size_Medium.Margin = new Padding(4, 4, 4, 4);
            RDO_Pizza_Size_Medium.Name = "RDO_Pizza_Size_Medium";
            RDO_Pizza_Size_Medium.Size = new Size(73, 18);
            RDO_Pizza_Size_Medium.TabIndex = 1;
            RDO_Pizza_Size_Medium.TabStop = true;
            RDO_Pizza_Size_Medium.Text = "Medium";
            RDO_Pizza_Size_Medium.UseVisualStyleBackColor = true;
            // 
            // RDO_Pizza_Size_Small
            // 
            RDO_Pizza_Size_Small.AutoSize = true;
            RDO_Pizza_Size_Small.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RDO_Pizza_Size_Small.Location = new Point(10, 20);
            RDO_Pizza_Size_Small.Margin = new Padding(4, 4, 4, 4);
            RDO_Pizza_Size_Small.Name = "RDO_Pizza_Size_Small";
            RDO_Pizza_Size_Small.Size = new Size(58, 18);
            RDO_Pizza_Size_Small.TabIndex = 0;
            RDO_Pizza_Size_Small.TabStop = true;
            RDO_Pizza_Size_Small.Text = "Small";
            RDO_Pizza_Size_Small.UseVisualStyleBackColor = true;
            // 
            // GRP_Toppings
            // 
            GRP_Toppings.Controls.Add(CHK_Olives_Topping);
            GRP_Toppings.Controls.Add(CHK_Sausage_Topping);
            GRP_Toppings.Controls.Add(CHK_Pineapple_Topping);
            GRP_Toppings.Controls.Add(CHK_Mushrooms_Topping);
            GRP_Toppings.Controls.Add(CHK_Pepperoni_Topping);
            GRP_Toppings.Controls.Add(CHK_Beef_Topping);
            GRP_Toppings.Location = new Point(12, 301);
            GRP_Toppings.Margin = new Padding(4, 4, 4, 4);
            GRP_Toppings.Name = "GRP_Toppings";
            GRP_Toppings.Padding = new Padding(4, 4, 4, 4);
            GRP_Toppings.Size = new Size(282, 100);
            GRP_Toppings.TabIndex = 1;
            GRP_Toppings.TabStop = false;
            GRP_Toppings.Text = "Pizza Toppings";
            // 
            // CHK_Olives_Topping
            // 
            CHK_Olives_Topping.AutoSize = true;
            CHK_Olives_Topping.Location = new Point(122, 71);
            CHK_Olives_Topping.Margin = new Padding(4, 4, 4, 4);
            CHK_Olives_Topping.Name = "CHK_Olives_Topping";
            CHK_Olives_Topping.Size = new Size(60, 19);
            CHK_Olives_Topping.TabIndex = 5;
            CHK_Olives_Topping.Text = "Olives";
            CHK_Olives_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Sausage_Topping
            // 
            CHK_Sausage_Topping.AutoSize = true;
            CHK_Sausage_Topping.Location = new Point(122, 47);
            CHK_Sausage_Topping.Margin = new Padding(4, 4, 4, 4);
            CHK_Sausage_Topping.Name = "CHK_Sausage_Topping";
            CHK_Sausage_Topping.Size = new Size(76, 19);
            CHK_Sausage_Topping.TabIndex = 4;
            CHK_Sausage_Topping.Text = "Sausage";
            CHK_Sausage_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Pineapple_Topping
            // 
            CHK_Pineapple_Topping.AutoSize = true;
            CHK_Pineapple_Topping.Location = new Point(122, 23);
            CHK_Pineapple_Topping.Margin = new Padding(4, 4, 4, 4);
            CHK_Pineapple_Topping.Name = "CHK_Pineapple_Topping";
            CHK_Pineapple_Topping.Size = new Size(82, 19);
            CHK_Pineapple_Topping.TabIndex = 3;
            CHK_Pineapple_Topping.Text = "Pineapple";
            CHK_Pineapple_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Mushrooms_Topping
            // 
            CHK_Mushrooms_Topping.AutoSize = true;
            CHK_Mushrooms_Topping.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CHK_Mushrooms_Topping.Location = new Point(5, 71);
            CHK_Mushrooms_Topping.Margin = new Padding(4, 4, 4, 4);
            CHK_Mushrooms_Topping.Name = "CHK_Mushrooms_Topping";
            CHK_Mushrooms_Topping.Size = new Size(98, 18);
            CHK_Mushrooms_Topping.TabIndex = 2;
            CHK_Mushrooms_Topping.Text = "Mushrooms";
            CHK_Mushrooms_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Pepperoni_Topping
            // 
            CHK_Pepperoni_Topping.AutoSize = true;
            CHK_Pepperoni_Topping.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CHK_Pepperoni_Topping.Location = new Point(6, 47);
            CHK_Pepperoni_Topping.Margin = new Padding(4, 4, 4, 4);
            CHK_Pepperoni_Topping.Name = "CHK_Pepperoni_Topping";
            CHK_Pepperoni_Topping.Size = new Size(90, 18);
            CHK_Pepperoni_Topping.TabIndex = 1;
            CHK_Pepperoni_Topping.Text = "Pepperoni";
            CHK_Pepperoni_Topping.UseVisualStyleBackColor = true;
            // 
            // CHK_Beef_Topping
            // 
            CHK_Beef_Topping.AutoSize = true;
            CHK_Beef_Topping.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CHK_Beef_Topping.Location = new Point(6, 23);
            CHK_Beef_Topping.Margin = new Padding(4, 4, 4, 4);
            CHK_Beef_Topping.Name = "CHK_Beef_Topping";
            CHK_Beef_Topping.Size = new Size(54, 18);
            CHK_Beef_Topping.TabIndex = 0;
            CHK_Beef_Topping.Text = "Beef";
            CHK_Beef_Topping.UseVisualStyleBackColor = true;
            // 
            // GRP_Pizza_Type
            // 
            GRP_Pizza_Type.Controls.Add(RDO_Neapolitan_Type);
            GRP_Pizza_Type.Controls.Add(RDO_NewYork_Type);
            GRP_Pizza_Type.Controls.Add(RDO_Deep_Dish_Type);
            GRP_Pizza_Type.Location = new Point(12, 195);
            GRP_Pizza_Type.Margin = new Padding(4, 4, 4, 4);
            GRP_Pizza_Type.Name = "GRP_Pizza_Type";
            GRP_Pizza_Type.Padding = new Padding(4, 4, 4, 4);
            GRP_Pizza_Type.Size = new Size(282, 100);
            GRP_Pizza_Type.TabIndex = 2;
            GRP_Pizza_Type.TabStop = false;
            GRP_Pizza_Type.Text = "Pizza Type";
            // 
            // RDO_Neapolitan_Type
            // 
            RDO_Neapolitan_Type.AutoSize = true;
            RDO_Neapolitan_Type.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RDO_Neapolitan_Type.Location = new Point(5, 70);
            RDO_Neapolitan_Type.Margin = new Padding(4, 4, 4, 4);
            RDO_Neapolitan_Type.Name = "RDO_Neapolitan_Type";
            RDO_Neapolitan_Type.Size = new Size(128, 18);
            RDO_Neapolitan_Type.TabIndex = 2;
            RDO_Neapolitan_Type.TabStop = true;
            RDO_Neapolitan_Type.Text = "Neapolitan Style";
            RDO_Neapolitan_Type.UseVisualStyleBackColor = true;
            // 
            // RDO_NewYork_Type
            // 
            RDO_NewYork_Type.AutoSize = true;
            RDO_NewYork_Type.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RDO_NewYork_Type.Location = new Point(6, 45);
            RDO_NewYork_Type.Margin = new Padding(4, 4, 4, 4);
            RDO_NewYork_Type.Name = "RDO_NewYork_Type";
            RDO_NewYork_Type.Size = new Size(118, 18);
            RDO_NewYork_Type.TabIndex = 1;
            RDO_NewYork_Type.TabStop = true;
            RDO_NewYork_Type.Text = "New-York Style";
            RDO_NewYork_Type.UseVisualStyleBackColor = true;
            // 
            // RDO_Deep_Dish_Type
            // 
            RDO_Deep_Dish_Type.AutoSize = true;
            RDO_Deep_Dish_Type.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RDO_Deep_Dish_Type.Location = new Point(7, 20);
            RDO_Deep_Dish_Type.Margin = new Padding(4, 4, 4, 4);
            RDO_Deep_Dish_Type.Name = "RDO_Deep_Dish_Type";
            RDO_Deep_Dish_Type.Size = new Size(89, 18);
            RDO_Deep_Dish_Type.TabIndex = 0;
            RDO_Deep_Dish_Type.TabStop = true;
            RDO_Deep_Dish_Type.Text = "Deep Dish";
            RDO_Deep_Dish_Type.UseVisualStyleBackColor = true;
            // 
            // GRP_Sides
            // 
            GRP_Sides.Controls.Add(CHK_Onion_Rings_Side);
            GRP_Sides.Controls.Add(CHK_Bread_Sticks_Side);
            GRP_Sides.Controls.Add(CHK_Potato_Wedges_Side);
            GRP_Sides.Controls.Add(CHK_GarlicBread_Side);
            GRP_Sides.Controls.Add(CHK_FrenchFries_Side);
            GRP_Sides.Controls.Add(CHK_Salad_Side);
            GRP_Sides.Location = new Point(12, 411);
            GRP_Sides.Margin = new Padding(4, 4, 4, 4);
            GRP_Sides.Name = "GRP_Sides";
            GRP_Sides.Padding = new Padding(4, 4, 4, 4);
            GRP_Sides.Size = new Size(282, 100);
            GRP_Sides.TabIndex = 3;
            GRP_Sides.TabStop = false;
            GRP_Sides.Text = "Side Orders";
            // 
            // CHK_Onion_Rings_Side
            // 
            CHK_Onion_Rings_Side.AutoSize = true;
            CHK_Onion_Rings_Side.Location = new Point(122, 70);
            CHK_Onion_Rings_Side.Margin = new Padding(4, 4, 4, 4);
            CHK_Onion_Rings_Side.Name = "CHK_Onion_Rings_Side";
            CHK_Onion_Rings_Side.Size = new Size(95, 19);
            CHK_Onion_Rings_Side.TabIndex = 5;
            CHK_Onion_Rings_Side.Text = "Onion Rings";
            CHK_Onion_Rings_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_Bread_Sticks_Side
            // 
            CHK_Bread_Sticks_Side.AutoSize = true;
            CHK_Bread_Sticks_Side.Location = new Point(122, 46);
            CHK_Bread_Sticks_Side.Margin = new Padding(4, 4, 4, 4);
            CHK_Bread_Sticks_Side.Name = "CHK_Bread_Sticks_Side";
            CHK_Bread_Sticks_Side.Size = new Size(95, 19);
            CHK_Bread_Sticks_Side.TabIndex = 4;
            CHK_Bread_Sticks_Side.Text = "Bread Sticks";
            CHK_Bread_Sticks_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_Potato_Wedges_Side
            // 
            CHK_Potato_Wedges_Side.AutoSize = true;
            CHK_Potato_Wedges_Side.Location = new Point(122, 22);
            CHK_Potato_Wedges_Side.Margin = new Padding(4, 4, 4, 4);
            CHK_Potato_Wedges_Side.Name = "CHK_Potato_Wedges_Side";
            CHK_Potato_Wedges_Side.Size = new Size(110, 19);
            CHK_Potato_Wedges_Side.TabIndex = 3;
            CHK_Potato_Wedges_Side.Text = "Potato Wedges";
            CHK_Potato_Wedges_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_GarlicBread_Side
            // 
            CHK_GarlicBread_Side.AutoSize = true;
            CHK_GarlicBread_Side.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CHK_GarlicBread_Side.Location = new Point(4, 70);
            CHK_GarlicBread_Side.Margin = new Padding(4, 4, 4, 4);
            CHK_GarlicBread_Side.Name = "CHK_GarlicBread_Side";
            CHK_GarlicBread_Side.Size = new Size(101, 18);
            CHK_GarlicBread_Side.TabIndex = 2;
            CHK_GarlicBread_Side.Text = "Garlic Bread";
            CHK_GarlicBread_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_FrenchFries_Side
            // 
            CHK_FrenchFries_Side.AutoSize = true;
            CHK_FrenchFries_Side.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CHK_FrenchFries_Side.Location = new Point(4, 46);
            CHK_FrenchFries_Side.Margin = new Padding(4, 4, 4, 4);
            CHK_FrenchFries_Side.Name = "CHK_FrenchFries_Side";
            CHK_FrenchFries_Side.Size = new Size(102, 18);
            CHK_FrenchFries_Side.TabIndex = 1;
            CHK_FrenchFries_Side.Text = "French Fries";
            CHK_FrenchFries_Side.UseVisualStyleBackColor = true;
            // 
            // CHK_Salad_Side
            // 
            CHK_Salad_Side.AutoSize = true;
            CHK_Salad_Side.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CHK_Salad_Side.Location = new Point(4, 22);
            CHK_Salad_Side.Margin = new Padding(4, 4, 4, 4);
            CHK_Salad_Side.Name = "CHK_Salad_Side";
            CHK_Salad_Side.Size = new Size(61, 18);
            CHK_Salad_Side.TabIndex = 0;
            CHK_Salad_Side.Text = "Salad";
            CHK_Salad_Side.UseVisualStyleBackColor = true;
            // 
            // LIS_Orders
            // 
            LIS_Orders.FormattingEnabled = true;
            LIS_Orders.ItemHeight = 15;
            LIS_Orders.Location = new Point(340, 23);
            LIS_Orders.Margin = new Padding(4, 4, 4, 4);
            LIS_Orders.Name = "LIS_Orders";
            LIS_Orders.Size = new Size(333, 439);
            LIS_Orders.TabIndex = 4;
            // 
            // TXT_Cost
            // 
            TXT_Cost.Location = new Point(340, 495);
            TXT_Cost.Margin = new Padding(4, 4, 4, 4);
            TXT_Cost.Name = "TXT_Cost";
            TXT_Cost.Size = new Size(193, 21);
            TXT_Cost.TabIndex = 5;
            // 
            // BTN_Submit
            // 
            BTN_Submit.Location = new Point(538, 481);
            BTN_Submit.Margin = new Padding(4, 4, 4, 4);
            BTN_Submit.Name = "BTN_Submit";
            BTN_Submit.Size = new Size(134, 49);
            BTN_Submit.TabIndex = 6;
            BTN_Submit.Text = "Submit";
            BTN_Submit.UseVisualStyleBackColor = true;
            BTN_Submit.Click += BTN_Submit_Click;
            // 
            // LBL_Price
            // 
            LBL_Price.AutoSize = true;
            LBL_Price.Location = new Point(301, 499);
            LBL_Price.Margin = new Padding(4, 0, 4, 0);
            LBL_Price.Name = "LBL_Price";
            LBL_Price.Size = new Size(35, 15);
            LBL_Price.TabIndex = 7;
            LBL_Price.Text = "Price";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(686, 536);
            Controls.Add(pictureBox1);
            Controls.Add(LBL_Price);
            Controls.Add(BTN_Submit);
            Controls.Add(TXT_Cost);
            Controls.Add(LIS_Orders);
            Controls.Add(GRP_Sides);
            Controls.Add(GRP_Pizza_Type);
            Controls.Add(GRP_Toppings);
            Controls.Add(GRP_Pizza_Size);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            GRP_Pizza_Size.ResumeLayout(false);
            GRP_Pizza_Size.PerformLayout();
            GRP_Toppings.ResumeLayout(false);
            GRP_Toppings.PerformLayout();
            GRP_Pizza_Type.ResumeLayout(false);
            GRP_Pizza_Type.PerformLayout();
            GRP_Sides.ResumeLayout(false);
            GRP_Sides.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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