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
	public class ConfMapsAddRequestBuilder : RequestBuilder<ConfMaps>
	{
		#region Constants
		public const string MAP = "map";
		#endregion

		public ConfMaps Map
		{
			set;
			get;
		}

		public ConfMapsAddRequestBuilder()
			: base("confmaps_confmaps", "add")
		{
		}

		public ConfMapsAddRequestBuilder(ConfMaps map)
			: this()
		{
			this.Map = map;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("map"))
				kparams.AddIfNotNull("map", Map);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ConfMaps>(result);
		}
	}

	public class ConfMapsGetRequestBuilder : RequestBuilder<ConfMaps>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public ConfMapsFilter Filter
		{
			set;
			get;
		}

		public ConfMapsGetRequestBuilder()
			: base("confmaps_confmaps", "get")
		{
		}

		public ConfMapsGetRequestBuilder(ConfMapsFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ConfMaps>(result);
		}
	}

	public class ConfMapsGetMapNamesRequestBuilder : RequestBuilder<IList<String>>
	{
		#region Constants
		#endregion


		public ConfMapsGetMapNamesRequestBuilder()
			: base("confmaps_confmaps", "getMapNames")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<String> list = new List<String>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<String>(node));
			}
			return list;
		}
	}

	public class ConfMapsListRequestBuilder : RequestBuilder<ListResponse<ConfMaps>>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public ConfMapsFilter Filter
		{
			set;
			get;
		}

		public ConfMapsListRequestBuilder()
			: base("confmaps_confmaps", "list")
		{
		}

		public ConfMapsListRequestBuilder(ConfMapsFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<ConfMaps>>(result);
		}
	}

	public class ConfMapsUpdateRequestBuilder : RequestBuilder<ConfMaps>
	{
		#region Constants
		public const string MAP = "map";
		#endregion

		public ConfMaps Map
		{
			set;
			get;
		}

		public ConfMapsUpdateRequestBuilder()
			: base("confmaps_confmaps", "update")
		{
		}

		public ConfMapsUpdateRequestBuilder(ConfMaps map)
			: this()
		{
			this.Map = map;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("map"))
				kparams.AddIfNotNull("map", Map);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ConfMaps>(result);
		}
	}


	public class ConfMapsService
	{
		private ConfMapsService()
		{
		}

		public static ConfMapsAddRequestBuilder Add(ConfMaps map)
		{
			return new ConfMapsAddRequestBuilder(map);
		}

		public static ConfMapsGetRequestBuilder Get(ConfMapsFilter filter)
		{
			return new ConfMapsGetRequestBuilder(filter);
		}

		public static ConfMapsGetMapNamesRequestBuilder GetMapNames()
		{
			return new ConfMapsGetMapNamesRequestBuilder();
		}

		public static ConfMapsListRequestBuilder List(ConfMapsFilter filter)
		{
			return new ConfMapsListRequestBuilder(filter);
		}

		public static ConfMapsUpdateRequestBuilder Update(ConfMaps map)
		{
			return new ConfMapsUpdateRequestBuilder(map);
		}
	}
}
