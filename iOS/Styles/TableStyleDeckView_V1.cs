using System;
using UIKit;

using MvvmCross.Binding.iOS.Views;

using FictionBox.UI.iOS.Styles;

namespace FictionBox.UI.iOS.Styles
{
	public class TableStyleDeckView_V1 : TableStyle, ITableStyle
	{
		public TableStyleDeckView_V1()
		{
			GeneratedTableStyleEnum = TableStyleEnum.DECK_VIEW_V1;
			generateTableBackground();
			generateTableSelectedBackground();
		}

		public void generateTableStyle(UITableView tableview)
		{
			tableview.RowHeight = UITableView.AutomaticDimension;
			tableview.EstimatedRowHeight = 180.0f;
			tableview.BackgroundColor = UIColor.Brown;
			tableview.SetEditing(false, false);
			tableview.BackgroundColor = UIColor.FromPatternImage(TableBackgroundImage);

			tableview.SeparatorStyle = UITableViewCellSeparatorStyle.None;
		}

		public void generateTableBackground()
		{
			TableBackgroundImage = UIImage.FromFile("visit-twin-peaks-prints.jpg");
		}

		public void generateTableSelectedBackground()
		{
		}
	}
}
