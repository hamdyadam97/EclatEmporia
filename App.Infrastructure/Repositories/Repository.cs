using App.Application.Contracts;
using App.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly StoreContext _dbContext;

		public Repository(StoreContext dbContext)
		{
			_dbContext = dbContext;
		}

		public T GetById(int id)
		{
			return _dbContext.Set<T>().Find(id);
		}

		public IEnumerable<T> GetAll()
		{
			return _dbContext.Set<T>().ToList();
		}

		public void Add(T entity)
		{
			_dbContext.Set<T>().Add(entity);
			_dbContext.SaveChanges();
		}

		public void Update(T entity)
		{
			_dbContext.Set<T>().Update(entity);
			_dbContext.SaveChanges();
		}

		public void Delete(int id)
		{
			T entity = GetById(id);
			if (entity != null)
			{
				_dbContext.Set<T>().Remove(entity);
				_dbContext.SaveChanges();
			}
		}

        public int Save()
        {
            throw new NotImplementedException();
        }
    }

}

