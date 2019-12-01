using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configuration
{
	public partial class MyDbContext : DbContext
	{
		public MyDbContext()
		{

		}

		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
		{

		}


	}
}
