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
	public class FlavorParamsAddRequestBuilder : RequestBuilder<FlavorParams>
	{
		#region Constants
		public const string FLAVOR_PARAMS = "flavorParams";
		#endregion

		public FlavorParams FlavorParams { get; set; }

		public FlavorParamsAddRequestBuilder()
			: base("flavorparams", "add")
		{
		}

		public FlavorParamsAddRequestBuilder(FlavorParams flavorParams)
			: this()
		{
			this.FlavorParams = flavorParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("flavorParams"))
				kparams.AddIfNotNull("flavorParams", FlavorParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<FlavorParams>(result);
		}
	}

	public class FlavorParamsDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public FlavorParamsDeleteRequestBuilder()
			: base("flavorparams", "delete")
		{
		}

		public FlavorParamsDeleteRequestBuilder(long id)
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

	public class FlavorParamsGetRequestBuilder : RequestBuilder<FlavorParams>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public FlavorParamsGetRequestBuilder()
			: base("flavorparams", "get")
		{
		}

		public FlavorParamsGetRequestBuilder(long id)
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
			return ObjectFactory.Create<FlavorParams>(result);
		}
	}

	public class FlavorParamsGetByConversionProfileIdRequestBuilder : RequestBuilder<IList<FlavorParams>>
	{
		#region Constants
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		#endregion

		public int ConversionProfileId { get; set; }

		public FlavorParamsGetByConversionProfileIdRequestBuilder()
			: base("flavorparams", "getByConversionProfileId")
		{
		}

		public FlavorParamsGetByConversionProfileIdRequestBuilder(int conversionProfileId)
			: this()
		{
			this.ConversionProfileId = conversionProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("conversionProfileId"))
				kparams.AddIfNotNull("conversionProfileId", ConversionProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<FlavorParams> list = new List<FlavorParams>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<FlavorParams>(node));
			}
			return list;
		}
	}

	public class FlavorParamsListRequestBuilder : RequestBuilder<ListResponse<FlavorParams>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public FlavorParamsFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public FlavorParamsListRequestBuilder()
			: base("flavorparams", "list")
		{
		}

		public FlavorParamsListRequestBuilder(FlavorParamsFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<FlavorParams>>(result);
		}
	}

	public class FlavorParamsUpdateRequestBuilder : RequestBuilder<FlavorParams>
	{
		#region Constants
		public const string ID = "id";
		public const string FLAVOR_PARAMS = "flavorParams";
		#endregion

		public long Id { get; set; }
		public FlavorParams FlavorParams { get; set; }

		public FlavorParamsUpdateRequestBuilder()
			: base("flavorparams", "update")
		{
		}

		public FlavorParamsUpdateRequestBuilder(long id, FlavorParams flavorParams)
			: this()
		{
			this.Id = id;
			this.FlavorParams = flavorParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("flavorParams"))
				kparams.AddIfNotNull("flavorParams", FlavorParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<FlavorParams>(result);
		}
	}


	public class FlavorParamsService
	{
		private FlavorParamsService()
		{
		}

		public static FlavorParamsAddRequestBuilder Add(FlavorParams flavorParams)
		{
			return new FlavorParamsAddRequestBuilder(flavorParams);
		}

		public static FlavorParamsDeleteRequestBuilder Delete(long id)
		{
			return new FlavorParamsDeleteRequestBuilder(id);
		}

		public static FlavorParamsGetRequestBuilder Get(long id)
		{
			return new FlavorParamsGetRequestBuilder(id);
		}

		public static FlavorParamsGetByConversionProfileIdRequestBuilder GetByConversionProfileId(int conversionProfileId)
		{
			return new FlavorParamsGetByConversionProfileIdRequestBuilder(conversionProfileId);
		}

		public static FlavorParamsListRequestBuilder List(FlavorParamsFilter filter = null, FilterPager pager = null)
		{
			return new FlavorParamsListRequestBuilder(filter, pager);
		}

		public static FlavorParamsUpdateRequestBuilder Update(long id, FlavorParams flavorParams)
		{
			return new FlavorParamsUpdateRequestBuilder(id, flavorParams);
		}
	}
}
