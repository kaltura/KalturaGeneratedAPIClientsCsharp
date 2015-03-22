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

	public class KalturaAccessControlProfileService : KalturaServiceBase
	{
	public KalturaAccessControlProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAccessControlProfile Add(KalturaAccessControlProfile accessControlProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (accessControlProfile != null)
				kparams.Add("accessControlProfile", accessControlProfile.ToParams());
			_Client.QueueServiceCall("accesscontrolprofile", "add", "KalturaAccessControlProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAccessControlProfile)KalturaObjectFactory.Create(result, "KalturaAccessControlProfile");
		}

		public KalturaAccessControlProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("accesscontrolprofile", "get", "KalturaAccessControlProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAccessControlProfile)KalturaObjectFactory.Create(result, "KalturaAccessControlProfile");
		}

		public KalturaAccessControlProfile Update(int id, KalturaAccessControlProfile accessControlProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (accessControlProfile != null)
				kparams.Add("accessControlProfile", accessControlProfile.ToParams());
			_Client.QueueServiceCall("accesscontrolprofile", "update", "KalturaAccessControlProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAccessControlProfile)KalturaObjectFactory.Create(result, "KalturaAccessControlProfile");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("accesscontrolprofile", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaAccessControlProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaAccessControlProfileListResponse List(KalturaAccessControlProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaAccessControlProfileListResponse List(KalturaAccessControlProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("accesscontrolprofile", "list", "KalturaAccessControlProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAccessControlProfileListResponse)KalturaObjectFactory.Create(result, "KalturaAccessControlProfileListResponse");
		}
	}
}
