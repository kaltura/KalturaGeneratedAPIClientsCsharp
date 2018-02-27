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
	public class DrmPolicyAddRequestBuilder : RequestBuilder<DrmPolicy>
	{
		#region Constants
		public const string DRM_POLICY = "drmPolicy";
		#endregion

		public DrmPolicy DrmPolicy
		{
			set;
			get;
		}

		public DrmPolicyAddRequestBuilder()
			: base("drm_drmpolicy", "add")
		{
		}

		public DrmPolicyAddRequestBuilder(DrmPolicy drmPolicy)
			: this()
		{
			this.DrmPolicy = drmPolicy;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("drmPolicy"))
				kparams.AddIfNotNull("drmPolicy", DrmPolicy);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmPolicy>(result);
		}
	}

	public class DrmPolicyDeleteRequestBuilder : RequestBuilder<DrmPolicy>
	{
		#region Constants
		public const string DRM_POLICY_ID = "drmPolicyId";
		#endregion

		public int DrmPolicyId
		{
			set;
			get;
		}

		public DrmPolicyDeleteRequestBuilder()
			: base("drm_drmpolicy", "delete")
		{
		}

		public DrmPolicyDeleteRequestBuilder(int drmPolicyId)
			: this()
		{
			this.DrmPolicyId = drmPolicyId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("drmPolicyId"))
				kparams.AddIfNotNull("drmPolicyId", DrmPolicyId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmPolicy>(result);
		}
	}

	public class DrmPolicyGetRequestBuilder : RequestBuilder<DrmPolicy>
	{
		#region Constants
		public const string DRM_POLICY_ID = "drmPolicyId";
		#endregion

		public int DrmPolicyId
		{
			set;
			get;
		}

		public DrmPolicyGetRequestBuilder()
			: base("drm_drmpolicy", "get")
		{
		}

		public DrmPolicyGetRequestBuilder(int drmPolicyId)
			: this()
		{
			this.DrmPolicyId = drmPolicyId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("drmPolicyId"))
				kparams.AddIfNotNull("drmPolicyId", DrmPolicyId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmPolicy>(result);
		}
	}

	public class DrmPolicyListRequestBuilder : RequestBuilder<ListResponse<DrmPolicy>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DrmPolicyFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public DrmPolicyListRequestBuilder()
			: base("drm_drmpolicy", "list")
		{
		}

		public DrmPolicyListRequestBuilder(DrmPolicyFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DrmPolicy>>(result);
		}
	}

	public class DrmPolicyUpdateRequestBuilder : RequestBuilder<DrmPolicy>
	{
		#region Constants
		public const string DRM_POLICY_ID = "drmPolicyId";
		public const string DRM_POLICY = "drmPolicy";
		#endregion

		public int DrmPolicyId
		{
			set;
			get;
		}
		public DrmPolicy DrmPolicy
		{
			set;
			get;
		}

		public DrmPolicyUpdateRequestBuilder()
			: base("drm_drmpolicy", "update")
		{
		}

		public DrmPolicyUpdateRequestBuilder(int drmPolicyId, DrmPolicy drmPolicy)
			: this()
		{
			this.DrmPolicyId = drmPolicyId;
			this.DrmPolicy = drmPolicy;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("drmPolicyId"))
				kparams.AddIfNotNull("drmPolicyId", DrmPolicyId);
			if (!isMapped("drmPolicy"))
				kparams.AddIfNotNull("drmPolicy", DrmPolicy);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DrmPolicy>(result);
		}
	}


	public class DrmPolicyService
	{
		private DrmPolicyService()
		{
		}

		public static DrmPolicyAddRequestBuilder Add(DrmPolicy drmPolicy)
		{
			return new DrmPolicyAddRequestBuilder(drmPolicy);
		}

		public static DrmPolicyDeleteRequestBuilder Delete(int drmPolicyId)
		{
			return new DrmPolicyDeleteRequestBuilder(drmPolicyId);
		}

		public static DrmPolicyGetRequestBuilder Get(int drmPolicyId)
		{
			return new DrmPolicyGetRequestBuilder(drmPolicyId);
		}

		public static DrmPolicyListRequestBuilder List(DrmPolicyFilter filter = null, FilterPager pager = null)
		{
			return new DrmPolicyListRequestBuilder(filter, pager);
		}

		public static DrmPolicyUpdateRequestBuilder Update(int drmPolicyId, DrmPolicy drmPolicy)
		{
			return new DrmPolicyUpdateRequestBuilder(drmPolicyId, drmPolicy);
		}
	}
}
