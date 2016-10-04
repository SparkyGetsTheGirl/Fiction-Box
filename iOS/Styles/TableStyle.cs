using System;
using UIKit;

using MvvmCross.Binding.iOS.Views;

namespace FictionBox.UI.iOS.Styles
{
	public class TableStyle
	{
		UIImageView _selectedBackgroundView;
		UIImage _backgroundImage;
		TableStyleEnum _generatedTableStyleEnum;

		public UIImageView TableSelectedBackgroundView
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

		public UIImage TableBackgroundImage
		{
			get
			{
				return _backgroundImage;
			}
			set
			{
				_backgroundImage = value;
			}
		}

		public TableStyleEnum GeneratedTableStyleEnum
		{
			get
			{
				return _generatedTableStyleEnum;
			}
			set
			{
				_generatedTableStyleEnum = value;
			}
		}

		public TableStyle()
		{
			GeneratedTableStyleEnum = TableStyleEnum.NONE;
			TableSelectedBackgroundView = null;
			TableBackgroundImage = null;
		}

		virtual public void generateTableStyle(UITableView tableview)
		{
		}

		virtual public void generateTableBackground()
		{
		}

		virtual public void generateTableSelectedBackground()
		{
		}
	}
}
