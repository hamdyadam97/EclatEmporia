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
        public void AddCart(CartProducts cartProducts);
        public int GetCart(int userID);
        public int Save();
    }
}
