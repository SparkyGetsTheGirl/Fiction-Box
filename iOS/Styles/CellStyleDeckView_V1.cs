using System;
using UIKit;

using MvvmCross.Binding.iOS.Views;

using FictionBox.UI.iOS.Styles;

namespace FictionBox.UI.iOS.Styles
{
	public class CellStyleDeckView_V1 : CellStyle, ICellStyle
	{
		public CellStyleDeckView_V1()
		{
			GeneratedCellStyleEnum = CellStyleEnum.DECK_VIEW_V1;
			generateCellSelectedBackground();
		}

		public void generateCellStyle(MvxTableViewCell cell)
		{
			cell.BackgroundColor = UIColor.Clear;

			cell.ContentView.Layer.CornerRadius = 20;
			cell.ContentView.Layer.BorderWidth = 1;
			cell.ContentView.Layer.MasksToBounds = true;
			cell.ContentView.Layer.ShadowColor = UIColor.Clear.CGColor;
			cell.ContentView.Layer.BackgroundColor = UIColor.White.CGColor;

			if (cell.SelectedBackgroundView == null)
			{
				cell.SelectedBackgroundView = CellSelectedBackgroundView;
			}
			cell.SelectedBackgroundView.Layer.CornerRadius = 20;
			cell.SelectedBackgroundView.Layer.BorderWidth = 1;
			cell.SelectedBackgroundView.Layer.MasksToBounds = true;
			cell.SelectedBackgroundView.Layer.ShadowColor = UIColor.Clear.CGColor;
			cell.SelectedBackgroundView.Layer.BackgroundColor = UIColor.White.CGColor;
		}

		public void generateCellSelectedBackground()
		{
			CellSelectedBackgroundView = new UIImageView() { BackgroundColor = UIColor.Clear };
		}
	}
}
