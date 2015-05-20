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

	public class KalturaUiConfService : KalturaServiceBase
	{
	public KalturaUiConfService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUiConf Add(KalturaUiConf uiConf)
		{
			KalturaParams kparams = new KalturaParams();
			if (uiConf != null)
				kparams.Add("uiConf", uiConf.ToParams());
			_Client.QueueServiceCall("uiconf", "add", "KalturaUiConf", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConf)KalturaObjectFactory.Create(result, "KalturaUiConf");
		}

		public KalturaUiConf Update(int id, KalturaUiConf uiConf)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (uiConf != null)
				kparams.Add("uiConf", uiConf.ToParams());
			_Client.QueueServiceCall("uiconf", "update", "KalturaUiConf", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConf)KalturaObjectFactory.Create(result, "KalturaUiConf");
		}

		public KalturaUiConf Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("uiconf", "get", "KalturaUiConf", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConf)KalturaObjectFactory.Create(result, "KalturaUiConf");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("uiconf", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUiConf Clone(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("uiconf", "clone", "KalturaUiConf", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConf)KalturaObjectFactory.Create(result, "KalturaUiConf");
		}

		public KalturaUiConfListResponse ListTemplates()
		{
			return this.ListTemplates(null);
		}

		public KalturaUiConfListResponse ListTemplates(KalturaUiConfFilter filter)
		{
			return this.ListTemplates(filter, null);
		}

		public KalturaUiConfListResponse ListTemplates(KalturaUiConfFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("uiconf", "listTemplates", "KalturaUiConfListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConfListResponse)KalturaObjectFactory.Create(result, "KalturaUiConfListResponse");
		}

		public KalturaUiConfListResponse List()
		{
			return this.List(null);
		}

		public KalturaUiConfListResponse List(KalturaUiConfFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUiConfListResponse List(KalturaUiConfFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("uiconf", "list", "KalturaUiConfListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConfListResponse)KalturaObjectFactory.Create(result, "KalturaUiConfListResponse");
		}

		public IList<KalturaUiConfTypeInfo> GetAvailableTypes()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("uiconf", "getAvailableTypes", "KalturaUiConfTypeInfo", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaUiConfTypeInfo> list = new List<KalturaUiConfTypeInfo>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaUiConfTypeInfo)KalturaObjectFactory.Create(node, "KalturaUiConfTypeInfo"));
			}
			return list;
		}
	}
}
