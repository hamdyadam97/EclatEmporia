﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_EclatEmporiaPresentation.DTO
{
	public class ProductDto
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public decimal? Price { get; set; }
		public int? StockQuantity { get; set; }
		public DateTime DateAdded { get; set; }
		public byte[]? Image { get; set; }
		public string CategoryName { get; set; }
	}
}
