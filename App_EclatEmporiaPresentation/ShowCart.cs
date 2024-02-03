using App.Application.Services;
using App.Context;
using App.Context.Migrations;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;
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
        OrderService orderService = new OrderService(new Repository<Order>(new StoreContext()));
        StoreContext context = new StoreContext();
        public ShowCart()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void ShowCart_Load(object sender, EventArgs e)
        {
            var cart = CartProductServices.GetCartUserId(SessionData.Instance.user.UserID); ;

            var productsInCart = CartProductServices.GetProductsInCart(cart);

            dataGridView1.DataSource = productsInCart;

        }



        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                var cart = CartProductServices.GetCartUserId(SessionData.Instance.user.UserID);
                var ProductID = Convert.ToInt32(selectedRow.Cells[0].Value);
                CartProductServices.RemoveCartProduct(cart, ProductID);
              
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }

        }
        //private void button2_Click(object sender, EventArgs e)
        //{

        //    List<Product> productList = (List<Product>)dataGridView1.DataSource;

        //    var productIds = productList.Select(product => product.ProductID).ToArray();
        //    List<Product> productListPrice = (List<Product>)dataGridView1.DataSource;

        //    decimal totalPrice = 0;

        //    foreach (Product product in productListPrice)
        //    {
        //        // Ensure both Price and StockQuantity are not null
        //        if (product.Price.HasValue && product.StockQuantity.HasValue)
        //        {
        //            decimal productTotalPrice = product.Price.Value * product.StockQuantity.Value;
        //            totalPrice += productTotalPrice;
        //        }
        //    }

        //    // Now totalPrice contains the total price after multiplying each product's price by its stock quantity

        //    // Instantiate a new Order object
        //    Order newOrder = new Order
        //    {
        //        OrderDate = DateTime.Now,
        //        TotalAmount = totalPrice /* Calculate total amount */,
        //        OrderStatus = "New", // Set appropriate status
        //        ShippingAddress = "Assuiot" /* Get shipping address */,
        //        PaymentMethod = "Cash"/* Get payment method */,
        //        UserID = SessionData.Instance.user.UserID // Set the UserID
        //    };
        //    foreach (int productId in productIds)
        //    {
        //        newOrder.OrderProducts.Add(new ProductOrder
        //        {
        //            ProductID = productId
        //        });
        //    }
        //    orderService.AddOrder(newOrder);

        //    var cart = CartProductServices.GetCartUserId(SessionData.Instance.user.UserID);
        //    foreach (int productId in productIds)
        //    {
        //        CartProductServices.UpdateCartProduct(productId, cart);
        //    }



        //    MyOrders myOrders = new MyOrders();
        //    myOrders.Show();
        //}

       

        private void Confirm_Click(object sender, EventArgs e)
        {


            List<Product> productList = (List<Product>)dataGridView1.DataSource;

            var productIds = productList.Select(product => product.ProductID).ToArray();
            List<Product> productListPrice = (List<Product>)dataGridView1.DataSource;

            decimal totalPrice = 0;

            foreach (Product product in productListPrice)
            {
                // Ensure both Price and StockQuantity are not null
                if (product.Price.HasValue && product.StockQuantity.HasValue)
                {
                    decimal productTotalPrice = product.Price.Value * product.StockQuantity.Value;
                    totalPrice += productTotalPrice;
                }
            }

            // Now totalPrice contains the total price after multiplying each product's price by its stock quantity

            // Instantiate a new Order object
            Order newOrder = new Order
            {
                OrderDate = DateTime.Now,
                TotalAmount = totalPrice /* Calculate total amount */,
                OrderStatus = "New", // Set appropriate status
                ShippingAddress = "Assuiot" /* Get shipping address */,
                PaymentMethod = "Cash"/* Get payment method */,
                UserID = SessionData.Instance.user.UserID // Set the UserID
            };
            foreach (int productId in productIds)
            {
                newOrder.OrderProducts.Add(new ProductOrder
                {
                    ProductID = productId
                });
            }
            orderService.AddOrder(newOrder);

            var cart = CartProductServices.GetCartUserId(SessionData.Instance.user.UserID);
            foreach (int productId in productIds)
            {
                CartProductServices.UpdateCartProduct(productId, cart);
            }



            var productsInCart = CartProductServices.GetProductsInCart(cart);

            dataGridView1.DataSource = productsInCart;
            MyOrders myOrders = new MyOrders();
            myOrders.Show();
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                var cart = CartProductServices.GetCartUserId(SessionData.Instance.user.UserID);
                var ProductID = Convert.ToInt32(selectedRow.Cells[0].Value);
                
                MessageBox.Show(Convert.ToString(cart));
                MessageBox.Show(Convert.ToString(ProductID));
                var product = context.CartProducts.FirstOrDefault(c => c.CartID == cart && c.ProductID == ProductID);
                if (product.Quantity > 1) {
                    product.Quantity = product.Quantity - 1;
                    context.SaveChanges();

                }
                else
                {
                     CartProductServices.RemoveCartProduct(cart, ProductID);
                }
               
                
               
                ShowCart_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }
        }
    }
}
