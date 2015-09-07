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

	public class KalturaBulkUploadService : KalturaServiceBase
	{
	public KalturaBulkUploadService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaBulkUpload Add(int conversionProfileId, FileStream csvFileData)
		{
			return this.Add(conversionProfileId, csvFileData, null);
		}

		public KalturaBulkUpload Add(int conversionProfileId, FileStream csvFileData, KalturaBulkUploadType bulkUploadType)
		{
			return this.Add(conversionProfileId, csvFileData, bulkUploadType, null);
		}

		public KalturaBulkUpload Add(int conversionProfileId, FileStream csvFileData, KalturaBulkUploadType bulkUploadType, string uploadedBy)
		{
			return this.Add(conversionProfileId, csvFileData, bulkUploadType, uploadedBy, null);
		}

		public KalturaBulkUpload Add(int conversionProfileId, FileStream csvFileData, KalturaBulkUploadType bulkUploadType, string uploadedBy, string fileName)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("conversionProfileId", conversionProfileId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("csvFileData", csvFileData);
			kparams.AddIfNotNull("bulkUploadType", bulkUploadType);
			kparams.AddIfNotNull("uploadedBy", uploadedBy);
			kparams.AddIfNotNull("fileName", fileName);
			_Client.QueueServiceCall("bulkupload", "add", "KalturaBulkUpload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result, "KalturaBulkUpload");
		}

		public KalturaBulkUpload Get(long id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("bulkupload", "get", "KalturaBulkUpload", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result, "KalturaBulkUpload");
		}

		public KalturaBulkUploadListResponse List()
		{
			return this.List(null);
		}

		public KalturaBulkUploadListResponse List(KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("bulkupload", "list", "KalturaBulkUploadListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUploadListResponse)KalturaObjectFactory.Create(result, "KalturaBulkUploadListResponse");
		}

		public KalturaBulkUpload Abort(long id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("bulkupload", "abort", "KalturaBulkUpload", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result, "KalturaBulkUpload");
		}
	}
}
