using System;
using Xamarin.Forms;
using TekConf.Models;

namespace TekConf
{
	public static class Extensions
	{
		public static ScrollView Scroll(this StackLayout stackLayout)
		{
			return new ScrollView { Content = stackLayout };
		}
	}
	
}