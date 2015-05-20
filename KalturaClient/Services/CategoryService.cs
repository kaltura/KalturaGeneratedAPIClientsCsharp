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
// Copyright (C) 2006-2015  Kaltura Inc.
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

namespace Kaltura
{

	public class KalturaCategoryService : KalturaServiceBase
	{
	public KalturaCategoryService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCategory Add(KalturaCategory category)
		{
			KalturaParams kparams = new KalturaParams();
			if (category != null)
				kparams.Add("category", category.ToParams());
			_Client.QueueServiceCall("category", "add", "KalturaCategory", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategory)KalturaObjectFactory.Create(result, "KalturaCategory");
		}

		public KalturaCategory Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("category", "get", "KalturaCategory", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategory)KalturaObjectFactory.Create(result, "KalturaCategory");
		}

		public KalturaCategory Update(int id, KalturaCategory category)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (category != null)
				kparams.Add("category", category.ToParams());
			_Client.QueueServiceCall("category", "update", "KalturaCategory", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategory)KalturaObjectFactory.Create(result, "KalturaCategory");
		}

		public void Delete(int id)
		{
			this.Delete(id, (KalturaNullableBoolean)(1));
		}

		public void Delete(int id, KalturaNullableBoolean moveEntriesToParentCategory)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddEnumIfNotNull("moveEntriesToParentCategory", moveEntriesToParentCategory);
			_Client.QueueServiceCall("category", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCategoryListResponse List()
		{
			return this.List(null);
		}

		public KalturaCategoryListResponse List(KalturaCategoryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaCategoryListResponse List(KalturaCategoryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("category", "list", "KalturaCategoryListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryListResponse)KalturaObjectFactory.Create(result, "KalturaCategoryListResponse");
		}

		public int Index(int id)
		{
			return this.Index(id, true);
		}

		public int Index(int id, bool shouldUpdate)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddBoolIfNotNull("shouldUpdate", shouldUpdate);
			_Client.QueueServiceCall("category", "index", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaCategoryListResponse Move(string categoryIds, int targetCategoryParentId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("categoryIds", categoryIds);
			kparams.AddIntIfNotNull("targetCategoryParentId", targetCategoryParentId);
			_Client.QueueServiceCall("category", "move", "KalturaCategoryListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryListResponse)KalturaObjectFactory.Create(result, "KalturaCategoryListResponse");
		}

		public void UnlockCategories()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("category", "unlockCategories", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaBulkUpload AddFromBulkUpload(FileStream fileData)
		{
			return this.AddFromBulkUpload(fileData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(FileStream fileData, KalturaBulkUploadJobData bulkUploadData)
		{
			return this.AddFromBulkUpload(fileData, bulkUploadData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(FileStream fileData, KalturaBulkUploadJobData bulkUploadData, KalturaBulkUploadCategoryData bulkUploadCategoryData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			if (bulkUploadData != null)
				kparams.Add("bulkUploadData", bulkUploadData.ToParams());
			if (bulkUploadCategoryData != null)
				kparams.Add("bulkUploadCategoryData", bulkUploadCategoryData.ToParams());
			_Client.QueueServiceCall("category", "addFromBulkUpload", "KalturaBulkUpload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result, "KalturaBulkUpload");
		}
	}
}
