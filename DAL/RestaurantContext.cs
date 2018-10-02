using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class RestaurantContext : DbContext
	{
		public RestaurantContext() : base("RestaurantDB")
		{

		}

		public DbSet<Table> Tables { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Menu> Menus { get; set; }

	}
}
