using App.Application.Services;
using App.Context;
using App.Context.Migrations;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_EclatEmporiaPresentation
{
    public partial class ShowCart : Form
    {
        ShowProductService showProductService = new ShowProductService(new ShowProductRepositry(new StoreContext()));
        CartProductServices CartProductServices = new CartProductServices(new CartRepositry(new StoreContext()));

        public ShowCart()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowCart_Load(object sender, EventArgs e)
        {
            int cartId = 6;
            var productsInCart = CartProductServices.GetProductsInCart(cartId)
                .Select(p => new
                {
                   productid= p.ProductID,
                    productName = p.ProductName,
                    description = p.Description,
                    price = p.Price,
                    stockQuantity = p.StockQuantity
                });

            dataGridView1.DataSource = productsInCart.ToList();
        }



        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var ProductID = Convert.ToInt32(selectedRow.Cells[0].Value);
                CartProductServices.RemoveCartProduct(ProductID);
                MessageBox.Show("Delete button clicked");
                ShowCart_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {



            MyOrders myOrders   = new MyOrders();
            myOrders.Show();
        }
    }
}
