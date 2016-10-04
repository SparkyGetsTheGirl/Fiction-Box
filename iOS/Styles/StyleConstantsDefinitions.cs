using System;
using UIKit;

namespace FictionBox.UI.iOS.Styles
{
	static public class StyleConstantsDefinitions
	{
		static public object[,] getCellDeckView_V1()
		{
			return new object[,] {
				{ "BackgroundColor", UIColor.Clear },
				{ "CellSelectedBackgroundView.BackgroundColor", UIColor.Clear },
				{ "ContentView.Layer.CornerRadius", 20.0f},
				{ "ContentView.Layer.BorderWidth", 1.0f },
				{ "ContentView.Layer.MasksToBounds", true },
				{ "ContentView.Layer.ShadowColor", UIColor.Clear.CGColor },
				{ "ContentView.Layer.BackgroundColor", UIColor.White.CGColor },
			};
		}

		static public object[,] getTableDeckView_V1()
		{
			return new object[,] {
				{ "TableBackgroundImageFilename", "visit-twin-peaks-prints.jpg" },
				{ "EstimatedRowHeight", 180.0f },
				{ "RowHeight", UITableView.AutomaticDimension },
				{ "SeparatorStyle", UITableViewCellSeparatorStyle.None }
			};
		}
	}
}
