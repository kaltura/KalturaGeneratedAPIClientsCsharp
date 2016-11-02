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

	public class KalturaFlavorAssetService : KalturaServiceBase
	{
	public KalturaFlavorAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaFlavorAsset Add(string entryId, KalturaFlavorAsset flavorAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("flavorAsset", flavorAsset);
			_Client.QueueServiceCall("flavorasset", "add", "KalturaFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result, "KalturaFlavorAsset");
		}

		public KalturaFlavorAsset Update(string id, KalturaFlavorAsset flavorAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("flavorAsset", flavorAsset);
			_Client.QueueServiceCall("flavorasset", "update", "KalturaFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result, "KalturaFlavorAsset");
		}

		public KalturaFlavorAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("contentResource", contentResource);
			_Client.QueueServiceCall("flavorasset", "setContent", "KalturaFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result, "KalturaFlavorAsset");
		}

		public KalturaFlavorAsset Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "get", "KalturaFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result, "KalturaFlavorAsset");
		}

		public IList<KalturaFlavorAsset> GetByEntryId(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getByEntryId", "KalturaFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAsset> list = new List<KalturaFlavorAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(node, "KalturaFlavorAsset"));
			}
			return list;
		}

		public KalturaFlavorAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaFlavorAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaFlavorAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("flavorasset", "list", "KalturaFlavorAssetListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAssetListResponse)KalturaObjectFactory.Create(result, "KalturaFlavorAssetListResponse");
		}

		public IList<KalturaFlavorAsset> GetWebPlayableByEntryId(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getWebPlayableByEntryId", "KalturaFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAsset> list = new List<KalturaFlavorAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(node, "KalturaFlavorAsset"));
			}
			return list;
		}

		public void Convert(string entryId, int flavorParamsId)
		{
			this.Convert(entryId, flavorParamsId, 0);
		}

		public void Convert(string entryId, int flavorParamsId, int priority)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("flavorParamsId", flavorParamsId);
			kparams.AddIfNotNull("priority", priority);
			_Client.QueueServiceCall("flavorasset", "convert", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Reconvert(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "reconvert", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string GetUrl(string id)
		{
			return this.GetUrl(id, Int32.MinValue);
		}

		public string GetUrl(string id, int storageId)
		{
			return this.GetUrl(id, storageId, false);
		}

		public string GetUrl(string id, int storageId, bool forceProxy)
		{
			return this.GetUrl(id, storageId, forceProxy, null);
		}

		public string GetUrl(string id, int storageId, bool forceProxy, KalturaFlavorAssetUrlOptions options)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("storageId", storageId);
			kparams.AddIfNotNull("forceProxy", forceProxy);
			kparams.AddIfNotNull("options", options);
			_Client.QueueServiceCall("flavorasset", "getUrl", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "getRemotePaths", "KalturaRemotePathListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result, "KalturaRemotePathListResponse");
		}

		public string GetDownloadUrl(string id)
		{
			return this.GetDownloadUrl(id, false);
		}

		public string GetDownloadUrl(string id, bool useCdn)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("useCdn", useCdn);
			_Client.QueueServiceCall("flavorasset", "getDownloadUrl", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public IList<KalturaFlavorAssetWithParams> GetFlavorAssetsWithParams(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getFlavorAssetsWithParams", "KalturaFlavorAssetWithParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAssetWithParams> list = new List<KalturaFlavorAssetWithParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAssetWithParams)KalturaObjectFactory.Create(node, "KalturaFlavorAssetWithParams"));
			}
			return list;
		}

		public KalturaFlavorAsset Export(string assetId, int storageProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("assetId", assetId);
			kparams.AddIfNotNull("storageProfileId", storageProfileId);
			_Client.QueueServiceCall("flavorasset", "export", "KalturaFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result, "KalturaFlavorAsset");
		}

		public void SetAsSource(string assetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("assetId", assetId);
			_Client.QueueServiceCall("flavorasset", "setAsSource", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void DeleteLocalContent(string assetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("assetId", assetId);
			_Client.QueueServiceCall("flavorasset", "deleteLocalContent", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string ServeAdStitchCmd(string assetId)
		{
			return this.ServeAdStitchCmd(assetId, null);
		}

		public string ServeAdStitchCmd(string assetId, string ffprobeJson)
		{
			return this.ServeAdStitchCmd(assetId, ffprobeJson, null);
		}

		public string ServeAdStitchCmd(string assetId, string ffprobeJson, string duration)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("assetId", assetId);
			kparams.AddIfNotNull("ffprobeJson", ffprobeJson);
			kparams.AddIfNotNull("duration", duration);
			_Client.QueueServiceCall("flavorasset", "serveAdStitchCmd", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
