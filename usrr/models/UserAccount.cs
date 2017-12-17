using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pipmix.Models
{
	public class UserAccount
	{



		public int Id { get; protected set; }
		[Required]
		[StringLength(30, ErrorMessage = "User Name too long ")]
		public string UserAccountName { get; protected set; }
		[Required]
		public string Email { get; protected set; }
		[Required]
		public string Password { get; protected set; }
		public string FirstName { get; protected set; }
		public string LastName { get; protected set; }
		public string Salt { get; protected set; }

		public DateTime CreationDate { get; protected set; }

		protected UserAccount()
		{
		}

		public UserAccount(string firstname, string lastname, string email)
		{

			if (string.IsNullOrWhiteSpace(email))
			{

			}


			
			FirstName = firstname;
			LastName = lastname;
			Email = email.ToLowerInvariant();
			CreationDate = DateTime.UtcNow;
		}


	}
}
