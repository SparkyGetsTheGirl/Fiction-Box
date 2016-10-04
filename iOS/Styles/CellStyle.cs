using System;
using UIKit;

using MvvmCross.Binding.iOS.Views;

namespace FictionBox.UI.iOS.Styles
{
	public class CellStyle
	{
		UIImageView _selectedBackgroundView;
		CellStyleEnum _generatedCellStyleEnum;

		public UIImageView CellSelectedBackgroundView
		{
			get
			{
				return _selectedBackgroundView;
			}
			set
			{
				_selectedBackgroundView = value;
			}
		}

		public CellStyleEnum GeneratedCellStyleEnum
		{
			get
			{
				return _generatedCellStyleEnum;
			}
			set
			{
				_generatedCellStyleEnum = value;
			}
		}

		public CellStyle()
		{
			GeneratedCellStyleEnum = CellStyleEnum.NONE;
			CellSelectedBackgroundView = null;

		}

		virtual public void generateCellStyle(MvxTableViewCell cell)
		{
			
		}

		virtual public void generateCellSelectedBackground()
		{
		}
	}
}
