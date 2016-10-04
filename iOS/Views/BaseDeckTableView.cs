using System.Collections.Generic;
using UIKit;
using Foundation;
using CoreGraphics;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

using FictionBox.Core.ViewModels;
using FictionBox.UI.iOS.Cells;
using FictionBox.UI.iOS.Styles;

namespace FictionBox.UI.iOS.Views
{
	public class BaseDeckTableView
		: MvxTableViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			TableView = new UITableView(new CGRect(), UITableViewStyle.Grouped);

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

			TableStyleFactory.createTableStyle(TableStyleEnum.DECK_VIEW_V1).generateTableStyle(TableView);

			TableView.Source = source;
			TableView.ReloadData();
		}

		// Need to tap this into the current size of the Deck
		public override System.nint NumberOfSections(UITableView tableView)
		{
			return 3;
		}

		public override System.nint RowsInSection(UITableView tableView, System.nint section)
		{
			return 1;
		}

		public override System.nfloat GetHeightForFooter(UITableView tableView, System.nint section)
		{
			return 50.0f;
		}

		public override UIView GetViewForHeader(UITableView tableView, System.nint section)
		{
			var view = new UIView();
			view.BackgroundColor = UIColor.Clear;
			return view;
		}

		/*- (NSInteger)numberOfSectionsInTableView:(UITableView*)tableView{
		    //array is your db, here we just need how many they are
		    return [array count];
		}
		- (NSInteger)tableView:(UITableView*)tableView numberOfRowsInSection:(NSInteger)section{
		    return 1;
		}
		- (UITableViewCell*)tableView:(UITableView*)tableView cellForRowAtIndexPath:(NSIndexPath*)indexPath{
		    //place your image to cell
		}
		- (float)tableView:(UITableView*)tableView heightForFooterInSection:(NSInteger)section{
		    //this is the space
		    return 50;
		}*/

		public class TableSource : MvxTableViewSource
		{
			public TableSource(UITableView tableView): base(tableView)
			{
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
				CellStyleFactory.createCellStyle(CellStyleEnum.DECK_VIEW_V1).generateCellStyle(cell);

				return cell;
			}
		}
	}
}