﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace hwork8.EF
{
	public class AtistContext : DbContext
	{
		public DbSet<Art> Arts {get;set;}
		public DbSet<ArtOrder> Orders { get; set; }
		public DbSet<Atist> Atists { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Gallery> Galleries { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Type> Types { get; set; }
		public DbSet<PaymentType> PaymentTypes { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=HW8;Trusted_Connection=True;");
		}

		public AtistContext()
		{
			Database.EnsureCreated();
		}
	}
}
