using System;
using Newtonsoft.Json.Linq;
using FictionBox.Core.Models;

namespace FictionBox.Core.TemplateParser
{
	public abstract class TemplateParserFactory
	{
		public abstract BaseCardModel ParseTemplatedCard(JToken jsonCard);
	}
}
