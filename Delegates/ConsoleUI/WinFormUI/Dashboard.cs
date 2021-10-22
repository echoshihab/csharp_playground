using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        private ShoppingCartModel _cart = new ShoppingCartModel();
        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void PopulateCartWithDemoData()
        {
            _cart.Items.Add(new ProductModel{ItemName = "Cereal", Price = 3.63M});
            _cart.Items.Add(new ProductModel{ItemName = "Milk", Price = 2.95M});
            _cart.Items.Add(new ProductModel{ItemName = "Strawberries", Price = 7.51M});
            _cart.Items.Add(new ProductModel{ItemName = "Blueberries", Price = 8.84M});
        }
        private void msgBoxBtn_Click(object sender, EventArgs e)
        {
            decimal total = _cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, PrintOutDiscountAlert);

            MessageBox.Show($"The total is {total:C2}");
        }

        private void textBoxBtn_Click(object sender, EventArgs e)
        {
            decimal total = _cart.GenerateTotal((subTotal) => subTotalTxt.Text = $"{subTotal:C2}",
                (products, subTotal) => subTotal - (products.Count * 2), 
                (message) => { });

            totalTxt.Text = $"{total:C2}";
        }


        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message);
        }

        private void SubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"The subtotal is {subTotal:C2}");
        }

        private decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subTotal)
        {
            return subTotal - products.Count();

        }
    }
}
