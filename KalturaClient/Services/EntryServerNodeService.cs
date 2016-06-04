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

	public class KalturaEntryServerNodeService : KalturaServiceBase
	{
	public KalturaEntryServerNodeService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaEntryServerNode Update(int id, KalturaEntryServerNode entryServerNode)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("entryServerNode", entryServerNode);
			_Client.QueueServiceCall("entryservernode", "update", "KalturaEntryServerNode", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryServerNode)KalturaObjectFactory.Create(result, "KalturaEntryServerNode");
		}

		public KalturaEntryServerNodeListResponse List()
		{
			return this.List(null);
		}

		public KalturaEntryServerNodeListResponse List(KalturaEntryServerNodeFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaEntryServerNodeListResponse List(KalturaEntryServerNodeFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("entryservernode", "list", "KalturaEntryServerNodeListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryServerNodeListResponse)KalturaObjectFactory.Create(result, "KalturaEntryServerNodeListResponse");
		}

		public KalturaEntryServerNode Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("entryservernode", "get", "KalturaEntryServerNode", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryServerNode)KalturaObjectFactory.Create(result, "KalturaEntryServerNode");
		}

		public void ValidateRegisteredEntryServerNode(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("entryservernode", "validateRegisteredEntryServerNode", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
