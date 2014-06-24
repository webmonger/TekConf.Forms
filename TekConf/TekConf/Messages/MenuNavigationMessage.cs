using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TekConf
{
	public class MenuNavigationMessage : IMessage
	{
		public Page Page { get; set; }
	}
}
