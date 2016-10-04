using System;
using System.Collections.Generic;
using UIKit;

using MvvmCross.Binding.iOS.Views;

namespace FictionBox.UI.iOS.Styles
{
	public class CellStyle
	{
		Type _cellType;
		UIImageView _selectedBackgroundView;
		CellStyleEnum _generatedCellStyleEnum;
		int _enumValue;
		Dictionary<String, object> _styleDictionary;

		public Dictionary<String, object> StyleDict
		{
			get
			{
				return _styleDictionary;
			}
			set
			{
				_styleDictionary = value;
			}
		}

		public Type CellType
		{
			get
			{
				return _cellType;
			}
			set
			{
				_cellType = value;
			}
		}

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

		public int EnumValue
		{
			get
			{
				return _enumValue;
			}
			set
			{
				_enumValue = value;
			}
		}

		public CellStyle()
		{
			GeneratedCellStyleEnum = CellStyleEnum.NONE;
			CellSelectedBackgroundView = null;
			EnumValue = -1;
			StyleDict = null;
		}

		virtual public void generateCellStyle(MvxTableViewCell cell)
		{
		}

		virtual public void attachCellStyleConstraint(MvxTableViewCell cell)
		{
		}

		virtual public void generateCellSelectedBackground()
		{
		}
	}
}
