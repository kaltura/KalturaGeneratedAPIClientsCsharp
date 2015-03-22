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

	public class KalturaStorageProfileService : KalturaServiceBase
	{
	public KalturaStorageProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaStorageProfile Add(KalturaStorageProfile storageProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (storageProfile != null)
				kparams.Add("storageProfile", storageProfile.ToParams());
			_Client.QueueServiceCall("storageprofile", "add", "KalturaStorageProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStorageProfile)KalturaObjectFactory.Create(result, "KalturaStorageProfile");
		}

		public void UpdateStatus(int storageId, KalturaStorageProfileStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("storageId", storageId);
			kparams.AddEnumIfNotNull("status", status);
			_Client.QueueServiceCall("storageprofile", "updateStatus", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaStorageProfile Get(int storageProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("storageProfileId", storageProfileId);
			_Client.QueueServiceCall("storageprofile", "get", "KalturaStorageProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStorageProfile)KalturaObjectFactory.Create(result, "KalturaStorageProfile");
		}

		public KalturaStorageProfile Update(int storageProfileId, KalturaStorageProfile storageProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("storageProfileId", storageProfileId);
			if (storageProfile != null)
				kparams.Add("storageProfile", storageProfile.ToParams());
			_Client.QueueServiceCall("storageprofile", "update", "KalturaStorageProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStorageProfile)KalturaObjectFactory.Create(result, "KalturaStorageProfile");
		}

		public KalturaStorageProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaStorageProfileListResponse List(KalturaStorageProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaStorageProfileListResponse List(KalturaStorageProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("storageprofile", "list", "KalturaStorageProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStorageProfileListResponse)KalturaObjectFactory.Create(result, "KalturaStorageProfileListResponse");
		}
	}
}
