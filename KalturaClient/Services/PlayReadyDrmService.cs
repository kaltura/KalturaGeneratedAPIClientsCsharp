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

	public class KalturaPlayReadyDrmService : KalturaServiceBase
	{
	public KalturaPlayReadyDrmService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPlayReadyContentKey GenerateKey()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("playready_playreadydrm", "generateKey", "KalturaPlayReadyContentKey", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlayReadyContentKey)KalturaObjectFactory.Create(result, "KalturaPlayReadyContentKey");
		}

		public IList<KalturaPlayReadyContentKey> GetContentKeys(string keyIds)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("keyIds", keyIds);
			_Client.QueueServiceCall("playready_playreadydrm", "getContentKeys", "KalturaPlayReadyContentKey", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaPlayReadyContentKey> list = new List<KalturaPlayReadyContentKey>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaPlayReadyContentKey)KalturaObjectFactory.Create(node, "KalturaPlayReadyContentKey"));
			}
			return list;
		}

		public KalturaPlayReadyContentKey GetEntryContentKey(string entryId)
		{
			return this.GetEntryContentKey(entryId, false);
		}

		public KalturaPlayReadyContentKey GetEntryContentKey(string entryId, bool createIfMissing)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddBoolIfNotNull("createIfMissing", createIfMissing);
			_Client.QueueServiceCall("playready_playreadydrm", "getEntryContentKey", "KalturaPlayReadyContentKey", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlayReadyContentKey)KalturaObjectFactory.Create(result, "KalturaPlayReadyContentKey");
		}

		public KalturaPlayReadyLicenseDetails GetLicenseDetails(string keyId, string deviceId, int deviceType)
		{
			return this.GetLicenseDetails(keyId, deviceId, deviceType, null);
		}

		public KalturaPlayReadyLicenseDetails GetLicenseDetails(string keyId, string deviceId, int deviceType, string entryId)
		{
			return this.GetLicenseDetails(keyId, deviceId, deviceType, entryId, null);
		}

		public KalturaPlayReadyLicenseDetails GetLicenseDetails(string keyId, string deviceId, int deviceType, string entryId, string referrer)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("keyId", keyId);
			kparams.AddStringIfNotNull("deviceId", deviceId);
			kparams.AddIntIfNotNull("deviceType", deviceType);
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("referrer", referrer);
			_Client.QueueServiceCall("playready_playreadydrm", "getLicenseDetails", "KalturaPlayReadyLicenseDetails", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlayReadyLicenseDetails)KalturaObjectFactory.Create(result, "KalturaPlayReadyLicenseDetails");
		}
	}
}
