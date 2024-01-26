using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Contracts
{
	public interface IProductRepository : IRepository<Product>
	{
		//public IQueryable<Product> GetProductByName(string name);
        public IQueryable<Product> GetProducts();
		public void updateQuantity(int Productid);

    }
}
