using App.Application.Contracts;
using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class CartProductServices : ICartRepositry
    {
        ICartRepositry _ICartRepositry;
        public CartProductServices(ICartRepositry ICartRepositry)
        {
            _ICartRepositry = ICartRepositry;
        }

        public void AddCart(Cart cart)
        {
            _ICartRepositry.AddCart(cart);
            _ICartRepositry.Save();
        }



        public void AddCartProduct(CartProducts cartProducts)
        {
            _ICartRepositry.AddCartProduct(cartProducts);
            _ICartRepositry.Save();
        }
        
        public int GetCart(int userID)
        {
            return _ICartRepositry.GetCart(userID);
        }
        public int Save()
        {
            return _ICartRepositry.Save();
        }

        public bool SearchCart(int userID)
        {
            return _ICartRepositry.SearchCart(userID);
        }


        /// new func
        public List<Product> GetProductsInCart(int CartID)
        {
            return _ICartRepositry.GetProductsInCart(CartID);
        }
 
         public void RemoveCartProduct(int CartID, int ProductID)
        {
            _ICartRepositry.RemoveCartProduct(CartID, ProductID);
        }

    }
}
