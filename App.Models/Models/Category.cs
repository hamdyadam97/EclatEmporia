using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models
{
	public class Category
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CategoryID { get; set; }
		public string? CategoryName { get; set; }
		public string? Description { get; set; }

		// One-to-Many: One category can many products
		public virtual List<Product>? Products { get; set; }
		public int? UserID { get; set; }
        public User User { get; set; }
		
	}
}
