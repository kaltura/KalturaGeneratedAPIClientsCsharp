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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class EntryServerNodeGetRequestBuilder : RequestBuilder<EntryServerNode>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public EntryServerNodeGetRequestBuilder()
			: base("entryservernode", "get")
		{
		}

		public EntryServerNodeGetRequestBuilder(string id)
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
			return ObjectFactory.Create<EntryServerNode>(result);
		}
	}

	public class EntryServerNodeListRequestBuilder : RequestBuilder<ListResponse<EntryServerNode>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public EntryServerNodeFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public EntryServerNodeListRequestBuilder()
			: base("entryservernode", "list")
		{
		}

		public EntryServerNodeListRequestBuilder(EntryServerNodeFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<EntryServerNode>>(result);
		}
	}

	public class EntryServerNodeUpdateRequestBuilder : RequestBuilder<EntryServerNode>
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_SERVER_NODE = "entryServerNode";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public EntryServerNode EntryServerNode
		{
			set;
			get;
		}

		public EntryServerNodeUpdateRequestBuilder()
			: base("entryservernode", "update")
		{
		}

		public EntryServerNodeUpdateRequestBuilder(int id, EntryServerNode entryServerNode)
			: this()
		{
			this.Id = id;
			this.EntryServerNode = entryServerNode;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("entryServerNode"))
				kparams.AddIfNotNull("entryServerNode", EntryServerNode);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryServerNode>(result);
		}
	}

	public class EntryServerNodeValidateRegisteredEntryServerNodeRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EntryServerNodeValidateRegisteredEntryServerNodeRequestBuilder()
			: base("entryservernode", "validateRegisteredEntryServerNode")
		{
		}

		public EntryServerNodeValidateRegisteredEntryServerNodeRequestBuilder(int id)
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
	}


	public class EntryServerNodeService
	{
		private EntryServerNodeService()
		{
		}

		public static EntryServerNodeGetRequestBuilder Get(string id)
		{
			return new EntryServerNodeGetRequestBuilder(id);
		}

		public static EntryServerNodeListRequestBuilder List(EntryServerNodeFilter filter = null, FilterPager pager = null)
		{
			return new EntryServerNodeListRequestBuilder(filter, pager);
		}

		public static EntryServerNodeUpdateRequestBuilder Update(int id, EntryServerNode entryServerNode)
		{
			return new EntryServerNodeUpdateRequestBuilder(id, entryServerNode);
		}

		public static EntryServerNodeValidateRegisteredEntryServerNodeRequestBuilder ValidateRegisteredEntryServerNode(int id)
		{
			return new EntryServerNodeValidateRegisteredEntryServerNodeRequestBuilder(id);
		}
	}
}
