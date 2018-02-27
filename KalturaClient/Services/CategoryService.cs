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

namespace Kaltura.Services
{
	public class CategoryAddRequestBuilder : RequestBuilder<Category>
	{
		#region Constants
		public const string CATEGORY = "category";
		#endregion

		public Category Category
		{
			set;
			get;
		}

		public CategoryAddRequestBuilder()
			: base("category", "add")
		{
		}

		public CategoryAddRequestBuilder(Category category)
			: this()
		{
			this.Category = category;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("category"))
				kparams.AddIfNotNull("category", Category);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Category>(result);
		}
	}

	public class CategoryAddFromBulkUploadRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		public const string BULK_UPLOAD_CATEGORY_DATA = "bulkUploadCategoryData";
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
		public BulkUploadCategoryData BulkUploadCategoryData
		{
			set;
			get;
		}

		public CategoryAddFromBulkUploadRequestBuilder()
			: base("category", "addFromBulkUpload")
		{
		}

		public CategoryAddFromBulkUploadRequestBuilder(Stream fileData, BulkUploadJobData bulkUploadData, BulkUploadCategoryData bulkUploadCategoryData)
			: this()
		{
			this.FileData = fileData;
			this.BulkUploadData = bulkUploadData;
			this.BulkUploadCategoryData = bulkUploadCategoryData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadData"))
				kparams.AddIfNotNull("bulkUploadData", BulkUploadData);
			if (!isMapped("bulkUploadCategoryData"))
				kparams.AddIfNotNull("bulkUploadCategoryData", BulkUploadCategoryData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("fileData", FileData);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class CategoryDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		public const string MOVE_ENTRIES_TO_PARENT_CATEGORY = "moveEntriesToParentCategory";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public NullableBoolean MoveEntriesToParentCategory
		{
			set;
			get;
		}

		public CategoryDeleteRequestBuilder()
			: base("category", "delete")
		{
		}

		public CategoryDeleteRequestBuilder(int id, NullableBoolean moveEntriesToParentCategory)
			: this()
		{
			this.Id = id;
			this.MoveEntriesToParentCategory = moveEntriesToParentCategory;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("moveEntriesToParentCategory"))
				kparams.AddIfNotNull("moveEntriesToParentCategory", MoveEntriesToParentCategory);
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

	public class CategoryGetRequestBuilder : RequestBuilder<Category>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public CategoryGetRequestBuilder()
			: base("category", "get")
		{
		}

		public CategoryGetRequestBuilder(int id)
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
			return ObjectFactory.Create<Category>(result);
		}
	}

	public class CategoryIndexRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string ID = "id";
		public const string SHOULD_UPDATE = "shouldUpdate";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public bool ShouldUpdate
		{
			set;
			get;
		}

		public CategoryIndexRequestBuilder()
			: base("category", "index")
		{
		}

		public CategoryIndexRequestBuilder(int id, bool shouldUpdate)
			: this()
		{
			this.Id = id;
			this.ShouldUpdate = shouldUpdate;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("shouldUpdate"))
				kparams.AddIfNotNull("shouldUpdate", ShouldUpdate);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return int.Parse(result.InnerText);
		}
	}

	public class CategoryListRequestBuilder : RequestBuilder<ListResponse<Category>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public CategoryFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public CategoryListRequestBuilder()
			: base("category", "list")
		{
		}

		public CategoryListRequestBuilder(CategoryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Category>>(result);
		}
	}

	public class CategoryMoveRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string CATEGORY_IDS = "categoryIds";
		public const string TARGET_CATEGORY_PARENT_ID = "targetCategoryParentId";
		#endregion

		public string CategoryIds
		{
			set;
			get;
		}
		public int TargetCategoryParentId
		{
			set;
			get;
		}

		public CategoryMoveRequestBuilder()
			: base("category", "move")
		{
		}

		public CategoryMoveRequestBuilder(string categoryIds, int targetCategoryParentId)
			: this()
		{
			this.CategoryIds = categoryIds;
			this.TargetCategoryParentId = targetCategoryParentId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryIds"))
				kparams.AddIfNotNull("categoryIds", CategoryIds);
			if (!isMapped("targetCategoryParentId"))
				kparams.AddIfNotNull("targetCategoryParentId", TargetCategoryParentId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class CategoryUnlockCategoriesRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		#endregion


		public CategoryUnlockCategoriesRequestBuilder()
			: base("category", "unlockCategories")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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

	public class CategoryUpdateRequestBuilder : RequestBuilder<Category>
	{
		#region Constants
		public const string ID = "id";
		public const string CATEGORY = "category";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public Category Category
		{
			set;
			get;
		}

		public CategoryUpdateRequestBuilder()
			: base("category", "update")
		{
		}

		public CategoryUpdateRequestBuilder(int id, Category category)
			: this()
		{
			this.Id = id;
			this.Category = category;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("category"))
				kparams.AddIfNotNull("category", Category);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Category>(result);
		}
	}


	public class CategoryService
	{
		private CategoryService()
		{
		}

		public static CategoryAddRequestBuilder Add(Category category)
		{
			return new CategoryAddRequestBuilder(category);
		}

		public static CategoryAddFromBulkUploadRequestBuilder AddFromBulkUpload(Stream fileData, BulkUploadJobData bulkUploadData = null, BulkUploadCategoryData bulkUploadCategoryData = null)
		{
			return new CategoryAddFromBulkUploadRequestBuilder(fileData, bulkUploadData, bulkUploadCategoryData);
		}

		public static CategoryDeleteRequestBuilder Delete(int id, NullableBoolean moveEntriesToParentCategory = (NullableBoolean)(1))
		{
			return new CategoryDeleteRequestBuilder(id, moveEntriesToParentCategory);
		}

		public static CategoryGetRequestBuilder Get(int id)
		{
			return new CategoryGetRequestBuilder(id);
		}

		public static CategoryIndexRequestBuilder Index(int id, bool shouldUpdate = true)
		{
			return new CategoryIndexRequestBuilder(id, shouldUpdate);
		}

		public static CategoryListRequestBuilder List(CategoryFilter filter = null, FilterPager pager = null)
		{
			return new CategoryListRequestBuilder(filter, pager);
		}

		public static CategoryMoveRequestBuilder Move(string categoryIds, int targetCategoryParentId)
		{
			return new CategoryMoveRequestBuilder(categoryIds, targetCategoryParentId);
		}

		public static CategoryUnlockCategoriesRequestBuilder UnlockCategories()
		{
			return new CategoryUnlockCategoriesRequestBuilder();
		}

		public static CategoryUpdateRequestBuilder Update(int id, Category category)
		{
			return new CategoryUpdateRequestBuilder(id, category);
		}
	}
}
