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
	public class VirusScanProfileAddRequestBuilder : RequestBuilder<VirusScanProfile>
	{
		#region Constants
		public const string VIRUS_SCAN_PROFILE = "virusScanProfile";
		#endregion

		public VirusScanProfile VirusScanProfile { get; set; }

		public VirusScanProfileAddRequestBuilder()
			: base("virusscan_virusscanprofile", "add")
		{
		}

		public VirusScanProfileAddRequestBuilder(VirusScanProfile virusScanProfile)
			: this()
		{
			this.VirusScanProfile = virusScanProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("virusScanProfile"))
				kparams.AddIfNotNull("virusScanProfile", VirusScanProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VirusScanProfile>(result);
		}
	}

	public class VirusScanProfileDeleteRequestBuilder : RequestBuilder<VirusScanProfile>
	{
		#region Constants
		public const string VIRUS_SCAN_PROFILE_ID = "virusScanProfileId";
		#endregion

		public int VirusScanProfileId { get; set; }

		public VirusScanProfileDeleteRequestBuilder()
			: base("virusscan_virusscanprofile", "delete")
		{
		}

		public VirusScanProfileDeleteRequestBuilder(int virusScanProfileId)
			: this()
		{
			this.VirusScanProfileId = virusScanProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("virusScanProfileId"))
				kparams.AddIfNotNull("virusScanProfileId", VirusScanProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VirusScanProfile>(result);
		}
	}

	public class VirusScanProfileGetRequestBuilder : RequestBuilder<VirusScanProfile>
	{
		#region Constants
		public const string VIRUS_SCAN_PROFILE_ID = "virusScanProfileId";
		#endregion

		public int VirusScanProfileId { get; set; }

		public VirusScanProfileGetRequestBuilder()
			: base("virusscan_virusscanprofile", "get")
		{
		}

		public VirusScanProfileGetRequestBuilder(int virusScanProfileId)
			: this()
		{
			this.VirusScanProfileId = virusScanProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("virusScanProfileId"))
				kparams.AddIfNotNull("virusScanProfileId", VirusScanProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VirusScanProfile>(result);
		}
	}

	public class VirusScanProfileListRequestBuilder : RequestBuilder<ListResponse<VirusScanProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public VirusScanProfileFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public VirusScanProfileListRequestBuilder()
			: base("virusscan_virusscanprofile", "list")
		{
		}

		public VirusScanProfileListRequestBuilder(VirusScanProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<VirusScanProfile>>(result);
		}
	}

	public class VirusScanProfileScanRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string VIRUS_SCAN_PROFILE_ID = "virusScanProfileId";
		#endregion

		public string FlavorAssetId { get; set; }
		public int VirusScanProfileId { get; set; }

		public VirusScanProfileScanRequestBuilder()
			: base("virusscan_virusscanprofile", "scan")
		{
		}

		public VirusScanProfileScanRequestBuilder(string flavorAssetId, int virusScanProfileId)
			: this()
		{
			this.FlavorAssetId = flavorAssetId;
			this.VirusScanProfileId = virusScanProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("flavorAssetId"))
				kparams.AddIfNotNull("flavorAssetId", FlavorAssetId);
			if (!isMapped("virusScanProfileId"))
				kparams.AddIfNotNull("virusScanProfileId", VirusScanProfileId);
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

	public class VirusScanProfileUpdateRequestBuilder : RequestBuilder<VirusScanProfile>
	{
		#region Constants
		public const string VIRUS_SCAN_PROFILE_ID = "virusScanProfileId";
		public const string VIRUS_SCAN_PROFILE = "virusScanProfile";
		#endregion

		public int VirusScanProfileId { get; set; }
		public VirusScanProfile VirusScanProfile { get; set; }

		public VirusScanProfileUpdateRequestBuilder()
			: base("virusscan_virusscanprofile", "update")
		{
		}

		public VirusScanProfileUpdateRequestBuilder(int virusScanProfileId, VirusScanProfile virusScanProfile)
			: this()
		{
			this.VirusScanProfileId = virusScanProfileId;
			this.VirusScanProfile = virusScanProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("virusScanProfileId"))
				kparams.AddIfNotNull("virusScanProfileId", VirusScanProfileId);
			if (!isMapped("virusScanProfile"))
				kparams.AddIfNotNull("virusScanProfile", VirusScanProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VirusScanProfile>(result);
		}
	}


	public class VirusScanProfileService
	{
		private VirusScanProfileService()
		{
		}

		public static VirusScanProfileAddRequestBuilder Add(VirusScanProfile virusScanProfile)
		{
			return new VirusScanProfileAddRequestBuilder(virusScanProfile);
		}

		public static VirusScanProfileDeleteRequestBuilder Delete(int virusScanProfileId)
		{
			return new VirusScanProfileDeleteRequestBuilder(virusScanProfileId);
		}

		public static VirusScanProfileGetRequestBuilder Get(int virusScanProfileId)
		{
			return new VirusScanProfileGetRequestBuilder(virusScanProfileId);
		}

		public static VirusScanProfileListRequestBuilder List(VirusScanProfileFilter filter = null, FilterPager pager = null)
		{
			return new VirusScanProfileListRequestBuilder(filter, pager);
		}

		public static VirusScanProfileScanRequestBuilder Scan(string flavorAssetId, int virusScanProfileId = Int32.MinValue)
		{
			return new VirusScanProfileScanRequestBuilder(flavorAssetId, virusScanProfileId);
		}

		public static VirusScanProfileUpdateRequestBuilder Update(int virusScanProfileId, VirusScanProfile virusScanProfile)
		{
			return new VirusScanProfileUpdateRequestBuilder(virusScanProfileId, virusScanProfile);
		}
	}
}
