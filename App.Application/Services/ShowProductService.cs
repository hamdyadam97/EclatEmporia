using App.Application.Contracts;
using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class ShowProductService : IShowRepositry
    {
        IShowRepositry _IShowRepositry;
        public ShowProductService(IShowRepositry IshowRepositry)
        {
            _IShowRepositry = IshowRepositry;
        }

        public void AddOrder(Order order)
        {
            _IShowRepositry.AddOrder(order);
            _IShowRepositry.Save();
        }

        public IQueryable<Category> GetCategories()
        {
            return _IShowRepositry.GetCategories();
        }

        public IQueryable<Product> GetProductByName(string Name)
        {
            return _IShowRepositry.GetProductByName(Name);
        }

        //public IQueryable<Product> GetProducts()
        //{
        //    return _IShowRepositry.GetProducts();
        //}

        public IQueryable<Product> GetProductsByCat(string category)
        {
            return _IShowRepositry.GetProductsByCat(category);
        }

        public int Save()
        {
            return _IShowRepositry.Save();
        }
    }
}
