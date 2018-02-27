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
// Copyright (C) 2006-2018  Kaltura Inc.
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
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class ScheduleEventAddRequestBuilder : RequestBuilder<ScheduleEvent>
	{
		#region Constants
		public const string SCHEDULE_EVENT = "scheduleEvent";
		#endregion

		public ScheduleEvent ScheduleEvent
		{
			set;
			get;
		}

		public ScheduleEventAddRequestBuilder()
			: base("schedule_scheduleevent", "add")
		{
		}

		public ScheduleEventAddRequestBuilder(ScheduleEvent scheduleEvent)
			: this()
		{
			this.ScheduleEvent = scheduleEvent;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEvent"))
				kparams.AddIfNotNull("scheduleEvent", ScheduleEvent);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ScheduleEvent>(result);
		}
	}

	public class ScheduleEventAddFromBulkUploadRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		#endregion

		public Stream FileData
		{
			set;
			get;
		}
		public BulkUploadICalJobData BulkUploadData
		{
			set;
			get;
		}

		public ScheduleEventAddFromBulkUploadRequestBuilder()
			: base("schedule_scheduleevent", "addFromBulkUpload")
		{
		}

		public ScheduleEventAddFromBulkUploadRequestBuilder(Stream fileData, BulkUploadICalJobData bulkUploadData)
			: this()
		{
			this.FileData = fileData;
			this.BulkUploadData = bulkUploadData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadData"))
				kparams.AddIfNotNull("bulkUploadData", BulkUploadData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("fileData", FileData);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class ScheduleEventCancelRequestBuilder : RequestBuilder<ScheduleEvent>
	{
		#region Constants
		public const string SCHEDULE_EVENT_ID = "scheduleEventId";
		#endregion

		public int ScheduleEventId
		{
			set;
			get;
		}

		public ScheduleEventCancelRequestBuilder()
			: base("schedule_scheduleevent", "cancel")
		{
		}

		public ScheduleEventCancelRequestBuilder(int scheduleEventId)
			: this()
		{
			this.ScheduleEventId = scheduleEventId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEventId"))
				kparams.AddIfNotNull("scheduleEventId", ScheduleEventId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ScheduleEvent>(result);
		}
	}

	public class ScheduleEventDeleteRequestBuilder : RequestBuilder<ScheduleEvent>
	{
		#region Constants
		public const string SCHEDULE_EVENT_ID = "scheduleEventId";
		#endregion

		public int ScheduleEventId
		{
			set;
			get;
		}

		public ScheduleEventDeleteRequestBuilder()
			: base("schedule_scheduleevent", "delete")
		{
		}

		public ScheduleEventDeleteRequestBuilder(int scheduleEventId)
			: this()
		{
			this.ScheduleEventId = scheduleEventId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEventId"))
				kparams.AddIfNotNull("scheduleEventId", ScheduleEventId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ScheduleEvent>(result);
		}
	}

	public class ScheduleEventGetRequestBuilder : RequestBuilder<ScheduleEvent>
	{
		#region Constants
		public const string SCHEDULE_EVENT_ID = "scheduleEventId";
		#endregion

		public int ScheduleEventId
		{
			set;
			get;
		}

		public ScheduleEventGetRequestBuilder()
			: base("schedule_scheduleevent", "get")
		{
		}

		public ScheduleEventGetRequestBuilder(int scheduleEventId)
			: this()
		{
			this.ScheduleEventId = scheduleEventId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEventId"))
				kparams.AddIfNotNull("scheduleEventId", ScheduleEventId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ScheduleEvent>(result);
		}
	}

	public class ScheduleEventGetConflictsRequestBuilder : RequestBuilder<ListResponse<ScheduleEvent>>
	{
		#region Constants
		public const string RESOURCE_IDS = "resourceIds";
		public const string SCHEDULE_EVENT = "scheduleEvent";
		public const string SCHEDULE_EVENT_ID_TO_IGNORE = "scheduleEventIdToIgnore";
		#endregion

		public string ResourceIds
		{
			set;
			get;
		}
		public ScheduleEvent ScheduleEvent
		{
			set;
			get;
		}
		public string ScheduleEventIdToIgnore
		{
			set;
			get;
		}

		public ScheduleEventGetConflictsRequestBuilder()
			: base("schedule_scheduleevent", "getConflicts")
		{
		}

		public ScheduleEventGetConflictsRequestBuilder(string resourceIds, ScheduleEvent scheduleEvent, string scheduleEventIdToIgnore)
			: this()
		{
			this.ResourceIds = resourceIds;
			this.ScheduleEvent = scheduleEvent;
			this.ScheduleEventIdToIgnore = scheduleEventIdToIgnore;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("resourceIds"))
				kparams.AddIfNotNull("resourceIds", ResourceIds);
			if (!isMapped("scheduleEvent"))
				kparams.AddIfNotNull("scheduleEvent", ScheduleEvent);
			if (!isMapped("scheduleEventIdToIgnore"))
				kparams.AddIfNotNull("scheduleEventIdToIgnore", ScheduleEventIdToIgnore);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<ScheduleEvent>>(result);
		}
	}

	public class ScheduleEventListRequestBuilder : RequestBuilder<ListResponse<ScheduleEvent>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ScheduleEventFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ScheduleEventListRequestBuilder()
			: base("schedule_scheduleevent", "list")
		{
		}

		public ScheduleEventListRequestBuilder(ScheduleEventFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<ScheduleEvent>>(result);
		}
	}

	public class ScheduleEventUpdateRequestBuilder : RequestBuilder<ScheduleEvent>
	{
		#region Constants
		public const string SCHEDULE_EVENT_ID = "scheduleEventId";
		public const string SCHEDULE_EVENT = "scheduleEvent";
		#endregion

		public int ScheduleEventId
		{
			set;
			get;
		}
		public ScheduleEvent ScheduleEvent
		{
			set;
			get;
		}

		public ScheduleEventUpdateRequestBuilder()
			: base("schedule_scheduleevent", "update")
		{
		}

		public ScheduleEventUpdateRequestBuilder(int scheduleEventId, ScheduleEvent scheduleEvent)
			: this()
		{
			this.ScheduleEventId = scheduleEventId;
			this.ScheduleEvent = scheduleEvent;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleEventId"))
				kparams.AddIfNotNull("scheduleEventId", ScheduleEventId);
			if (!isMapped("scheduleEvent"))
				kparams.AddIfNotNull("scheduleEvent", ScheduleEvent);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ScheduleEvent>(result);
		}
	}


	public class ScheduleEventService
	{
		private ScheduleEventService()
		{
		}

		public static ScheduleEventAddRequestBuilder Add(ScheduleEvent scheduleEvent)
		{
			return new ScheduleEventAddRequestBuilder(scheduleEvent);
		}

		public static ScheduleEventAddFromBulkUploadRequestBuilder AddFromBulkUpload(Stream fileData, BulkUploadICalJobData bulkUploadData = null)
		{
			return new ScheduleEventAddFromBulkUploadRequestBuilder(fileData, bulkUploadData);
		}

		public static ScheduleEventCancelRequestBuilder Cancel(int scheduleEventId)
		{
			return new ScheduleEventCancelRequestBuilder(scheduleEventId);
		}

		public static ScheduleEventDeleteRequestBuilder Delete(int scheduleEventId)
		{
			return new ScheduleEventDeleteRequestBuilder(scheduleEventId);
		}

		public static ScheduleEventGetRequestBuilder Get(int scheduleEventId)
		{
			return new ScheduleEventGetRequestBuilder(scheduleEventId);
		}

		public static ScheduleEventGetConflictsRequestBuilder GetConflicts(string resourceIds, ScheduleEvent scheduleEvent, string scheduleEventIdToIgnore = null)
		{
			return new ScheduleEventGetConflictsRequestBuilder(resourceIds, scheduleEvent, scheduleEventIdToIgnore);
		}

		public static ScheduleEventListRequestBuilder List(ScheduleEventFilter filter = null, FilterPager pager = null)
		{
			return new ScheduleEventListRequestBuilder(filter, pager);
		}

		public static ScheduleEventUpdateRequestBuilder Update(int scheduleEventId, ScheduleEvent scheduleEvent)
		{
			return new ScheduleEventUpdateRequestBuilder(scheduleEventId, scheduleEvent);
		}
	}
}
