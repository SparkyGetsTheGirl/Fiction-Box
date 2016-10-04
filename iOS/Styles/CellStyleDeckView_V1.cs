using System;
using UIKit;
using CoreGraphics;
using Cirrious.FluentLayouts.Touch;

using MvvmCross.Binding.iOS.Views;

using FictionBox.UI.iOS.Styles;
using FictionBox.UI.iOS.Cells;

namespace FictionBox.UI.iOS.Styles
{
	public class CellStyleDeckView_V1 : CellStyle, ICellStyle
	{
		public CellStyleDeckView_V1()
		{
			GeneratedCellStyleEnum = CellStyleEnum.DECK_VIEW_V1;
			EnumValue = (int)CellStyleEnum.DECK_VIEW_V1;
			StyleDict = StyleConstants.constantDictionary[EnumValue];
			CellType = typeof(BaseJotCell);
			Init();
		}

		public void Init()
		{
			generateCellSelectedBackground();
		}

		public override void generateCellStyle(MvxTableViewCell cell)
		{
			cell.BackgroundColor = (UIColor)StyleDict["BackgroundColor"];

			cell.ContentView.Layer.CornerRadius = (float)StyleDict["ContentView.Layer.CornerRadius"];
			cell.ContentView.Layer.BorderWidth = (float)StyleDict["ContentView.Layer.BorderWidth"];
			cell.ContentView.Layer.MasksToBounds = (bool)StyleDict["ContentView.Layer.MasksToBounds"];
			cell.ContentView.Layer.ShadowColor = (CGColor)StyleDict["ContentView.Layer.ShadowColor"];
			cell.ContentView.Layer.BackgroundColor = (CGColor)StyleDict["ContentView.Layer.BackgroundColor"];

			if (cell.SelectedBackgroundView == null)
			{
				cell.SelectedBackgroundView = CellSelectedBackgroundView;
			}
			cell.SelectedBackgroundView.Layer.CornerRadius = (float)StyleDict["ContentView.Layer.CornerRadius"];
			cell.SelectedBackgroundView.Layer.BorderWidth = (float)StyleDict["ContentView.Layer.BorderWidth"];
			cell.SelectedBackgroundView.Layer.MasksToBounds = (bool)StyleDict["ContentView.Layer.MasksToBounds"];
			cell.SelectedBackgroundView.Layer.ShadowColor = (CGColor)StyleDict["ContentView.Layer.ShadowColor"];
			cell.SelectedBackgroundView.Layer.BackgroundColor = (CGColor)StyleDict["ContentView.Layer.BackgroundColor"];
		}

		public override void attachCellStyleConstraint(MvxTableViewCell cell)
		{
			var ContentView = cell.ContentView;

			// These connect the UI eleemts with the styles
			var title = (CellType.GetProperty("TitleLabel").GetValue(cell, null)) as UILabel;
			var subtitle = (CellType.GetProperty("SubtitleLabel").GetValue(cell, null)) as UILabel;
			var property = (CellType.GetProperty("PropertyLabel").GetValue(cell, null)) as UILabel;

			ContentView.AddConstraints(
				title.AtTopOf(ContentView, 10.0f),
				title.AtRightOf(ContentView, 10.0f),
				title.AtLeftOf(ContentView, 10.0f),

				subtitle.Below(title, 10.0f),
				subtitle.AtRightOf(ContentView, 10.0f),
				subtitle.AtLeftOf(ContentView, 10.0f),

				property.Below(subtitle, 10.0f),
				property.AtRightOf(ContentView, 10.0f),
				property.AtLeftOf(ContentView, 10.0f),
				property.AtBottomOf(ContentView, 10.0f)
			);
		}

		public override void generateCellSelectedBackground()
		{
			CellSelectedBackgroundView = new UIImageView() { 
				BackgroundColor = (UIColor)StyleDict["CellSelectedBackgroundView.BackgroundColor"]
			};
		}
	}
}
