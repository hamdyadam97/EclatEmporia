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
		Category Mastercategory = new Category();
		private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
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

		private void addBtnCateg_Click(object sender, EventArgs e)
		{
			//if (Mastercategory.User.Role == true)
			//{
				Category category = new Category()
				{
					CategoryName = textBox1.Text,
					Description = textBox2.Text
				};
				_categoryService.AddCategory(category);
				SetupDataGridView();
			//}

		}


		private void SetupDataGridView()
		{
			dataGridViewCateg.AutoGenerateColumns = true;
			dataGridViewCateg.DataSource = _categoryService.GetAllCategories().ToList();
		}
		private void dataGridViewCateg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void UpdateBtnCat_Click(object sender, EventArgs e)
		{
			
				try
				{
					int selectedIndex = dataGridViewCateg.SelectedRows[0].Index;
					int categoryIdToUpdate = Convert.ToInt32(dataGridViewCateg.Rows[selectedIndex].Cells["CategoryId"].Value);

					Category categoryToUpdate = _categoryService.GetCategoryById(categoryIdToUpdate);
					categoryToUpdate.CategoryName = textBox1.Text;
					categoryToUpdate.Description = textBox2.Text;
					_categoryService.UpdateCategory(categoryToUpdate);
					SetupDataGridView();
				}
				catch (Exception ex)
				{

					MessageBox.Show($"Error updating category: {ex.Message}");
				}
			

		}

		private void DelBtnCateg_Click(object sender, EventArgs e)
		{
			
				try
				{

					int selectedIndex = dataGridViewCateg.SelectedRows[0].Index;
					int categoryIdToDelete = Convert.ToInt32(dataGridViewCateg.Rows[selectedIndex].Cells["CategoryId"].Value);

					_categoryService.DeleteCategory(categoryIdToDelete);
					SetupDataGridView();
				}
				catch (Exception ex)
				{

					MessageBox.Show($"Error deleting category: {ex.Message}");
				}
			

		}

		private void ShowBtnCateg_Click(object sender, EventArgs e)
		{

		}
	}
}
