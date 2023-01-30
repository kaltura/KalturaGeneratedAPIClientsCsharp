// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class LiveReportsExportToCsvRequestBuilder : RequestBuilder<LiveReportExportResponse>
	{
		#region Constants
		public const string REPORT_TYPE = "reportType";
		public const string PARAMS = "params";
		#endregion

		public LiveReportExportType ReportType { get; set; }
		public LiveReportExportParams Params_ { get; set; }

		public LiveReportsExportToCsvRequestBuilder()
			: base("livereports", "exportToCsv")
		{
		}

		public LiveReportsExportToCsvRequestBuilder(LiveReportExportType reportType, LiveReportExportParams params_)
			: this()
		{
			this.ReportType = reportType;
			this.Params_ = params_;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reportType"))
				kparams.AddIfNotNull("reportType", ReportType);
			if (!isMapped("params_"))
				kparams.AddIfNotNull("params_", Params_);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveReportExportResponse>(result);
		}
	}

	public class LiveReportsGetEventsRequestBuilder : RequestBuilder<IList<ReportGraph>>
	{
		#region Constants
		public const string REPORT_TYPE = "reportType";
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public LiveReportType ReportType { get; set; }
		public LiveReportInputFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public LiveReportsGetEventsRequestBuilder()
			: base("livereports", "getEvents")
		{
		}

		public LiveReportsGetEventsRequestBuilder(LiveReportType reportType, LiveReportInputFilter filter, FilterPager pager)
			: this()
		{
			this.ReportType = reportType;
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reportType"))
				kparams.AddIfNotNull("reportType", ReportType);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<ReportGraph> list = new List<ReportGraph>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<ReportGraph>(node));
			}
			return list;
		}
	}

	public class LiveReportsServeReportRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public LiveReportsServeReportRequestBuilder()
			: base("livereports", "serveReport")
		{
		}

		public LiveReportsServeReportRequestBuilder(string id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}


	public class LiveReportsService
	{
		private LiveReportsService()
		{
		}

		public static LiveReportsExportToCsvRequestBuilder ExportToCsv(LiveReportExportType reportType, LiveReportExportParams params_)
		{
			return new LiveReportsExportToCsvRequestBuilder(reportType, params_);
		}

		public static LiveReportsGetEventsRequestBuilder GetEvents(LiveReportType reportType, LiveReportInputFilter filter = null, FilterPager pager = null)
		{
			return new LiveReportsGetEventsRequestBuilder(reportType, filter, pager);
		}

		public static LiveReportsServeReportRequestBuilder ServeReport(string id)
		{
			return new LiveReportsServeReportRequestBuilder(id);
		}
	}
}
