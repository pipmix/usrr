using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pipmix.Models
{


	public class ContentTag
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
    public class WebPost
    {

		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Text { get; set; }
		public DateTime CreatedOn { get; set; }
		List<ContentTag> ContentTags { get; set; }

    }
}
