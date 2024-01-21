using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App.Models.Models
{
	public class Order
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderID { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal TotalAmount { get; set; }
		public string OrderStatus { get; set; }
		public string ShippingAddress { get; set; }
		public string PaymentMethod { get; set; }

		// Many-to-One: Multiple orders belong to the same user
		public int UserID { get; set; }
		public User User { get; set; }
		public ICollection<ProductOrder> OrderProducts { get; set; }


	}
}
