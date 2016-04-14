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

	public class KalturaScheduleEventService : KalturaServiceBase
	{
	public KalturaScheduleEventService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaScheduleEvent Add(KalturaScheduleEvent scheduleEvent)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEvent", scheduleEvent);
			_Client.QueueServiceCall("schedule_scheduleevent", "add", "KalturaScheduleEvent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEvent)KalturaObjectFactory.Create(result, "KalturaScheduleEvent");
		}

		public KalturaScheduleEvent Get(int scheduleEventId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEventId", scheduleEventId);
			_Client.QueueServiceCall("schedule_scheduleevent", "get", "KalturaScheduleEvent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEvent)KalturaObjectFactory.Create(result, "KalturaScheduleEvent");
		}

		public KalturaScheduleEvent Update(int scheduleEventId, KalturaScheduleEvent scheduleEvent)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEventId", scheduleEventId);
			kparams.AddIfNotNull("scheduleEvent", scheduleEvent);
			_Client.QueueServiceCall("schedule_scheduleevent", "update", "KalturaScheduleEvent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEvent)KalturaObjectFactory.Create(result, "KalturaScheduleEvent");
		}

		public KalturaScheduleEvent Delete(int scheduleEventId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEventId", scheduleEventId);
			_Client.QueueServiceCall("schedule_scheduleevent", "delete", "KalturaScheduleEvent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEvent)KalturaObjectFactory.Create(result, "KalturaScheduleEvent");
		}

		public KalturaScheduleEvent Cancel(int scheduleEventId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleEventId", scheduleEventId);
			_Client.QueueServiceCall("schedule_scheduleevent", "cancel", "KalturaScheduleEvent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEvent)KalturaObjectFactory.Create(result, "KalturaScheduleEvent");
		}

		public KalturaScheduleEventListResponse List()
		{
			return this.List(null);
		}

		public KalturaScheduleEventListResponse List(KalturaScheduleEventFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaScheduleEventListResponse List(KalturaScheduleEventFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("schedule_scheduleevent", "list", "KalturaScheduleEventListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleEventListResponse)KalturaObjectFactory.Create(result, "KalturaScheduleEventListResponse");
		}
	}
}
