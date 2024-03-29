﻿using App.Application.Contracts;
using App.Context;
using App.Models.Models;
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
        public int GetCart(int userID)
        {
            var result = from x in context.CartProducts
                         join s in context.Carts on x.CartID equals s.ShoppingCartID
                         where s.UserID == userID
                         select x.ProductID;
            return result.Count();
        }
        public int Save()
        {
            return (int)context.SaveChanges();
        }

        public bool SearchCart(int userID)
        {
            return context.Carts.Any(x => x.UserID == userID);
        }
    }
}
