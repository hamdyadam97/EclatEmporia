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

		private byte[] selectedImageBytes;
		public Add_Product()
		{
			InitializeComponent();
			var container = DependencyConfig.Configure();
			_categoryService = container.Resolve<ICategoryService>();
			_productService = container.Resolve<IProductService>();
			_categoryService = new CategoryService(new CategoryRepository(new StoreContext()));
			_productService = new ProductService(new ProductRepository(new StoreContext()));

			textBox1.TextChanged += textBox1_TextChanged;

		}

		private void Add_Product_Load(object sender, EventArgs e)
		{
			LoadCategories();
			GetProducts();
			ResetForm();

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
				MessageBox.Show("Please enter a productName.");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtDescription.Text))
			{
				MessageBox.Show("Please enter a product description");
				return;
			}

			var product = new Product
			{
				ProductName = txtProductName.Text,
				Description = txtDescription.Text,
				Price = Convert.ToDecimal(txtPrice.Text),
				StockQuantity = Convert.ToInt32(numericUpDownStockQuantity.Value),
				DateAdded = DateTime.Now,
				CategoryID = comboBoxCategories.SelectedValue != null
				? Convert.ToInt32(comboBoxCategories.SelectedValue)
				: 0,
				Image = selectedImageBytes
			};

			_productService.AddProduct(product);

			MessageBox.Show("Product added successfully.");
			GetProducts();
			ResetForm();
		}
		private void GetProducts()
		{

			var products = _productService.GetAllProductsWithIncludes();

			var productData = products.Select(p => new
			{
				p.ProductID,
				p.ProductName,
				p.Description,
				p.Price,
				p.StockQuantity,
				p.DateAdded,
				//p.Category.CategoryName = p.Category != null ? p.Category.CategoryName : string.Empty,
                CategoryName = p.Category != null ? p.Category.CategoryName : string.Empty,
				Image = p.Image
			}).ToList();
			dataGridViewProduct.DataSource = productData;
			if (!dataGridViewProduct.Columns.Contains("Image"))
			{
				DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
				imageColumn.HeaderText = "Image";
				imageColumn.Name = "Image";
				dataGridViewProduct.Columns.Add(imageColumn);
			}

			}
		private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void BtnUpdateProduct_Click(object sender, EventArgs e)
		{
			try
			{
				
				if (string.IsNullOrWhiteSpace(txtProductName.Text))
				{
					MessageBox.Show("Please enter a  productName");
					return;
				}

			
				if (comboBoxCategories.SelectedItem == null)
				{
					MessageBox.Show("Please select a category");
					return;
				}

				


				var selectedRow = dataGridViewProduct.SelectedRows[0].Index;
				int productId = Convert.ToInt32(dataGridViewProduct.Rows[selectedRow].Cells["ProductId"].Value);

				var product = _productService.GetProductById(productId);

				product.ProductName = txtProductName.Text;
				product.CategoryID = Convert.ToInt32(comboBoxCategories.SelectedValue);
				product.Price = Convert.ToDecimal(txtPrice.Text);
				product.Description = txtDescription.Text;
				product.StockQuantity = Convert.ToInt32(numericUpDownStockQuantity.Value);
				product.Image = selectedImageBytes;
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
			pictureBox1.Image = null;
			selectedImageBytes = null;

		}



		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string searchTerm = textBox1.Text.Trim();
			IQueryable<Product> searchResults = _productService.SearchProductsByName(searchTerm);

			var productData = searchResults.Select(p => new
			{
				p.ProductID,
				p.ProductName,
				p.Description,
				p.Price,
				p.StockQuantity,
				p.DateAdded,
				p.Category.CategoryName
			}).ToList();

			var products = _productService.GetAllProductsWithIncludes();


			dataGridViewProduct.DataSource = productData;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void uploadImg_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			openFileDialog.Title = "Select an Image File";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				selectedImageBytes = File.ReadAllBytes(openFileDialog.FileName);
				// Optionally, you can display the selected image in a PictureBox:
				pictureBox1.Image = Image.FromStream(new MemoryStream(selectedImageBytes));
			}
		}
	}
}
