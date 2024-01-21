using App.Application.Contracts;
using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;

		public CategoryService(ICategoryRepository categoryRepository)
        {
			_categoryRepository = categoryRepository;
		}

		public void AddCategory(Category category)
		{
			_categoryRepository.Add(category);
			
		}

		public void DeleteCategory(int id)
		{
			_categoryRepository.Delete(id);
		}

		public IEnumerable<Category> GetAllCategories()
		{
			//IEnumerable<Category> categories = _categoryRepository.GetAll();
			//return categories;
			return _categoryRepository.GetAll();
		}

		public Category GetCategoryById(int id)
		{
			return _categoryRepository.GetById(id);
		}

		public void UpdateCategory(Category category)
		{
			_categoryRepository.Update(category);
		}
	}
}
