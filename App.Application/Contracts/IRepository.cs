using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Contracts
{
	public interface IRepository<T>
	{
	
		T GetById(int id);
		IEnumerable<T> GetAll();
		void Add(T entity);
		void Update(T entity);
		void Delete(int id);
        public int Save();
    }
}
