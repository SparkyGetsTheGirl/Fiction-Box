using System;
using System.Collections.Generic;

namespace FictionBox.UI.iOS.Styles
{
	public class EnumDataItemList : List<EnumDataItem>
	{
	}

	public class EnumDataItem
	{
		private String _name;
		private String _className;
		private int _value;

		public String Name
		{
			get
			{
				return _name;
			}

			set
			{
				_name = value;
			}
		}

		public String ClassName
		{
			get
			{
				return _className;
			}

			set
			{
				_className = value;
			}
		}

		public int Value
		{
			get
			{
				return _value;
			}

			set
			{
				_value = value;
			}
		}

		public Type Type
		{
			get
			{
				if (_className != null)
					return Type.GetType(_className);
				else
					return null;
			}
		}
	}
}

