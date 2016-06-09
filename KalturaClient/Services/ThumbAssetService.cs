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

	public class KalturaThumbAssetService : KalturaServiceBase
	{
	public KalturaThumbAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaThumbAsset Add(string entryId, KalturaThumbAsset thumbAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("thumbAsset", thumbAsset);
			_Client.QueueServiceCall("thumbasset", "add", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public KalturaThumbAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("contentResource", contentResource);
			_Client.QueueServiceCall("thumbasset", "setContent", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public KalturaThumbAsset Update(string id, KalturaThumbAsset thumbAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("thumbAsset", thumbAsset);
			_Client.QueueServiceCall("thumbasset", "update", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public void SetAsDefault(string thumbAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("thumbAssetId", thumbAssetId);
			_Client.QueueServiceCall("thumbasset", "setAsDefault", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaThumbAsset GenerateByEntryId(string entryId, int destThumbParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("destThumbParamsId", destThumbParamsId);
			_Client.QueueServiceCall("thumbasset", "generateByEntryId", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public KalturaThumbAsset Generate(string entryId, KalturaThumbParams thumbParams)
		{
			return this.Generate(entryId, thumbParams, null);
		}

		public KalturaThumbAsset Generate(string entryId, KalturaThumbParams thumbParams, string sourceAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("thumbParams", thumbParams);
			kparams.AddIfNotNull("sourceAssetId", sourceAssetId);
			_Client.QueueServiceCall("thumbasset", "generate", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public KalturaThumbAsset Regenerate(string thumbAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("thumbAssetId", thumbAssetId);
			_Client.QueueServiceCall("thumbasset", "regenerate", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public KalturaThumbAsset Get(string thumbAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("thumbAssetId", thumbAssetId);
			_Client.QueueServiceCall("thumbasset", "get", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public IList<KalturaThumbAsset> GetByEntryId(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("thumbasset", "getByEntryId", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaThumbAsset> list = new List<KalturaThumbAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaThumbAsset)KalturaObjectFactory.Create(node, "KalturaThumbAsset"));
			}
			return list;
		}

		public KalturaThumbAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaThumbAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaThumbAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("thumbasset", "list", "KalturaThumbAssetListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAssetListResponse)KalturaObjectFactory.Create(result, "KalturaThumbAssetListResponse");
		}

		public KalturaThumbAsset AddFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("url", url);
			_Client.QueueServiceCall("thumbasset", "addFromUrl", "KalturaThumbAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public KalturaThumbAsset AddFromImage(string entryId, Stream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("thumbasset", "addFromImage", "KalturaThumbAsset", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbAsset)KalturaObjectFactory.Create(result, "KalturaThumbAsset");
		}

		public void Delete(string thumbAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("thumbAssetId", thumbAssetId);
			_Client.QueueServiceCall("thumbasset", "delete", null, kparams);
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
			return this.GetUrl(id, storageId, null);
		}

		public string GetUrl(string id, int storageId, KalturaThumbParams thumbParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("storageId", storageId);
			kparams.AddIfNotNull("thumbParams", thumbParams);
			_Client.QueueServiceCall("thumbasset", "getUrl", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("thumbasset", "getRemotePaths", "KalturaRemotePathListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result, "KalturaRemotePathListResponse");
		}

		public KalturaFlavorAsset Export(string assetId, int storageProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("assetId", assetId);
			kparams.AddIfNotNull("storageProfileId", storageProfileId);
			_Client.QueueServiceCall("thumbasset", "export", "KalturaFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result, "KalturaFlavorAsset");
		}
	}
}
