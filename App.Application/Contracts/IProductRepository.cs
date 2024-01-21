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
		public List<Product> SearchByTitle(string name);
	}
}
