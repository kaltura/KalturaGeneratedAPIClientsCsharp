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

namespace Kaltura
{

	public class KalturaSyndicationFeedService : KalturaServiceBase
	{
	public KalturaSyndicationFeedService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaBaseSyndicationFeed Add(KalturaBaseSyndicationFeed syndicationFeed)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("syndicationFeed", syndicationFeed);
			_Client.QueueServiceCall("syndicationfeed", "add", "KalturaBaseSyndicationFeed", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseSyndicationFeed)KalturaObjectFactory.Create(result, "KalturaBaseSyndicationFeed");
		}

		public KalturaBaseSyndicationFeed Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("syndicationfeed", "get", "KalturaBaseSyndicationFeed", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseSyndicationFeed)KalturaObjectFactory.Create(result, "KalturaBaseSyndicationFeed");
		}

		public KalturaBaseSyndicationFeed Update(string id, KalturaBaseSyndicationFeed syndicationFeed)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("syndicationFeed", syndicationFeed);
			_Client.QueueServiceCall("syndicationfeed", "update", "KalturaBaseSyndicationFeed", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseSyndicationFeed)KalturaObjectFactory.Create(result, "KalturaBaseSyndicationFeed");
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("syndicationfeed", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaBaseSyndicationFeedListResponse List()
		{
			return this.List(null);
		}

		public KalturaBaseSyndicationFeedListResponse List(KalturaBaseSyndicationFeedFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaBaseSyndicationFeedListResponse List(KalturaBaseSyndicationFeedFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("syndicationfeed", "list", "KalturaBaseSyndicationFeedListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseSyndicationFeedListResponse)KalturaObjectFactory.Create(result, "KalturaBaseSyndicationFeedListResponse");
		}

		public KalturaSyndicationFeedEntryCount GetEntryCount(string feedId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("feedId", feedId);
			_Client.QueueServiceCall("syndicationfeed", "getEntryCount", "KalturaSyndicationFeedEntryCount", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSyndicationFeedEntryCount)KalturaObjectFactory.Create(result, "KalturaSyndicationFeedEntryCount");
		}

		public string RequestConversion(string feedId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("feedId", feedId);
			_Client.QueueServiceCall("syndicationfeed", "requestConversion", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
