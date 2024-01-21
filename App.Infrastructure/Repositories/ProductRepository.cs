using App.Application.Contracts;
using App.Context;
using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		public ProductRepository(StoreContext dbContext) : base(dbContext) { }

		public List<Product> SearchByTitle(string name)
		{
			throw new NotImplementedException();
		}

	}
}
