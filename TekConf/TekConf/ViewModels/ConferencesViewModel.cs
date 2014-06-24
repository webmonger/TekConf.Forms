using System;
using System.Collections.ObjectModel;
using TekConf.Models;
using System.Net.Http;
using ModernHttpClient;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xamarin.Forms;

namespace TekConf
{
	public class ConferencesViewModel : BaseViewModel
	{

		private const string ConferencesApi = "http://api.tekconf.com/v1/conferences";
		public ConferencesViewModel ()
		{
//			var device = Resolver.Resolve<IDevice> ();
//			var display = device.Display;
//			var dpi = display.Xdpi;
			this.Conferences = new ObservableCollection<Conference> ();
		}
			

		private ObservableCollection<Conference> _conferences;
		public ObservableCollection<Conference> Conferences {
			get {
				return _conferences;
			}
			set {
				_conferences = value;
				OnPropertyChanged ("Conferences");
			}
		}

		public async Task LoadConferences()
		{
			if (IsBusy)
				return;

			IsBusy = true;

			string json = string.Empty;
			using (var httpClient = new HttpClient()) {
				httpClient.DefaultRequestHeaders.Add ("Accept", "application/json");
				json = await httpClient.GetStringAsync (ConferencesApi);
			}

			if (!string.IsNullOrWhiteSpace (json)) {
				var conferences = await Task.Run (() => {
					return JsonConvert.DeserializeObject<List<Conference>>(json);
				});

				this.Conferences.Clear ();
				if (conferences != null && conferences.Any ()) {
					foreach (var conference in conferences) {
						this.Conferences.Add (conference);
					}
				}
			}

			IsBusy = false;
		}
	}
}
