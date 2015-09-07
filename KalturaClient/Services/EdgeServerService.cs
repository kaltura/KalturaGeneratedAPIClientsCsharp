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

	public class KalturaEdgeServerService : KalturaServiceBase
	{
	public KalturaEdgeServerService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaEdgeServer Add(KalturaEdgeServer edgeServer)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("edgeServer", edgeServer);
			_Client.QueueServiceCall("edgeserver", "add", "KalturaEdgeServer", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEdgeServer)KalturaObjectFactory.Create(result, "KalturaEdgeServer");
		}

		public KalturaEdgeServer Get(int edgeServerId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("edgeServerId", edgeServerId);
			_Client.QueueServiceCall("edgeserver", "get", "KalturaEdgeServer", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEdgeServer)KalturaObjectFactory.Create(result, "KalturaEdgeServer");
		}

		public KalturaEdgeServer Update(int edgeServerId, KalturaEdgeServer edgeServer)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("edgeServerId", edgeServerId);
			kparams.AddIfNotNull("edgeServer", edgeServer);
			_Client.QueueServiceCall("edgeserver", "update", "KalturaEdgeServer", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEdgeServer)KalturaObjectFactory.Create(result, "KalturaEdgeServer");
		}

		public void Delete(string edgeServerId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("edgeServerId", edgeServerId);
			_Client.QueueServiceCall("edgeserver", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaEdgeServerListResponse List()
		{
			return this.List(null);
		}

		public KalturaEdgeServerListResponse List(KalturaEdgeServerFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaEdgeServerListResponse List(KalturaEdgeServerFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("edgeserver", "list", "KalturaEdgeServerListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEdgeServerListResponse)KalturaObjectFactory.Create(result, "KalturaEdgeServerListResponse");
		}
	}
}
