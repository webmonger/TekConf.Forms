using System;
using System.Collections.ObjectModel;

namespace TekConf
{

	public class MenuViewModel
	{
		public ObservableCollection<MenuItem> MenuItems { get; set; }

		public MenuViewModel ()
		{
			this.MenuItems = new ObservableCollection<MenuItem> ();
			this.MenuItems.Add (new MenuItem () { Title = Menus.Conferences });
			this.MenuItems.Add (new MenuItem () { Title = Menus.MyFavorites });
			this.MenuItems.Add (new MenuItem () { Title = Menus.Settings });
			this.MenuItems.Add (new MenuItem () { Title = Menus.Login });
		}
	}
	
}
