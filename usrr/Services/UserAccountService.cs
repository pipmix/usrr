using Pipmix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pipmix.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Pipmix.Services
{
	public class UserAccountService : IUserAccount
	{

		private SiteContext _context;

		public UserAccountService(SiteContext context)
		{
			_context = context;
		}
		public void Add(UserAccount account)
		{
			_context.Add(account);
			_context.SaveChanges();
		}

		public IEnumerable<UserAccount> GetAll()
		{
			return _context.UserAccounts;
		}

		public UserAccount GetById(int id)
		{
			return _context.UserAccounts.SingleOrDefault(m => m.Id == id);
		}
	}
}
