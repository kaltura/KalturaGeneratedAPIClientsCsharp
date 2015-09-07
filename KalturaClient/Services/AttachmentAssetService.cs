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

	public class KalturaAttachmentAssetService : KalturaServiceBase
	{
	public KalturaAttachmentAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAttachmentAsset Add(string entryId, KalturaAttachmentAsset attachmentAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("attachmentAsset", attachmentAsset);
			_Client.QueueServiceCall("attachment_attachmentasset", "add", "KalturaAttachmentAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAsset)KalturaObjectFactory.Create(result, "KalturaAttachmentAsset");
		}

		public KalturaAttachmentAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("contentResource", contentResource);
			_Client.QueueServiceCall("attachment_attachmentasset", "setContent", "KalturaAttachmentAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAsset)KalturaObjectFactory.Create(result, "KalturaAttachmentAsset");
		}

		public KalturaAttachmentAsset Update(string id, KalturaAttachmentAsset attachmentAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("attachmentAsset", attachmentAsset);
			_Client.QueueServiceCall("attachment_attachmentasset", "update", "KalturaAttachmentAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAsset)KalturaObjectFactory.Create(result, "KalturaAttachmentAsset");
		}

		public string GetUrl(string id)
		{
			return this.GetUrl(id, Int32.MinValue);
		}

		public string GetUrl(string id, int storageId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("storageId", storageId);
			_Client.QueueServiceCall("attachment_attachmentasset", "getUrl", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("attachment_attachmentasset", "getRemotePaths", "KalturaRemotePathListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result, "KalturaRemotePathListResponse");
		}

		public KalturaAttachmentAsset Get(string attachmentAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("attachmentAssetId", attachmentAssetId);
			_Client.QueueServiceCall("attachment_attachmentasset", "get", "KalturaAttachmentAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAsset)KalturaObjectFactory.Create(result, "KalturaAttachmentAsset");
		}

		public KalturaAttachmentAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaAttachmentAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaAttachmentAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("attachment_attachmentasset", "list", "KalturaAttachmentAssetListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAssetListResponse)KalturaObjectFactory.Create(result, "KalturaAttachmentAssetListResponse");
		}

		public void Delete(string attachmentAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("attachmentAssetId", attachmentAssetId);
			_Client.QueueServiceCall("attachment_attachmentasset", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
