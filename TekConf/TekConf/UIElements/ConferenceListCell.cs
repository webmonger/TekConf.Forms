using System;
using Xamarin.Forms;

namespace TekConf
{
	public class ConferenceListCell : ViewCell
	{
		public ConferenceListCell()
		{
			var stack = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
			};

			AddImage (stack);
			AddName (stack);

			View = stack;
		}

		static void AddImage (StackLayout stack)
		{
			var image = new Image {
				HorizontalOptions = LayoutOptions.Center,
				MinimumHeightRequest = 180,
				HeightRequest = 180,
				WidthRequest = 260,
				MinimumWidthRequest = 260
			};
			image.SetBinding (Image.SourceProperty, new Binding ("ImageUrl"));
			//image.WidthRequest = image.HeightRequest = 100;
			stack.Children.Add (image);
		}

		static void AddName (StackLayout stack)
		{
			var view = new NameListContentView () {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.End,
				BackgroundColor = Color.FromHex ("#FF81994D"),
				HeightRequest = 100,
			};


			var nameLabel = new Label {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.Black,
				Font = Font.SystemFontOfSize(14)
			};
			nameLabel.SetBinding (Label.TextProperty, "Name");

			view.Content = nameLabel;

			stack.Children.Add (view);
		}
	}

}
