using Pipmix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pipmix.Data
{
    public interface IUserAccount
	{
		IEnumerable<UserAccount> GetAll();
		UserAccount GetById(int id);
		void Add(UserAccount account);
	}
}
