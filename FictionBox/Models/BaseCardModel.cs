using System;
using System.Collections.Generic;

namespace FictionBox.Core
{
	public class BaseCardModel : IBaseCardModel
	{
		public String Title { get; set; }
		public String Subtitle { get; set; }
		public String Property { get; set; }
		public List<String> OptionList { get; set; }

	}
}
