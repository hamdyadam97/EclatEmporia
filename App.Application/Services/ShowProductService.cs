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

        public bool check(int productid, int categoryid)
        {
            return _IShowRepositry.check(productid, categoryid);
        }

        //public void AddCart(CartProducts cartProducts)
        //{
        //    _IShowRepositry.AddCart(cartProducts);
        //    _IShowRepositry.Save();
        //}

        //public int GetCart(int userID)
        //{
        //    return _IShowRepositry.GetCart(userID);
        //}

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

        public void updateQuantity(int Productid)
        {
            _IShowRepositry.updateQuantity(Productid);
        }

        public int usercartid(int userid)
        {
            return _IShowRepositry.usercartid(userid);
        }
    }
}
