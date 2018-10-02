using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Table
	{
		public int Id { get; set; }
		public bool IsAvailable { get; set; }
		public int Numero { get; set; }

		virtual public ICollection<Reservation> Reservations { get; set; }

	}
}
