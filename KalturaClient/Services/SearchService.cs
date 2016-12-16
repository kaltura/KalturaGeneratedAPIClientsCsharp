// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2016  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class SearchSearchRequestBuilder : RequestBuilder<SearchResultResponse>
	{
		#region Constants
		public const string SEARCH = "search";
		public const string PAGER = "pager";
		#endregion

		public Search Search
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public SearchSearchRequestBuilder()
			: base("search", "search")
		{
		}

		public SearchSearchRequestBuilder(Search search, FilterPager pager)
			: this()
		{
			this.Search = search;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("search"))
				kparams.AddIfNotNull("search", Search);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<SearchResultResponse>(result);
		}
	}

	public class SearchGetMediaInfoRequestBuilder : RequestBuilder<SearchResult>
	{
		#region Constants
		public const string SEARCH_RESULT = "searchResult";
		#endregion

		public SearchResult SearchResult
		{
			set;
			get;
		}

		public SearchGetMediaInfoRequestBuilder()
			: base("search", "getMediaInfo")
		{
		}

		public SearchGetMediaInfoRequestBuilder(SearchResult searchResult)
			: this()
		{
			this.SearchResult = searchResult;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("searchResult"))
				kparams.AddIfNotNull("searchResult", SearchResult);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<SearchResult>(result);
		}
	}

	public class SearchSearchUrlRequestBuilder : RequestBuilder<SearchResult>
	{
		#region Constants
		public const string MEDIA_TYPE = "mediaType";
		public const string URL = "url";
		#endregion

		public MediaType MediaType
		{
			set;
			get;
		}
		public string Url
		{
			set;
			get;
		}

		public SearchSearchUrlRequestBuilder()
			: base("search", "searchUrl")
		{
		}

		public SearchSearchUrlRequestBuilder(MediaType mediaType, string url)
			: this()
		{
			this.MediaType = mediaType;
			this.Url = url;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mediaType"))
				kparams.AddIfNotNull("mediaType", MediaType);
			if (!isMapped("url"))
				kparams.AddIfNotNull("url", Url);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<SearchResult>(result);
		}
	}

	public class SearchExternalLoginRequestBuilder : RequestBuilder<SearchAuthData>
	{
		#region Constants
		public const string SEARCH_SOURCE = "searchSource";
		public const string USER_NAME = "userName";
		public const string PASSWORD = "password";
		#endregion

		public SearchProviderType SearchSource
		{
			set;
			get;
		}
		public string UserName
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}

		public SearchExternalLoginRequestBuilder()
			: base("search", "externalLogin")
		{
		}

		public SearchExternalLoginRequestBuilder(SearchProviderType searchSource, string userName, string password)
			: this()
		{
			this.SearchSource = searchSource;
			this.UserName = userName;
			this.Password = password;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("searchSource"))
				kparams.AddIfNotNull("searchSource", SearchSource);
			if (!isMapped("userName"))
				kparams.AddIfNotNull("userName", UserName);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<SearchAuthData>(result);
		}
	}


	public class SearchService
	{
		private SearchService()
		{
		}

		public static SearchSearchRequestBuilder Search(Search search, FilterPager pager = null)
		{
			return new SearchSearchRequestBuilder(search, pager);
		}

		public static SearchGetMediaInfoRequestBuilder GetMediaInfo(SearchResult searchResult)
		{
			return new SearchGetMediaInfoRequestBuilder(searchResult);
		}

		public static SearchSearchUrlRequestBuilder SearchUrl(MediaType mediaType, string url)
		{
			return new SearchSearchUrlRequestBuilder(mediaType, url);
		}

		public static SearchExternalLoginRequestBuilder ExternalLogin(SearchProviderType searchSource, string userName, string password)
		{
			return new SearchExternalLoginRequestBuilder(searchSource, userName, password);
		}
	}
}
