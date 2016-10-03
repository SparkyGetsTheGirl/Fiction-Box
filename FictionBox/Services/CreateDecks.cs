using System;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using FictionBox.Core.Utilities;
using FictionBox.Core.Models;
using FictionBox.Core.Json;
using FictionBox.Core.TemplateParser;

namespace FictionBox.Core.Services
{
	public class CreateDecks : ICreateDecks
	{

		// Specifically for JSON files from EmbeddedResources. Will need a better way, perhaps via database.
		// We should create a factory with common interfaces instead of using the belwo List. One internally contains 
		// a list, the other contains a DB interface
		public List<DeckModel> loadDecksFromResources()
		{
			List<DeckModel> fictionBoxDecks = new List<DeckModel>();

			foreach (var deckResourceString in Constants.EMBEDDED_RESOURCES_DECK_ARRAY)
			{
				JArray currentJotDeckJson = JsonLoader.loadJsonFromFileResourceString(deckResourceString);
				var currentDeck = new DeckModel() { Name = deckResourceString };

				TemplateParserFactory templateParserFactory = null;

				// For now, this is how we determine a template (only use template1 for now). We're going to take care of 
				// figuring out templates on the media's side (seperate metadata file for .json files that contains the 
				// the template type for each card. In a database, we can also add this data to each card. We'll need 
				// some sort of media accessor class (factory) with common accessor functions.

				if (true)
				{
					templateParserFactory = new Template1ParserFactory();
				}

				foreach (var jsonCard in currentJotDeckJson)
				{
					BaseCardModel currentCardModel = templateParserFactory.ParseTemplatedCard(jsonCard);
					currentDeck.Cards.Add(currentCardModel);
				}

				System.Diagnostics.Debug.WriteLine(currentDeck);

				fictionBoxDecks.Add(currentDeck);
			}

			return fictionBoxDecks;
		}

		// Need to create FictionBoxDecks to replace the one in this class and add accessor functions. Need to 
		// instantiated DB accessor and attach it to the FictionBoxDecks, and then check for this when iterating,
		// searching, etc. We'll also need to create an SQLite DB on first load and import all the data. How will
		// we represent this data?
		public void loadDecksFromDB()
		{

		}
	}
}
