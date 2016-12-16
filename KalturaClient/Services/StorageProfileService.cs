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
	public class StorageProfileAddRequestBuilder : RequestBuilder<StorageProfile>
	{
		#region Constants
		public const string STORAGE_PROFILE = "storageProfile";
		#endregion

		public StorageProfile StorageProfile
		{
			set;
			get;
		}

		public StorageProfileAddRequestBuilder()
			: base("storageprofile", "add")
		{
		}

		public StorageProfileAddRequestBuilder(StorageProfile storageProfile)
			: this()
		{
			this.StorageProfile = storageProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("storageProfile"))
				kparams.AddIfNotNull("storageProfile", StorageProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<StorageProfile>(result);
		}
	}

	public class StorageProfileUpdateStatusRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string STORAGE_ID = "storageId";
		public const string STATUS = "status";
		#endregion

		public int StorageId
		{
			set;
			get;
		}
		public StorageProfileStatus Status
		{
			set;
			get;
		}

		public StorageProfileUpdateStatusRequestBuilder()
			: base("storageprofile", "updateStatus")
		{
		}

		public StorageProfileUpdateStatusRequestBuilder(int storageId, StorageProfileStatus status)
			: this()
		{
			this.StorageId = storageId;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("storageId"))
				kparams.AddIfNotNull("storageId", StorageId);
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
			return null;
		}
	}

	public class StorageProfileGetRequestBuilder : RequestBuilder<StorageProfile>
	{
		#region Constants
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		#endregion

		public int StorageProfileId
		{
			set;
			get;
		}

		public StorageProfileGetRequestBuilder()
			: base("storageprofile", "get")
		{
		}

		public StorageProfileGetRequestBuilder(int storageProfileId)
			: this()
		{
			this.StorageProfileId = storageProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("storageProfileId"))
				kparams.AddIfNotNull("storageProfileId", StorageProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<StorageProfile>(result);
		}
	}

	public class StorageProfileUpdateRequestBuilder : RequestBuilder<StorageProfile>
	{
		#region Constants
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		public const string STORAGE_PROFILE = "storageProfile";
		#endregion

		public int StorageProfileId
		{
			set;
			get;
		}
		public StorageProfile StorageProfile
		{
			set;
			get;
		}

		public StorageProfileUpdateRequestBuilder()
			: base("storageprofile", "update")
		{
		}

		public StorageProfileUpdateRequestBuilder(int storageProfileId, StorageProfile storageProfile)
			: this()
		{
			this.StorageProfileId = storageProfileId;
			this.StorageProfile = storageProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("storageProfileId"))
				kparams.AddIfNotNull("storageProfileId", StorageProfileId);
			if (!isMapped("storageProfile"))
				kparams.AddIfNotNull("storageProfile", StorageProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<StorageProfile>(result);
		}
	}

	public class StorageProfileListRequestBuilder : RequestBuilder<ListResponse<StorageProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public StorageProfileFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public StorageProfileListRequestBuilder()
			: base("storageprofile", "list")
		{
		}

		public StorageProfileListRequestBuilder(StorageProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<StorageProfile>>(result);
		}
	}


	public class StorageProfileService
	{
		private StorageProfileService()
		{
		}

		public static StorageProfileAddRequestBuilder Add(StorageProfile storageProfile)
		{
			return new StorageProfileAddRequestBuilder(storageProfile);
		}

		public static StorageProfileUpdateStatusRequestBuilder UpdateStatus(int storageId, StorageProfileStatus status)
		{
			return new StorageProfileUpdateStatusRequestBuilder(storageId, status);
		}

		public static StorageProfileGetRequestBuilder Get(int storageProfileId)
		{
			return new StorageProfileGetRequestBuilder(storageProfileId);
		}

		public static StorageProfileUpdateRequestBuilder Update(int storageProfileId, StorageProfile storageProfile)
		{
			return new StorageProfileUpdateRequestBuilder(storageProfileId, storageProfile);
		}

		public static StorageProfileListRequestBuilder List(StorageProfileFilter filter = null, FilterPager pager = null)
		{
			return new StorageProfileListRequestBuilder(filter, pager);
		}
	}
}
