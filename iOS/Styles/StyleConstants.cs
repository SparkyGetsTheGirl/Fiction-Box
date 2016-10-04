using System;
using System.Collections.Generic;

namespace FictionBox.UI.iOS.Styles
{

	static public class StyleConstants
	{
		static Type[] constantEnums = { typeof(CellStyleEnum), typeof(TableStyleEnum) };

		public static Dictionary<int, Dictionary<String, object>> constantDictionary;

		static StyleConstants()
		{
			StyleConstants.constantDictionary = new Dictionary<int, Dictionary<String, object>>();

			foreach (Type styleEnumType in StyleConstants.constantEnums)
			{
			    Array cellEnumValues = Enum.GetValues(styleEnumType);
				var methodInfo = typeof(StyleConstants).GetMethod("GetList");
				var genericMethod = methodInfo.MakeGenericMethod(styleEnumType);
				var genericEnumDataItemList = genericMethod.Invoke(null, null);
				      
				foreach (EnumDataItem genericEnumDataItem in (genericEnumDataItemList as EnumDataItemList))
				{
					StyleConstants.generateConstants(genericEnumDataItem);
				}
			}
		}

		public static bool Compare(object enumLoop, object enumConstant)
		{
			return (((int)enumLoop == (int)enumConstant) ? true : false);
		}

		public static EnumDataItemList GetList<T>() where T : struct
		{
			EnumDataItemList items = new EnumDataItemList();
			foreach (int e in Enum.GetValues(typeof(T)))
			{
				EnumDataItem item = new EnumDataItem();
				item.Name = Enum.GetName(typeof(T), e);
				item.ClassName = typeof(T).FullName;
				item.Value = e;
				items.Add(item);
			}

			return items;
		}

		private static void generateConstants(EnumDataItem genericEnum)
		{
			var typedEnum = Enum.Parse(genericEnum.Type, genericEnum.Name);
			var enumValue = genericEnum.Value;
			var enumConstantDict = getConstantDict(enumValue);

			// Cell constant styles
			if (Compare(typedEnum, CellStyleEnum.DECK_VIEW_V1))
			{
				AddConstants(enumValue, enumConstantDict, StyleConstantsDefinitions.getCellDeckView_V1);
			}

			// Table constant styles
			if (Compare(typedEnum, TableStyleEnum.DECK_VIEW_V1))
			{
				AddConstants(enumValue, enumConstantDict, StyleConstantsDefinitions.getTableDeckView_V1);
			}
		}

		private static void AddConstants(int enumValue, Dictionary<String, object> enumConstantDict, Func<object[,]> getConstants)
		{
			object[,] constantArray = getConstants();
			for (int x = 0; x < constantArray.GetLength(0); x += 1)
			{
				enumConstantDict.Add(constantArray[x,0] as String, constantArray[x,1]);
			}

			updateConstantDict(enumValue, enumConstantDict);
		}

		private static void updateConstantDict(int enumValue, Dictionary<String, object> enumConstantDict)
		{
			StyleConstants.constantDictionary[enumValue] = enumConstantDict;
		}

		private static Dictionary<String, object> getConstantDict(int enumValue)
		{
			Dictionary<String, object> enumConstantDictionary = new Dictionary<String, object>();
			if (!(StyleConstants.constantDictionary.TryGetValue(enumValue, out enumConstantDictionary)))
			{
				enumConstantDictionary = new Dictionary<String, object>();
			}
			return enumConstantDictionary;
		}
	}
}
