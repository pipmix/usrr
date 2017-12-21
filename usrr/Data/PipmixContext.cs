using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pipmix.Models;

namespace Pipmix.Data
{
	public class PipmixContext : DbContext
	{
		public PipmixContext(DbContextOptions<PipmixContext> options)
			: base(options)
		{
		}

		public DbSet<GameInfo> GameInfos { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

		}




	}
}


