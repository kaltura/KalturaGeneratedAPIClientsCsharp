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

	public class KalturaFileAssetService : KalturaServiceBase
	{
	public KalturaFileAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaFileAsset Add(KalturaFileAsset fileAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("fileAsset", fileAsset);
			_Client.QueueServiceCall("fileasset", "add", "KalturaFileAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFileAsset)KalturaObjectFactory.Create(result, "KalturaFileAsset");
		}

		public KalturaFileAsset Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("fileasset", "get", "KalturaFileAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFileAsset)KalturaObjectFactory.Create(result, "KalturaFileAsset");
		}

		public KalturaFileAsset Update(int id, KalturaFileAsset fileAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("fileAsset", fileAsset);
			_Client.QueueServiceCall("fileasset", "update", "KalturaFileAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFileAsset)KalturaObjectFactory.Create(result, "KalturaFileAsset");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("fileasset", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaFileAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("contentResource", contentResource);
			_Client.QueueServiceCall("fileasset", "setContent", "KalturaFileAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFileAsset)KalturaObjectFactory.Create(result, "KalturaFileAsset");
		}

		public KalturaFileAssetListResponse List(KalturaFileAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaFileAssetListResponse List(KalturaFileAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("fileasset", "list", "KalturaFileAssetListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFileAssetListResponse)KalturaObjectFactory.Create(result, "KalturaFileAssetListResponse");
		}
	}
}
