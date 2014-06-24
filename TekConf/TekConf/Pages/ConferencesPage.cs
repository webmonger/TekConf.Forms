using System;
using Xamarin.Forms;
using TekConf.Models;

namespace TekConf
{
	public class ConferencesPage : BasePage
	{
		public ConferencesPage ()
		{
			this.BackgroundColor = Color.White;

			var viewModel = new ConferencesViewModel ();
			this.BindingContext = viewModel;

			this.Title = "Conferences";

			var stack = new StackLayout {
				Orientation = StackOrientation.Vertical,
				Padding = new Thickness(0, 8, 0, 8)
			};


			var listView = new ListView ();
			var cell = new DataTemplate(typeof(ConferenceListCell));

			listView.ItemTemplate = cell;
			listView.RowHeight = 260;
			listView.ItemSelected += (sender, e) => {
				var conference = (Conference)e.SelectedItem;
				var conferenceDetailPage = new ConferenceDetailPage(conference); // so the new page shows correct data
				Navigation.PushAsync(conferenceDetailPage);
			};

			listView.ItemsSource = viewModel.Conferences;

			var activity = new ActivityIndicator {
				Color = Color.Red,
				IsEnabled = true
			};
			activity.SetBinding (ActivityIndicator.IsVisibleProperty, "IsBusy");
			activity.SetBinding (ActivityIndicator.IsRunningProperty, "IsBusy");

			stack.Children.Add (activity);
			stack.Children.Add (listView);

			Content = stack;

			viewModel.LoadConferences ();

		}
	}
}