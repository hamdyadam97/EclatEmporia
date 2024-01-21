using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models
{
	public class ProductOrder
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductID { get; set; }
		public Product Product { get; set; }
		public int OrderID { get; set; }
		public Order Order { get; set; }
		
	}
}
