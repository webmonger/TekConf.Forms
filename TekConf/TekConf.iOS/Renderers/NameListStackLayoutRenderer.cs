using System;
using Xamarin.Forms;
using TekConf;
using Xamarin.Forms.Platform.iOS;
using MonoTouch.UIKit;

namespace TekConf.iOS
{
	public class NameListStackLayoutRenderer : FrameRenderer
	{
		public override void Draw (System.Drawing.RectangleF rect)
		{
			base.Draw (rect);

//			using (var context = UIGraphics.GetCurrentContext()) {
//				context.SetFillColor (UIColor.Red);
//				context.SetStrokeColor (UIColor.Green);
//				context.SetLineWidth (5);
//			}
		}

	}

}

