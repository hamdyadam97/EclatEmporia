using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class MyOrders : Form
    {
        OrderService orderService = new OrderService(new Repository<Order>(new StoreContext()));
        StoreContext dbContext = new StoreContext();
        public MyOrders()
        {
            InitializeComponent();

            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GetOrders();
        }
        private void GetOrders()
        {
            var products = orderService.GetAllOrders();


            MessageBox.Show(SessionData.Instance.user.Email);
            var orders = dbContext.Orders
                .Where(order => order.OrderStatus != "Delivered" && order.UserID == SessionData.Instance.user.UserID)
                .Select(order => new
                {
                    OrderID = order.OrderID,
                    OrderDate = order.OrderDate,
                    TotalAmount = order.TotalAmount,
                    OrderStatus = order.OrderStatus,
                    ShippingAddress = order.ShippingAddress,
                    PaymentMethod = order.PaymentMethod,
                    Products = order.OrderProducts.Select(productOrder => new
                    {
                        ProductID = productOrder.Product.ProductID,
                        ProductName = productOrder.Product.ProductName,
                        Description = productOrder.Product.Description,
                        Price = productOrder.Product.Price,
                        StockQuantity = productOrder.Product.StockQuantity,
                        DateAdded = productOrder.Product.DateAdded,
                        CategoryID = productOrder.Product.CategoryID,
                    }).ToList()
                })
                .ToList();

            dataGridView1.DataSource = orders;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
