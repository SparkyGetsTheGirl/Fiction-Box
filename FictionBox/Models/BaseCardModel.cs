using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace FictionBox.Core.Models
=======
namespace FictionBox.Core
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
{
	public class BaseCardModel : IBaseCardModel
	{
		public String Title { get; set; }
		public String Subtitle { get; set; }
		public String Property { get; set; }
		public List<String> OptionList { get; set; }

	}
}
