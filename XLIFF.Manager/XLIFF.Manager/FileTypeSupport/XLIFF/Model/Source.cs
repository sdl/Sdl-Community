﻿using System.Collections.Generic;

namespace Sdl.Community.XLIFF.Manager.FileTypeSupport.XLIFF.Model
{
	public class Source : Segment
	{
		public Source()
		{
			Elements = new List<Element>();			
		}

		public string Id { get; set; }
	}
}
