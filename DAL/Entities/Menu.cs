using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Menu
	{
		public int Id { get; set; }
		public double Prix { get; set; }
		public string Nom { get; set; }

		virtual public ICollection<Reservation> Reservations { get; set; }
	}
}
