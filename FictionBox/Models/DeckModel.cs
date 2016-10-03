using System;
using System.Collections.Generic;
<<<<<<< HEAD

=======
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
namespace FictionBox.Core.Models
{
	public class DeckModel : IDeckModel
	{
<<<<<<< HEAD
		public List<BaseCardModel> Cards { get; set; }
=======
		public List<IBaseCardModel> Cards { get; set; }
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
		public String Name { get; set; }

		public DeckModel()
		{
<<<<<<< HEAD
			Cards = new List<BaseCardModel>();
=======
			Cards = new List<IBaseCardModel>();
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
		}

		public override string ToString()
		{
			var outputString = "";

			foreach (BaseCardModel card in Cards)
			{
				outputString += (card.Title + "\n");
			}

			return string.Format("[DeckModel: Cards={0} Titles={1}]", Cards, outputString);
		}
	}
}
