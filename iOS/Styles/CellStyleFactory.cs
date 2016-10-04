using System;
using System.Collections.Generic;
using UIKit;

using MvvmCross.Binding.iOS.Views;

namespace FictionBox.UI.iOS.Styles
{
	public enum CellStyleEnum { NONE = -1, DECK_VIEW_V1 = 101 };

	static public class CellStyleFactory
	{
		static private Dictionary<CellStyleEnum, CellStyle> cellStyleDict;

		static CellStyleFactory()
		{
			cellStyleDict = new Dictionary<CellStyleEnum, CellStyle>();
		}

		static public ICellStyle createCellStyle(CellStyleEnum cellStyleEnum)
		{
			CellStyle cellStyle = null;

			// Check for value and fill cellStyle if found. If not found, generate the CellStyle.
			if (!cellStyleDict.TryGetValue(cellStyleEnum, out cellStyle))
			{

				switch (cellStyleEnum)
				{
					case CellStyleEnum.DECK_VIEW_V1:
						cellStyle = new CellStyleDeckView_V1();
						cellStyleDict.Add(cellStyleEnum, cellStyle);
						break;
				}
			}

			return cellStyle as ICellStyle;
		}
	}
}
