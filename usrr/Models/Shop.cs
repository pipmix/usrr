using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pipmix.Models
{
    public class ShopOrder
	{
		public int Id { get; set; }
		public UserAccount UserAccount { get; set; }
    }

	public class ShopItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Decimal Price { get; set; }
	}


}
