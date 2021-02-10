using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PhoneContactWebsite.Models
{
	public class Phone
	{
		// EF Core configures the database to generate this value
		public int PhoneId { get; set; }

		[Required(ErrorMessage = "Please enter a name.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter a phone number.")]
		public int Number { get; set; }

		[Required(ErrorMessage ="Please enter an address.")]
		public string Address { get; set; }

		[Required(ErrorMessage = "Please enter any notes.")]
		public string Note { get; set; }

	}
}
