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
        public void AddCart(CartProducts cartProducts)
        {
            _ICartRepositry.AddCart(cartProducts);
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

    }
}
