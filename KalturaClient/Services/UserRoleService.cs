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

	public class KalturaUserRoleService : KalturaServiceBase
	{
	public KalturaUserRoleService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUserRole Add(KalturaUserRole userRole)
		{
			KalturaParams kparams = new KalturaParams();
			if (userRole != null)
				kparams.Add("userRole", userRole.ToParams());
			_Client.QueueServiceCall("userrole", "add", "KalturaUserRole", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result, "KalturaUserRole");
		}

		public KalturaUserRole Get(int userRoleId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("userRoleId", userRoleId);
			_Client.QueueServiceCall("userrole", "get", "KalturaUserRole", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result, "KalturaUserRole");
		}

		public KalturaUserRole Update(int userRoleId, KalturaUserRole userRole)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("userRoleId", userRoleId);
			if (userRole != null)
				kparams.Add("userRole", userRole.ToParams());
			_Client.QueueServiceCall("userrole", "update", "KalturaUserRole", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result, "KalturaUserRole");
		}

		public KalturaUserRole Delete(int userRoleId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("userRoleId", userRoleId);
			_Client.QueueServiceCall("userrole", "delete", "KalturaUserRole", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result, "KalturaUserRole");
		}

		public KalturaUserRoleListResponse List()
		{
			return this.List(null);
		}

		public KalturaUserRoleListResponse List(KalturaUserRoleFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUserRoleListResponse List(KalturaUserRoleFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("userrole", "list", "KalturaUserRoleListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRoleListResponse)KalturaObjectFactory.Create(result, "KalturaUserRoleListResponse");
		}

		public KalturaUserRole Clone(int userRoleId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("userRoleId", userRoleId);
			_Client.QueueServiceCall("userrole", "clone", "KalturaUserRole", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result, "KalturaUserRole");
		}
	}
}
