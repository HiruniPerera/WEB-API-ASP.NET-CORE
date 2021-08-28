using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookapi.Models
{
	public class Book
	{
		public int Id { get; set; }
		public String Title { get; set; }
		public String Author { get; set; }
		public String Description { get; set; }
	}
}
