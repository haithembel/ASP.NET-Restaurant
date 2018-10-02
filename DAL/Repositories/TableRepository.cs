using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TableRepository
    {
        RestaurantContext ctx = null;

        public TableRepository()
        {
            ctx = new RestaurantContext();
        }

        public void AddTable(Table t)
        {
            ctx.Tables.Add(t);
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }

        public IEnumerable<Table> GetAllTables()
        {
            var req = from Table in ctx.Tables
                      orderby Table.Numero select Table;

            return req.ToList();
        }

        public IEnumerable<Table> GetTablesReserverdTomorrow()
        {
            List<Table> listeTables = new List<Table>();

         var listReservationDemain = ctx.Reservations.
                Where(r => r.DateReservation == DateTime.Today.AddDays(1));

            foreach( Reservation item in listReservationDemain)
            {
                listeTables.Add(item.Table);
            }

            return listeTables;
        }

        public IEnumerable<TableCouple> GetAllTablesCouple()
        {
            return ctx.Tables.OfType<TableCouple>();
        }

        public TableCouple GetFirstTableCoupleAvailable(bool chandelle)
        {
                return ctx.Tables.Where(t => t.IsAvailable == chandelle).OfType<TableCouple>().
                    Where(t => t.DineeChandelle == chandelle).First();
            }
        public int CountTablesCoupleAvailable()
        {
            return ctx.Tables.Where(t => t.IsAvailable == true).OfType<TableCouple>().Count();

        }
    }
}
