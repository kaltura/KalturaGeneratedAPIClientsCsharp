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

	public class KalturaExternalMediaService : KalturaServiceBase
	{
	public KalturaExternalMediaService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaExternalMediaEntry Add(KalturaExternalMediaEntry entry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entry", entry);
			_Client.QueueServiceCall("externalmedia_externalmedia", "add", "KalturaExternalMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaExternalMediaEntry)KalturaObjectFactory.Create(result, "KalturaExternalMediaEntry");
		}

		public KalturaExternalMediaEntry Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("externalmedia_externalmedia", "get", "KalturaExternalMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaExternalMediaEntry)KalturaObjectFactory.Create(result, "KalturaExternalMediaEntry");
		}

		public KalturaExternalMediaEntry Update(string id, KalturaExternalMediaEntry entry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("entry", entry);
			_Client.QueueServiceCall("externalmedia_externalmedia", "update", "KalturaExternalMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaExternalMediaEntry)KalturaObjectFactory.Create(result, "KalturaExternalMediaEntry");
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("externalmedia_externalmedia", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaExternalMediaEntryListResponse List()
		{
			return this.List(null);
		}

		public KalturaExternalMediaEntryListResponse List(KalturaExternalMediaEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaExternalMediaEntryListResponse List(KalturaExternalMediaEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("externalmedia_externalmedia", "list", "KalturaExternalMediaEntryListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaExternalMediaEntryListResponse)KalturaObjectFactory.Create(result, "KalturaExternalMediaEntryListResponse");
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaExternalMediaEntryFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			_Client.QueueServiceCall("externalmedia_externalmedia", "count", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}
	}
}
