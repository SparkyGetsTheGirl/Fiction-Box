using System;
using System.Reflection;
using Newtonsoft.Json.Linq;
using FictionBox.Core.Utilities;

namespace FictionBox.Core.Utilities
{
	public static class JsonLoader
	{
		public static JArray loadJsonFromFileResourceString(String resourceString)
		{
			var assembly = typeof(ResourceLoader).GetTypeInfo().Assembly;
			String currentResourceContentString = ResourceLoader.GetEmbeddedResourceString(assembly, resourceString);
			return JsonLoader.loadJsonFromString(currentResourceContentString);
		}

		public static JArray loadJsonFromString(String jsonString)
		{
			return JArray.Parse(jsonString);
		}
	}
}
