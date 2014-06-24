using System;
using Xamarin.Forms;

namespace TekConf
{
	public class RootPage : MasterDetailPage
	{
		public RootPage ()
		{
			MsgHub.Subscribe<CloseModalMessage> (this, async (nav) => {
				await this.Detail.Navigation.PopModalAsync();

			});

			MsgHub.Subscribe<MenuNavigationMessage> (this, async (nav) => {
				if (nav.Page is ModalPage) {
					await this.Detail.Navigation.PushModalAsync(nav.Page);
				} else {
					var page = nav.Page;
					var detail = new NavigationPage(page);
					this.Detail = detail;
				}
				this.IsPresented = false;
			});

			this.Master = new MenuPage ();
			this.Detail = new NavigationPage (new ConferencesPage ());
			this.IsGestureEnabled = false;
		}
	}
}