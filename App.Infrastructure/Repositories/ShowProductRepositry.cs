using App.Application.Contracts;
using App.Context;
using App.Context.Migrations;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;
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

        public bool check(int productid, int categoryid)
        {
            bool exists = context.CartProducts.Any(pc => pc.ProductID == productid && pc.CartID == categoryid);
            return exists;
        }

        //public void AddCart(CartProducts cartProducts)
        //{
        //    context.CartProducts.Add(cartProducts);
        //}

        //public int GetCart(int userID)
        //{
        //    var result = from x in context.CartProducts
        //                 join s in context.Carts on x.CartID equals s.ShoppingCartID
        //                 where s.UserID == userID
        //                 select x.ProductID;
        //    return result.Count();
        //}

        public IQueryable<Category> GetCategories()
        {
          return context.Categorys.Select(x => x);
        }

        public IQueryable<Product> GetProductByName( string Name)
        {
            return context.Products.Where(x => x.ProductName.Contains(Name)).AsQueryable();  
        }

        //public IQueryable<Product> GetProducts()
        //{
        //    return context.Products.Select(x => x);
        //}

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

        public void updateQuantity(int Productid)
        {
            var product = context.CartProducts.FirstOrDefault(p => p.ProductID == Productid);
            product.Quantity += 1;

            context.SaveChanges();
        }

        public int usercartid(int userid)
        {
            return context.Carts.Where(c => c.UserID == userid).Select(c => c.ShoppingCartID).FirstOrDefault();
        }
    }
}
