using System;

using Foundation;
using UIKit;

namespace GrowRowTable
{
	public partial class LoadFooterCell : UITableViewCell
	{
		private bool loading;
		public bool Loading {
			get { return loading; }
			set { loading = value;
					//set hidden values here
				if (loading) {
					Spinner.StartAnimating ();
					NoMoreItemsLabel.Hidden = true;
				} else {
					Spinner.StopAnimating ();
					NoMoreItemsLabel.Hidden = false;
				}
			}
		}

		public LoadFooterCell (IntPtr handle) : base (handle)
		{
		}
	}
}
