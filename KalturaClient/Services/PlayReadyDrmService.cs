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
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class PlayReadyDrmGenerateKeyRequestBuilder : RequestBuilder<PlayReadyContentKey>
	{
		#region Constants
		#endregion


		public PlayReadyDrmGenerateKeyRequestBuilder()
			: base("playready_playreadydrm", "generateKey")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PlayReadyContentKey>(result);
		}
	}

	public class PlayReadyDrmGetContentKeysRequestBuilder : RequestBuilder<IList<PlayReadyContentKey>>
	{
		#region Constants
		public const string KEY_IDS = "keyIds";
		#endregion

		public string KeyIds { get; set; }

		public PlayReadyDrmGetContentKeysRequestBuilder()
			: base("playready_playreadydrm", "getContentKeys")
		{
		}

		public PlayReadyDrmGetContentKeysRequestBuilder(string keyIds)
			: this()
		{
			this.KeyIds = keyIds;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("keyIds"))
				kparams.AddIfNotNull("keyIds", KeyIds);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<PlayReadyContentKey> list = new List<PlayReadyContentKey>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<PlayReadyContentKey>(node));
			}
			return list;
		}
	}

	public class PlayReadyDrmGetEntryContentKeyRequestBuilder : RequestBuilder<PlayReadyContentKey>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CREATE_IF_MISSING = "createIfMissing";
		#endregion

		public string EntryId { get; set; }
		public bool CreateIfMissing { get; set; }

		public PlayReadyDrmGetEntryContentKeyRequestBuilder()
			: base("playready_playreadydrm", "getEntryContentKey")
		{
		}

		public PlayReadyDrmGetEntryContentKeyRequestBuilder(string entryId, bool createIfMissing)
			: this()
		{
			this.EntryId = entryId;
			this.CreateIfMissing = createIfMissing;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("createIfMissing"))
				kparams.AddIfNotNull("createIfMissing", CreateIfMissing);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PlayReadyContentKey>(result);
		}
	}

	public class PlayReadyDrmGetLicenseDetailsRequestBuilder : RequestBuilder<PlayReadyLicenseDetails>
	{
		#region Constants
		public const string KEY_ID = "keyId";
		public const string DEVICE_ID = "deviceId";
		public const string DEVICE_TYPE = "deviceType";
		public const string ENTRY_ID = "entryId";
		public const string REFERRER = "referrer";
		#endregion

		public string KeyId { get; set; }
		public string DeviceId { get; set; }
		public int DeviceType { get; set; }
		public string EntryId { get; set; }
		public string Referrer { get; set; }

		public PlayReadyDrmGetLicenseDetailsRequestBuilder()
			: base("playready_playreadydrm", "getLicenseDetails")
		{
		}

		public PlayReadyDrmGetLicenseDetailsRequestBuilder(string keyId, string deviceId, int deviceType, string entryId, string referrer)
			: this()
		{
			this.KeyId = keyId;
			this.DeviceId = deviceId;
			this.DeviceType = deviceType;
			this.EntryId = entryId;
			this.Referrer = referrer;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("keyId"))
				kparams.AddIfNotNull("keyId", KeyId);
			if (!isMapped("deviceId"))
				kparams.AddIfNotNull("deviceId", DeviceId);
			if (!isMapped("deviceType"))
				kparams.AddIfNotNull("deviceType", DeviceType);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("referrer"))
				kparams.AddIfNotNull("referrer", Referrer);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PlayReadyLicenseDetails>(result);
		}
	}


	public class PlayReadyDrmService
	{
		private PlayReadyDrmService()
		{
		}

		public static PlayReadyDrmGenerateKeyRequestBuilder GenerateKey()
		{
			return new PlayReadyDrmGenerateKeyRequestBuilder();
		}

		public static PlayReadyDrmGetContentKeysRequestBuilder GetContentKeys(string keyIds)
		{
			return new PlayReadyDrmGetContentKeysRequestBuilder(keyIds);
		}

		public static PlayReadyDrmGetEntryContentKeyRequestBuilder GetEntryContentKey(string entryId, bool createIfMissing = false)
		{
			return new PlayReadyDrmGetEntryContentKeyRequestBuilder(entryId, createIfMissing);
		}

		public static PlayReadyDrmGetLicenseDetailsRequestBuilder GetLicenseDetails(string keyId, string deviceId, int deviceType, string entryId = null, string referrer = null)
		{
			return new PlayReadyDrmGetLicenseDetailsRequestBuilder(keyId, deviceId, deviceType, entryId, referrer);
		}
	}
}
