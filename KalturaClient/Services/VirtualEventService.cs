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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class VirtualEventAddRequestBuilder : RequestBuilder<VirtualEvent>
	{
		#region Constants
		public const string VIRTUAL_EVENT = "virtualEvent";
		#endregion

		public VirtualEvent VirtualEvent { get; set; }

		public VirtualEventAddRequestBuilder()
			: base("virtualevent_virtualevent", "add")
		{
		}

		public VirtualEventAddRequestBuilder(VirtualEvent virtualEvent)
			: this()
		{
			this.VirtualEvent = virtualEvent;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("virtualEvent"))
				kparams.AddIfNotNull("virtualEvent", VirtualEvent);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VirtualEvent>(result);
		}
	}

	public class VirtualEventDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public VirtualEventDeleteRequestBuilder()
			: base("virtualevent_virtualevent", "delete")
		{
		}

		public VirtualEventDeleteRequestBuilder(int id)
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

	public class VirtualEventGetRequestBuilder : RequestBuilder<VirtualEvent>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public VirtualEventGetRequestBuilder()
			: base("virtualevent_virtualevent", "get")
		{
		}

		public VirtualEventGetRequestBuilder(int id)
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
			return ObjectFactory.Create<VirtualEvent>(result);
		}
	}

	public class VirtualEventListRequestBuilder : RequestBuilder<ListResponse<VirtualEvent>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public VirtualEventFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public VirtualEventListRequestBuilder()
			: base("virtualevent_virtualevent", "list")
		{
		}

		public VirtualEventListRequestBuilder(VirtualEventFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<VirtualEvent>>(result);
		}
	}

	public class VirtualEventUpdateRequestBuilder : RequestBuilder<VirtualEvent>
	{
		#region Constants
		public const string ID = "id";
		public const string VIRTUAL_EVENT = "virtualEvent";
		#endregion

		public int Id { get; set; }
		public VirtualEvent VirtualEvent { get; set; }

		public VirtualEventUpdateRequestBuilder()
			: base("virtualevent_virtualevent", "update")
		{
		}

		public VirtualEventUpdateRequestBuilder(int id, VirtualEvent virtualEvent)
			: this()
		{
			this.Id = id;
			this.VirtualEvent = virtualEvent;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("virtualEvent"))
				kparams.AddIfNotNull("virtualEvent", VirtualEvent);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VirtualEvent>(result);
		}
	}


	public class VirtualEventService
	{
		private VirtualEventService()
		{
		}

		public static VirtualEventAddRequestBuilder Add(VirtualEvent virtualEvent)
		{
			return new VirtualEventAddRequestBuilder(virtualEvent);
		}

		public static VirtualEventDeleteRequestBuilder Delete(int id)
		{
			return new VirtualEventDeleteRequestBuilder(id);
		}

		public static VirtualEventGetRequestBuilder Get(int id)
		{
			return new VirtualEventGetRequestBuilder(id);
		}

		public static VirtualEventListRequestBuilder List(VirtualEventFilter filter = null, FilterPager pager = null)
		{
			return new VirtualEventListRequestBuilder(filter, pager);
		}

		public static VirtualEventUpdateRequestBuilder Update(int id, VirtualEvent virtualEvent)
		{
			return new VirtualEventUpdateRequestBuilder(id, virtualEvent);
		}
	}
}
