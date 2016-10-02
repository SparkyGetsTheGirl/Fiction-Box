using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FictionBox.Core.Json
{
	public class JsonTemplate1
	{
		[JsonProperty(PropertyName = "count")]
		public String Count { get; set; }
		[JsonProperty(PropertyName = "title")]
		public String Title { get; set; }
		[JsonProperty(PropertyName = "contents")]
		public List<String> Contents { get; set; }
		[JsonProperty(PropertyName = "tags")]
		public List<String> Tags { get; set; } 
		[JsonProperty(PropertyName = "color")]
		public String Color { get; set; }
		[JsonProperty(PropertyName = "icon")]
    	public String Icon { get; set; }
		[JsonProperty(PropertyName = "title_size")]
		public String TitleSize { get; set; }
	}
}
