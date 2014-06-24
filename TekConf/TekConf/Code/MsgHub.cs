using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace TekConf
{
	public class MsgHub
	{
		public static MsgHub Instance = new MsgHub();

		public static void Send<TArgs> (TArgs args) 
		{
			var msg = args.GetType ().Name;

			MessagingCenter.Send<MsgHub, TArgs> (Instance, msg, args);
		}

		public static void Subscribe<TArgs> (object subscriber, Action<TArgs> callback)
		{
			var msg = typeof(TArgs).Name;

			MessagingCenter.Subscribe<MsgHub, TArgs> (subscriber, msg, (s, a) => callback(a), Instance);
		}

		public static void Unsubscribe<TArgs> (object subscriber)
		{
			var msg = typeof(TArgs).Name;

			MessagingCenter.Unsubscribe<MsgHub, TArgs> (subscriber, msg);
		}
	}
}
