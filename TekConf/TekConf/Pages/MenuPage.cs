using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TekConf
{
	public class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			this.BackgroundColor = Color.White;

			this.Title = "Menu";
			this.Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 5);

			var listView = new ListView ();
			var viewModel = new MenuViewModel ();
			listView.ItemsSource = viewModel.MenuItems;

			var cellTemplate = new DataTemplate (typeof(TextCell));

			cellTemplate.SetBinding (TextCell.TextProperty, "Title");

			listView.ItemTemplate = cellTemplate;
			listView.ItemSelected += (sender, e) => {
				 NavigateTo (e.SelectedItem as MenuItem);
			};
				
			Content = listView;
		}

		private void NavigateTo (MenuItem menuItem)
		{
			Page page = null;
			switch (menuItem.Title) {
			case Menus.Conferences:
				page = new ConferencesPage ();
				break;
			case Menus.MyFavorites:
				page = new FavoriteConferencesPage ();
				break;
			case Menus.Settings:
				page = new SettingsPage ();
				break;
			case Menus.Login:
				page = new LoginPage ();
				break;
			}

			MsgHub.Send<MenuNavigationMessage> (new MenuNavigationMessage () { 
				Page = page
			});
		}
	}

}

