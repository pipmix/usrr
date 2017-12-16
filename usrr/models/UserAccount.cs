using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pipmix.Models
{
	public class UserAccount
	{



		public Guid Id { get; protected set; }
		public string Email { get; protected set; }
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


			Id = Guid.NewGuid();
			FirstName = firstname;
			LastName = lastname;
			Email = email.ToLowerInvariant();
			CreationDate = DateTime.UtcNow;
		}


	}
}
