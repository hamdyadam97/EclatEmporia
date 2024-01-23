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

			if (string.IsNullOrWhiteSpace(txtProductName.Text))
			{
				MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtDescription.Text))
			{
				MessageBox.Show("Please enter a product description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			decimal price;
			if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
			{
				MessageBox.Show("Please enter a valid positive price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int stockQuantity;
			if (!int.TryParse(numericUpDownStockQuantity.Value.ToString(), out stockQuantity) || stockQuantity < 0)
			{
				MessageBox.Show("Please enter a valid positive stock quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var product = new Product
			{
				ProductName = txtProductName.Text,
				Description = txtDescription.Text,
				Price = price,
				StockQuantity = stockQuantity,
				DateAdded = DateTime.Now,
				//CategoryID = Convert.ToInt32(comboBoxCategories.SelectedValue)
				CategoryID = comboBoxCategories.SelectedValue != null
					? Convert.ToInt32(comboBoxCategories.SelectedValue)
					: 0
			};

			_productService.AddProduct(product);

			MessageBox.Show("Product added successfully.");
			GetProducts();
			ResetForm();
		}
		private void GetProducts()
		{
			//var products = _productService.GetAllProducts();

			//dataGridViewProduct.DataSource = products;

			var products = _productService.GetAllProducts();
			var productData = products.Select(p => new
			{
				p.ProductID,
				p.ProductName,
				p.Description,
				p.Price,
				p.StockQuantity,
				p.DateAdded,
				CategoryName = p.Category != null ? p.Category.CategoryName : string.Empty
			}).ToList();

			dataGridViewProduct.DataSource = productData;


		}
		private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void BtnUpdateProduct_Click(object sender, EventArgs e)
		{
			try
			{
				// Validate Product Name
				if (string.IsNullOrWhiteSpace(txtProductName.Text))
				{
					MessageBox.Show("Please enter a valid product name.");
					return;
				}

				// Validate Category
				if (comboBoxCategories.SelectedItem == null)
				{
					MessageBox.Show("Please select a valid category.");
					return;
				}

				// Validate Price
				decimal price;
				if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
				{
					MessageBox.Show("Please enter a valid positive price.");
					return;
				}

				// All validation passed, proceed to update the product
				var selectedRow = dataGridViewProduct.SelectedRows[0].Index;
				int productId = Convert.ToInt32(dataGridViewProduct.Rows[selectedRow].Cells["ProductId"].Value);

				var product = _productService.GetProductById(productId);

				product.ProductName = txtProductName.Text;
				product.CategoryID = Convert.ToInt32(comboBoxCategories.SelectedValue);
				product.Price = price;
				product.Description = txtDescription.Text;

				//numericUpDownStockQuantity.Value = Convert.ToInt32(product.StockQuantity);
				product.StockQuantity = Convert.ToInt32(numericUpDownStockQuantity.Value);
				_productService.UpdateProduct(product);
				MessageBox.Show("Product updated successfully.");

				GetProducts();
				ResetForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}

		}

		private void BtnDeleteProduct_Click(object sender, EventArgs e)
		{


			try
			{
				// Check if a row is selected
				if (dataGridViewProduct.SelectedRows.Count == 0)
				{
					MessageBox.Show("Please select a product to delete.");
					return;
				}
				DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);
				if (result == DialogResult.No)
				{
					return;
				}

				var selectedRow = dataGridViewProduct.SelectedRows[0].Index;
				int productId = Convert.ToInt32(dataGridViewProduct.Rows[selectedRow].Cells["ProductId"].Value);
				_productService.DeleteProduct(productId);
				MessageBox.Show("Product deleted successfully.");

				GetProducts();
				ResetForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}
		}

		private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewProduct.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select a row.");
				return;
			}

			int selectedRow = dataGridViewProduct.SelectedRows[0].Index;

			if (selectedRow >= 0 && selectedRow < dataGridViewProduct.Rows.Count)
			{
				int productId = Convert.ToInt32(dataGridViewProduct.Rows[selectedRow].Cells["ProductId"].Value);
				var product = _productService.GetProductById(productId);

				txtProductName.Text = product.ProductName;
				comboBoxCategories.SelectedValue = product.CategoryID;
				//comboBoxCategories.SelectedValue = product.Category.CategoryName;
				txtPrice.Text = product.Price.ToString();
				txtDescription.Text = product.Description;
				numericUpDownStockQuantity.Value = Convert.ToInt32(product.StockQuantity);
			}


		}

		private void dataGridViewProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dataGridViewProduct.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select one row.");
				return;
			}

			int selectedRow = dataGridViewProduct.SelectedRows[0].Index;

			if (selectedRow >= 0 && selectedRow < dataGridViewProduct.Rows.Count)
			{
				int productId = Convert.ToInt32(dataGridViewProduct.Rows[selectedRow].Cells["ProductId"].Value);
				var product = _productService.GetProductById(productId);


				txtProductName.Text = product.ProductName;
				comboBoxCategories.SelectedValue = product.CategoryID;
				//comboBoxCategories.SelectedValue = product.Category.CategoryName;
				txtPrice.Text = product.Price.ToString();
				txtDescription.Text = product.Description;
				numericUpDownStockQuantity.Value = Convert.ToInt32(product.StockQuantity);
			}
		}

		//Reset Fuction
		private void ResetForm()
		{
			txtProductName.Text = string.Empty;
			txtDescription.Text = string.Empty;
			txtPrice.Text = string.Empty;
			numericUpDownStockQuantity.Value = 0;
			comboBoxCategories.SelectedIndex = -1;

		}


	}
}
