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

	public class KalturaScheduleResourceService : KalturaServiceBase
	{
	public KalturaScheduleResourceService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaScheduleResource Add(KalturaScheduleResource scheduleResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleResource", scheduleResource);
			_Client.QueueServiceCall("schedule_scheduleresource", "add", "KalturaScheduleResource", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleResource)KalturaObjectFactory.Create(result, "KalturaScheduleResource");
		}

		public KalturaScheduleResource Get(int scheduleResourceId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleResourceId", scheduleResourceId);
			_Client.QueueServiceCall("schedule_scheduleresource", "get", "KalturaScheduleResource", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleResource)KalturaObjectFactory.Create(result, "KalturaScheduleResource");
		}

		public KalturaScheduleResource Update(int scheduleResourceId, KalturaScheduleResource scheduleResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleResourceId", scheduleResourceId);
			kparams.AddIfNotNull("scheduleResource", scheduleResource);
			_Client.QueueServiceCall("schedule_scheduleresource", "update", "KalturaScheduleResource", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleResource)KalturaObjectFactory.Create(result, "KalturaScheduleResource");
		}

		public KalturaScheduleResource Delete(int scheduleResourceId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduleResourceId", scheduleResourceId);
			_Client.QueueServiceCall("schedule_scheduleresource", "delete", "KalturaScheduleResource", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleResource)KalturaObjectFactory.Create(result, "KalturaScheduleResource");
		}

		public KalturaScheduleResourceListResponse List()
		{
			return this.List(null);
		}

		public KalturaScheduleResourceListResponse List(KalturaScheduleResourceFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaScheduleResourceListResponse List(KalturaScheduleResourceFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("schedule_scheduleresource", "list", "KalturaScheduleResourceListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduleResourceListResponse)KalturaObjectFactory.Create(result, "KalturaScheduleResourceListResponse");
		}
	}
}
