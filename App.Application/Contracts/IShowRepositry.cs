using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Contracts
{
    public interface IShowRepositry
    {
        //public IQueryable<Product> GetProducts();
        public IQueryable<Category> GetCategories();
        public IQueryable<Product> GetProductByName(string Name);
        public void AddOrder (Order order);
        public IQueryable<Product> GetProductsByCat(string category);
        public int Save();
    }
}
