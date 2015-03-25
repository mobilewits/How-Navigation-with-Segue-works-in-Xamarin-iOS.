using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NavigationSegue.iOS
{
	partial class NavigationSegue : UIViewController
	{
		public NavigationSegue (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}
		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);
			var transferdata = segue.DestinationViewController as TransferView;

			if (transferdata != null) {
				transferdata.data="Data from 1st view";
			}
		}
	}
}
