using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhoneContactWebsite.Models
{
	/*	DbContext is a class that communicates to the database
	 *	DbContextOptions stores configuration options for the the DbContext object 
	 *	DbSet<Entity> is a collection of objects that is created from the entity!
	 */
	public class PhoneContext : DbContext
	{
		public PhoneContext(DbContextOptions<PhoneContext> options)
			: base(options)
		{ }

		public DbSet<Phone> Phones { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Phone>().HasData(
				new Phone
				{
					PhoneId = 1,
					Name = "John Doe",
					Number = 911,
					Address = "1337 Long Beach Drive",
					Note = "This is a note!"
				},
				new Phone
				{
					PhoneId = 2,
					Name = "Jane Doe",
					Number = 911,
					Address = "1337 Long Beach Drive",
					Note = "This is another note!"
				}
			);
		}
	}
}
