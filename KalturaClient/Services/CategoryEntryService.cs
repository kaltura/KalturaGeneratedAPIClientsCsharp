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

	public class KalturaCategoryEntryService : KalturaServiceBase
	{
	public KalturaCategoryEntryService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCategoryEntry Add(KalturaCategoryEntry categoryEntry)
		{
			KalturaParams kparams = new KalturaParams();
			if (categoryEntry != null)
				kparams.Add("categoryEntry", categoryEntry.ToParams());
			_Client.QueueServiceCall("categoryentry", "add", "KalturaCategoryEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryEntry)KalturaObjectFactory.Create(result, "KalturaCategoryEntry");
		}

		public void Delete(string entryId, int categoryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("categoryId", categoryId);
			_Client.QueueServiceCall("categoryentry", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCategoryEntryListResponse List()
		{
			return this.List(null);
		}

		public KalturaCategoryEntryListResponse List(KalturaCategoryEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaCategoryEntryListResponse List(KalturaCategoryEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("categoryentry", "list", "KalturaCategoryEntryListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryEntryListResponse)KalturaObjectFactory.Create(result, "KalturaCategoryEntryListResponse");
		}

		public int Index(string entryId, int categoryId)
		{
			return this.Index(entryId, categoryId, true);
		}

		public int Index(string entryId, int categoryId, bool shouldUpdate)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("categoryId", categoryId);
			kparams.AddBoolIfNotNull("shouldUpdate", shouldUpdate);
			_Client.QueueServiceCall("categoryentry", "index", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public void Activate(string entryId, int categoryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("categoryId", categoryId);
			_Client.QueueServiceCall("categoryentry", "activate", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Reject(string entryId, int categoryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("categoryId", categoryId);
			_Client.QueueServiceCall("categoryentry", "reject", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void SyncPrivacyContext(string entryId, int categoryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("categoryId", categoryId);
			_Client.QueueServiceCall("categoryentry", "syncPrivacyContext", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaBulkUpload AddFromBulkUpload(KalturaBulkServiceData bulkUploadData)
		{
			return this.AddFromBulkUpload(bulkUploadData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(KalturaBulkServiceData bulkUploadData, KalturaBulkUploadCategoryEntryData bulkUploadCategoryEntryData)
		{
			KalturaParams kparams = new KalturaParams();
			if (bulkUploadData != null)
				kparams.Add("bulkUploadData", bulkUploadData.ToParams());
			if (bulkUploadCategoryEntryData != null)
				kparams.Add("bulkUploadCategoryEntryData", bulkUploadCategoryEntryData.ToParams());
			_Client.QueueServiceCall("categoryentry", "addFromBulkUpload", "KalturaBulkUpload", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result, "KalturaBulkUpload");
		}
	}
}
