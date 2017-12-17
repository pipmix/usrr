using Microsoft.EntityFrameworkCore;
using Pipmix.Models;
using System;

namespace Pipmix
{
	public class SiteContext : DbContext
	{

		public SiteContext(DbContextOptions opt) : base(opt)
		{

		}
		public DbSet<UserAccount> UserAccounts { get; set; }
		//public DbSet<ShopItem> ShopItems { get; set; }
		//public DbSet<ContentTag> ContentTags { get; set; }
		//public DbSet<ShopOrder> ShopOrders { get; set; }
	}
}
