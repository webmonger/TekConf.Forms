using System;
using Xamarin.Forms;
using TekConf.Models;

namespace TekConf
{
	public class ConferenceDetailPage : ContentPage
	{
		public ConferenceDetailPage (Conference conference)
		{
			this.BackgroundColor = Color.White;
			this.BindingContext = conference;


			var stack = new StackLayout ()
			{
				Orientation = StackOrientation.Vertical
			};

			AddImage (stack);
			AddName (stack);
			AddDate (stack);

			this.Content = stack.Scroll();
		}

		static void AddImage (StackLayout stack)
		{
			var image = new Image () {
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.Center,
				BackgroundColor = Color.Red,
				MinimumHeightRequest = 180,
				HeightRequest = 180,
				WidthRequest = 260,
				MinimumWidthRequest = 260
			};
			image.SetBinding (Image.SourceProperty, "ImageUrl");
			stack.Children.Add (image);
		}

		static void AddName (StackLayout stack)
		{
			var nameLabel = new Label () {
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
			nameLabel.SetBinding (Label.TextProperty, "Name");
			stack.Children.Add (nameLabel);
		}

		static void AddDate(StackLayout stack)
		{
			var dateLabel = new Label {
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
					
			dateLabel.SetBinding(Label.TextProperty, new Binding(path: "Start", stringFormat: "{0:dd/MM/yyyy}"));
			stack.Children.Add (dateLabel);
		}
	}
	
}