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
	public class CategoryEntryActivateRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CATEGORY_ID = "categoryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int CategoryId
		{
			set;
			get;
		}

		public CategoryEntryActivateRequestBuilder()
			: base("categoryentry", "activate")
		{
		}

		public CategoryEntryActivateRequestBuilder(string entryId, int categoryId)
			: this()
		{
			this.EntryId = entryId;
			this.CategoryId = categoryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
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

	public class CategoryEntryAddRequestBuilder : RequestBuilder<CategoryEntry>
	{
		#region Constants
		public const string CATEGORY_ENTRY = "categoryEntry";
		#endregion

		public CategoryEntry CategoryEntry
		{
			set;
			get;
		}

		public CategoryEntryAddRequestBuilder()
			: base("categoryentry", "add")
		{
		}

		public CategoryEntryAddRequestBuilder(CategoryEntry categoryEntry)
			: this()
		{
			this.CategoryEntry = categoryEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryEntry"))
				kparams.AddIfNotNull("categoryEntry", CategoryEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CategoryEntry>(result);
		}
	}

	public class CategoryEntryAddFromBulkUploadRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		public const string BULK_UPLOAD_CATEGORY_ENTRY_DATA = "bulkUploadCategoryEntryData";
		#endregion

		public BulkServiceData BulkUploadData
		{
			set;
			get;
		}
		public BulkUploadCategoryEntryData BulkUploadCategoryEntryData
		{
			set;
			get;
		}

		public CategoryEntryAddFromBulkUploadRequestBuilder()
			: base("categoryentry", "addFromBulkUpload")
		{
		}

		public CategoryEntryAddFromBulkUploadRequestBuilder(BulkServiceData bulkUploadData, BulkUploadCategoryEntryData bulkUploadCategoryEntryData)
			: this()
		{
			this.BulkUploadData = bulkUploadData;
			this.BulkUploadCategoryEntryData = bulkUploadCategoryEntryData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadData"))
				kparams.AddIfNotNull("bulkUploadData", BulkUploadData);
			if (!isMapped("bulkUploadCategoryEntryData"))
				kparams.AddIfNotNull("bulkUploadCategoryEntryData", BulkUploadCategoryEntryData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class CategoryEntryDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CATEGORY_ID = "categoryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int CategoryId
		{
			set;
			get;
		}

		public CategoryEntryDeleteRequestBuilder()
			: base("categoryentry", "delete")
		{
		}

		public CategoryEntryDeleteRequestBuilder(string entryId, int categoryId)
			: this()
		{
			this.EntryId = entryId;
			this.CategoryId = categoryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
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

	public class CategoryEntryIndexRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CATEGORY_ID = "categoryId";
		public const string SHOULD_UPDATE = "shouldUpdate";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int CategoryId
		{
			set;
			get;
		}
		public bool ShouldUpdate
		{
			set;
			get;
		}

		public CategoryEntryIndexRequestBuilder()
			: base("categoryentry", "index")
		{
		}

		public CategoryEntryIndexRequestBuilder(string entryId, int categoryId, bool shouldUpdate)
			: this()
		{
			this.EntryId = entryId;
			this.CategoryId = categoryId;
			this.ShouldUpdate = shouldUpdate;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
			if (!isMapped("shouldUpdate"))
				kparams.AddIfNotNull("shouldUpdate", ShouldUpdate);
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

	public class CategoryEntryListRequestBuilder : RequestBuilder<ListResponse<CategoryEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public CategoryEntryFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public CategoryEntryListRequestBuilder()
			: base("categoryentry", "list")
		{
		}

		public CategoryEntryListRequestBuilder(CategoryEntryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<CategoryEntry>>(result);
		}
	}

	public class CategoryEntryRejectRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CATEGORY_ID = "categoryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int CategoryId
		{
			set;
			get;
		}

		public CategoryEntryRejectRequestBuilder()
			: base("categoryentry", "reject")
		{
		}

		public CategoryEntryRejectRequestBuilder(string entryId, int categoryId)
			: this()
		{
			this.EntryId = entryId;
			this.CategoryId = categoryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
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

	public class CategoryEntrySyncPrivacyContextRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CATEGORY_ID = "categoryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int CategoryId
		{
			set;
			get;
		}

		public CategoryEntrySyncPrivacyContextRequestBuilder()
			: base("categoryentry", "syncPrivacyContext")
		{
		}

		public CategoryEntrySyncPrivacyContextRequestBuilder(string entryId, int categoryId)
			: this()
		{
			this.EntryId = entryId;
			this.CategoryId = categoryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
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

	public class CategoryEntryUpdateStatusFromBulkRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		public const string BULK_UPLOAD_CATEGORY_ENTRY_DATA = "bulkUploadCategoryEntryData";
		#endregion

		public Stream FileData
		{
			set;
			get;
		}
		public BulkUploadJobData BulkUploadData
		{
			set;
			get;
		}
		public BulkUploadCategoryEntryData BulkUploadCategoryEntryData
		{
			set;
			get;
		}

		public CategoryEntryUpdateStatusFromBulkRequestBuilder()
			: base("categoryentry", "updateStatusFromBulk")
		{
		}

		public CategoryEntryUpdateStatusFromBulkRequestBuilder(Stream fileData, BulkUploadJobData bulkUploadData, BulkUploadCategoryEntryData bulkUploadCategoryEntryData)
			: this()
		{
			this.FileData = fileData;
			this.BulkUploadData = bulkUploadData;
			this.BulkUploadCategoryEntryData = bulkUploadCategoryEntryData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadData"))
				kparams.AddIfNotNull("bulkUploadData", BulkUploadData);
			if (!isMapped("bulkUploadCategoryEntryData"))
				kparams.AddIfNotNull("bulkUploadCategoryEntryData", BulkUploadCategoryEntryData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("fileData", FileData);
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}


	public class CategoryEntryService
	{
		private CategoryEntryService()
		{
		}

		public static CategoryEntryActivateRequestBuilder Activate(string entryId, int categoryId)
		{
			return new CategoryEntryActivateRequestBuilder(entryId, categoryId);
		}

		public static CategoryEntryAddRequestBuilder Add(CategoryEntry categoryEntry)
		{
			return new CategoryEntryAddRequestBuilder(categoryEntry);
		}

		public static CategoryEntryAddFromBulkUploadRequestBuilder AddFromBulkUpload(BulkServiceData bulkUploadData, BulkUploadCategoryEntryData bulkUploadCategoryEntryData = null)
		{
			return new CategoryEntryAddFromBulkUploadRequestBuilder(bulkUploadData, bulkUploadCategoryEntryData);
		}

		public static CategoryEntryDeleteRequestBuilder Delete(string entryId, int categoryId)
		{
			return new CategoryEntryDeleteRequestBuilder(entryId, categoryId);
		}

		public static CategoryEntryIndexRequestBuilder Index(string entryId, int categoryId, bool shouldUpdate = true)
		{
			return new CategoryEntryIndexRequestBuilder(entryId, categoryId, shouldUpdate);
		}

		public static CategoryEntryListRequestBuilder List(CategoryEntryFilter filter = null, FilterPager pager = null)
		{
			return new CategoryEntryListRequestBuilder(filter, pager);
		}

		public static CategoryEntryRejectRequestBuilder Reject(string entryId, int categoryId)
		{
			return new CategoryEntryRejectRequestBuilder(entryId, categoryId);
		}

		public static CategoryEntrySyncPrivacyContextRequestBuilder SyncPrivacyContext(string entryId, int categoryId)
		{
			return new CategoryEntrySyncPrivacyContextRequestBuilder(entryId, categoryId);
		}

		public static CategoryEntryUpdateStatusFromBulkRequestBuilder UpdateStatusFromBulk(Stream fileData, BulkUploadJobData bulkUploadData = null, BulkUploadCategoryEntryData bulkUploadCategoryEntryData = null)
		{
			return new CategoryEntryUpdateStatusFromBulkRequestBuilder(fileData, bulkUploadData, bulkUploadCategoryEntryData);
		}
	}
}
