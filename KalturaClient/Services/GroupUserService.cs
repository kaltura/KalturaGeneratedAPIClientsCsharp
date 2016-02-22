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

	public class KalturaGroupUserService : KalturaServiceBase
	{
	public KalturaGroupUserService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaGroupUser Add(KalturaGroupUser groupUser)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("groupUser", groupUser);
			_Client.QueueServiceCall("groupuser", "add", "KalturaGroupUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGroupUser)KalturaObjectFactory.Create(result, "KalturaGroupUser");
		}

		public void Delete(string userId, string groupId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("groupId", groupId);
			_Client.QueueServiceCall("groupuser", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaGroupUserListResponse List()
		{
			return this.List(null);
		}

		public KalturaGroupUserListResponse List(KalturaGroupUserFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaGroupUserListResponse List(KalturaGroupUserFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("groupuser", "list", "KalturaGroupUserListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGroupUserListResponse)KalturaObjectFactory.Create(result, "KalturaGroupUserListResponse");
		}
	}
}
