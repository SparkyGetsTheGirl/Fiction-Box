using System;
using UIKit;

using MvvmCross.Binding.iOS.Views;

namespace FictionBox.UI.iOS.Styles
{
	public interface ITableStyle
	{
		void generateTableStyle(UITableView tableview);
		void generateTableBackground();
		void generateTableSelectedBackground();
	}
}
