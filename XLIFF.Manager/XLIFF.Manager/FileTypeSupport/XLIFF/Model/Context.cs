﻿using System;
using System.Collections.Generic;

namespace Sdl.Community.XLIFF.Manager.FileTypeSupport.XLIFF.Model
{
	public class Context : ICloneable
	{
		public Context()
		{
			MetaData = new Dictionary<string, string>();
		}

		public string Id { get; set; }

		public string ContextType { get; set; }

		public string DisplayName { get; set; }

		public string Description { get; set; }

		public string DisplayCode { get; set; }

		public Dictionary<string, string> MetaData { get; set; }

		public object Clone()
		{
			var context = new Context
			{
				Id = Id,
				ContextType = ContextType,
				DisplayName = DisplayName,
				Description = Description,
				DisplayCode = DisplayCode
			};

			foreach (var item in MetaData)
			{
				context.MetaData.Add(item.Key, item.Value);
			}

			return context;
		}
	}
}
