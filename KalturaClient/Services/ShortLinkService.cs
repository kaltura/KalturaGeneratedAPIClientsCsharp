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
	public class ShortLinkAddRequestBuilder : RequestBuilder<ShortLink>
	{
		#region Constants
		public const string SHORT_LINK = "shortLink";
		#endregion

		public ShortLink ShortLink { get; set; }

		public ShortLinkAddRequestBuilder()
			: base("shortlink_shortlink", "add")
		{
		}

		public ShortLinkAddRequestBuilder(ShortLink shortLink)
			: this()
		{
			this.ShortLink = shortLink;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("shortLink"))
				kparams.AddIfNotNull("shortLink", ShortLink);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ShortLink>(result);
		}
	}

	public class ShortLinkDeleteRequestBuilder : RequestBuilder<ShortLink>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public ShortLinkDeleteRequestBuilder()
			: base("shortlink_shortlink", "delete")
		{
		}

		public ShortLinkDeleteRequestBuilder(string id)
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
			return ObjectFactory.Create<ShortLink>(result);
		}
	}

	public class ShortLinkGetRequestBuilder : RequestBuilder<ShortLink>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public ShortLinkGetRequestBuilder()
			: base("shortlink_shortlink", "get")
		{
		}

		public ShortLinkGetRequestBuilder(string id)
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
			return ObjectFactory.Create<ShortLink>(result);
		}
	}

	public class ShortLinkListRequestBuilder : RequestBuilder<ListResponse<ShortLink>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ShortLinkFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public ShortLinkListRequestBuilder()
			: base("shortlink_shortlink", "list")
		{
		}

		public ShortLinkListRequestBuilder(ShortLinkFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ShortLink>>(result);
		}
	}

	public class ShortLinkUpdateRequestBuilder : RequestBuilder<ShortLink>
	{
		#region Constants
		public const string ID = "id";
		public const string SHORT_LINK = "shortLink";
		#endregion

		public string Id { get; set; }
		public ShortLink ShortLink { get; set; }

		public ShortLinkUpdateRequestBuilder()
			: base("shortlink_shortlink", "update")
		{
		}

		public ShortLinkUpdateRequestBuilder(string id, ShortLink shortLink)
			: this()
		{
			this.Id = id;
			this.ShortLink = shortLink;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("shortLink"))
				kparams.AddIfNotNull("shortLink", ShortLink);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ShortLink>(result);
		}
	}


	public class ShortLinkService
	{
		private ShortLinkService()
		{
		}

		public static ShortLinkAddRequestBuilder Add(ShortLink shortLink)
		{
			return new ShortLinkAddRequestBuilder(shortLink);
		}

		public static ShortLinkDeleteRequestBuilder Delete(string id)
		{
			return new ShortLinkDeleteRequestBuilder(id);
		}

		public static ShortLinkGetRequestBuilder Get(string id)
		{
			return new ShortLinkGetRequestBuilder(id);
		}

		public static ShortLinkListRequestBuilder List(ShortLinkFilter filter = null, FilterPager pager = null)
		{
			return new ShortLinkListRequestBuilder(filter, pager);
		}

		public static ShortLinkUpdateRequestBuilder Update(string id, ShortLink shortLink)
		{
			return new ShortLinkUpdateRequestBuilder(id, shortLink);
		}
	}
}
