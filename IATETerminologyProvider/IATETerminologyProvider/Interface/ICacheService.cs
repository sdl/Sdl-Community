﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sdl.Community.IATETerminologyProvider.Model;
using Sdl.Terminology.TerminologyProvider.Core;

namespace Sdl.Community.IATETerminologyProvider.Interface
{
	public interface ICacheService:IDisposable
	{
		Task<List<ISearchResult>> GetCachedResults(string sourceText, string targetLanguage, string bodyModelString);
		IEnumerable<SearchCache> GetAllCachedResults();
		Task AddSearchResults(SearchCache searchCache,List<ISearchResult> iateSearchResult);	
		Task ClearCachedResults();
		bool IsDbConnected();
	}
}
