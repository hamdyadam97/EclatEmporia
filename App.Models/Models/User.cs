using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App.Models.Models
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserID { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
      
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime RegistrationDate { get; set; }

		// One-to-Many: One user can many orders
		public List<Order> Orders { get; set; }

		// One-to-One: One user can have one shopping cart
		public Cart Cart { get; set; }
        public List<Category> Categories { get; set; }

        public bool Role { get; set; }
	}
}
