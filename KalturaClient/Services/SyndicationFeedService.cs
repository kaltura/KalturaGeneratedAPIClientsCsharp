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
	public class SyndicationFeedAddRequestBuilder : RequestBuilder<BaseSyndicationFeed>
	{
		#region Constants
		public const string SYNDICATION_FEED = "syndicationFeed";
		#endregion

		public BaseSyndicationFeed SyndicationFeed { get; set; }

		public SyndicationFeedAddRequestBuilder()
			: base("syndicationfeed", "add")
		{
		}

		public SyndicationFeedAddRequestBuilder(BaseSyndicationFeed syndicationFeed)
			: this()
		{
			this.SyndicationFeed = syndicationFeed;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("syndicationFeed"))
				kparams.AddIfNotNull("syndicationFeed", SyndicationFeed);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseSyndicationFeed>(result);
		}
	}

	public class SyndicationFeedDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public SyndicationFeedDeleteRequestBuilder()
			: base("syndicationfeed", "delete")
		{
		}

		public SyndicationFeedDeleteRequestBuilder(string id)
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

	public class SyndicationFeedGetRequestBuilder : RequestBuilder<BaseSyndicationFeed>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public SyndicationFeedGetRequestBuilder()
			: base("syndicationfeed", "get")
		{
		}

		public SyndicationFeedGetRequestBuilder(string id)
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
			return ObjectFactory.Create<BaseSyndicationFeed>(result);
		}
	}

	public class SyndicationFeedGetEntryCountRequestBuilder : RequestBuilder<SyndicationFeedEntryCount>
	{
		#region Constants
		public const string FEED_ID = "feedId";
		#endregion

		public string FeedId { get; set; }

		public SyndicationFeedGetEntryCountRequestBuilder()
			: base("syndicationfeed", "getEntryCount")
		{
		}

		public SyndicationFeedGetEntryCountRequestBuilder(string feedId)
			: this()
		{
			this.FeedId = feedId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("feedId"))
				kparams.AddIfNotNull("feedId", FeedId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SyndicationFeedEntryCount>(result);
		}
	}

	public class SyndicationFeedListRequestBuilder : RequestBuilder<ListResponse<BaseSyndicationFeed>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public BaseSyndicationFeedFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public SyndicationFeedListRequestBuilder()
			: base("syndicationfeed", "list")
		{
		}

		public SyndicationFeedListRequestBuilder(BaseSyndicationFeedFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<BaseSyndicationFeed>>(result);
		}
	}

	public class SyndicationFeedRequestConversionRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FEED_ID = "feedId";
		#endregion

		public string FeedId { get; set; }

		public SyndicationFeedRequestConversionRequestBuilder()
			: base("syndicationfeed", "requestConversion")
		{
		}

		public SyndicationFeedRequestConversionRequestBuilder(string feedId)
			: this()
		{
			this.FeedId = feedId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("feedId"))
				kparams.AddIfNotNull("feedId", FeedId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class SyndicationFeedUpdateRequestBuilder : RequestBuilder<BaseSyndicationFeed>
	{
		#region Constants
		public const string ID = "id";
		public const string SYNDICATION_FEED = "syndicationFeed";
		#endregion

		public string Id { get; set; }
		public BaseSyndicationFeed SyndicationFeed { get; set; }

		public SyndicationFeedUpdateRequestBuilder()
			: base("syndicationfeed", "update")
		{
		}

		public SyndicationFeedUpdateRequestBuilder(string id, BaseSyndicationFeed syndicationFeed)
			: this()
		{
			this.Id = id;
			this.SyndicationFeed = syndicationFeed;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("syndicationFeed"))
				kparams.AddIfNotNull("syndicationFeed", SyndicationFeed);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseSyndicationFeed>(result);
		}
	}


	public class SyndicationFeedService
	{
		private SyndicationFeedService()
		{
		}

		public static SyndicationFeedAddRequestBuilder Add(BaseSyndicationFeed syndicationFeed)
		{
			return new SyndicationFeedAddRequestBuilder(syndicationFeed);
		}

		public static SyndicationFeedDeleteRequestBuilder Delete(string id)
		{
			return new SyndicationFeedDeleteRequestBuilder(id);
		}

		public static SyndicationFeedGetRequestBuilder Get(string id)
		{
			return new SyndicationFeedGetRequestBuilder(id);
		}

		public static SyndicationFeedGetEntryCountRequestBuilder GetEntryCount(string feedId)
		{
			return new SyndicationFeedGetEntryCountRequestBuilder(feedId);
		}

		public static SyndicationFeedListRequestBuilder List(BaseSyndicationFeedFilter filter = null, FilterPager pager = null)
		{
			return new SyndicationFeedListRequestBuilder(filter, pager);
		}

		public static SyndicationFeedRequestConversionRequestBuilder RequestConversion(string feedId)
		{
			return new SyndicationFeedRequestConversionRequestBuilder(feedId);
		}

		public static SyndicationFeedUpdateRequestBuilder Update(string id, BaseSyndicationFeed syndicationFeed)
		{
			return new SyndicationFeedUpdateRequestBuilder(id, syndicationFeed);
		}
	}
}
