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
			foreach (Type styleEnumType in StyleConstants.constantEnums)
			{
			    Array cellEnumValues = Enum.GetValues(styleEnumType);
				var methodInfo = typeof(StyleConstants).GetMethod("GetList");
				var genericMethod = methodInfo.MakeGenericMethod(styleEnumType);
				var genericEnumDataItem = genericMethod.Invoke(null, null);
				            
				foreach (EnumDataItem genericEnumDateItem in (genericEnumDataItem as EnumDataItemList))
				{
					StyleConstants.generateConstants(genericEnumDateItem);
				}
			}
		}

		public static bool Compare(object enumLoop, object enumConstant)
		{
			return ((int)enumLoop == (int)enumConstant ? true : false);
		}
		private static EnumDataItemList GetList<T>() where T : struct
		{
			EnumDataItemList items = new EnumDataItemList();
			foreach (int e in Enum.GetValues(typeof(T)))
			{
				EnumDataItem item = new EnumDataItem();
				item.Name = Enum.GetName(typeof(T), e);
				item.Value = e;
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
			foreach (object[] objectTuple in constantArray)
			{
				enumConstantDict.Add(objectTuple[0] as String, objectTuple[1]);
			}

			addConstantDict(enumValue, enumConstantDict);
		}

		private static void addConstantDict(int enumValue, Dictionary<String, object> enumConstantDict)
		{

		}

		private static Dictionary<String, object> getConstantDict(int enumValue)
		{
			Dictionary<String, object> enumConstantDictionary = null;
			if (!(constantDictionary.TryGetValue(enumValue, out enumConstantDictionary)))
			{
				enumConstantDictionary = new Dictionary<String, object>();
			}
			return enumConstantDictionary;
		}
	}
}
