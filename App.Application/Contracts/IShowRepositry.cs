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
        //public void AddCart(CartProducts cartProducts);
        public IQueryable<Product> GetProductsByCat(string category);
        public bool check(int productid , int categoryid);
        public int usercartid(int userid);
        public void updateQuantity(int Productid, int cartid);
        //public int GetCart(int userID);
        public int Save();
    }
}
