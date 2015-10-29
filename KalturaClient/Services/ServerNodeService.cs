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

	public class KalturaServerNodeService : KalturaServiceBase
	{
	public KalturaServerNodeService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaServerNode Add(KalturaServerNode serverNode)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("serverNode", serverNode);
			_Client.QueueServiceCall("servernode", "add", "KalturaServerNode", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaServerNode)KalturaObjectFactory.Create(result, "KalturaServerNode");
		}

		public KalturaServerNode Get(int serverNodeId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("serverNodeId", serverNodeId);
			_Client.QueueServiceCall("servernode", "get", "KalturaServerNode", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaServerNode)KalturaObjectFactory.Create(result, "KalturaServerNode");
		}

		public KalturaServerNode Update(int serverNodeId, KalturaServerNode serverNode)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("serverNodeId", serverNodeId);
			kparams.AddIfNotNull("serverNode", serverNode);
			_Client.QueueServiceCall("servernode", "update", "KalturaServerNode", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaServerNode)KalturaObjectFactory.Create(result, "KalturaServerNode");
		}

		public void Delete(string serverNodeId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("serverNodeId", serverNodeId);
			_Client.QueueServiceCall("servernode", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaServerNode Disable(string serverNodeId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("serverNodeId", serverNodeId);
			_Client.QueueServiceCall("servernode", "disable", "KalturaServerNode", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaServerNode)KalturaObjectFactory.Create(result, "KalturaServerNode");
		}

		public KalturaServerNode Enable(string serverNodeId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("serverNodeId", serverNodeId);
			_Client.QueueServiceCall("servernode", "enable", "KalturaServerNode", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaServerNode)KalturaObjectFactory.Create(result, "KalturaServerNode");
		}

		public KalturaServerNodeListResponse List()
		{
			return this.List(null);
		}

		public KalturaServerNodeListResponse List(KalturaServerNodeFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaServerNodeListResponse List(KalturaServerNodeFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("servernode", "list", "KalturaServerNodeListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaServerNodeListResponse)KalturaObjectFactory.Create(result, "KalturaServerNodeListResponse");
		}

		public KalturaServerNode ReportStatus(string hostName)
		{
			return this.ReportStatus(hostName, null);
		}

		public KalturaServerNode ReportStatus(string hostName, KalturaServerNode serverNode)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("hostName", hostName);
			kparams.AddIfNotNull("serverNode", serverNode);
			_Client.QueueServiceCall("servernode", "reportStatus", "KalturaServerNode", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaServerNode)KalturaObjectFactory.Create(result, "KalturaServerNode");
		}
	}
}
