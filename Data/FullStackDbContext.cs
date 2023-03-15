using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fullstackapi.Models;
using Microsoft.EntityFrameworkCore ;

namespace Fullstackapi.Data
{
	public class FullStackDbContext :DbContext
	{
		public FullStackDbContext(DbContextOptions options):base(options)
		{
			
		}
		
		public DbSet<Employee> Employees {get;set;}
	}
}