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
	public class DataAddRequestBuilder : RequestBuilder<DataEntry>
	{
		#region Constants
		public const string DATA_ENTRY = "dataEntry";
		#endregion

		public DataEntry DataEntry { get; set; }

		public DataAddRequestBuilder()
			: base("data", "add")
		{
		}

		public DataAddRequestBuilder(DataEntry dataEntry)
			: this()
		{
			this.DataEntry = dataEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dataEntry"))
				kparams.AddIfNotNull("dataEntry", DataEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DataEntry>(result);
		}
	}

	public class DataAddContentRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RESOURCE = "resource";
		#endregion

		public string EntryId { get; set; }
		public GenericDataCenterContentResource Resource { get; set; }

		public DataAddContentRequestBuilder()
			: base("data", "addContent")
		{
		}

		public DataAddContentRequestBuilder(string entryId, GenericDataCenterContentResource resource)
			: this()
		{
			this.EntryId = entryId;
			this.Resource = resource;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("resource"))
				kparams.AddIfNotNull("resource", Resource);
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

	public class DataDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public DataDeleteRequestBuilder()
			: base("data", "delete")
		{
		}

		public DataDeleteRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
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

	public class DataGetRequestBuilder : RequestBuilder<DataEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string VERSION = "version";
		#endregion

		public string EntryId { get; set; }
		public int Version { get; set; }

		public DataGetRequestBuilder()
			: base("data", "get")
		{
		}

		public DataGetRequestBuilder(string entryId, int version)
			: this()
		{
			this.EntryId = entryId;
			this.Version = version;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("version"))
				kparams.AddIfNotNull("version", Version);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DataEntry>(result);
		}
	}

	public class DataListRequestBuilder : RequestBuilder<ListResponse<DataEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DataEntryFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public DataListRequestBuilder()
			: base("data", "list")
		{
		}

		public DataListRequestBuilder(DataEntryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DataEntry>>(result);
		}
	}

	public class DataUpdateRequestBuilder : RequestBuilder<DataEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string DOCUMENT_ENTRY = "documentEntry";
		#endregion

		public string EntryId { get; set; }
		public DataEntry DocumentEntry { get; set; }

		public DataUpdateRequestBuilder()
			: base("data", "update")
		{
		}

		public DataUpdateRequestBuilder(string entryId, DataEntry documentEntry)
			: this()
		{
			this.EntryId = entryId;
			this.DocumentEntry = documentEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("documentEntry"))
				kparams.AddIfNotNull("documentEntry", DocumentEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DataEntry>(result);
		}
	}


	public class DataService
	{
		private DataService()
		{
		}

		public static DataAddRequestBuilder Add(DataEntry dataEntry)
		{
			return new DataAddRequestBuilder(dataEntry);
		}

		public static DataAddContentRequestBuilder AddContent(string entryId, GenericDataCenterContentResource resource)
		{
			return new DataAddContentRequestBuilder(entryId, resource);
		}

		public static DataDeleteRequestBuilder Delete(string entryId)
		{
			return new DataDeleteRequestBuilder(entryId);
		}

		public static DataGetRequestBuilder Get(string entryId, int version = -1)
		{
			return new DataGetRequestBuilder(entryId, version);
		}

		public static DataListRequestBuilder List(DataEntryFilter filter = null, FilterPager pager = null)
		{
			return new DataListRequestBuilder(filter, pager);
		}

		public static DataUpdateRequestBuilder Update(string entryId, DataEntry documentEntry)
		{
			return new DataUpdateRequestBuilder(entryId, documentEntry);
		}
	}
}
