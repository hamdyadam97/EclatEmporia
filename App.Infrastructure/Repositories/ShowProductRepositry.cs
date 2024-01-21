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
    public class ShowProductRepositry : IShowRepositry
    {
        StoreContext context;
        public ShowProductRepositry(StoreContext storeContext)
        {
            context = storeContext;
        }
        public void AddOrder(Order order)
        {
           context.Orders.Add(order);
        }

        public IQueryable<Category> GetCategories()
        {
          return context.Categorys.Select(x => x);
        }

        public IQueryable<Product> GetProductByName( string Name)
        {
            return  context.Products.Where(x => x.ProductName.Contains(Name)).AsQueryable();  
        }

        public IQueryable<Product> GetProducts()
        {
            return context.Products.Select(x => x);
        }

        public IQueryable<Product> GetProductsByCat(string category)
        {
             var result = from x in context.Products 
                          join s in context.Categorys on x.CategoryID equals s.CategoryID
                          where s.CategoryName == category
                          select x;
            return result;
        }

        public int Save()
        {
            return (int)context.SaveChanges();
        }
    }
}
