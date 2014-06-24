using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TekConf
{
	public class FavoriteConferencesPage : CarouselPage
	{
		public FavoriteConferencesPage ()
		{
			this.BackgroundColor = Color.White;
			this.Title = "Favorites";

			var viewModel = new ConferencesViewModel ();
			viewModel.LoadConferences ();

			this.ItemsSource = viewModel.Conferences;
			this.ItemTemplate = new DataTemplate (() => {
				return new FavoriteConferencePage();
			});


		}
	}

}
