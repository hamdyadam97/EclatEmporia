using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
	public interface ICategoryService
	{
		Category GetCategoryById(int id);
	    IEnumerable<Category> GetAllCategories();
		void AddCategory(Category category);
		void UpdateCategory(Category category);
		void DeleteCategory(int id);
	}
}
