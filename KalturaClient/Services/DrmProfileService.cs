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
	public class DrmProfileAddRequestBuilder : RequestBuilder<DrmProfile>
	{
		#region Constants
		public const string DRM_PROFILE = "drmProfile";
		#endregion

		public DrmProfile DrmProfile
		{
			set;
			get;
		}

		public DrmProfileAddRequestBuilder()
			: base("drm_drmprofile", "add")
		{
		}

		public DrmProfileAddRequestBuilder(DrmProfile drmProfile)
			: this()
		{
			this.DrmProfile = drmProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("drmProfile"))
				kparams.AddIfNotNull("drmProfile", DrmProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<DrmProfile>((IDictionary<string,object>)result);
		}
	}

	public class DrmProfileDeleteRequestBuilder : RequestBuilder<DrmProfile>
	{
		#region Constants
		public const string DRM_PROFILE_ID = "drmProfileId";
		#endregion

		public int DrmProfileId
		{
			set;
			get;
		}

		public DrmProfileDeleteRequestBuilder()
			: base("drm_drmprofile", "delete")
		{
		}

		public DrmProfileDeleteRequestBuilder(int drmProfileId)
			: this()
		{
			this.DrmProfileId = drmProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("drmProfileId"))
				kparams.AddIfNotNull("drmProfileId", DrmProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<DrmProfile>((IDictionary<string,object>)result);
		}
	}

	public class DrmProfileGetRequestBuilder : RequestBuilder<DrmProfile>
	{
		#region Constants
		public const string DRM_PROFILE_ID = "drmProfileId";
		#endregion

		public int DrmProfileId
		{
			set;
			get;
		}

		public DrmProfileGetRequestBuilder()
			: base("drm_drmprofile", "get")
		{
		}

		public DrmProfileGetRequestBuilder(int drmProfileId)
			: this()
		{
			this.DrmProfileId = drmProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("drmProfileId"))
				kparams.AddIfNotNull("drmProfileId", DrmProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<DrmProfile>((IDictionary<string,object>)result);
		}
	}

	public class DrmProfileGetByProviderRequestBuilder : RequestBuilder<DrmProfile>
	{
		#region Constants
		public const string PROVIDER = "provider";
		#endregion

		public DrmProviderType Provider
		{
			set;
			get;
		}

		public DrmProfileGetByProviderRequestBuilder()
			: base("drm_drmprofile", "getByProvider")
		{
		}

		public DrmProfileGetByProviderRequestBuilder(DrmProviderType provider)
			: this()
		{
			this.Provider = provider;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("provider"))
				kparams.AddIfNotNull("provider", Provider);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<DrmProfile>((IDictionary<string,object>)result);
		}
	}

	public class DrmProfileListRequestBuilder : RequestBuilder<ListResponse<DrmProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DrmProfileFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public DrmProfileListRequestBuilder()
			: base("drm_drmprofile", "list")
		{
		}

		public DrmProfileListRequestBuilder(DrmProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DrmProfile>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<DrmProfile>>((IDictionary<string,object>)result);
		}
	}

	public class DrmProfileUpdateRequestBuilder : RequestBuilder<DrmProfile>
	{
		#region Constants
		public const string DRM_PROFILE_ID = "drmProfileId";
		public const string DRM_PROFILE = "drmProfile";
		#endregion

		public int DrmProfileId
		{
			set;
			get;
		}
		public DrmProfile DrmProfile
		{
			set;
			get;
		}

		public DrmProfileUpdateRequestBuilder()
			: base("drm_drmprofile", "update")
		{
		}

		public DrmProfileUpdateRequestBuilder(int drmProfileId, DrmProfile drmProfile)
			: this()
		{
			this.DrmProfileId = drmProfileId;
			this.DrmProfile = drmProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("drmProfileId"))
				kparams.AddIfNotNull("drmProfileId", DrmProfileId);
			if (!isMapped("drmProfile"))
				kparams.AddIfNotNull("drmProfile", DrmProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<DrmProfile>((IDictionary<string,object>)result);
		}
	}


	public class DrmProfileService
	{
		private DrmProfileService()
		{
		}

		public static DrmProfileAddRequestBuilder Add(DrmProfile drmProfile)
		{
			return new DrmProfileAddRequestBuilder(drmProfile);
		}

		public static DrmProfileDeleteRequestBuilder Delete(int drmProfileId)
		{
			return new DrmProfileDeleteRequestBuilder(drmProfileId);
		}

		public static DrmProfileGetRequestBuilder Get(int drmProfileId)
		{
			return new DrmProfileGetRequestBuilder(drmProfileId);
		}

		public static DrmProfileGetByProviderRequestBuilder GetByProvider(DrmProviderType provider)
		{
			return new DrmProfileGetByProviderRequestBuilder(provider);
		}

		public static DrmProfileListRequestBuilder List(DrmProfileFilter filter = null, FilterPager pager = null)
		{
			return new DrmProfileListRequestBuilder(filter, pager);
		}

		public static DrmProfileUpdateRequestBuilder Update(int drmProfileId, DrmProfile drmProfile)
		{
			return new DrmProfileUpdateRequestBuilder(drmProfileId, drmProfile);
		}
	}
}
