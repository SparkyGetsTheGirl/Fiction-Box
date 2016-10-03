<<<<<<< HEAD
﻿using System.Collections.Generic;
using FictionBox.Core.Models;

namespace FictionBox.Core.Services
{
	public interface ICreateDecks
	{
		List<DeckModel> loadDecksFromResources();
=======
﻿namespace FictionBox.Core.Services
{
	public interface ICreateDecks
	{
		void loadDecksFromResources();
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
		void loadDecksFromDB();
	}
}
