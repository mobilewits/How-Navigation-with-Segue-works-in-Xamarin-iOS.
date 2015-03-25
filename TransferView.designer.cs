// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NavigationSegue.iOS
{
	[Register ("TransferView")]
	partial class TransferView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl_data { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lbl_data != null) {
				lbl_data.Dispose ();
				lbl_data = null;
			}
		}
	}
}
