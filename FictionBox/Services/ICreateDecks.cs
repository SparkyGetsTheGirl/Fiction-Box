<<<<<<< HEAD
<<<<<<< HEAD
﻿using System.Collections.Generic;
using FictionBox.Core.Models;

namespace FictionBox.Core.Services
{
	public interface ICreateDecks
	{
		List<DeckModel> loadDecksFromResources();
=======
=======
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
﻿namespace FictionBox.Core.Services
{
	public interface ICreateDecks
	{
		void loadDecksFromResources();
<<<<<<< HEAD
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
=======
>>>>>>> 5ff3b118b39d99fb9b8044aa9b772842f14f6833
		void loadDecksFromDB();
	}
}
