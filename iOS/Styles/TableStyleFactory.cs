using System;
using System.Collections.Generic;
using UIKit;

using MvvmCross.Binding.iOS.Views;

namespace FictionBox.UI.iOS.Styles
{
	public enum TableStyleEnum { NONE = -1, DECK_VIEW_V1 = 1 };

	static public class TableStyleFactory
	{
		static private Dictionary<TableStyleEnum, TableStyle> tableStyleDict;

		static TableStyleFactory()
		{
			tableStyleDict = new Dictionary<TableStyleEnum, TableStyle>();
		}

		static public ITableStyle createTableStyle(TableStyleEnum tableStyleEnum)
		{
			TableStyle tableStyle = null;

			// Check for value and fill tableStyle if found. If not found, generate the TableStyle.
			if (!tableStyleDict.TryGetValue(tableStyleEnum, out tableStyle))
			{
				switch (tableStyleEnum)
				{
					case TableStyleEnum.DECK_VIEW_V1:
						tableStyle = new TableStyleDeckView_V1();
						break;
				}

				tableStyleDict.Add(tableStyleEnum, tableStyle);
			}

			return tableStyle as ITableStyle;
		}
	}
}
