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

	public class KalturaScheduleEventResourceService : KalturaServiceBase
	{
	public KalturaScheduleEventResourceService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaScheduleEventResource Add(KalturaScheduleEventResource scheduleEventResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEventResource", scheduleEventResource);
			_Client.QueueServiceCall("schedule_scheduleeventresource", "add", "KalturaScheduleEventResource", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEventResource)KalturaObjectFactory.Create(result, "KalturaScheduleEventResource");
		}

		public KalturaScheduleEventResource Get(int scheduleEventId, int scheduleResourceId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEventId", scheduleEventId);
			kparams.AddIfNotNull("scheduleResourceId", scheduleResourceId);
			_Client.QueueServiceCall("schedule_scheduleeventresource", "get", "KalturaScheduleEventResource", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEventResource)KalturaObjectFactory.Create(result, "KalturaScheduleEventResource");
		}

		public KalturaScheduleEventResource Update(int scheduleEventId, int scheduleResourceId, KalturaScheduleEventResource scheduleEventResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEventId", scheduleEventId);
			kparams.AddIfNotNull("scheduleResourceId", scheduleResourceId);
			kparams.AddIfNotNull("scheduleEventResource", scheduleEventResource);
			_Client.QueueServiceCall("schedule_scheduleeventresource", "update", "KalturaScheduleEventResource", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEventResource)KalturaObjectFactory.Create(result, "KalturaScheduleEventResource");
		}

		public void Delete(int scheduleEventId, int scheduleResourceId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEventId", scheduleEventId);
			kparams.AddIfNotNull("scheduleResourceId", scheduleResourceId);
			_Client.QueueServiceCall("schedule_scheduleeventresource", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaScheduleEventResourceListResponse List()
		{
			return this.List(null);
		}

		public KalturaScheduleEventResourceListResponse List(KalturaScheduleEventResourceFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaScheduleEventResourceListResponse List(KalturaScheduleEventResourceFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("schedule_scheduleeventresource", "list", "KalturaScheduleEventResourceListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEventResourceListResponse)KalturaObjectFactory.Create(result, "KalturaScheduleEventResourceListResponse");
		}
	}
}
