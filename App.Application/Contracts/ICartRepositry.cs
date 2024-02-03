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
        public void UpdateCartProduct(int productId, int cartId);
        public int GetCart(int userID);
        public int GetCartUserId(int userID);
        public bool SearchCart(int userID);
        public int Save();

        public bool CartStats(int productID, int cartId);
        public void UpdateCart(int productid, int cartId);

        /// new func

        public void RemoveCartProduct(int CartID, int ProductID);
        
        List<Product> GetProductsInCart(int cartId);


    }
}