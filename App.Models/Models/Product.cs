using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App.Models.Models
{
	public class Product
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductID { get; set; }
		public string? ProductName { get; set; }
		public string? Description { get; set; }
		public decimal? Price { get; set; }
		public int? StockQuantity { get; set; }

		public DateTime DateAdded { get; set; }
		public byte[]? Image { get; set; }
	
		// One-to-Many: One category can many products
		public int? CategoryID { get; set; }
		public virtual Category Category { get; set; }

		//public int CartID { get; set; }
		//public Cart Cart { get; set; }
		public ICollection<CartProducts> Carts { get; set; }

		public ICollection<ProductOrder>? OrderProducts { get; set; }
	}
}
