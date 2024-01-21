using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace App_EclatEmporiaPresentation
{
    public partial class ShowProducts : Form
    {
        //ShowProductService showProductService = new ShowProductService(new ShowProductRepositry(new StoreContext()));
        ProductService productService = new ProductService(new ProductRepository(new StoreContext()));
        CategoryService categoryService = new CategoryService(new CategoryRepository(new StoreContext()));
        public ShowProducts()
        {
            InitializeComponent();


            //var result = showProductService.GetCategories();
            var result = categoryService.GetAllCategories();

            foreach (var category in result)
            {
                comboBox1.Items.Add(category.CategoryName);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox2.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            var Products = productService.GetAllProducts();
            foreach (var Product in Products)
            {
                listView1.Items.Add(Product.ProductID.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.ProductName);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.Description);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.Price.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.StockQuantity.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.DateAdded.ToString());
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var productList = await productService.GetProductByName(textBox1.Text).ToListAsync();

            listView1.Items.Clear();

            foreach (var Product in productList)
            {
                listView1.Items.Add(Product.ProductID.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.ProductName);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.Description);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.Price.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.StockQuantity.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.DateAdded.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedProduct = listView1.SelectedItems[0];
                if (selectedProduct is null) return;
                var productStringId = selectedProduct.Text;
                var productId = Convert.ToInt32(productStringId);

                //productService.AddOrder(new Order()
                //{
                //    TotalAmount = 1,
                //    OrderDate = DateTime.Now,
                //    UserID = 1,
                //    OrderStatus = "Waiting",
                //    ShippingAddress = "Hurgada",
                //    PaymentMethod = "cash",
                //    OrderProducts = new List<ProductOrder>()
                //    {
                //        new ProductOrder()
                //        {
                //            OrderID = 1,
                //            ProductID = productId
                //        }
                //    }
                //});


                MessageBox.Show("The Product Added Successfully");
            }
            else
            {
                MessageBox.Show("Please select the product");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            //if (comboBox1.SelectedItem == null) return;
            //var productcat = productService.GetProductsByCat(comboBox1.SelectedItem.ToString());
            //foreach( var item in productcat)
            //{
            //    listView1.Items.Add(item.ProductID.ToString());
            //    listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.ProductName);
            //    listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.Description);
            //    listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.Price.ToString());
            //    listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.StockQuantity.ToString());
            //    listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.DateAdded.ToString());
            //}

        }
    }
}
