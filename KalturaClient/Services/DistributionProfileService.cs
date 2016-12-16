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
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class DistributionProfileAddRequestBuilder : RequestBuilder<DistributionProfile>
	{
		#region Constants
		public const string DISTRIBUTION_PROFILE = "distributionProfile";
		#endregion

		public DistributionProfile DistributionProfile
		{
			set;
			get;
		}

		public DistributionProfileAddRequestBuilder()
			: base("contentdistribution_distributionprofile", "add")
		{
		}

		public DistributionProfileAddRequestBuilder(DistributionProfile distributionProfile)
			: this()
		{
			this.DistributionProfile = distributionProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("distributionProfile"))
				kparams.AddIfNotNull("distributionProfile", DistributionProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DistributionProfile>(result);
		}
	}

	public class DistributionProfileGetRequestBuilder : RequestBuilder<DistributionProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public DistributionProfileGetRequestBuilder()
			: base("contentdistribution_distributionprofile", "get")
		{
		}

		public DistributionProfileGetRequestBuilder(int id)
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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DistributionProfile>(result);
		}
	}

	public class DistributionProfileUpdateRequestBuilder : RequestBuilder<DistributionProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string DISTRIBUTION_PROFILE = "distributionProfile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public DistributionProfile DistributionProfile
		{
			set;
			get;
		}

		public DistributionProfileUpdateRequestBuilder()
			: base("contentdistribution_distributionprofile", "update")
		{
		}

		public DistributionProfileUpdateRequestBuilder(int id, DistributionProfile distributionProfile)
			: this()
		{
			this.Id = id;
			this.DistributionProfile = distributionProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("distributionProfile"))
				kparams.AddIfNotNull("distributionProfile", DistributionProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DistributionProfile>(result);
		}
	}

	public class DistributionProfileUpdateStatusRequestBuilder : RequestBuilder<DistributionProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public DistributionProfileStatus Status
		{
			set;
			get;
		}

		public DistributionProfileUpdateStatusRequestBuilder()
			: base("contentdistribution_distributionprofile", "updateStatus")
		{
		}

		public DistributionProfileUpdateStatusRequestBuilder(int id, DistributionProfileStatus status)
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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DistributionProfile>(result);
		}
	}

	public class DistributionProfileDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public DistributionProfileDeleteRequestBuilder()
			: base("contentdistribution_distributionprofile", "delete")
		{
		}

		public DistributionProfileDeleteRequestBuilder(int id)
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

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class DistributionProfileListRequestBuilder : RequestBuilder<ListResponse<DistributionProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DistributionProfileFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public DistributionProfileListRequestBuilder()
			: base("contentdistribution_distributionprofile", "list")
		{
		}

		public DistributionProfileListRequestBuilder(DistributionProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DistributionProfile>>(result);
		}
	}

	public class DistributionProfileListByPartnerRequestBuilder : RequestBuilder<ListResponse<DistributionProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public PartnerFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public DistributionProfileListByPartnerRequestBuilder()
			: base("contentdistribution_distributionprofile", "listByPartner")
		{
		}

		public DistributionProfileListByPartnerRequestBuilder(PartnerFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DistributionProfile>>(result);
		}
	}


	public class DistributionProfileService
	{
		private DistributionProfileService()
		{
		}

		public static DistributionProfileAddRequestBuilder Add(DistributionProfile distributionProfile)
		{
			return new DistributionProfileAddRequestBuilder(distributionProfile);
		}

		public static DistributionProfileGetRequestBuilder Get(int id)
		{
			return new DistributionProfileGetRequestBuilder(id);
		}

		public static DistributionProfileUpdateRequestBuilder Update(int id, DistributionProfile distributionProfile)
		{
			return new DistributionProfileUpdateRequestBuilder(id, distributionProfile);
		}

		public static DistributionProfileUpdateStatusRequestBuilder UpdateStatus(int id, DistributionProfileStatus status)
		{
			return new DistributionProfileUpdateStatusRequestBuilder(id, status);
		}

		public static DistributionProfileDeleteRequestBuilder Delete(int id)
		{
			return new DistributionProfileDeleteRequestBuilder(id);
		}

		public static DistributionProfileListRequestBuilder List(DistributionProfileFilter filter = null, FilterPager pager = null)
		{
			return new DistributionProfileListRequestBuilder(filter, pager);
		}

		public static DistributionProfileListByPartnerRequestBuilder ListByPartner(PartnerFilter filter = null, FilterPager pager = null)
		{
			return new DistributionProfileListByPartnerRequestBuilder(filter, pager);
		}
	}
}
