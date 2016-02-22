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

	public class KalturaLiveChannelSegmentService : KalturaServiceBase
	{
	public KalturaLiveChannelSegmentService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaLiveChannelSegment Add(KalturaLiveChannelSegment liveChannelSegment)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("liveChannelSegment", liveChannelSegment);
			_Client.QueueServiceCall("livechannelsegment", "add", "KalturaLiveChannelSegment", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveChannelSegment)KalturaObjectFactory.Create(result, "KalturaLiveChannelSegment");
		}

		public KalturaLiveChannelSegment Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("livechannelsegment", "get", "KalturaLiveChannelSegment", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveChannelSegment)KalturaObjectFactory.Create(result, "KalturaLiveChannelSegment");
		}

		public KalturaLiveChannelSegment Update(int id, KalturaLiveChannelSegment liveChannelSegment)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("liveChannelSegment", liveChannelSegment);
			_Client.QueueServiceCall("livechannelsegment", "update", "KalturaLiveChannelSegment", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveChannelSegment)KalturaObjectFactory.Create(result, "KalturaLiveChannelSegment");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("livechannelsegment", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaLiveChannelSegmentListResponse List()
		{
			return this.List(null);
		}

		public KalturaLiveChannelSegmentListResponse List(KalturaLiveChannelSegmentFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaLiveChannelSegmentListResponse List(KalturaLiveChannelSegmentFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("livechannelsegment", "list", "KalturaLiveChannelSegmentListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveChannelSegmentListResponse)KalturaObjectFactory.Create(result, "KalturaLiveChannelSegmentListResponse");
		}
	}
}
