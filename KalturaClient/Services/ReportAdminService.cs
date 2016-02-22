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

	public class KalturaReportAdminService : KalturaServiceBase
	{
	public KalturaReportAdminService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaReport Add(KalturaReport report)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("report", report);
			_Client.QueueServiceCall("adminconsole_reportadmin", "add", "KalturaReport", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaReport)KalturaObjectFactory.Create(result, "KalturaReport");
		}

		public KalturaReport Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("adminconsole_reportadmin", "get", "KalturaReport", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaReport)KalturaObjectFactory.Create(result, "KalturaReport");
		}

		public KalturaReportListResponse List()
		{
			return this.List(null);
		}

		public KalturaReportListResponse List(KalturaReportFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaReportListResponse List(KalturaReportFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("adminconsole_reportadmin", "list", "KalturaReportListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaReportListResponse)KalturaObjectFactory.Create(result, "KalturaReportListResponse");
		}

		public KalturaReport Update(int id, KalturaReport report)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("report", report);
			_Client.QueueServiceCall("adminconsole_reportadmin", "update", "KalturaReport", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaReport)KalturaObjectFactory.Create(result, "KalturaReport");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("adminconsole_reportadmin", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaReportResponse ExecuteDebug(int id)
		{
			return this.ExecuteDebug(id, null);
		}

		public KalturaReportResponse ExecuteDebug(int id, IList<KalturaKeyValue> params_)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("params", params_);
			_Client.QueueServiceCall("adminconsole_reportadmin", "executeDebug", "KalturaReportResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaReportResponse)KalturaObjectFactory.Create(result, "KalturaReportResponse");
		}

		public IList<KalturaString> GetParameters(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("adminconsole_reportadmin", "getParameters", "KalturaString", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaString> list = new List<KalturaString>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaString)KalturaObjectFactory.Create(node, "KalturaString"));
			}
			return list;
		}

		public string GetCsvUrl(int id, int reportPartnerId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("reportPartnerId", reportPartnerId);
			_Client.QueueServiceCall("adminconsole_reportadmin", "getCsvUrl", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
