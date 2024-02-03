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
    public class CartRepositry : ICartRepositry
    {
        StoreContext context;
        public CartRepositry(StoreContext storeContext)
        {
            context = storeContext;
        }

        public void AddCart(Cart cart)
        {
            context.Carts.Add(cart);
        }

        public void AddCartProduct(CartProducts cartProducts)
        {
            context.CartProducts.Add(cartProducts);
        }
        public void UpdateCartProduct(int Productid,int CartId)
        {
            var product = context.CartProducts.FirstOrDefault(p => p.ProductID == Productid&& p.CartID==CartId);
            product.IsAddOrder =true;

            context.SaveChanges();
           
        }
        public int GetCart(int userID)
        {
            var result = from x in context.CartProducts
                         join s in context.Carts on x.CartID equals s.ShoppingCartID
                         where s.UserID == userID && x.IsAddOrder == false
                         select x.ProductID;
            return result.Count();
        }
        public int  GetCartUserId(int userID)
        {
            var cartId = context.Carts
                              .Where(x => x.UserID == userID)
                              .Select(x => x.ShoppingCartID)
                              .FirstOrDefault();

            return cartId;
        }
        public int Save()
        {
            return (int)context.SaveChanges();
        }

        public bool SearchCart(int userID)
        {
            return context.Carts.Any(x => x.UserID == userID);
        }


        // new func 



        public void RemoveCartProduct(int cartId, int productId)
        {
            int x = cartId;
            int y = productId;
            var cartProduct = context.CartProducts
                .FirstOrDefault(cp => cp.CartID == cartId && cp.ProductID == productId);

            if (cartProduct != null)
            {
                context.CartProducts.Remove(cartProduct);
                context.SaveChanges();
            }
        }




        //public List<CartProducts> GetProductsInCart(int cartId)
        //{
        //    return context.CartProducts.Where(cp => cp.CartID == cartId).ToList();
        //}



        public List<Product> GetProductsInCart(int cartId)
        {
            return context.CartProducts
                .Where(cp => cp.CartID == cartId && cp.IsAddOrder!=true)
                .Select(cp => new Product
                {
                    ProductID = cp.ProductID,
                    ProductName = cp.Product.ProductName,
                    Description = cp.Product.Description,
                    Price = cp.Product.Price,
                    StockQuantity = cp.Quantity
                })
                .ToList();
        }

        public bool CartStats(int productID, int cartId)
        {
            return context.CartProducts.Where(c => c.CartID == cartId && c.ProductID == productID).Select(c => c.IsAddOrder).FirstOrDefault();
        }

        public void UpdateCart(int productid, int cartId)
        {
           var product = context.CartProducts.FirstOrDefault(c => c.CartID == cartId && c.ProductID == productid);
            product.IsAddOrder = false;
            product.Quantity = 0;
            context.SaveChanges();
        }
    }
}
