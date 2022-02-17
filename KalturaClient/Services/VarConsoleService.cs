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
	public class VarConsoleGetPartnerUsageRequestBuilder : RequestBuilder<ListResponse<VarPartnerUsageItem>>
	{
		#region Constants
		public const string PARTNER_FILTER = "partnerFilter";
		public const string USAGE_FILTER = "usageFilter";
		public const string PAGER = "pager";
		#endregion

		public PartnerFilter PartnerFilter { get; set; }
		public ReportInputFilter UsageFilter { get; set; }
		public FilterPager Pager { get; set; }

		public VarConsoleGetPartnerUsageRequestBuilder()
			: base("varconsole_varconsole", "getPartnerUsage")
		{
		}

		public VarConsoleGetPartnerUsageRequestBuilder(PartnerFilter partnerFilter, ReportInputFilter usageFilter, FilterPager pager)
			: this()
		{
			this.PartnerFilter = partnerFilter;
			this.UsageFilter = usageFilter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerFilter"))
				kparams.AddIfNotNull("partnerFilter", PartnerFilter);
			if (!isMapped("usageFilter"))
				kparams.AddIfNotNull("usageFilter", UsageFilter);
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
			return ObjectFactory.Create<ListResponse<VarPartnerUsageItem>>(result);
		}
	}

	public class VarConsoleUpdateStatusRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public int Id { get; set; }
		public PartnerStatus Status { get; set; }

		public VarConsoleUpdateStatusRequestBuilder()
			: base("varconsole_varconsole", "updateStatus")
		{
		}

		public VarConsoleUpdateStatusRequestBuilder(int id, PartnerStatus status)
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
			return null;
		}
	}


	public class VarConsoleService
	{
		private VarConsoleService()
		{
		}

		public static VarConsoleGetPartnerUsageRequestBuilder GetPartnerUsage(PartnerFilter partnerFilter = null, ReportInputFilter usageFilter = null, FilterPager pager = null)
		{
			return new VarConsoleGetPartnerUsageRequestBuilder(partnerFilter, usageFilter, pager);
		}

		public static VarConsoleUpdateStatusRequestBuilder UpdateStatus(int id, PartnerStatus status)
		{
			return new VarConsoleUpdateStatusRequestBuilder(id, status);
		}
	}
}
