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

	public class KalturaVirusScanProfileService : KalturaServiceBase
	{
	public KalturaVirusScanProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaVirusScanProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaVirusScanProfileListResponse List(KalturaVirusScanProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaVirusScanProfileListResponse List(KalturaVirusScanProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("virusscan_virusscanprofile", "list", "KalturaVirusScanProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfileListResponse)KalturaObjectFactory.Create(result, "KalturaVirusScanProfileListResponse");
		}

		public KalturaVirusScanProfile Add(KalturaVirusScanProfile virusScanProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (virusScanProfile != null)
				kparams.Add("virusScanProfile", virusScanProfile.ToParams());
			_Client.QueueServiceCall("virusscan_virusscanprofile", "add", "KalturaVirusScanProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfile)KalturaObjectFactory.Create(result, "KalturaVirusScanProfile");
		}

		public KalturaVirusScanProfile Get(int virusScanProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("virusScanProfileId", virusScanProfileId);
			_Client.QueueServiceCall("virusscan_virusscanprofile", "get", "KalturaVirusScanProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfile)KalturaObjectFactory.Create(result, "KalturaVirusScanProfile");
		}

		public KalturaVirusScanProfile Update(int virusScanProfileId, KalturaVirusScanProfile virusScanProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("virusScanProfileId", virusScanProfileId);
			if (virusScanProfile != null)
				kparams.Add("virusScanProfile", virusScanProfile.ToParams());
			_Client.QueueServiceCall("virusscan_virusscanprofile", "update", "KalturaVirusScanProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfile)KalturaObjectFactory.Create(result, "KalturaVirusScanProfile");
		}

		public KalturaVirusScanProfile Delete(int virusScanProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("virusScanProfileId", virusScanProfileId);
			_Client.QueueServiceCall("virusscan_virusscanprofile", "delete", "KalturaVirusScanProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfile)KalturaObjectFactory.Create(result, "KalturaVirusScanProfile");
		}

		public int Scan(string flavorAssetId)
		{
			return this.Scan(flavorAssetId, Int32.MinValue);
		}

		public int Scan(string flavorAssetId, int virusScanProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("flavorAssetId", flavorAssetId);
			kparams.AddIntIfNotNull("virusScanProfileId", virusScanProfileId);
			_Client.QueueServiceCall("virusscan_virusscanprofile", "scan", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}
	}
}
