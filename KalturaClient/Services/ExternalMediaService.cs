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
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class ExternalMediaAddRequestBuilder : RequestBuilder<ExternalMediaEntry>
	{
		#region Constants
		public const string ENTRY = "entry";
		#endregion

		public ExternalMediaEntry Entry
		{
			set;
			get;
		}

		public ExternalMediaAddRequestBuilder()
			: base("externalmedia_externalmedia", "add")
		{
		}

		public ExternalMediaAddRequestBuilder(ExternalMediaEntry entry)
			: this()
		{
			this.Entry = entry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entry"))
				kparams.AddIfNotNull("entry", Entry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ExternalMediaEntry>(result);
		}
	}

	public class ExternalMediaCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public ExternalMediaEntryFilter Filter
		{
			set;
			get;
		}

		public ExternalMediaCountRequestBuilder()
			: base("externalmedia_externalmedia", "count")
		{
		}

		public ExternalMediaCountRequestBuilder(ExternalMediaEntryFilter filter)
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
			return result.Value<int>();
		}
	}

	public class ExternalMediaDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public ExternalMediaDeleteRequestBuilder()
			: base("externalmedia_externalmedia", "delete")
		{
		}

		public ExternalMediaDeleteRequestBuilder(string id)
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

	public class ExternalMediaGetRequestBuilder : RequestBuilder<ExternalMediaEntry>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public ExternalMediaGetRequestBuilder()
			: base("externalmedia_externalmedia", "get")
		{
		}

		public ExternalMediaGetRequestBuilder(string id)
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
			return ObjectFactory.Create<ExternalMediaEntry>(result);
		}
	}

	public class ExternalMediaListRequestBuilder : RequestBuilder<ListResponse<ExternalMediaEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ExternalMediaEntryFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ExternalMediaListRequestBuilder()
			: base("externalmedia_externalmedia", "list")
		{
		}

		public ExternalMediaListRequestBuilder(ExternalMediaEntryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ExternalMediaEntry>>(result);
		}
	}

	public class ExternalMediaUpdateRequestBuilder : RequestBuilder<ExternalMediaEntry>
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY = "entry";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public ExternalMediaEntry Entry
		{
			set;
			get;
		}

		public ExternalMediaUpdateRequestBuilder()
			: base("externalmedia_externalmedia", "update")
		{
		}

		public ExternalMediaUpdateRequestBuilder(string id, ExternalMediaEntry entry)
			: this()
		{
			this.Id = id;
			this.Entry = entry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("entry"))
				kparams.AddIfNotNull("entry", Entry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ExternalMediaEntry>(result);
		}
	}


	public class ExternalMediaService
	{
		private ExternalMediaService()
		{
		}

		public static ExternalMediaAddRequestBuilder Add(ExternalMediaEntry entry)
		{
			return new ExternalMediaAddRequestBuilder(entry);
		}

		public static ExternalMediaCountRequestBuilder Count(ExternalMediaEntryFilter filter = null)
		{
			return new ExternalMediaCountRequestBuilder(filter);
		}

		public static ExternalMediaDeleteRequestBuilder Delete(string id)
		{
			return new ExternalMediaDeleteRequestBuilder(id);
		}

		public static ExternalMediaGetRequestBuilder Get(string id)
		{
			return new ExternalMediaGetRequestBuilder(id);
		}

		public static ExternalMediaListRequestBuilder List(ExternalMediaEntryFilter filter = null, FilterPager pager = null)
		{
			return new ExternalMediaListRequestBuilder(filter, pager);
		}

		public static ExternalMediaUpdateRequestBuilder Update(string id, ExternalMediaEntry entry)
		{
			return new ExternalMediaUpdateRequestBuilder(id, entry);
		}
	}
}
