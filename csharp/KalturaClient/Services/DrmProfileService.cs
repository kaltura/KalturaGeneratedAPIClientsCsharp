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

	public class KalturaDrmProfileService : KalturaServiceBase
	{
	public KalturaDrmProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDrmProfile Add(KalturaDrmProfile drmProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (drmProfile != null)
				kparams.Add("drmProfile", drmProfile.ToParams());
			_Client.QueueServiceCall("drm_drmprofile", "add", "KalturaDrmProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmProfile)KalturaObjectFactory.Create(result, "KalturaDrmProfile");
		}

		public KalturaDrmProfile Get(int drmProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("drmProfileId", drmProfileId);
			_Client.QueueServiceCall("drm_drmprofile", "get", "KalturaDrmProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmProfile)KalturaObjectFactory.Create(result, "KalturaDrmProfile");
		}

		public KalturaDrmProfile Update(int drmProfileId, KalturaDrmProfile drmProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("drmProfileId", drmProfileId);
			if (drmProfile != null)
				kparams.Add("drmProfile", drmProfile.ToParams());
			_Client.QueueServiceCall("drm_drmprofile", "update", "KalturaDrmProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmProfile)KalturaObjectFactory.Create(result, "KalturaDrmProfile");
		}

		public KalturaDrmProfile Delete(int drmProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("drmProfileId", drmProfileId);
			_Client.QueueServiceCall("drm_drmprofile", "delete", "KalturaDrmProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmProfile)KalturaObjectFactory.Create(result, "KalturaDrmProfile");
		}

		public KalturaDrmProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaDrmProfileListResponse List(KalturaDrmProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDrmProfileListResponse List(KalturaDrmProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("drm_drmprofile", "list", "KalturaDrmProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmProfileListResponse)KalturaObjectFactory.Create(result, "KalturaDrmProfileListResponse");
		}

		public KalturaDrmProfile GetByProvider(KalturaDrmProviderType provider)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringEnumIfNotNull("provider", provider);
			_Client.QueueServiceCall("drm_drmprofile", "getByProvider", "KalturaDrmProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmProfile)KalturaObjectFactory.Create(result, "KalturaDrmProfile");
		}
	}
}
