using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
	public interface IProductService
	{
		Product GetProductById(int id);
		IEnumerable<Product> GetAllProducts();
		void AddProduct(Product product);
		void UpdateProduct(Product product);
		void DeleteProduct(int id);
        public IQueryable<Product> GetProducts();
        //public IQueryable<Product> GetProductByName(string Name);
        //List<Product> GetAllPagination(int Num, int Prd);

    }
}
