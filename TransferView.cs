using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NavigationSegue.iOS
{
	partial class TransferView : UIViewController
	{
		public string data;
		public TransferView (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			lbl_data.Text = data;
			Console.WriteLine ("Data"+data);
		}
	}
}
