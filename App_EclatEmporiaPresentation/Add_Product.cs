using App.Application.Contracts;
using App.Application.Services;
using App.Models.Models;
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
		private readonly IProductService _productService;
		private readonly ICategoryService _categoryService;

		public Add_Product(IProductService productService,
			ICategoryService categoryService)
		{
			InitializeComponent();
			_productService = productService;
			_categoryService = categoryService;
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
			var products = _productService.GetAllProducts;

			dataGridViewProduct.DataSource = products;
		}
		private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void BtnUpdateProduct_Click(object sender, EventArgs e)
		{
			var selectedRow = dataGridViewProduct.SelectedRows[0];
			var productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

			var product = _productService.GetProductById(productId);


			product.ProductName = txtProductName.Text;
			product.CategoryID = Convert.ToInt32(comboBoxCategories.SelectedValue);
			product.Price = Convert.ToDecimal(txtPrice.Text);
			product.Description = txtDescription.Text;

			_productService.UpdateProduct(product);
			MessageBox.Show("Product updated successfully.");


			GetProducts();
		}

		private void BtnDeleteProduct_Click(object sender, EventArgs e)
		{
			//var selectedRow = dataGridViewProducts.SelectedRows[0];
			//var productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

			//await _productRepository.DeleteProductAsync(productId);
			//MessageBox.Show("Product deleted successfully.");

			
			//GetProducts();
		}
	}
}
