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
// Copyright (C) 2006-2021  Kaltura Inc.
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

		public VendorCatalogItem VendorCatalogItem { get; set; }

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

	public class VendorCatalogItemAddFromBulkUploadRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		public const string BULK_UPLOAD_VENDOR_CATALOG_ITEM_DATA = "bulkUploadVendorCatalogItemData";
		#endregion

		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }
		public BulkUploadJobData BulkUploadData { get; set; }
		public BulkUploadVendorCatalogItemData BulkUploadVendorCatalogItemData { get; set; }

		public VendorCatalogItemAddFromBulkUploadRequestBuilder()
			: base("reach_vendorcatalogitem", "addFromBulkUpload")
		{
		}

		public VendorCatalogItemAddFromBulkUploadRequestBuilder(Stream fileData, BulkUploadJobData bulkUploadData, BulkUploadVendorCatalogItemData bulkUploadVendorCatalogItemData)
			: this()
		{
			this.FileData = fileData;
			this.BulkUploadData = bulkUploadData;
			this.BulkUploadVendorCatalogItemData = bulkUploadVendorCatalogItemData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadData"))
				kparams.AddIfNotNull("bulkUploadData", BulkUploadData);
			if (!isMapped("bulkUploadVendorCatalogItemData"))
				kparams.AddIfNotNull("bulkUploadVendorCatalogItemData", BulkUploadVendorCatalogItemData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("fileData", new FileData(FileData, FileData_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class VendorCatalogItemDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

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

		public int Id { get; set; }

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

	public class VendorCatalogItemGetServeUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string VENDOR_PARTNER_ID = "vendorPartnerId";
		#endregion

		public int VendorPartnerId { get; set; }

		public VendorCatalogItemGetServeUrlRequestBuilder()
			: base("reach_vendorcatalogitem", "getServeUrl")
		{
		}

		public VendorCatalogItemGetServeUrlRequestBuilder(int vendorPartnerId)
			: this()
		{
			this.VendorPartnerId = vendorPartnerId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("vendorPartnerId"))
				kparams.AddIfNotNull("vendorPartnerId", VendorPartnerId);
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

	public class VendorCatalogItemListRequestBuilder : RequestBuilder<ListResponse<VendorCatalogItem>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public VendorCatalogItemFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

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

		public int Id { get; set; }
		public VendorCatalogItem VendorCatalogItem { get; set; }

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

		public int Id { get; set; }
		public VendorCatalogItemStatus Status { get; set; }

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

		public static VendorCatalogItemAddFromBulkUploadRequestBuilder AddFromBulkUpload(Stream fileData, BulkUploadJobData bulkUploadData = null, BulkUploadVendorCatalogItemData bulkUploadVendorCatalogItemData = null)
		{
			return new VendorCatalogItemAddFromBulkUploadRequestBuilder(fileData, bulkUploadData, bulkUploadVendorCatalogItemData);
		}

		public static VendorCatalogItemDeleteRequestBuilder Delete(int id)
		{
			return new VendorCatalogItemDeleteRequestBuilder(id);
		}

		public static VendorCatalogItemGetRequestBuilder Get(int id)
		{
			return new VendorCatalogItemGetRequestBuilder(id);
		}

		public static VendorCatalogItemGetServeUrlRequestBuilder GetServeUrl(int vendorPartnerId = Int32.MinValue)
		{
			return new VendorCatalogItemGetServeUrlRequestBuilder(vendorPartnerId);
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
