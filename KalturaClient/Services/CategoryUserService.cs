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

namespace Kaltura
{

	public class KalturaCategoryUserService : KalturaServiceBase
	{
	public KalturaCategoryUserService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCategoryUser Add(KalturaCategoryUser categoryUser)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("categoryUser", categoryUser);
			_Client.QueueServiceCall("categoryuser", "add", "KalturaCategoryUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryUser)KalturaObjectFactory.Create(result, "KalturaCategoryUser");
		}

		public KalturaCategoryUser Get(int categoryId, string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("categoryId", categoryId);
			kparams.AddIfNotNull("userId", userId);
			_Client.QueueServiceCall("categoryuser", "get", "KalturaCategoryUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryUser)KalturaObjectFactory.Create(result, "KalturaCategoryUser");
		}

		public KalturaCategoryUser Update(int categoryId, string userId, KalturaCategoryUser categoryUser)
		{
			return this.Update(categoryId, userId, categoryUser, false);
		}

		public KalturaCategoryUser Update(int categoryId, string userId, KalturaCategoryUser categoryUser, bool override_)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("categoryId", categoryId);
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("categoryUser", categoryUser);
			kparams.AddIfNotNull("override", override_);
			_Client.QueueServiceCall("categoryuser", "update", "KalturaCategoryUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryUser)KalturaObjectFactory.Create(result, "KalturaCategoryUser");
		}

		public void Delete(int categoryId, string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("categoryId", categoryId);
			kparams.AddIfNotNull("userId", userId);
			_Client.QueueServiceCall("categoryuser", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCategoryUser Activate(int categoryId, string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("categoryId", categoryId);
			kparams.AddIfNotNull("userId", userId);
			_Client.QueueServiceCall("categoryuser", "activate", "KalturaCategoryUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryUser)KalturaObjectFactory.Create(result, "KalturaCategoryUser");
		}

		public KalturaCategoryUser Deactivate(int categoryId, string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("categoryId", categoryId);
			kparams.AddIfNotNull("userId", userId);
			_Client.QueueServiceCall("categoryuser", "deactivate", "KalturaCategoryUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryUser)KalturaObjectFactory.Create(result, "KalturaCategoryUser");
		}

		public KalturaCategoryUserListResponse List()
		{
			return this.List(null);
		}

		public KalturaCategoryUserListResponse List(KalturaCategoryUserFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaCategoryUserListResponse List(KalturaCategoryUserFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("categoryuser", "list", "KalturaCategoryUserListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryUserListResponse)KalturaObjectFactory.Create(result, "KalturaCategoryUserListResponse");
		}

		public void CopyFromCategory(int categoryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("categoryId", categoryId);
			_Client.QueueServiceCall("categoryuser", "copyFromCategory", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public int Index(string userId, int categoryId)
		{
			return this.Index(userId, categoryId, true);
		}

		public int Index(string userId, int categoryId, bool shouldUpdate)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("categoryId", categoryId);
			kparams.AddIfNotNull("shouldUpdate", shouldUpdate);
			_Client.QueueServiceCall("categoryuser", "index", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaBulkUpload AddFromBulkUpload(Stream fileData)
		{
			return this.AddFromBulkUpload(fileData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(Stream fileData, KalturaBulkUploadJobData bulkUploadData)
		{
			return this.AddFromBulkUpload(fileData, bulkUploadData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(Stream fileData, KalturaBulkUploadJobData bulkUploadData, KalturaBulkUploadCategoryUserData bulkUploadCategoryUserData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			kparams.AddIfNotNull("bulkUploadData", bulkUploadData);
			kparams.AddIfNotNull("bulkUploadCategoryUserData", bulkUploadCategoryUserData);
			_Client.QueueServiceCall("categoryuser", "addFromBulkUpload", "KalturaBulkUpload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result, "KalturaBulkUpload");
		}
	}
}
