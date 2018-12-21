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
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class ScheduledTaskProfileAddRequestBuilder : RequestBuilder<ScheduledTaskProfile>
	{
		#region Constants
		public const string SCHEDULED_TASK_PROFILE = "scheduledTaskProfile";
		#endregion

		public ScheduledTaskProfile ScheduledTaskProfile
		{
			set;
			get;
		}

		public ScheduledTaskProfileAddRequestBuilder()
			: base("scheduledtask_scheduledtaskprofile", "add")
		{
		}

		public ScheduledTaskProfileAddRequestBuilder(ScheduledTaskProfile scheduledTaskProfile)
			: this()
		{
			this.ScheduledTaskProfile = scheduledTaskProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduledTaskProfile"))
				kparams.AddIfNotNull("scheduledTaskProfile", ScheduledTaskProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduledTaskProfile>(result);
		}
	}

	public class ScheduledTaskProfileDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ScheduledTaskProfileDeleteRequestBuilder()
			: base("scheduledtask_scheduledtaskprofile", "delete")
		{
		}

		public ScheduledTaskProfileDeleteRequestBuilder(int id)
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
			return null;
		}
	}

	public class ScheduledTaskProfileGetRequestBuilder : RequestBuilder<ScheduledTaskProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ScheduledTaskProfileGetRequestBuilder()
			: base("scheduledtask_scheduledtaskprofile", "get")
		{
		}

		public ScheduledTaskProfileGetRequestBuilder(int id)
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
			return ObjectFactory.Create<ScheduledTaskProfile>(result);
		}
	}

	public class ScheduledTaskProfileGetDryRunResultsRequestBuilder : RequestBuilder<ListResponse<ObjectBase>>
	{
		#region Constants
		public const string REQUEST_ID = "requestId";
		#endregion

		public int RequestId
		{
			set;
			get;
		}

		public ScheduledTaskProfileGetDryRunResultsRequestBuilder()
			: base("scheduledtask_scheduledtaskprofile", "getDryRunResults")
		{
		}

		public ScheduledTaskProfileGetDryRunResultsRequestBuilder(int requestId)
			: this()
		{
			this.RequestId = requestId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("requestId"))
				kparams.AddIfNotNull("requestId", RequestId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<ObjectBase>>(result);
		}
	}

	public class ScheduledTaskProfileListRequestBuilder : RequestBuilder<ListResponse<ScheduledTaskProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ScheduledTaskProfileFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ScheduledTaskProfileListRequestBuilder()
			: base("scheduledtask_scheduledtaskprofile", "list")
		{
		}

		public ScheduledTaskProfileListRequestBuilder(ScheduledTaskProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ScheduledTaskProfile>>(result);
		}
	}

	public class ScheduledTaskProfileRequestDryRunRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string SCHEDULED_TASK_PROFILE_ID = "scheduledTaskProfileId";
		public const string MAX_RESULTS = "maxResults";
		#endregion

		public int ScheduledTaskProfileId
		{
			set;
			get;
		}
		public int MaxResults
		{
			set;
			get;
		}

		public ScheduledTaskProfileRequestDryRunRequestBuilder()
			: base("scheduledtask_scheduledtaskprofile", "requestDryRun")
		{
		}

		public ScheduledTaskProfileRequestDryRunRequestBuilder(int scheduledTaskProfileId, int maxResults)
			: this()
		{
			this.ScheduledTaskProfileId = scheduledTaskProfileId;
			this.MaxResults = maxResults;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("scheduledTaskProfileId"))
				kparams.AddIfNotNull("scheduledTaskProfileId", ScheduledTaskProfileId);
			if (!isMapped("maxResults"))
				kparams.AddIfNotNull("maxResults", MaxResults);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<int>();
		}
	}

	public class ScheduledTaskProfileUpdateRequestBuilder : RequestBuilder<ScheduledTaskProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string SCHEDULED_TASK_PROFILE = "scheduledTaskProfile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public ScheduledTaskProfile ScheduledTaskProfile
		{
			set;
			get;
		}

		public ScheduledTaskProfileUpdateRequestBuilder()
			: base("scheduledtask_scheduledtaskprofile", "update")
		{
		}

		public ScheduledTaskProfileUpdateRequestBuilder(int id, ScheduledTaskProfile scheduledTaskProfile)
			: this()
		{
			this.Id = id;
			this.ScheduledTaskProfile = scheduledTaskProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("scheduledTaskProfile"))
				kparams.AddIfNotNull("scheduledTaskProfile", ScheduledTaskProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ScheduledTaskProfile>(result);
		}
	}


	public class ScheduledTaskProfileService
	{
		private ScheduledTaskProfileService()
		{
		}

		public static ScheduledTaskProfileAddRequestBuilder Add(ScheduledTaskProfile scheduledTaskProfile)
		{
			return new ScheduledTaskProfileAddRequestBuilder(scheduledTaskProfile);
		}

		public static ScheduledTaskProfileDeleteRequestBuilder Delete(int id)
		{
			return new ScheduledTaskProfileDeleteRequestBuilder(id);
		}

		public static ScheduledTaskProfileGetRequestBuilder Get(int id)
		{
			return new ScheduledTaskProfileGetRequestBuilder(id);
		}

		public static ScheduledTaskProfileGetDryRunResultsRequestBuilder GetDryRunResults(int requestId)
		{
			return new ScheduledTaskProfileGetDryRunResultsRequestBuilder(requestId);
		}

		public static ScheduledTaskProfileListRequestBuilder List(ScheduledTaskProfileFilter filter = null, FilterPager pager = null)
		{
			return new ScheduledTaskProfileListRequestBuilder(filter, pager);
		}

		public static ScheduledTaskProfileRequestDryRunRequestBuilder RequestDryRun(int scheduledTaskProfileId, int maxResults = 500)
		{
			return new ScheduledTaskProfileRequestDryRunRequestBuilder(scheduledTaskProfileId, maxResults);
		}

		public static ScheduledTaskProfileUpdateRequestBuilder Update(int id, ScheduledTaskProfile scheduledTaskProfile)
		{
			return new ScheduledTaskProfileUpdateRequestBuilder(id, scheduledTaskProfile);
		}
	}
}
