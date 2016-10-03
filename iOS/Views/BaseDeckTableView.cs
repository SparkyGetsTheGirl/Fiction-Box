using System.Collections.Generic;
using UIKit;
using Foundation;
using CoreGraphics;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

using FictionBox.Core.ViewModels;
using FictionBox.UI.iOS.Cells;

namespace FictionBox.UI.iOS.Views
{
	public class BaseDeckTableView
		: MvxTableViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var source = new TableSource(TableView)
			{
				UseAnimations = true,
				AddAnimation = UITableViewRowAnimation.Left,
				RemoveAnimation = UITableViewRowAnimation.Right
			};

			this.AddBindings(new Dictionary<object, string>
				{
					// So do we change bindings based on which deck we're currently looking at?	
					{source, "ItemsSource FictionBoxDecks[0].Cards"}
			});

			TableView.RowHeight = UITableView.AutomaticDimension;
			TableView.EstimatedRowHeight = 180.0f;
			TableView.BackgroundColor = UIColor.Brown;
			TableView.SetEditing(false, false);
			TableView.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("visit-twin-peaks-prints.jpg"));

			TableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;

			TableView.Source = source;
			TableView.ReloadData();
		}

		public class TableSource : MvxTableViewSource
		{
			private UIImageView _selectedBackgroundView;

			public TableSource(UITableView tableView): base(tableView)
			{
				_selectedBackgroundView = new UIImageView() { BackgroundColor = UIColor.Clear };
				tableView.RegisterClassForCellReuse(typeof(BaseJotCell), new NSString("BaseJotCell"));
			}

			public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
			{
				return true;
			}

			public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
			{
				if (editingStyle == UITableViewCellEditingStyle.Delete)
				{
					// Delete the row from the data source
					tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
			    }   
			    else if (editingStyle == UITableViewCellEditingStyle.Insert) 
				{
			        // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
			    }   
			}

			protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
			{
				var cell = (BaseJotCell)tableView.DequeueReusableCell("BaseJotCell");
				//cell.SelectionStyle = UITableViewCellSelectionStyle.None;
				cell.BackgroundColor = UIColor.Clear;

				cell.ContentView.Layer.CornerRadius = 20;
				cell.ContentView.Layer.BorderWidth = 1;
				cell.ContentView.Layer.MasksToBounds = true;
				cell.ContentView.Layer.ShadowColor = UIColor.Clear.CGColor;
				cell.ContentView.Layer.BackgroundColor = UIColor.White.CGColor;

				if (cell.SelectedBackgroundView == null)
				{
					cell.SelectedBackgroundView = this._selectedBackgroundView;
				}
				cell.SelectedBackgroundView.Layer.CornerRadius = 20;
				cell.SelectedBackgroundView.Layer.BorderWidth = 1;
				cell.SelectedBackgroundView.Layer.MasksToBounds = true;
				cell.SelectedBackgroundView.Layer.ShadowColor = UIColor.Clear.CGColor;
				cell.SelectedBackgroundView.Layer.BackgroundColor = UIColor.White.CGColor;
				return cell;
			}
		}
	}
}