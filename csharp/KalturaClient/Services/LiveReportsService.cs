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

	public class KalturaLiveReportsService : KalturaServiceBase
	{
	public KalturaLiveReportsService(KalturaClient client)
			: base(client)
		{
		}

		public IList<KalturaReportGraph> GetEvents(KalturaLiveReportType reportType)
		{
			return this.GetEvents(reportType, null);
		}

		public IList<KalturaReportGraph> GetEvents(KalturaLiveReportType reportType, KalturaLiveReportInputFilter filter)
		{
			return this.GetEvents(reportType, filter, null);
		}

		public IList<KalturaReportGraph> GetEvents(KalturaLiveReportType reportType, KalturaLiveReportInputFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringEnumIfNotNull("reportType", reportType);
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("livereports", "getEvents", "KalturaReportGraph", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaReportGraph> list = new List<KalturaReportGraph>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaReportGraph)KalturaObjectFactory.Create(node, "KalturaReportGraph"));
			}
			return list;
		}

		public KalturaLiveStatsListResponse GetReport(KalturaLiveReportType reportType)
		{
			return this.GetReport(reportType, null);
		}

		public KalturaLiveStatsListResponse GetReport(KalturaLiveReportType reportType, KalturaLiveReportInputFilter filter)
		{
			return this.GetReport(reportType, filter, null);
		}

		public KalturaLiveStatsListResponse GetReport(KalturaLiveReportType reportType, KalturaLiveReportInputFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringEnumIfNotNull("reportType", reportType);
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("livereports", "getReport", "KalturaLiveStatsListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStatsListResponse)KalturaObjectFactory.Create(result, "KalturaLiveStatsListResponse");
		}

		public KalturaLiveReportExportResponse ExportToCsv(KalturaLiveReportExportType reportType, KalturaLiveReportExportParams params_)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("reportType", reportType);
			if (params_ != null)
				kparams.Add("params", params_.ToParams());
			_Client.QueueServiceCall("livereports", "exportToCsv", "KalturaLiveReportExportResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveReportExportResponse)KalturaObjectFactory.Create(result, "KalturaLiveReportExportResponse");
		}

		public string ServeReport(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("livereports", "serveReport", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
