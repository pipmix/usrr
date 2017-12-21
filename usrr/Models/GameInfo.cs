using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pipmix.Models
{
	public class GameInfo
	{

		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public string Publisher { get; set; }
		public string Developer { get; set; }
		public DateTime ReleaseDate { get; set; }
		public decimal Price { get; set; }
		public string Genre { get; set; }

	}
}
