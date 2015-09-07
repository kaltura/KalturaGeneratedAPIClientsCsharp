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
// Copyright (C) 2006-2015  Kaltura Inc.
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

	public class KalturaDataService : KalturaServiceBase
	{
	public KalturaDataService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDataEntry Add(KalturaDataEntry dataEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dataEntry", dataEntry);
			_Client.QueueServiceCall("data", "add", "KalturaDataEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDataEntry)KalturaObjectFactory.Create(result, "KalturaDataEntry");
		}

		public KalturaDataEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaDataEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("version", version);
			_Client.QueueServiceCall("data", "get", "KalturaDataEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDataEntry)KalturaObjectFactory.Create(result, "KalturaDataEntry");
		}

		public KalturaDataEntry Update(string entryId, KalturaDataEntry documentEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("documentEntry", documentEntry);
			_Client.QueueServiceCall("data", "update", "KalturaDataEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDataEntry)KalturaObjectFactory.Create(result, "KalturaDataEntry");
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("data", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaDataListResponse List()
		{
			return this.List(null);
		}

		public KalturaDataListResponse List(KalturaDataEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDataListResponse List(KalturaDataEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("data", "list", "KalturaDataListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDataListResponse)KalturaObjectFactory.Create(result, "KalturaDataListResponse");
		}
	}
}
