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

	public class KalturaResponseProfileService : KalturaServiceBase
	{
	public KalturaResponseProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaResponseProfile Add(KalturaResponseProfile addResponseProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("addResponseProfile", addResponseProfile);
			_Client.QueueServiceCall("responseprofile", "add", "KalturaResponseProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaResponseProfile)KalturaObjectFactory.Create(result, "KalturaResponseProfile");
		}

		public KalturaResponseProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("responseprofile", "get", "KalturaResponseProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaResponseProfile)KalturaObjectFactory.Create(result, "KalturaResponseProfile");
		}

		public KalturaResponseProfile Update(int id, KalturaResponseProfile updateResponseProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("updateResponseProfile", updateResponseProfile);
			_Client.QueueServiceCall("responseprofile", "update", "KalturaResponseProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaResponseProfile)KalturaObjectFactory.Create(result, "KalturaResponseProfile");
		}

		public KalturaResponseProfile UpdateStatus(int id, KalturaResponseProfileStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("status", status);
			_Client.QueueServiceCall("responseprofile", "updateStatus", "KalturaResponseProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaResponseProfile)KalturaObjectFactory.Create(result, "KalturaResponseProfile");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("responseprofile", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaResponseProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaResponseProfileListResponse List(KalturaResponseProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaResponseProfileListResponse List(KalturaResponseProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("responseprofile", "list", "KalturaResponseProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaResponseProfileListResponse)KalturaObjectFactory.Create(result, "KalturaResponseProfileListResponse");
		}

		public KalturaResponseProfileCacheRecalculateResults Recalculate(KalturaResponseProfileCacheRecalculateOptions options)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("options", options);
			_Client.QueueServiceCall("responseprofile", "recalculate", "KalturaResponseProfileCacheRecalculateResults", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaResponseProfileCacheRecalculateResults)KalturaObjectFactory.Create(result, "KalturaResponseProfileCacheRecalculateResults");
		}

		public KalturaResponseProfile Clone(int id, KalturaResponseProfile profile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("profile", profile);
			_Client.QueueServiceCall("responseprofile", "clone", "KalturaResponseProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaResponseProfile)KalturaObjectFactory.Create(result, "KalturaResponseProfile");
		}
	}
}
