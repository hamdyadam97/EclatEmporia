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
	public partial class AddCategoryProduct : Form
	{

		private readonly ICategoryService _categoryService;
		private readonly IProductService _productService;
        public User user { get; set; }
        public AddCategoryProduct()
		{
			InitializeComponent();

			var container = DependencyConfig.Configure();
			_categoryService = container.Resolve<ICategoryService>();
			_productService = container.Resolve<IProductService>();
			_categoryService = new CategoryService(new CategoryRepository(new StoreContext()));
			_productService = new ProductService(new ProductRepository(new StoreContext()));
            
            SetupDataGridView();
		}

		private void SetupDataGridView()
		{
			dataGridViewCateg.AutoGenerateColumns = true;
			dataGridViewCateg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			RefreshDataGridView();
		}

		private void RefreshDataGridView()
		{
			dataGridViewCateg.DataSource = _categoryService.GetAllCategories().ToList();
		}
		private void addBtnCateg_Click(object sender, EventArgs e)
		{
			if (ValidateCategoryInput())
			{
				Category category = new Category()
				{
					CategoryName = textBox1.Text,
					Description = textBox2.Text
				};
				_categoryService.AddCategory(category);
				RefreshDataGridView();
				ResetForm();
			}
		}

		//test code
		private void dataGridViewCateg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < dataGridViewCateg.Rows.Count)
			{
				DataGridViewRow selectedRow = dataGridViewCateg.Rows[e.RowIndex];
				textBox1.Text = selectedRow.Cells["CategoryName"].Value?.ToString();
				textBox2.Text = selectedRow.Cells["Description"].Value?.ToString();
			}
		}
		private void UpdateBtnCat_Click(object sender, EventArgs e)
		{
			try
			{
				
				if (ValidateCategoryInput())
				{
					
					if (dataGridViewCateg.SelectedRows.Count > 0)
					{
						
						DataGridViewRow selectedRow = dataGridViewCateg.SelectedRows[0];

						
						if (selectedRow != null && selectedRow.Index != -1)
						{
							
							int categoryIdToUpdate = Convert.ToInt32(selectedRow.Cells["CategoryId"].Value);

							
							Category categoryToUpdate = _categoryService.GetCategoryById(categoryIdToUpdate);

							
							DialogResult result = MessageBox.Show("Are you sure you want to update this category?", "Confirmation", MessageBoxButtons.YesNo);

							if (result == DialogResult.Yes)
							{
							
								categoryToUpdate.CategoryName = textBox1.Text;
								categoryToUpdate.Description = textBox2.Text;

							
								_categoryService.UpdateCategory(categoryToUpdate);

								
								RefreshDataGridView();

								
								ResetForm();
							}
						}
						else
						{
							
							MessageBox.Show("Please select a valid category to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						
						MessageBox.Show("Please select a category to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				
				MessageBox.Show($"Error updating category: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Delete
		private void DelBtnCateg_Click(object sender, EventArgs e)
		{

			try
			{

				int selectedIndex = dataGridViewCateg.SelectedRows[0].Index;
				int categoryIdToDelete = Convert.ToInt32(dataGridViewCateg.Rows[selectedIndex].Cells["CategoryId"].Value);

				_categoryService.DeleteCategory(categoryIdToDelete);
				RefreshDataGridView();


			}
			catch (Exception ex)
			{

				MessageBox.Show($"Error deleting category: {ex.Message}");
			}
		}

		private bool ValidateCategoryInput()
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Please enter valid category name and description.");
				return false;
			}

			return true;
		}

		//Reset Function
		private void ResetForm()
		{
			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;

		}

		
	}
}
