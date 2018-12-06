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
	public class LiveChannelSegmentAddRequestBuilder : RequestBuilder<LiveChannelSegment>
	{
		#region Constants
		public const string LIVE_CHANNEL_SEGMENT = "liveChannelSegment";
		#endregion

		public LiveChannelSegment LiveChannelSegment
		{
			set;
			get;
		}

		public LiveChannelSegmentAddRequestBuilder()
			: base("livechannelsegment", "add")
		{
		}

		public LiveChannelSegmentAddRequestBuilder(LiveChannelSegment liveChannelSegment)
			: this()
		{
			this.LiveChannelSegment = liveChannelSegment;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("liveChannelSegment"))
				kparams.AddIfNotNull("liveChannelSegment", LiveChannelSegment);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveChannelSegment>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<LiveChannelSegment>((IDictionary<string,object>)result);
		}
	}

	public class LiveChannelSegmentDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id
		{
			set;
			get;
		}

		public LiveChannelSegmentDeleteRequestBuilder()
			: base("livechannelsegment", "delete")
		{
		}

		public LiveChannelSegmentDeleteRequestBuilder(long id)
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
		public override object DeserializeObject(object result)
		{
			return null;
		}
	}

	public class LiveChannelSegmentGetRequestBuilder : RequestBuilder<LiveChannelSegment>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id
		{
			set;
			get;
		}

		public LiveChannelSegmentGetRequestBuilder()
			: base("livechannelsegment", "get")
		{
		}

		public LiveChannelSegmentGetRequestBuilder(long id)
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
			return ObjectFactory.Create<LiveChannelSegment>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<LiveChannelSegment>((IDictionary<string,object>)result);
		}
	}

	public class LiveChannelSegmentListRequestBuilder : RequestBuilder<ListResponse<LiveChannelSegment>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public LiveChannelSegmentFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public LiveChannelSegmentListRequestBuilder()
			: base("livechannelsegment", "list")
		{
		}

		public LiveChannelSegmentListRequestBuilder(LiveChannelSegmentFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<LiveChannelSegment>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<LiveChannelSegment>>((IDictionary<string,object>)result);
		}
	}

	public class LiveChannelSegmentUpdateRequestBuilder : RequestBuilder<LiveChannelSegment>
	{
		#region Constants
		public const string ID = "id";
		public const string LIVE_CHANNEL_SEGMENT = "liveChannelSegment";
		#endregion

		public long Id
		{
			set;
			get;
		}
		public LiveChannelSegment LiveChannelSegment
		{
			set;
			get;
		}

		public LiveChannelSegmentUpdateRequestBuilder()
			: base("livechannelsegment", "update")
		{
		}

		public LiveChannelSegmentUpdateRequestBuilder(long id, LiveChannelSegment liveChannelSegment)
			: this()
		{
			this.Id = id;
			this.LiveChannelSegment = liveChannelSegment;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("liveChannelSegment"))
				kparams.AddIfNotNull("liveChannelSegment", LiveChannelSegment);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveChannelSegment>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<LiveChannelSegment>((IDictionary<string,object>)result);
		}
	}


	public class LiveChannelSegmentService
	{
		private LiveChannelSegmentService()
		{
		}

		public static LiveChannelSegmentAddRequestBuilder Add(LiveChannelSegment liveChannelSegment)
		{
			return new LiveChannelSegmentAddRequestBuilder(liveChannelSegment);
		}

		public static LiveChannelSegmentDeleteRequestBuilder Delete(long id)
		{
			return new LiveChannelSegmentDeleteRequestBuilder(id);
		}

		public static LiveChannelSegmentGetRequestBuilder Get(long id)
		{
			return new LiveChannelSegmentGetRequestBuilder(id);
		}

		public static LiveChannelSegmentListRequestBuilder List(LiveChannelSegmentFilter filter = null, FilterPager pager = null)
		{
			return new LiveChannelSegmentListRequestBuilder(filter, pager);
		}

		public static LiveChannelSegmentUpdateRequestBuilder Update(long id, LiveChannelSegment liveChannelSegment)
		{
			return new LiveChannelSegmentUpdateRequestBuilder(id, liveChannelSegment);
		}
	}
}
