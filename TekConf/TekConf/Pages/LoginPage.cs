using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TekConf
{
	public class LoginPage : ModalPage
	{
		public LoginPage ()
		{
			this.BackgroundColor = Color.White;

			var button = new Button () {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Text = "Close Modal"
			};

			button.Clicked += (sender, e) => {
				MsgHub.Send<CloseModalMessage>(new CloseModalMessage());
			};

			this.Content = button;
		}
	}

}
