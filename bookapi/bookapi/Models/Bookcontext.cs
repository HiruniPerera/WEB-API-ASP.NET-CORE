using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookapi.Models
{
	public class Bookcontext :DbContext 
	{
		public Bookcontext(DbContextOptions<Bookcontext>options)
			:base(options)
		{

		}
		public DbSet<Book> Books { get; set; }
	}
}
