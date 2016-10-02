using System;
using System.Collections.Generic;
namespace FictionBox.Core.Models
{
	public class DeckModel : IDeckModel
	{
		public List<IBaseCardModel> Cards { get; set; }
		public String Name { get; set; }

		public DeckModel()
		{
			Cards = new List<IBaseCardModel>();
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
