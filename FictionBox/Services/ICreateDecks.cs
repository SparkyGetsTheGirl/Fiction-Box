using System.Collections.Generic;
using FictionBox.Core.Models;

namespace FictionBox.Core.Services
{
	public interface ICreateDecks
	{
		List<DeckModel> loadDecksFromResources();
		void loadDecksFromDB();
	}
}
