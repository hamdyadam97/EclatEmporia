using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Contracts
{
    public interface ICartRepositry
    {
        public void AddCart(Cart cart);
        public void AddCartProduct(CartProducts cartProducts);
        public int GetCart(int userID);
        public bool SearchCart(int userID);
        public int Save();


        /// new func
        void RemoveCartProduct( int productId);

        List<Product> GetProductsInCart(int cartId);

    }
}
