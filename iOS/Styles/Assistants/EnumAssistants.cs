using System;
using System.Collections.Generic;

namespace FictionBox.UI.iOS.Styles
{
	public class EnumDataItemList : List<EnumDataItem>
	{
	}

	public class EnumDataItem
	{
		String _name;
		int _value;

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
				if (_name != null)
					return Type.GetType(_name);
				else
					return null;
			}
		}
	}
}

