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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class PermissionItemAddRequestBuilder : RequestBuilder<PermissionItem>
	{
		#region Constants
		public const string PERMISSION_ITEM = "permissionItem";
		#endregion

		public PermissionItem PermissionItem { get; set; }

		public PermissionItemAddRequestBuilder()
			: base("permissionitem", "add")
		{
		}

		public PermissionItemAddRequestBuilder(PermissionItem permissionItem)
			: this()
		{
			this.PermissionItem = permissionItem;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("permissionItem"))
				kparams.AddIfNotNull("permissionItem", PermissionItem);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PermissionItem>(result);
		}
	}

	public class PermissionItemDeleteRequestBuilder : RequestBuilder<PermissionItem>
	{
		#region Constants
		public const string PERMISSION_ITEM_ID = "permissionItemId";
		#endregion

		public int PermissionItemId { get; set; }

		public PermissionItemDeleteRequestBuilder()
			: base("permissionitem", "delete")
		{
		}

		public PermissionItemDeleteRequestBuilder(int permissionItemId)
			: this()
		{
			this.PermissionItemId = permissionItemId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("permissionItemId"))
				kparams.AddIfNotNull("permissionItemId", PermissionItemId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PermissionItem>(result);
		}
	}

	public class PermissionItemGetRequestBuilder : RequestBuilder<PermissionItem>
	{
		#region Constants
		public const string PERMISSION_ITEM_ID = "permissionItemId";
		#endregion

		public int PermissionItemId { get; set; }

		public PermissionItemGetRequestBuilder()
			: base("permissionitem", "get")
		{
		}

		public PermissionItemGetRequestBuilder(int permissionItemId)
			: this()
		{
			this.PermissionItemId = permissionItemId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("permissionItemId"))
				kparams.AddIfNotNull("permissionItemId", PermissionItemId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PermissionItem>(result);
		}
	}

	public class PermissionItemListRequestBuilder : RequestBuilder<ListResponse<PermissionItem>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public PermissionItemFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public PermissionItemListRequestBuilder()
			: base("permissionitem", "list")
		{
		}

		public PermissionItemListRequestBuilder(PermissionItemFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<PermissionItem>>(result);
		}
	}

	public class PermissionItemUpdateRequestBuilder : RequestBuilder<PermissionItem>
	{
		#region Constants
		public const string PERMISSION_ITEM_ID = "permissionItemId";
		public const string PERMISSION_ITEM = "permissionItem";
		#endregion

		public int PermissionItemId { get; set; }
		public PermissionItem PermissionItem { get; set; }

		public PermissionItemUpdateRequestBuilder()
			: base("permissionitem", "update")
		{
		}

		public PermissionItemUpdateRequestBuilder(int permissionItemId, PermissionItem permissionItem)
			: this()
		{
			this.PermissionItemId = permissionItemId;
			this.PermissionItem = permissionItem;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("permissionItemId"))
				kparams.AddIfNotNull("permissionItemId", PermissionItemId);
			if (!isMapped("permissionItem"))
				kparams.AddIfNotNull("permissionItem", PermissionItem);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PermissionItem>(result);
		}
	}


	public class PermissionItemService
	{
		private PermissionItemService()
		{
		}

		public static PermissionItemAddRequestBuilder Add(PermissionItem permissionItem)
		{
			return new PermissionItemAddRequestBuilder(permissionItem);
		}

		public static PermissionItemDeleteRequestBuilder Delete(int permissionItemId)
		{
			return new PermissionItemDeleteRequestBuilder(permissionItemId);
		}

		public static PermissionItemGetRequestBuilder Get(int permissionItemId)
		{
			return new PermissionItemGetRequestBuilder(permissionItemId);
		}

		public static PermissionItemListRequestBuilder List(PermissionItemFilter filter = null, FilterPager pager = null)
		{
			return new PermissionItemListRequestBuilder(filter, pager);
		}

		public static PermissionItemUpdateRequestBuilder Update(int permissionItemId, PermissionItem permissionItem)
		{
			return new PermissionItemUpdateRequestBuilder(permissionItemId, permissionItem);
		}
	}
}
