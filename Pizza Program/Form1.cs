namespace Pizza_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            //pizza size
            if (RDO_Pizza_Size_Small.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Small Sized Pizza");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("5.99");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            else if (RDO_Pizza_Size_Medium.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Medium Sized Pizza");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("10.99");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            else if (RDO_Pizza_Size_Large.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Large Sized Pizza");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("15.99");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            //pizza types
            if (RDO_Deep_Dish_Type.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Deep Dish");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("2.75");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            else if (RDO_Neapolitan_Type.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Neapolitan Type");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("5.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            else if (RDO_NewYork_Type.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("New York type");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("8.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            //toppings - will be expanded
            if (CHK_Beef_Topping.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Beef topping selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_Pepperoni_Topping.Checked == true)  //we don't use else if here because it results in the first one displaying only.
            {
                //new item
                ListViewItem item = new ListViewItem("Pepperoni topping selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_Mushrooms_Topping.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Mushrooms topping selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_Pineapple_Topping.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Pineapple topping selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_Sausage_Topping.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Sausage topping selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_Olives_Topping.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Olives topping selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            //sides
            if (CHK_Salad_Side.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Salad side selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_FrenchFries_Side.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("French Fries side selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_GarlicBread_Side.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Garlic Bread side selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_Potato_Wedges_Side.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Potato Wedges side selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_Bread_Sticks_Side.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Bread Sticks side selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            if (CHK_Onion_Rings_Side.Checked == true)
            {
                //new item
                ListViewItem item = new ListViewItem("Onion Rings side selected");
                //number of items
                item.SubItems.Add("1");
                //cost of item
                item.SubItems.Add("3.00");
                //now to add to listview...
                LIS_Orders.Items.Add(item);
            }
            //now to update the amount...
            double total = 0;
            foreach (ListViewItem item in LIS_Orders.Items)
            {
                //          0               1               2           3               4
                //("Small Size Pizza, New York type, beef topping, french fries side, 16.99")
                total += Convert.ToDouble(item.SubItems[4].Text);
                string amount = total.ToString("C2");
                TXT_Cost.Text = amount;
            }

        }
    }
}