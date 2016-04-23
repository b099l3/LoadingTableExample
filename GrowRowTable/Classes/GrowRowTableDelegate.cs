using System;
using UIKit;
using Foundation;
using System.Threading.Tasks;

namespace GrowRowTable
{
	public class GrowRowTableDelegate : UITableViewDelegate
	{
		#region Private Variables
		private GrowRowTableViewController Controller;
		public bool FullyLoaded;
		#endregion

		#region Constructors
		public GrowRowTableDelegate ()
		{
		}

		public GrowRowTableDelegate (GrowRowTableViewController controller)
		{
			// Initialize
			this.Controller = controller;
		}
		#endregion

		#region Override Methods
		public override nfloat EstimatedHeight (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 40f;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			// Output selected row
			Console.WriteLine("Row selected: {0}",indexPath.Row);
		}

		public override void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			// if showing last row of last section, load more
			if (indexPath.Section == tableView.NumberOfSections()-1 && indexPath.Row == tableView.DataSource.RowsInSection(tableView, indexPath.Section)-1 && !FullyLoaded) {
				var growRowSource = tableView.DataSource as GrowRowTableDataSource;
				if (growRowSource != null) {
					FullyLoaded = growRowSource.LoadNextPage ();
					Task.Delay (5000);
					tableView.ReloadData ();	
				}

			}
		}
		#endregion
	}
}

