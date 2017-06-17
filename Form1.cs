using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingLibrary;

namespace ShopUI
{
    public partial class Form1 : Form
    {
        private Store store=new Store();
        BindingSource ItemsBinding=new BindingSource();
        private List<Item> ItemsChartData=new List<Item>();
        BindingSource ChartBinding=new BindingSource();
        BindingSource VendorBinding =new BindingSource();
        private decimal StoreProfit = 0;

        public Form1()
        {
            InitializeComponent();
            Setup();
            ItemsBinding.DataSource = store.Items;
            ItemsListBox.DataSource = ItemsBinding;
            ItemsListBox.DisplayMember = "Disply";
            ItemsListBox.ValueMember = "Disply";

            ChartBinding.DataSource = ItemsChartData;
            ItemsCartBox.DataSource = ChartBinding;
            ItemsCartBox.DisplayMember = "Disply";
            ItemsCartBox.ValueMember = "Disply";

            VendorBinding.DataSource = store.Vendors;
            VendorBox.DataSource = VendorBinding;
            VendorBox.DisplayMember = "Disply";
            VendorBox.ValueMember = "Disply";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Setup()
        {
            store.Vendors.Add(new Vendor {FirstName = "Amit", LastName = "Cohen"});
            store.Vendors.Add(new Vendor { FirstName = "Avi",LastName = "Cohen" });

            store.Items.Add(new Item{Title = "Apple MacBook Pro",
                                     Description = "the ultimate laptop",
                                     Owner=store.Vendors[0],
                                     Price =(decimal)4.50,
                                     Amount=3}
                                     );

            store.Items.Add(new Item
            {
                Title = "Lenovo y50-70",
                Description = "the best laptop",
                Owner = store.Vendors[1],
                Price = (decimal) 3.80,
                Amount = 2
            });
        }

        private void AddToCartButtun_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ItemsListBox.SelectedItem;
            ItemsChartData.Add(selectedItem);
            --selectedItem.Amount;
            if (selectedItem.Amount == 0)
            {
                ChartBinding.ResetBindings(false);
                ItemsBinding.Remove(selectedItem);
            
            }
            ChartBinding.ResetBindings(false);
            MessageBox.Show(selectedItem.Title + " has added to cart!");

            if (ItemsBinding.Count == 0)
                MessageBox.Show("Store is out of stock!");

        }

        private void PurchaseButtun_Click(object sender, EventArgs e)
        {
            foreach (Item item in ItemsChartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue+= (decimal)item.Owner.Commission * item.Price;
                StoreProfit +=(1- (decimal) item.Owner.Commission) * item.Price;
            }
            ItemsChartData.Clear();
            ChartBinding.ResetBindings(false);
            MessageBox.Show("Items Purchased!");
            VendorBinding.ResetBindings(false);
            profitLabal.Text = string.Format("${0}", StoreProfit);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ShoppingCartLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }
    }
}
