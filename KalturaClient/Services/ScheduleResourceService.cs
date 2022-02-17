// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class ScheduleResourceAddRequestBuilder : RequestBuilder<ScheduleResource>
	{
		#region Constants
		public const string SCHEDULE_RESOURCE = "scheduleResource";
		#endregion

		public ScheduleResource ScheduleResource { get; set; }

		public ScheduleResourceAddRequestBuilder()
			: base("schedule_scheduleresource", "add")
		{
		}

		public ScheduleResourceAddRequestBuilder(ScheduleResource scheduleResource)
			: this()
		{
			this.ScheduleResource = scheduleResource;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleResource"))
				kparams.AddIfNotNull("scheduleResource", ScheduleResource);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduleResource>(result);
		}
	}

	public class ScheduleResourceAddFromBulkUploadRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		#endregion

		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }
		public BulkUploadCsvJobData BulkUploadData { get; set; }

		public ScheduleResourceAddFromBulkUploadRequestBuilder()
			: base("schedule_scheduleresource", "addFromBulkUpload")
		{
		}

		public ScheduleResourceAddFromBulkUploadRequestBuilder(Stream fileData, BulkUploadCsvJobData bulkUploadData)
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
			kfiles.Add("fileData", new FileData(FileData, FileData_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class ScheduleResourceDeleteRequestBuilder : RequestBuilder<ScheduleResource>
	{
		#region Constants
		public const string SCHEDULE_RESOURCE_ID = "scheduleResourceId";
		#endregion

		public int ScheduleResourceId { get; set; }

		public ScheduleResourceDeleteRequestBuilder()
			: base("schedule_scheduleresource", "delete")
		{
		}

		public ScheduleResourceDeleteRequestBuilder(int scheduleResourceId)
			: this()
		{
			this.ScheduleResourceId = scheduleResourceId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleResourceId"))
				kparams.AddIfNotNull("scheduleResourceId", ScheduleResourceId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduleResource>(result);
		}
	}

	public class ScheduleResourceGetRequestBuilder : RequestBuilder<ScheduleResource>
	{
		#region Constants
		public const string SCHEDULE_RESOURCE_ID = "scheduleResourceId";
		#endregion

		public int ScheduleResourceId { get; set; }

		public ScheduleResourceGetRequestBuilder()
			: base("schedule_scheduleresource", "get")
		{
		}

		public ScheduleResourceGetRequestBuilder(int scheduleResourceId)
			: this()
		{
			this.ScheduleResourceId = scheduleResourceId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleResourceId"))
				kparams.AddIfNotNull("scheduleResourceId", ScheduleResourceId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduleResource>(result);
		}
	}

	public class ScheduleResourceListRequestBuilder : RequestBuilder<ListResponse<ScheduleResource>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ScheduleResourceFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public ScheduleResourceListRequestBuilder()
			: base("schedule_scheduleresource", "list")
		{
		}

		public ScheduleResourceListRequestBuilder(ScheduleResourceFilter filter, FilterPager pager)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<ScheduleResource>>(result);
		}
	}

	public class ScheduleResourceUpdateRequestBuilder : RequestBuilder<ScheduleResource>
	{
		#region Constants
		public const string SCHEDULE_RESOURCE_ID = "scheduleResourceId";
		public const string SCHEDULE_RESOURCE = "scheduleResource";
		#endregion

		public int ScheduleResourceId { get; set; }
		public ScheduleResource ScheduleResource { get; set; }

		public ScheduleResourceUpdateRequestBuilder()
			: base("schedule_scheduleresource", "update")
		{
		}

		public ScheduleResourceUpdateRequestBuilder(int scheduleResourceId, ScheduleResource scheduleResource)
			: this()
		{
			this.ScheduleResourceId = scheduleResourceId;
			this.ScheduleResource = scheduleResource;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduleResourceId"))
				kparams.AddIfNotNull("scheduleResourceId", ScheduleResourceId);
			if (!isMapped("scheduleResource"))
				kparams.AddIfNotNull("scheduleResource", ScheduleResource);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduleResource>(result);
		}
	}


	public class ScheduleResourceService
	{
		private ScheduleResourceService()
		{
		}

		public static ScheduleResourceAddRequestBuilder Add(ScheduleResource scheduleResource)
		{
			return new ScheduleResourceAddRequestBuilder(scheduleResource);
		}

		public static ScheduleResourceAddFromBulkUploadRequestBuilder AddFromBulkUpload(Stream fileData, BulkUploadCsvJobData bulkUploadData = null)
		{
			return new ScheduleResourceAddFromBulkUploadRequestBuilder(fileData, bulkUploadData);
		}

		public static ScheduleResourceDeleteRequestBuilder Delete(int scheduleResourceId)
		{
			return new ScheduleResourceDeleteRequestBuilder(scheduleResourceId);
		}

		public static ScheduleResourceGetRequestBuilder Get(int scheduleResourceId)
		{
			return new ScheduleResourceGetRequestBuilder(scheduleResourceId);
		}

		public static ScheduleResourceListRequestBuilder List(ScheduleResourceFilter filter = null, FilterPager pager = null)
		{
			return new ScheduleResourceListRequestBuilder(filter, pager);
		}

		public static ScheduleResourceUpdateRequestBuilder Update(int scheduleResourceId, ScheduleResource scheduleResource)
		{
			return new ScheduleResourceUpdateRequestBuilder(scheduleResourceId, scheduleResource);
		}
	}
}
