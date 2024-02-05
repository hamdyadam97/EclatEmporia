using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;
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

    public partial class TraceProduct : Form
    {

        OrderService orderService = new OrderService(new Repository<Order>(new StoreContext()));
        StoreContext dbContext = new StoreContext();
        public TraceProduct()
        {
            InitializeComponent();
            LoadOrderStatues();
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
            var productData1 = dbContext.Orders
                .Where(order => order.OrderStatus != "Delivered")
                .Include(order => order.User)
                .Include(order => order.OrderProducts)
                    .ThenInclude(productOrder => productOrder.Product)
                .Select(order => new
                {
                    OrderID = order.OrderID,
                    OrderDate = order.OrderDate,
                    TotalAmount = order.TotalAmount,
                    OrderStatus = order.OrderStatus,
                    ShippingAddress = order.ShippingAddress,
                    PaymentMethod = order.PaymentMethod,
                    UserID = order.User.UserID,
                    Username = order.User.Username,
                    Email = order.User.Email,
                    FirstName = order.User.FirstName,
                    LastName = order.User.LastName,
                    Address = order.User.Address,
                    PhoneNumber = order.User.PhoneNumber,
                    RegistrationDate = order.User.RegistrationDate,
                    Role = order.User.Role,
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
            dataGridView1.DataSource = productData1;
        }
        private void LoadOrderStatues()
        {
            List<OrderStatusItem> statusList = new List<OrderStatusItem>
{
    new OrderStatusItem { COrderStatusName = "waiting", OrderStatusValue = "waiting" },
    new OrderStatusItem { COrderStatusName = "Derived", OrderStatusValue = "derived" },
    new OrderStatusItem { COrderStatusName = "go", OrderStatusValue = "go" }
};

            comboBox1.DataSource = statusList;
            comboBox1.DisplayMember = "COrderStatusName";
            comboBox1.ValueMember = "OrderStatusValue";

            // Event handler for selected index change
            comboBox1.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBox1.SelectedItem != null)
                {
                    OrderStatusItem selectedStatus = (OrderStatusItem)comboBox1.SelectedItem;
                    Console.WriteLine("Selected Value: " + selectedStatus.OrderStatusValue);
                }
            };
            comboBox1.DataSource = statusList;
            comboBox1.DisplayMember = "COrderStatusName";
            comboBox1.ValueMember = "OrderStatusValue";
        }




        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one row.");
                return;
            }

            int selectedRow = dataGridView1.SelectedRows[0].Index;

            if (selectedRow >= 0 && selectedRow < dataGridView1.Rows.Count)
            {
                int productId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["OrderID"].Value);
                var product = orderService.GetOrderById(productId);


                textBox1.Text = Convert.ToString(product.UserID);

                textBox6.Text = Convert.ToString(product.UserID);
                string str = product.OrderStatus;

                // Find the index of the item with the specified value
                int index = comboBox1.FindStringExact(str);

                // Set the selected index
                comboBox1.SelectedIndex = index;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                // Validate Category
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid category.");
                    return;
                }



                // All validation passed, proceed to update the product
                var selectedRow = dataGridView1.SelectedRows[0].Index;
                int orderId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["OrderId"].Value);

                var product = orderService.GetOrderById(orderId);


                product.OrderStatus = Convert.ToString(comboBox1.SelectedValue);


                //numericUpDownStockQuantity.Value = Convert.ToInt32(product.StockQuantity);

                orderService.UpdateOrder(product);
                MessageBox.Show("Product updated successfully.");
                SetupDataGridView();




            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
