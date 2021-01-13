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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class ReachProfileAddRequestBuilder : RequestBuilder<ReachProfile>
	{
		#region Constants
		public const string REACH_PROFILE = "reachProfile";
		#endregion

		public ReachProfile ReachProfile { get; set; }

		public ReachProfileAddRequestBuilder()
			: base("reach_reachprofile", "add")
		{
		}

		public ReachProfileAddRequestBuilder(ReachProfile reachProfile)
			: this()
		{
			this.ReachProfile = reachProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reachProfile"))
				kparams.AddIfNotNull("reachProfile", ReachProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ReachProfile>(result);
		}
	}

	public class ReachProfileDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public ReachProfileDeleteRequestBuilder()
			: base("reach_reachprofile", "delete")
		{
		}

		public ReachProfileDeleteRequestBuilder(int id)
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

	public class ReachProfileGetRequestBuilder : RequestBuilder<ReachProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public ReachProfileGetRequestBuilder()
			: base("reach_reachprofile", "get")
		{
		}

		public ReachProfileGetRequestBuilder(int id)
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
			return ObjectFactory.Create<ReachProfile>(result);
		}
	}

	public class ReachProfileListRequestBuilder : RequestBuilder<ListResponse<ReachProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ReachProfileFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public ReachProfileListRequestBuilder()
			: base("reach_reachprofile", "list")
		{
		}

		public ReachProfileListRequestBuilder(ReachProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ReachProfile>>(result);
		}
	}

	public class ReachProfileSyncCreditRequestBuilder : RequestBuilder<ReachProfile>
	{
		#region Constants
		public const string REACH_PROFILE_ID = "reachProfileId";
		#endregion

		public int ReachProfileId { get; set; }

		public ReachProfileSyncCreditRequestBuilder()
			: base("reach_reachprofile", "syncCredit")
		{
		}

		public ReachProfileSyncCreditRequestBuilder(int reachProfileId)
			: this()
		{
			this.ReachProfileId = reachProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reachProfileId"))
				kparams.AddIfNotNull("reachProfileId", ReachProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ReachProfile>(result);
		}
	}

	public class ReachProfileUpdateRequestBuilder : RequestBuilder<ReachProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string REACH_PROFILE = "reachProfile";
		#endregion

		public int Id { get; set; }
		public ReachProfile ReachProfile { get; set; }

		public ReachProfileUpdateRequestBuilder()
			: base("reach_reachprofile", "update")
		{
		}

		public ReachProfileUpdateRequestBuilder(int id, ReachProfile reachProfile)
			: this()
		{
			this.Id = id;
			this.ReachProfile = reachProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("reachProfile"))
				kparams.AddIfNotNull("reachProfile", ReachProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ReachProfile>(result);
		}
	}

	public class ReachProfileUpdateStatusRequestBuilder : RequestBuilder<ReachProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public int Id { get; set; }
		public ReachProfileStatus Status { get; set; }

		public ReachProfileUpdateStatusRequestBuilder()
			: base("reach_reachprofile", "updateStatus")
		{
		}

		public ReachProfileUpdateStatusRequestBuilder(int id, ReachProfileStatus status)
			: this()
		{
			this.Id = id;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("status"))
				kparams.AddIfNotNull("status", Status);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ReachProfile>(result);
		}
	}


	public class ReachProfileService
	{
		private ReachProfileService()
		{
		}

		public static ReachProfileAddRequestBuilder Add(ReachProfile reachProfile)
		{
			return new ReachProfileAddRequestBuilder(reachProfile);
		}

		public static ReachProfileDeleteRequestBuilder Delete(int id)
		{
			return new ReachProfileDeleteRequestBuilder(id);
		}

		public static ReachProfileGetRequestBuilder Get(int id)
		{
			return new ReachProfileGetRequestBuilder(id);
		}

		public static ReachProfileListRequestBuilder List(ReachProfileFilter filter = null, FilterPager pager = null)
		{
			return new ReachProfileListRequestBuilder(filter, pager);
		}

		public static ReachProfileSyncCreditRequestBuilder SyncCredit(int reachProfileId)
		{
			return new ReachProfileSyncCreditRequestBuilder(reachProfileId);
		}

		public static ReachProfileUpdateRequestBuilder Update(int id, ReachProfile reachProfile)
		{
			return new ReachProfileUpdateRequestBuilder(id, reachProfile);
		}

		public static ReachProfileUpdateStatusRequestBuilder UpdateStatus(int id, ReachProfileStatus status)
		{
			return new ReachProfileUpdateStatusRequestBuilder(id, status);
		}
	}
}
