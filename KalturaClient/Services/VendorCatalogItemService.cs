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
	public class VendorCatalogItemAddRequestBuilder : RequestBuilder<VendorCatalogItem>
	{
		#region Constants
		public const string VENDOR_CATALOG_ITEM = "vendorCatalogItem";
		#endregion

		public VendorCatalogItem VendorCatalogItem
		{
			set;
			get;
		}

		public VendorCatalogItemAddRequestBuilder()
			: base("reach_vendorcatalogitem", "add")
		{
		}

		public VendorCatalogItemAddRequestBuilder(VendorCatalogItem vendorCatalogItem)
			: this()
		{
			this.VendorCatalogItem = vendorCatalogItem;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("vendorCatalogItem"))
				kparams.AddIfNotNull("vendorCatalogItem", VendorCatalogItem);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VendorCatalogItem>(result);
		}
	}

	public class VendorCatalogItemDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public VendorCatalogItemDeleteRequestBuilder()
			: base("reach_vendorcatalogitem", "delete")
		{
		}

		public VendorCatalogItemDeleteRequestBuilder(int id)
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

	public class VendorCatalogItemGetRequestBuilder : RequestBuilder<VendorCatalogItem>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public VendorCatalogItemGetRequestBuilder()
			: base("reach_vendorcatalogitem", "get")
		{
		}

		public VendorCatalogItemGetRequestBuilder(int id)
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
			return ObjectFactory.Create<VendorCatalogItem>(result);
		}
	}

	public class VendorCatalogItemListRequestBuilder : RequestBuilder<ListResponse<VendorCatalogItem>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public VendorCatalogItemFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public VendorCatalogItemListRequestBuilder()
			: base("reach_vendorcatalogitem", "list")
		{
		}

		public VendorCatalogItemListRequestBuilder(VendorCatalogItemFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<VendorCatalogItem>>(result);
		}
	}

	public class VendorCatalogItemUpdateRequestBuilder : RequestBuilder<VendorCatalogItem>
	{
		#region Constants
		public const string ID = "id";
		public const string VENDOR_CATALOG_ITEM = "vendorCatalogItem";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public VendorCatalogItem VendorCatalogItem
		{
			set;
			get;
		}

		public VendorCatalogItemUpdateRequestBuilder()
			: base("reach_vendorcatalogitem", "update")
		{
		}

		public VendorCatalogItemUpdateRequestBuilder(int id, VendorCatalogItem vendorCatalogItem)
			: this()
		{
			this.Id = id;
			this.VendorCatalogItem = vendorCatalogItem;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("vendorCatalogItem"))
				kparams.AddIfNotNull("vendorCatalogItem", VendorCatalogItem);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VendorCatalogItem>(result);
		}
	}

	public class VendorCatalogItemUpdateStatusRequestBuilder : RequestBuilder<VendorCatalogItem>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public VendorCatalogItemStatus Status
		{
			set;
			get;
		}

		public VendorCatalogItemUpdateStatusRequestBuilder()
			: base("reach_vendorcatalogitem", "updateStatus")
		{
		}

		public VendorCatalogItemUpdateStatusRequestBuilder(int id, VendorCatalogItemStatus status)
			: this()
		{
			this.Id = id;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("status"))
				kparams.AddIfNotNull("status", Status);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VendorCatalogItem>(result);
		}
	}


	public class VendorCatalogItemService
	{
		private VendorCatalogItemService()
		{
		}

		public static VendorCatalogItemAddRequestBuilder Add(VendorCatalogItem vendorCatalogItem)
		{
			return new VendorCatalogItemAddRequestBuilder(vendorCatalogItem);
		}

		public static VendorCatalogItemDeleteRequestBuilder Delete(int id)
		{
			return new VendorCatalogItemDeleteRequestBuilder(id);
		}

		public static VendorCatalogItemGetRequestBuilder Get(int id)
		{
			return new VendorCatalogItemGetRequestBuilder(id);
		}

		public static VendorCatalogItemListRequestBuilder List(VendorCatalogItemFilter filter = null, FilterPager pager = null)
		{
			return new VendorCatalogItemListRequestBuilder(filter, pager);
		}

		public static VendorCatalogItemUpdateRequestBuilder Update(int id, VendorCatalogItem vendorCatalogItem)
		{
			return new VendorCatalogItemUpdateRequestBuilder(id, vendorCatalogItem);
		}

		public static VendorCatalogItemUpdateStatusRequestBuilder UpdateStatus(int id, VendorCatalogItemStatus status)
		{
			return new VendorCatalogItemUpdateStatusRequestBuilder(id, status);
		}
	}
}
