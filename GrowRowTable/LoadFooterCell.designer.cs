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

namespace GrowRowTable
{
	[Register ("LoadFooterCell")]
	partial class LoadFooterCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel NoMoreItemsLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIActivityIndicatorView Spinner { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (NoMoreItemsLabel != null) {
				NoMoreItemsLabel.Dispose ();
				NoMoreItemsLabel = null;
			}
			if (Spinner != null) {
				Spinner.Dispose ();
				Spinner = null;
			}
		}
	}
}
