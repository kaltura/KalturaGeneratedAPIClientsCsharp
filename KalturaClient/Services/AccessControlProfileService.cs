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
	public class AccessControlProfileAddRequestBuilder : RequestBuilder<AccessControlProfile>
	{
		#region Constants
		public const string ACCESS_CONTROL_PROFILE = "accessControlProfile";
		#endregion

		public AccessControlProfile AccessControlProfile { get; set; }

		public AccessControlProfileAddRequestBuilder()
			: base("accesscontrolprofile", "add")
		{
		}

		public AccessControlProfileAddRequestBuilder(AccessControlProfile accessControlProfile)
			: this()
		{
			this.AccessControlProfile = accessControlProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("accessControlProfile"))
				kparams.AddIfNotNull("accessControlProfile", AccessControlProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<AccessControlProfile>(result);
		}
	}

	public class AccessControlProfileDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public AccessControlProfileDeleteRequestBuilder()
			: base("accesscontrolprofile", "delete")
		{
		}

		public AccessControlProfileDeleteRequestBuilder(int id)
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

	public class AccessControlProfileGetRequestBuilder : RequestBuilder<AccessControlProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public AccessControlProfileGetRequestBuilder()
			: base("accesscontrolprofile", "get")
		{
		}

		public AccessControlProfileGetRequestBuilder(int id)
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
			return ObjectFactory.Create<AccessControlProfile>(result);
		}
	}

	public class AccessControlProfileListRequestBuilder : RequestBuilder<ListResponse<AccessControlProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public AccessControlProfileFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public AccessControlProfileListRequestBuilder()
			: base("accesscontrolprofile", "list")
		{
		}

		public AccessControlProfileListRequestBuilder(AccessControlProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<AccessControlProfile>>(result);
		}
	}

	public class AccessControlProfileUpdateRequestBuilder : RequestBuilder<AccessControlProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string ACCESS_CONTROL_PROFILE = "accessControlProfile";
		#endregion

		public int Id { get; set; }
		public AccessControlProfile AccessControlProfile { get; set; }

		public AccessControlProfileUpdateRequestBuilder()
			: base("accesscontrolprofile", "update")
		{
		}

		public AccessControlProfileUpdateRequestBuilder(int id, AccessControlProfile accessControlProfile)
			: this()
		{
			this.Id = id;
			this.AccessControlProfile = accessControlProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("accessControlProfile"))
				kparams.AddIfNotNull("accessControlProfile", AccessControlProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<AccessControlProfile>(result);
		}
	}


	public class AccessControlProfileService
	{
		private AccessControlProfileService()
		{
		}

		public static AccessControlProfileAddRequestBuilder Add(AccessControlProfile accessControlProfile)
		{
			return new AccessControlProfileAddRequestBuilder(accessControlProfile);
		}

		public static AccessControlProfileDeleteRequestBuilder Delete(int id)
		{
			return new AccessControlProfileDeleteRequestBuilder(id);
		}

		public static AccessControlProfileGetRequestBuilder Get(int id)
		{
			return new AccessControlProfileGetRequestBuilder(id);
		}

		public static AccessControlProfileListRequestBuilder List(AccessControlProfileFilter filter = null, FilterPager pager = null)
		{
			return new AccessControlProfileListRequestBuilder(filter, pager);
		}

		public static AccessControlProfileUpdateRequestBuilder Update(int id, AccessControlProfile accessControlProfile)
		{
			return new AccessControlProfileUpdateRequestBuilder(id, accessControlProfile);
		}
	}
}
