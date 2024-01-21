using App.Application.Contracts;
using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Autofac;
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
    public partial class Add_Product : Form
    {
        Product masterProduct = new Product();
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public Add_Product()
        {
            InitializeComponent();
            var container = DependencyConfig.Configure();
            _categoryService = container.Resolve<ICategoryService>();
            _productService = container.Resolve<IProductService>();
            _categoryService = new CategoryService(new CategoryRepository(new StoreContext()));
            _productService = new ProductService(new ProductRepository(new StoreContext()));
            //         _productService = productService;
            //_categoryService = categoryService;
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            LoadCategories();
            GetProducts();
        }
        private void LoadCategories()
        {
            var categories = _categoryService.GetAllCategories();


            comboBoxCategories.DataSource = categories.ToList();
            comboBoxCategories.DisplayMember = "CategoryName";
            comboBoxCategories.ValueMember = "CategoryID";
        }
        private void btnaAddProduct_Click(object sender, EventArgs e)
        {

            var product = new Product
            {
                ProductName = txtProductName.Text,
                Description = txtDescription.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                StockQuantity = (int)numericUpDownStockQuantity.Value,
                DateAdded = DateTime.Now,
                CategoryID = Convert.ToInt32(comboBoxCategories.SelectedValue)
            };

            _productService.AddProduct(product);
            MessageBox.Show("Product added successfully.");
            GetProducts();
        }
        private void GetProducts()
        {
            //dataGridViewCateg.AutoGenerateColumns = true;
            //dataGridViewCateg.DataSource = _categoryService.GetAllCategories().ToList();
            var products = _productService.GetAllProducts();

            dataGridViewProduct.DataSource = products;
        }
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridViewProduct.SelectedRows[0].Index;
            int productId = Convert.ToInt32(dataGridViewProduct.Rows[selectedRow].Cells["ProductId"].Value);

            var product = _productService.GetProductById(productId);


            product.ProductName = txtProductName.Text;
            product.CategoryID = Convert.ToInt32(comboBoxCategories.SelectedValue);
            product.Price = Convert.ToDecimal(txtPrice.Text);
            product.Description = txtDescription.Text;
            product.StockQuantity = Convert.ToInt16((int)numericUpDownStockQuantity.Value);

            _productService.UpdateProduct(product);
            MessageBox.Show("Product updated successfully.");

            GetProducts();

        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewProduct.SelectedRows[0];
            var productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            _productService.DeleteProduct(productId);
            MessageBox.Show("Product deleted successfully.");


            GetProducts();
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewProduct.Rows[e.RowIndex];
                var productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var product = _productService.GetProductById(productId);

                txtProductName.Text = product.ProductName;
                comboBoxCategories.SelectedValue = product.CategoryID;
                txtPrice.Text = product.Price.ToString();
                txtDescription.Text = product.Description;
            }
        }

        private void dataGridViewProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var selectedRow = dataGridViewProduct.Rows[e.RowIndex];
            //var productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            int selectedRow = dataGridViewProduct.SelectedRows[0].Index;
            int productId = Convert.ToInt32(dataGridViewProduct.Rows[selectedRow].Cells["ProductId"].Value);
            var product = _productService.GetProductById(productId);

            txtProductName.Text = product.ProductName;
            comboBoxCategories.SelectedValue = product.CategoryID;
            txtPrice.Text = product.Price.ToString();
            txtDescription.Text = product.Description;

        }
    }
}
