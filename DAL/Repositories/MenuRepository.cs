using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class MenuRepository : IDisposable
	{
		RestaurantContext ctx = null;
		public MenuRepository()
		{
			ctx = new RestaurantContext();
		}
		public void AddMenu(Menu m)
		{
			ctx.Menus.Add(m);
		}

		public void Commit()
		{
			ctx.SaveChanges();
		}

		public void Dispose()
		{
			ctx.Dispose();
		}

		public IEnumerable<Menu> GetAllMenus()
		{
			return ctx.Menus;
		}

        public Menu GetMenu(int? id)
        {
            return (Menu)ctx.Menus.Where(m => m.Id == id);
        }

        public Menu GetMenuByName(string name)
        {
            return (Menu)ctx.Menus.Where(m => m.Nom == name);
        }

	}
}
