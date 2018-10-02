using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ReservationRepository
    {
        RestaurantContext ctx = null;

        public ReservationRepository()
        {
            ctx = new RestaurantContext();
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }

        public IGrouping<Menu,List<Reservation>> ListerReservationGroupesByMenu()
        {
            var req = from Reservation in ctx.Reservations
                      group Reservation by Reservation.Menus
                      into variable
                      select new
                      {
                          cle = variable.Key,
                          liste = variable.ToList()
                      };

            return (IGrouping < Menu,List<Reservation>>)req;
            }


        }



    }

