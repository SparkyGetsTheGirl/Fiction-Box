using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using FictionBox.Core.Json;
using FictionBox.Core.Models;

namespace FictionBox.Core.TemplateParser
{
	public class Template1ParserFactory : TemplateParserFactory
	{
		public Template1ParserFactory()
		{
		}

		override public BaseCardModel ParseTemplatedCard(JToken jsonCard)
		{
			var currentTemplateCard = jsonCard.ToObject<JsonTemplate1>();

			BaseCardModel currentCardModel = new BaseCardModel() { Title = currentTemplateCard.Title, OptionList = new List<String>() };

			var cardContents = currentTemplateCard.Contents;

			foreach (var entry in cardContents)
			{
				if (entry.Contains(Constants.TEMPLATE1_SUBTITLE_DESIGNATOR))
				{
					//currentCardModel.Subtitle = entry.Split('|')[1].Trim();
					currentCardModel.Subtitle = entry.Replace(Constants.TEMPLATE1_SUBTITLE_DESIGNATOR, "");
				}
				if (entry.Contains(Constants.TEMPLATE1_PROPERTY_DESIGNATOR))
				{
					//currentCardModel.Subtitle = entry.Split('|')[1].Trim();
					currentCardModel.Property = entry.Replace(Constants.TEMPLATE1_PROPERTY_DESIGNATOR, "");
				}
				if (entry.Contains(Constants.TEMPLATE1_OPTION_DESIGNATOR))
				{
					//currentCardModel.Subtitle = entry.Split('|')[1].Trim();
					currentCardModel.OptionList.Add(entry.Replace(Constants.TEMPLATE1_OPTION_DESIGNATOR, ""));
				}
			}

			return currentCardModel;
		}
	}
}
