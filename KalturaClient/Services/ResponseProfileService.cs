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
	public class ResponseProfileAddRequestBuilder : RequestBuilder<ResponseProfile>
	{
		#region Constants
		public const string ADD_RESPONSE_PROFILE = "addResponseProfile";
		#endregion

		public ResponseProfile AddResponseProfile
		{
			set;
			get;
		}

		public ResponseProfileAddRequestBuilder()
			: base("responseprofile", "add")
		{
		}

		public ResponseProfileAddRequestBuilder(ResponseProfile addResponseProfile)
			: this()
		{
			this.AddResponseProfile = addResponseProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("addResponseProfile"))
				kparams.AddIfNotNull("addResponseProfile", AddResponseProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ResponseProfile>(result);
		}
	}

	public class ResponseProfileCloneRequestBuilder : RequestBuilder<ResponseProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string PROFILE = "profile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public ResponseProfile Profile
		{
			set;
			get;
		}

		public ResponseProfileCloneRequestBuilder()
			: base("responseprofile", "clone")
		{
		}

		public ResponseProfileCloneRequestBuilder(int id, ResponseProfile profile)
			: this()
		{
			this.Id = id;
			this.Profile = profile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("profile"))
				kparams.AddIfNotNull("profile", Profile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ResponseProfile>(result);
		}
	}

	public class ResponseProfileDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ResponseProfileDeleteRequestBuilder()
			: base("responseprofile", "delete")
		{
		}

		public ResponseProfileDeleteRequestBuilder(int id)
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

	public class ResponseProfileGetRequestBuilder : RequestBuilder<ResponseProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ResponseProfileGetRequestBuilder()
			: base("responseprofile", "get")
		{
		}

		public ResponseProfileGetRequestBuilder(int id)
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
			return ObjectFactory.Create<ResponseProfile>(result);
		}
	}

	public class ResponseProfileListRequestBuilder : RequestBuilder<ListResponse<ResponseProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ResponseProfileFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ResponseProfileListRequestBuilder()
			: base("responseprofile", "list")
		{
		}

		public ResponseProfileListRequestBuilder(ResponseProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ResponseProfile>>(result);
		}
	}

	public class ResponseProfileRecalculateRequestBuilder : RequestBuilder<ResponseProfileCacheRecalculateResults>
	{
		#region Constants
		public const string OPTIONS = "options";
		#endregion

		public ResponseProfileCacheRecalculateOptions Options
		{
			set;
			get;
		}

		public ResponseProfileRecalculateRequestBuilder()
			: base("responseprofile", "recalculate")
		{
		}

		public ResponseProfileRecalculateRequestBuilder(ResponseProfileCacheRecalculateOptions options)
			: this()
		{
			this.Options = options;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("options"))
				kparams.AddIfNotNull("options", Options);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ResponseProfileCacheRecalculateResults>(result);
		}
	}

	public class ResponseProfileUpdateRequestBuilder : RequestBuilder<ResponseProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string UPDATE_RESPONSE_PROFILE = "updateResponseProfile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public ResponseProfile UpdateResponseProfile
		{
			set;
			get;
		}

		public ResponseProfileUpdateRequestBuilder()
			: base("responseprofile", "update")
		{
		}

		public ResponseProfileUpdateRequestBuilder(int id, ResponseProfile updateResponseProfile)
			: this()
		{
			this.Id = id;
			this.UpdateResponseProfile = updateResponseProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("updateResponseProfile"))
				kparams.AddIfNotNull("updateResponseProfile", UpdateResponseProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ResponseProfile>(result);
		}
	}

	public class ResponseProfileUpdateStatusRequestBuilder : RequestBuilder<ResponseProfile>
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
		public ResponseProfileStatus Status
		{
			set;
			get;
		}

		public ResponseProfileUpdateStatusRequestBuilder()
			: base("responseprofile", "updateStatus")
		{
		}

		public ResponseProfileUpdateStatusRequestBuilder(int id, ResponseProfileStatus status)
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
			return ObjectFactory.Create<ResponseProfile>(result);
		}
	}


	public class ResponseProfileService
	{
		private ResponseProfileService()
		{
		}

		public static ResponseProfileAddRequestBuilder Add(ResponseProfile addResponseProfile)
		{
			return new ResponseProfileAddRequestBuilder(addResponseProfile);
		}

		public static ResponseProfileCloneRequestBuilder Clone(int id, ResponseProfile profile)
		{
			return new ResponseProfileCloneRequestBuilder(id, profile);
		}

		public static ResponseProfileDeleteRequestBuilder Delete(int id)
		{
			return new ResponseProfileDeleteRequestBuilder(id);
		}

		public static ResponseProfileGetRequestBuilder Get(int id)
		{
			return new ResponseProfileGetRequestBuilder(id);
		}

		public static ResponseProfileListRequestBuilder List(ResponseProfileFilter filter = null, FilterPager pager = null)
		{
			return new ResponseProfileListRequestBuilder(filter, pager);
		}

		public static ResponseProfileRecalculateRequestBuilder Recalculate(ResponseProfileCacheRecalculateOptions options)
		{
			return new ResponseProfileRecalculateRequestBuilder(options);
		}

		public static ResponseProfileUpdateRequestBuilder Update(int id, ResponseProfile updateResponseProfile)
		{
			return new ResponseProfileUpdateRequestBuilder(id, updateResponseProfile);
		}

		public static ResponseProfileUpdateStatusRequestBuilder UpdateStatus(int id, ResponseProfileStatus status)
		{
			return new ResponseProfileUpdateStatusRequestBuilder(id, status);
		}
	}
}
