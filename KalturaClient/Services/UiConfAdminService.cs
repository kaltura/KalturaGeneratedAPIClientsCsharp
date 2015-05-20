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

	public class KalturaUiConfAdminService : KalturaServiceBase
	{
	public KalturaUiConfAdminService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUiConfAdmin Add(KalturaUiConfAdmin uiConf)
		{
			KalturaParams kparams = new KalturaParams();
			if (uiConf != null)
				kparams.Add("uiConf", uiConf.ToParams());
			_Client.QueueServiceCall("adminconsole_uiconfadmin", "add", "KalturaUiConfAdmin", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConfAdmin)KalturaObjectFactory.Create(result, "KalturaUiConfAdmin");
		}

		public KalturaUiConfAdmin Update(int id, KalturaUiConfAdmin uiConf)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (uiConf != null)
				kparams.Add("uiConf", uiConf.ToParams());
			_Client.QueueServiceCall("adminconsole_uiconfadmin", "update", "KalturaUiConfAdmin", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConfAdmin)KalturaObjectFactory.Create(result, "KalturaUiConfAdmin");
		}

		public KalturaUiConfAdmin Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("adminconsole_uiconfadmin", "get", "KalturaUiConfAdmin", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConfAdmin)KalturaObjectFactory.Create(result, "KalturaUiConfAdmin");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("adminconsole_uiconfadmin", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUiConfAdminListResponse List()
		{
			return this.List(null);
		}

		public KalturaUiConfAdminListResponse List(KalturaUiConfFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUiConfAdminListResponse List(KalturaUiConfFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("adminconsole_uiconfadmin", "list", "KalturaUiConfAdminListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConfAdminListResponse)KalturaObjectFactory.Create(result, "KalturaUiConfAdminListResponse");
		}
	}
}
