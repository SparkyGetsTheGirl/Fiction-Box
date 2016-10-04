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
			EnumValue = (int)TableStyleEnum.DECK_VIEW_V1;
			StyleDict = StyleConstants.constantDictionary[EnumValue];
			Init();
		}

		public void Init()
		{
			generateTableBackground();
			generateTableSelectedBackground();
		}

		public override void generateTableStyle(UITableView tableview)
		{
			tableview.RowHeight = (nfloat)StyleDict["RowHeight"]; 
			tableview.SeparatorStyle = (UITableViewCellSeparatorStyle)StyleDict["SeparatorStyle"];
			tableview.EstimatedRowHeight = (float)StyleDict["EstimatedRowHeight"];
			tableview.BackgroundColor = UIColor.FromPatternImage(TableBackgroundImage);
			tableview.SetEditing(false, false);
		}

		public override void generateTableBackground()
		{
			TableBackgroundImage = UIImage.FromFile(
				(String)StyleDict["TableBackgroundImageFilename"]
			);
		}

		public override void generateTableSelectedBackground()
		{
		}
	}
}
