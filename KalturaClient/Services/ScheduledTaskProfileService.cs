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

	public class KalturaScheduledTaskProfileService : KalturaServiceBase
	{
	public KalturaScheduledTaskProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaScheduledTaskProfile Add(KalturaScheduledTaskProfile scheduledTaskProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduledTaskProfile", scheduledTaskProfile);
			_Client.QueueServiceCall("scheduledtask_scheduledtaskprofile", "add", "KalturaScheduledTaskProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduledTaskProfile)KalturaObjectFactory.Create(result, "KalturaScheduledTaskProfile");
		}

		public KalturaScheduledTaskProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("scheduledtask_scheduledtaskprofile", "get", "KalturaScheduledTaskProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduledTaskProfile)KalturaObjectFactory.Create(result, "KalturaScheduledTaskProfile");
		}

		public KalturaScheduledTaskProfile Update(int id, KalturaScheduledTaskProfile scheduledTaskProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("scheduledTaskProfile", scheduledTaskProfile);
			_Client.QueueServiceCall("scheduledtask_scheduledtaskprofile", "update", "KalturaScheduledTaskProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduledTaskProfile)KalturaObjectFactory.Create(result, "KalturaScheduledTaskProfile");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("scheduledtask_scheduledtaskprofile", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaScheduledTaskProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaScheduledTaskProfileListResponse List(KalturaScheduledTaskProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaScheduledTaskProfileListResponse List(KalturaScheduledTaskProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("scheduledtask_scheduledtaskprofile", "list", "KalturaScheduledTaskProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaScheduledTaskProfileListResponse)KalturaObjectFactory.Create(result, "KalturaScheduledTaskProfileListResponse");
		}

		public int RequestDryRun(int scheduledTaskProfileId)
		{
			return this.RequestDryRun(scheduledTaskProfileId, 500);
		}

		public int RequestDryRun(int scheduledTaskProfileId, int maxResults)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("scheduledTaskProfileId", scheduledTaskProfileId);
			kparams.AddIfNotNull("maxResults", maxResults);
			_Client.QueueServiceCall("scheduledtask_scheduledtaskprofile", "requestDryRun", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaObjectListResponse GetDryRunResults(int requestId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("requestId", requestId);
			_Client.QueueServiceCall("scheduledtask_scheduledtaskprofile", "getDryRunResults", "KalturaObjectListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaObjectListResponse)KalturaObjectFactory.Create(result, "KalturaObjectListResponse");
		}
	}
}
