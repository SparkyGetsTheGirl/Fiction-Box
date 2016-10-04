using System;
using UIKit;

using MvvmCross.Binding.iOS.Views;

namespace FictionBox.UI.iOS.Styles
{
	public interface ICellStyle
	{
		void generateCellStyle(MvxTableViewCell cell);
		void generateCellSelectedBackground();
	}
}
