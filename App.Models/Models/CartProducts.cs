using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models
{
    public class CartProducts
    {
        //public int Id { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int CartID { get; set; }
        public Cart Cart { get; set; }
        public bool IsAddOrder { get; set; }
        public int Quantity { get; set; }
    }
}
