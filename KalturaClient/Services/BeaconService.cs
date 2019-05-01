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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class BeaconAddRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string BEACON = "beacon";
		public const string SHOULD_LOG = "shouldLog";
		#endregion

		public Beacon Beacon { get; set; }
		public NullableBoolean ShouldLog { get; set; }

		public BeaconAddRequestBuilder()
			: base("beacon_beacon", "add")
		{
		}

		public BeaconAddRequestBuilder(Beacon beacon, NullableBoolean shouldLog)
			: this()
		{
			this.Beacon = beacon;
			this.ShouldLog = shouldLog;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("beacon"))
				kparams.AddIfNotNull("beacon", Beacon);
			if (!isMapped("shouldLog"))
				kparams.AddIfNotNull("shouldLog", ShouldLog);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class BeaconEnhanceSearchRequestBuilder : RequestBuilder<ListResponse<Beacon>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public BeaconEnhanceFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public BeaconEnhanceSearchRequestBuilder()
			: base("beacon_beacon", "enhanceSearch")
		{
		}

		public BeaconEnhanceSearchRequestBuilder(BeaconEnhanceFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Beacon>>(result);
		}
	}

	public class BeaconListRequestBuilder : RequestBuilder<ListResponse<Beacon>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public BeaconFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public BeaconListRequestBuilder()
			: base("beacon_beacon", "list")
		{
		}

		public BeaconListRequestBuilder(BeaconFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Beacon>>(result);
		}
	}

	public class BeaconSearchScheduledResourceRequestBuilder : RequestBuilder<ListResponse<Beacon>>
	{
		#region Constants
		public const string SEARCH_PARAMS = "searchParams";
		public const string PAGER = "pager";
		#endregion

		public BeaconSearchParams SearchParams { get; set; }
		public Pager Pager { get; set; }

		public BeaconSearchScheduledResourceRequestBuilder()
			: base("beacon_beacon", "searchScheduledResource")
		{
		}

		public BeaconSearchScheduledResourceRequestBuilder(BeaconSearchParams searchParams, Pager pager)
			: this()
		{
			this.SearchParams = searchParams;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("searchParams"))
				kparams.AddIfNotNull("searchParams", SearchParams);
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
			return ObjectFactory.Create<ListResponse<Beacon>>(result);
		}
	}


	public class BeaconService
	{
		private BeaconService()
		{
		}

		public static BeaconAddRequestBuilder Add(Beacon beacon, NullableBoolean shouldLog = (NullableBoolean)(0))
		{
			return new BeaconAddRequestBuilder(beacon, shouldLog);
		}

		public static BeaconEnhanceSearchRequestBuilder EnhanceSearch(BeaconEnhanceFilter filter = null, FilterPager pager = null)
		{
			return new BeaconEnhanceSearchRequestBuilder(filter, pager);
		}

		public static BeaconListRequestBuilder List(BeaconFilter filter = null, FilterPager pager = null)
		{
			return new BeaconListRequestBuilder(filter, pager);
		}

		public static BeaconSearchScheduledResourceRequestBuilder SearchScheduledResource(BeaconSearchParams searchParams, Pager pager = null)
		{
			return new BeaconSearchScheduledResourceRequestBuilder(searchParams, pager);
		}
	}
}
