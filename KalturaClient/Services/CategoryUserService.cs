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
	public class CategoryUserActivateRequestBuilder : RequestBuilder<CategoryUser>
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string USER_ID = "userId";
		#endregion

		public int CategoryId { get; set; }
		public string UserId { get; set; }

		public CategoryUserActivateRequestBuilder()
			: base("categoryuser", "activate")
		{
		}

		public CategoryUserActivateRequestBuilder(int categoryId, string userId)
			: this()
		{
			this.CategoryId = categoryId;
			this.UserId = userId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CategoryUser>(result);
		}
	}

	public class CategoryUserAddRequestBuilder : RequestBuilder<CategoryUser>
	{
		#region Constants
		public const string CATEGORY_USER = "categoryUser";
		#endregion

		public CategoryUser CategoryUser { get; set; }

		public CategoryUserAddRequestBuilder()
			: base("categoryuser", "add")
		{
		}

		public CategoryUserAddRequestBuilder(CategoryUser categoryUser)
			: this()
		{
			this.CategoryUser = categoryUser;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryUser"))
				kparams.AddIfNotNull("categoryUser", CategoryUser);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CategoryUser>(result);
		}
	}

	public class CategoryUserAddFromBulkUploadRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		public const string BULK_UPLOAD_CATEGORY_USER_DATA = "bulkUploadCategoryUserData";
		#endregion

		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }
		public BulkUploadJobData BulkUploadData { get; set; }
		public BulkUploadCategoryUserData BulkUploadCategoryUserData { get; set; }

		public CategoryUserAddFromBulkUploadRequestBuilder()
			: base("categoryuser", "addFromBulkUpload")
		{
		}

		public CategoryUserAddFromBulkUploadRequestBuilder(Stream fileData, BulkUploadJobData bulkUploadData, BulkUploadCategoryUserData bulkUploadCategoryUserData)
			: this()
		{
			this.FileData = fileData;
			this.BulkUploadData = bulkUploadData;
			this.BulkUploadCategoryUserData = bulkUploadCategoryUserData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadData"))
				kparams.AddIfNotNull("bulkUploadData", BulkUploadData);
			if (!isMapped("bulkUploadCategoryUserData"))
				kparams.AddIfNotNull("bulkUploadCategoryUserData", BulkUploadCategoryUserData);
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

	public class CategoryUserCopyFromCategoryRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		#endregion

		public int CategoryId { get; set; }

		public CategoryUserCopyFromCategoryRequestBuilder()
			: base("categoryuser", "copyFromCategory")
		{
		}

		public CategoryUserCopyFromCategoryRequestBuilder(int categoryId)
			: this()
		{
			this.CategoryId = categoryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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

	public class CategoryUserDeactivateRequestBuilder : RequestBuilder<CategoryUser>
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string USER_ID = "userId";
		#endregion

		public int CategoryId { get; set; }
		public string UserId { get; set; }

		public CategoryUserDeactivateRequestBuilder()
			: base("categoryuser", "deactivate")
		{
		}

		public CategoryUserDeactivateRequestBuilder(int categoryId, string userId)
			: this()
		{
			this.CategoryId = categoryId;
			this.UserId = userId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CategoryUser>(result);
		}
	}

	public class CategoryUserDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string USER_ID = "userId";
		#endregion

		public int CategoryId { get; set; }
		public string UserId { get; set; }

		public CategoryUserDeleteRequestBuilder()
			: base("categoryuser", "delete")
		{
		}

		public CategoryUserDeleteRequestBuilder(int categoryId, string userId)
			: this()
		{
			this.CategoryId = categoryId;
			this.UserId = userId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
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

	public class CategoryUserGetRequestBuilder : RequestBuilder<CategoryUser>
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string USER_ID = "userId";
		#endregion

		public int CategoryId { get; set; }
		public string UserId { get; set; }

		public CategoryUserGetRequestBuilder()
			: base("categoryuser", "get")
		{
		}

		public CategoryUserGetRequestBuilder(int categoryId, string userId)
			: this()
		{
			this.CategoryId = categoryId;
			this.UserId = userId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CategoryUser>(result);
		}
	}

	public class CategoryUserIndexRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string CATEGORY_ID = "categoryId";
		public const string SHOULD_UPDATE = "shouldUpdate";
		#endregion

		public string UserId { get; set; }
		public int CategoryId { get; set; }
		public bool ShouldUpdate { get; set; }

		public CategoryUserIndexRequestBuilder()
			: base("categoryuser", "index")
		{
		}

		public CategoryUserIndexRequestBuilder(string userId, int categoryId, bool shouldUpdate)
			: this()
		{
			this.UserId = userId;
			this.CategoryId = categoryId;
			this.ShouldUpdate = shouldUpdate;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
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

	public class CategoryUserListRequestBuilder : RequestBuilder<ListResponse<CategoryUser>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public CategoryUserFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public CategoryUserListRequestBuilder()
			: base("categoryuser", "list")
		{
		}

		public CategoryUserListRequestBuilder(CategoryUserFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<CategoryUser>>(result);
		}
	}

	public class CategoryUserUpdateRequestBuilder : RequestBuilder<CategoryUser>
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string USER_ID = "userId";
		public const string CATEGORY_USER = "categoryUser";
		public const string OVERRIDE = "override";
		#endregion

		public int CategoryId { get; set; }
		public string UserId { get; set; }
		public CategoryUser CategoryUser { get; set; }
		public bool Override_ { get; set; }

		public CategoryUserUpdateRequestBuilder()
			: base("categoryuser", "update")
		{
		}

		public CategoryUserUpdateRequestBuilder(int categoryId, string userId, CategoryUser categoryUser, bool override_)
			: this()
		{
			this.CategoryId = categoryId;
			this.UserId = userId;
			this.CategoryUser = categoryUser;
			this.Override_ = override_;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("categoryUser"))
				kparams.AddIfNotNull("categoryUser", CategoryUser);
			if (!isMapped("override_"))
				kparams.AddIfNotNull("override_", Override_);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CategoryUser>(result);
		}
	}


	public class CategoryUserService
	{
		private CategoryUserService()
		{
		}

		public static CategoryUserActivateRequestBuilder Activate(int categoryId, string userId)
		{
			return new CategoryUserActivateRequestBuilder(categoryId, userId);
		}

		public static CategoryUserAddRequestBuilder Add(CategoryUser categoryUser)
		{
			return new CategoryUserAddRequestBuilder(categoryUser);
		}

		public static CategoryUserAddFromBulkUploadRequestBuilder AddFromBulkUpload(Stream fileData, BulkUploadJobData bulkUploadData = null, BulkUploadCategoryUserData bulkUploadCategoryUserData = null)
		{
			return new CategoryUserAddFromBulkUploadRequestBuilder(fileData, bulkUploadData, bulkUploadCategoryUserData);
		}

		public static CategoryUserCopyFromCategoryRequestBuilder CopyFromCategory(int categoryId)
		{
			return new CategoryUserCopyFromCategoryRequestBuilder(categoryId);
		}

		public static CategoryUserDeactivateRequestBuilder Deactivate(int categoryId, string userId)
		{
			return new CategoryUserDeactivateRequestBuilder(categoryId, userId);
		}

		public static CategoryUserDeleteRequestBuilder Delete(int categoryId, string userId)
		{
			return new CategoryUserDeleteRequestBuilder(categoryId, userId);
		}

		public static CategoryUserGetRequestBuilder Get(int categoryId, string userId)
		{
			return new CategoryUserGetRequestBuilder(categoryId, userId);
		}

		public static CategoryUserIndexRequestBuilder Index(string userId, int categoryId, bool shouldUpdate = true)
		{
			return new CategoryUserIndexRequestBuilder(userId, categoryId, shouldUpdate);
		}

		public static CategoryUserListRequestBuilder List(CategoryUserFilter filter = null, FilterPager pager = null)
		{
			return new CategoryUserListRequestBuilder(filter, pager);
		}

		public static CategoryUserUpdateRequestBuilder Update(int categoryId, string userId, CategoryUser categoryUser, bool override_ = false)
		{
			return new CategoryUserUpdateRequestBuilder(categoryId, userId, categoryUser, override_);
		}
	}
}
