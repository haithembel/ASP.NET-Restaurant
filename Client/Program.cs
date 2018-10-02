using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace Client
{
	class Program
	{
		static void Main(string[] args)
		{
			var menuRepo = new MenuRepository();

			var menu1 = new Menu { Nom = "Lasagne", Prix = 5000 };
			var menu2 = new Menu { Nom = "Pizza 4 saisons", Prix = 7000 };
			var menu3 = new Menu { Nom = "Cordon bleu", Prix = 8000 };

			menuRepo.AddMenu(menu1);
			menuRepo.AddMenu(menu2);
			menuRepo.AddMenu(menu3);

			menuRepo.Commit();

			Console.WriteLine("La liste des menus");
			foreach (var menu in menuRepo.GetAllMenus())
			{
				Console.WriteLine("Le menu {0} est à {1} DT", menu.Nom, menu.Prix);
			}
			Console.WriteLine("Taper sur une touche pour sortir");
			Console.ReadKey();
		}
	}
}
