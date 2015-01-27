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
// Copyright (C) 2006-2011  Kaltura Inc.
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

	public class KalturaCaptionAssetService : KalturaServiceBase
	{
	public KalturaCaptionAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCaptionAsset Add(string entryId, KalturaCaptionAsset captionAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (captionAsset != null)
				kparams.Add("captionAsset", captionAsset.ToParams());
			_Client.QueueServiceCall("caption_captionasset", "add", "KalturaCaptionAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAsset)KalturaObjectFactory.Create(result, "KalturaCaptionAsset");
		}

		public KalturaCaptionAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (contentResource != null)
				kparams.Add("contentResource", contentResource.ToParams());
			_Client.QueueServiceCall("caption_captionasset", "setContent", "KalturaCaptionAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAsset)KalturaObjectFactory.Create(result, "KalturaCaptionAsset");
		}

		public KalturaCaptionAsset Update(string id, KalturaCaptionAsset captionAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (captionAsset != null)
				kparams.Add("captionAsset", captionAsset.ToParams());
			_Client.QueueServiceCall("caption_captionasset", "update", "KalturaCaptionAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAsset)KalturaObjectFactory.Create(result, "KalturaCaptionAsset");
		}

		public string GetUrl(string id)
		{
			return this.GetUrl(id, Int32.MinValue);
		}

		public string GetUrl(string id, int storageId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddIntIfNotNull("storageId", storageId);
			_Client.QueueServiceCall("caption_captionasset", "getUrl", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("caption_captionasset", "getRemotePaths", "KalturaRemotePathListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result, "KalturaRemotePathListResponse");
		}

		public void SetAsDefault(string captionAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("captionAssetId", captionAssetId);
			_Client.QueueServiceCall("caption_captionasset", "setAsDefault", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCaptionAsset Get(string captionAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("captionAssetId", captionAssetId);
			_Client.QueueServiceCall("caption_captionasset", "get", "KalturaCaptionAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAsset)KalturaObjectFactory.Create(result, "KalturaCaptionAsset");
		}

		public KalturaCaptionAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaCaptionAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaCaptionAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("caption_captionasset", "list", "KalturaCaptionAssetListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAssetListResponse)KalturaObjectFactory.Create(result, "KalturaCaptionAssetListResponse");
		}

		public void Delete(string captionAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("captionAssetId", captionAssetId);
			_Client.QueueServiceCall("caption_captionasset", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
