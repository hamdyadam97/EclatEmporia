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
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
		public CategoryRepository(StoreContext dbContext) : base(dbContext) { }
	}
}
