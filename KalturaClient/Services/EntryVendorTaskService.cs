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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class EntryVendorTaskAbortRequestBuilder : RequestBuilder<EntryVendorTask>
	{
		#region Constants
		public const string ID = "id";
		public const string ABORT_REASON = "abortReason";
		#endregion

		public int Id { get; set; }
		public string AbortReason { get; set; }

		public EntryVendorTaskAbortRequestBuilder()
			: base("reach_entryvendortask", "abort")
		{
		}

		public EntryVendorTaskAbortRequestBuilder(int id, string abortReason)
			: this()
		{
			this.Id = id;
			this.AbortReason = abortReason;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("abortReason"))
				kparams.AddIfNotNull("abortReason", AbortReason);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryVendorTask>(result);
		}
	}

	public class EntryVendorTaskAddRequestBuilder : RequestBuilder<EntryVendorTask>
	{
		#region Constants
		public const string ENTRY_VENDOR_TASK = "entryVendorTask";
		#endregion

		public EntryVendorTask EntryVendorTask { get; set; }

		public EntryVendorTaskAddRequestBuilder()
			: base("reach_entryvendortask", "add")
		{
		}

		public EntryVendorTaskAddRequestBuilder(EntryVendorTask entryVendorTask)
			: this()
		{
			this.EntryVendorTask = entryVendorTask;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryVendorTask"))
				kparams.AddIfNotNull("entryVendorTask", EntryVendorTask);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryVendorTask>(result);
		}
	}

	public class EntryVendorTaskApproveRequestBuilder : RequestBuilder<EntryVendorTask>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public EntryVendorTaskApproveRequestBuilder()
			: base("reach_entryvendortask", "approve")
		{
		}

		public EntryVendorTaskApproveRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryVendorTask>(result);
		}
	}

	public class EntryVendorTaskExportToCsvRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public EntryVendorTaskFilter Filter { get; set; }

		public EntryVendorTaskExportToCsvRequestBuilder()
			: base("reach_entryvendortask", "exportToCsv")
		{
		}

		public EntryVendorTaskExportToCsvRequestBuilder(EntryVendorTaskFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class EntryVendorTaskExtendAccessKeyRequestBuilder : RequestBuilder<EntryVendorTask>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public EntryVendorTaskExtendAccessKeyRequestBuilder()
			: base("reach_entryvendortask", "extendAccessKey")
		{
		}

		public EntryVendorTaskExtendAccessKeyRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryVendorTask>(result);
		}
	}

	public class EntryVendorTaskGetRequestBuilder : RequestBuilder<EntryVendorTask>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public EntryVendorTaskGetRequestBuilder()
			: base("reach_entryvendortask", "get")
		{
		}

		public EntryVendorTaskGetRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryVendorTask>(result);
		}
	}

	public class EntryVendorTaskGetJobsRequestBuilder : RequestBuilder<ListResponse<EntryVendorTask>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public EntryVendorTaskFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public EntryVendorTaskGetJobsRequestBuilder()
			: base("reach_entryvendortask", "getJobs")
		{
		}

		public EntryVendorTaskGetJobsRequestBuilder(EntryVendorTaskFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<EntryVendorTask>>(result);
		}
	}

	public class EntryVendorTaskListRequestBuilder : RequestBuilder<ListResponse<EntryVendorTask>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public EntryVendorTaskFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public EntryVendorTaskListRequestBuilder()
			: base("reach_entryvendortask", "list")
		{
		}

		public EntryVendorTaskListRequestBuilder(EntryVendorTaskFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<EntryVendorTask>>(result);
		}
	}

	public class EntryVendorTaskRejectRequestBuilder : RequestBuilder<EntryVendorTask>
	{
		#region Constants
		public const string ID = "id";
		public const string REJECT_REASON = "rejectReason";
		#endregion

		public int Id { get; set; }
		public string RejectReason { get; set; }

		public EntryVendorTaskRejectRequestBuilder()
			: base("reach_entryvendortask", "reject")
		{
		}

		public EntryVendorTaskRejectRequestBuilder(int id, string rejectReason)
			: this()
		{
			this.Id = id;
			this.RejectReason = rejectReason;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("rejectReason"))
				kparams.AddIfNotNull("rejectReason", RejectReason);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryVendorTask>(result);
		}
	}

	public class EntryVendorTaskServeCsvRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public EntryVendorTaskServeCsvRequestBuilder()
			: base("reach_entryvendortask", "serveCsv")
		{
		}

		public EntryVendorTaskServeCsvRequestBuilder(string id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class EntryVendorTaskUpdateRequestBuilder : RequestBuilder<EntryVendorTask>
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_VENDOR_TASK = "entryVendorTask";
		#endregion

		public int Id { get; set; }
		public EntryVendorTask EntryVendorTask { get; set; }

		public EntryVendorTaskUpdateRequestBuilder()
			: base("reach_entryvendortask", "update")
		{
		}

		public EntryVendorTaskUpdateRequestBuilder(int id, EntryVendorTask entryVendorTask)
			: this()
		{
			this.Id = id;
			this.EntryVendorTask = entryVendorTask;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("entryVendorTask"))
				kparams.AddIfNotNull("entryVendorTask", EntryVendorTask);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryVendorTask>(result);
		}
	}

	public class EntryVendorTaskUpdateJobRequestBuilder : RequestBuilder<EntryVendorTask>
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_VENDOR_TASK = "entryVendorTask";
		#endregion

		public int Id { get; set; }
		public EntryVendorTask EntryVendorTask { get; set; }

		public EntryVendorTaskUpdateJobRequestBuilder()
			: base("reach_entryvendortask", "updateJob")
		{
		}

		public EntryVendorTaskUpdateJobRequestBuilder(int id, EntryVendorTask entryVendorTask)
			: this()
		{
			this.Id = id;
			this.EntryVendorTask = entryVendorTask;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("entryVendorTask"))
				kparams.AddIfNotNull("entryVendorTask", EntryVendorTask);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryVendorTask>(result);
		}
	}


	public class EntryVendorTaskService
	{
		private EntryVendorTaskService()
		{
		}

		public static EntryVendorTaskAbortRequestBuilder Abort(int id, string abortReason = null)
		{
			return new EntryVendorTaskAbortRequestBuilder(id, abortReason);
		}

		public static EntryVendorTaskAddRequestBuilder Add(EntryVendorTask entryVendorTask)
		{
			return new EntryVendorTaskAddRequestBuilder(entryVendorTask);
		}

		public static EntryVendorTaskApproveRequestBuilder Approve(int id)
		{
			return new EntryVendorTaskApproveRequestBuilder(id);
		}

		public static EntryVendorTaskExportToCsvRequestBuilder ExportToCsv(EntryVendorTaskFilter filter)
		{
			return new EntryVendorTaskExportToCsvRequestBuilder(filter);
		}

		public static EntryVendorTaskExtendAccessKeyRequestBuilder ExtendAccessKey(int id)
		{
			return new EntryVendorTaskExtendAccessKeyRequestBuilder(id);
		}

		public static EntryVendorTaskGetRequestBuilder Get(int id)
		{
			return new EntryVendorTaskGetRequestBuilder(id);
		}

		public static EntryVendorTaskGetJobsRequestBuilder GetJobs(EntryVendorTaskFilter filter = null, FilterPager pager = null)
		{
			return new EntryVendorTaskGetJobsRequestBuilder(filter, pager);
		}

		public static EntryVendorTaskListRequestBuilder List(EntryVendorTaskFilter filter = null, FilterPager pager = null)
		{
			return new EntryVendorTaskListRequestBuilder(filter, pager);
		}

		public static EntryVendorTaskRejectRequestBuilder Reject(int id, string rejectReason = null)
		{
			return new EntryVendorTaskRejectRequestBuilder(id, rejectReason);
		}

		public static EntryVendorTaskServeCsvRequestBuilder ServeCsv(string id)
		{
			return new EntryVendorTaskServeCsvRequestBuilder(id);
		}

		public static EntryVendorTaskUpdateRequestBuilder Update(int id, EntryVendorTask entryVendorTask)
		{
			return new EntryVendorTaskUpdateRequestBuilder(id, entryVendorTask);
		}

		public static EntryVendorTaskUpdateJobRequestBuilder UpdateJob(int id, EntryVendorTask entryVendorTask)
		{
			return new EntryVendorTaskUpdateJobRequestBuilder(id, entryVendorTask);
		}
	}
}
