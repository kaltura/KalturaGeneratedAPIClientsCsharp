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

	public class KalturaAppTokenService : KalturaServiceBase
	{
	public KalturaAppTokenService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAppToken Add(KalturaAppToken appToken)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("appToken", appToken);
			_Client.QueueServiceCall("apptoken", "add", "KalturaAppToken", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAppToken)KalturaObjectFactory.Create(result, "KalturaAppToken");
		}

		public KalturaAppToken Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("apptoken", "get", "KalturaAppToken", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAppToken)KalturaObjectFactory.Create(result, "KalturaAppToken");
		}

		public KalturaAppToken Update(string id, KalturaAppToken appToken)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("appToken", appToken);
			_Client.QueueServiceCall("apptoken", "update", "KalturaAppToken", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAppToken)KalturaObjectFactory.Create(result, "KalturaAppToken");
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("apptoken", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaAppTokenListResponse List()
		{
			return this.List(null);
		}

		public KalturaAppTokenListResponse List(KalturaAppTokenFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaAppTokenListResponse List(KalturaAppTokenFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("apptoken", "list", "KalturaAppTokenListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAppTokenListResponse)KalturaObjectFactory.Create(result, "KalturaAppTokenListResponse");
		}

		public KalturaSessionInfo StartSession(string id, string tokenHash)
		{
			return this.StartSession(id, tokenHash, null);
		}

		public KalturaSessionInfo StartSession(string id, string tokenHash, string userId)
		{
			return this.StartSession(id, tokenHash, userId, (KalturaSessionType)(Int32.MinValue));
		}

		public KalturaSessionInfo StartSession(string id, string tokenHash, string userId, KalturaSessionType type)
		{
			return this.StartSession(id, tokenHash, userId, type, Int32.MinValue);
		}

		public KalturaSessionInfo StartSession(string id, string tokenHash, string userId, KalturaSessionType type, int expiry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("tokenHash", tokenHash);
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("type", type);
			kparams.AddIfNotNull("expiry", expiry);
			_Client.QueueServiceCall("apptoken", "startSession", "KalturaSessionInfo", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSessionInfo)KalturaObjectFactory.Create(result, "KalturaSessionInfo");
		}
	}
}
