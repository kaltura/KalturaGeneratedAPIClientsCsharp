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
// Copyright (C) 2006-2011  Kaltura Inc.
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

namespace Kaltura
{

	public class KalturaSearchService : KalturaServiceBase
	{
	public KalturaSearchService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaSearchResultResponse Search(KalturaSearch search)
		{
			return this.Search(search, null);
		}

		public KalturaSearchResultResponse Search(KalturaSearch search, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (search != null)
				kparams.Add("search", search.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("search", "search", "KalturaSearchResultResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSearchResultResponse)KalturaObjectFactory.Create(result, "KalturaSearchResultResponse");
		}

		public KalturaSearchResult GetMediaInfo(KalturaSearchResult searchResult)
		{
			KalturaParams kparams = new KalturaParams();
			if (searchResult != null)
				kparams.Add("searchResult", searchResult.ToParams());
			_Client.QueueServiceCall("search", "getMediaInfo", "KalturaSearchResult", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSearchResult)KalturaObjectFactory.Create(result, "KalturaSearchResult");
		}

		public KalturaSearchResult SearchUrl(KalturaMediaType mediaType, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("mediaType", mediaType);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("search", "searchUrl", "KalturaSearchResult", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSearchResult)KalturaObjectFactory.Create(result, "KalturaSearchResult");
		}

		public KalturaSearchAuthData ExternalLogin(KalturaSearchProviderType searchSource, string userName, string password)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("searchSource", searchSource);
			kparams.AddStringIfNotNull("userName", userName);
			kparams.AddStringIfNotNull("password", password);
			_Client.QueueServiceCall("search", "externalLogin", "KalturaSearchAuthData", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSearchAuthData)KalturaObjectFactory.Create(result, "KalturaSearchAuthData");
		}
	}
}
