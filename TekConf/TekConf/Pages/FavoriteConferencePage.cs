using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TekConf
{
	public class FavoriteConferencePage : BasePage
	{
		public FavoriteConferencePage ()
		{
			this.SetBinding(ContentPage.TitleProperty, "Name");
			this.BackgroundColor = Color.Blue;

			var nameLabel = new Label { 
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			nameLabel.SetBinding (Label.TextProperty, "Name");
			this.Content = nameLabel;
		}
	}

}