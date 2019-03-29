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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class ReportExecuteRequestBuilder : RequestBuilder<ReportResponse>
	{
		#region Constants
		public const string ID = "id";
		public const string PARAMS = "params";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public IList<KeyValue> Params_
		{
			set;
			get;
		}

		public ReportExecuteRequestBuilder()
			: base("report", "execute")
		{
		}

		public ReportExecuteRequestBuilder(int id, IList<KeyValue> params_)
			: this()
		{
			this.Id = id;
			this.Params_ = params_;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
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
			return ObjectFactory.Create<ReportResponse>(result);
		}
	}

	public class ReportExportToCsvRequestBuilder : RequestBuilder<ReportExportResponse>
	{
		#region Constants
		public const string PARAMS = "params";
		#endregion

		public ReportExportParams Params_
		{
			set;
			get;
		}

		public ReportExportToCsvRequestBuilder()
			: base("report", "exportToCsv")
		{
		}

		public ReportExportToCsvRequestBuilder(ReportExportParams params_)
			: this()
		{
			this.Params_ = params_;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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
			return ObjectFactory.Create<ReportExportResponse>(result);
		}
	}

	public class ReportGetBaseTotalRequestBuilder : RequestBuilder<IList<ReportBaseTotal>>
	{
		#region Constants
		public const string REPORT_TYPE = "reportType";
		public const string REPORT_INPUT_FILTER = "reportInputFilter";
		public const string OBJECT_IDS = "objectIds";
		public const string RESPONSE_OPTIONS = "responseOptions";
		#endregion

		public ReportType ReportType
		{
			set;
			get;
		}
		public ReportInputFilter ReportInputFilter
		{
			set;
			get;
		}
		public string ObjectIds
		{
			set;
			get;
		}
		public ReportResponseOptions ResponseOptions
		{
			set;
			get;
		}

		public ReportGetBaseTotalRequestBuilder()
			: base("report", "getBaseTotal")
		{
		}

		public ReportGetBaseTotalRequestBuilder(ReportType reportType, ReportInputFilter reportInputFilter, string objectIds, ReportResponseOptions responseOptions)
			: this()
		{
			this.ReportType = reportType;
			this.ReportInputFilter = reportInputFilter;
			this.ObjectIds = objectIds;
			this.ResponseOptions = responseOptions;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reportType"))
				kparams.AddIfNotNull("reportType", ReportType);
			if (!isMapped("reportInputFilter"))
				kparams.AddIfNotNull("reportInputFilter", ReportInputFilter);
			if (!isMapped("objectIds"))
				kparams.AddIfNotNull("objectIds", ObjectIds);
			if (!isMapped("responseOptions"))
				kparams.AddIfNotNull("responseOptions", ResponseOptions);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<ReportBaseTotal> list = new List<ReportBaseTotal>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<ReportBaseTotal>(node));
			}
			return list;
		}
	}

	public class ReportGetGraphsRequestBuilder : RequestBuilder<IList<ReportGraph>>
	{
		#region Constants
		public const string REPORT_TYPE = "reportType";
		public const string REPORT_INPUT_FILTER = "reportInputFilter";
		public const string DIMENSION = "dimension";
		public const string OBJECT_IDS = "objectIds";
		public const string RESPONSE_OPTIONS = "responseOptions";
		#endregion

		public ReportType ReportType
		{
			set;
			get;
		}
		public ReportInputFilter ReportInputFilter
		{
			set;
			get;
		}
		public string Dimension
		{
			set;
			get;
		}
		public string ObjectIds
		{
			set;
			get;
		}
		public ReportResponseOptions ResponseOptions
		{
			set;
			get;
		}

		public ReportGetGraphsRequestBuilder()
			: base("report", "getGraphs")
		{
		}

		public ReportGetGraphsRequestBuilder(ReportType reportType, ReportInputFilter reportInputFilter, string dimension, string objectIds, ReportResponseOptions responseOptions)
			: this()
		{
			this.ReportType = reportType;
			this.ReportInputFilter = reportInputFilter;
			this.Dimension = dimension;
			this.ObjectIds = objectIds;
			this.ResponseOptions = responseOptions;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reportType"))
				kparams.AddIfNotNull("reportType", ReportType);
			if (!isMapped("reportInputFilter"))
				kparams.AddIfNotNull("reportInputFilter", ReportInputFilter);
			if (!isMapped("dimension"))
				kparams.AddIfNotNull("dimension", Dimension);
			if (!isMapped("objectIds"))
				kparams.AddIfNotNull("objectIds", ObjectIds);
			if (!isMapped("responseOptions"))
				kparams.AddIfNotNull("responseOptions", ResponseOptions);
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

	public class ReportGetTableRequestBuilder : RequestBuilder<ReportTable>
	{
		#region Constants
		public const string REPORT_TYPE = "reportType";
		public const string REPORT_INPUT_FILTER = "reportInputFilter";
		public const string PAGER = "pager";
		public const string ORDER = "order";
		public const string OBJECT_IDS = "objectIds";
		public const string RESPONSE_OPTIONS = "responseOptions";
		#endregion

		public ReportType ReportType
		{
			set;
			get;
		}
		public ReportInputFilter ReportInputFilter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}
		public string Order
		{
			set;
			get;
		}
		public string ObjectIds
		{
			set;
			get;
		}
		public ReportResponseOptions ResponseOptions
		{
			set;
			get;
		}

		public ReportGetTableRequestBuilder()
			: base("report", "getTable")
		{
		}

		public ReportGetTableRequestBuilder(ReportType reportType, ReportInputFilter reportInputFilter, FilterPager pager, string order, string objectIds, ReportResponseOptions responseOptions)
			: this()
		{
			this.ReportType = reportType;
			this.ReportInputFilter = reportInputFilter;
			this.Pager = pager;
			this.Order = order;
			this.ObjectIds = objectIds;
			this.ResponseOptions = responseOptions;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reportType"))
				kparams.AddIfNotNull("reportType", ReportType);
			if (!isMapped("reportInputFilter"))
				kparams.AddIfNotNull("reportInputFilter", ReportInputFilter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			if (!isMapped("order"))
				kparams.AddIfNotNull("order", Order);
			if (!isMapped("objectIds"))
				kparams.AddIfNotNull("objectIds", ObjectIds);
			if (!isMapped("responseOptions"))
				kparams.AddIfNotNull("responseOptions", ResponseOptions);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ReportTable>(result);
		}
	}

	public class ReportGetTotalRequestBuilder : RequestBuilder<ReportTotal>
	{
		#region Constants
		public const string REPORT_TYPE = "reportType";
		public const string REPORT_INPUT_FILTER = "reportInputFilter";
		public const string OBJECT_IDS = "objectIds";
		public const string RESPONSE_OPTIONS = "responseOptions";
		#endregion

		public ReportType ReportType
		{
			set;
			get;
		}
		public ReportInputFilter ReportInputFilter
		{
			set;
			get;
		}
		public string ObjectIds
		{
			set;
			get;
		}
		public ReportResponseOptions ResponseOptions
		{
			set;
			get;
		}

		public ReportGetTotalRequestBuilder()
			: base("report", "getTotal")
		{
		}

		public ReportGetTotalRequestBuilder(ReportType reportType, ReportInputFilter reportInputFilter, string objectIds, ReportResponseOptions responseOptions)
			: this()
		{
			this.ReportType = reportType;
			this.ReportInputFilter = reportInputFilter;
			this.ObjectIds = objectIds;
			this.ResponseOptions = responseOptions;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reportType"))
				kparams.AddIfNotNull("reportType", ReportType);
			if (!isMapped("reportInputFilter"))
				kparams.AddIfNotNull("reportInputFilter", ReportInputFilter);
			if (!isMapped("objectIds"))
				kparams.AddIfNotNull("objectIds", ObjectIds);
			if (!isMapped("responseOptions"))
				kparams.AddIfNotNull("responseOptions", ResponseOptions);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ReportTotal>(result);
		}
	}

	public class ReportGetUrlForReportAsCsvRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string REPORT_TITLE = "reportTitle";
		public const string REPORT_TEXT = "reportText";
		public const string HEADERS = "headers";
		public const string REPORT_TYPE = "reportType";
		public const string REPORT_INPUT_FILTER = "reportInputFilter";
		public const string DIMENSION = "dimension";
		public const string PAGER = "pager";
		public const string ORDER = "order";
		public const string OBJECT_IDS = "objectIds";
		public const string RESPONSE_OPTIONS = "responseOptions";
		#endregion

		public string ReportTitle
		{
			set;
			get;
		}
		public string ReportText
		{
			set;
			get;
		}
		public string Headers
		{
			set;
			get;
		}
		public ReportType ReportType
		{
			set;
			get;
		}
		public ReportInputFilter ReportInputFilter
		{
			set;
			get;
		}
		public string Dimension
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}
		public string Order
		{
			set;
			get;
		}
		public string ObjectIds
		{
			set;
			get;
		}
		public ReportResponseOptions ResponseOptions
		{
			set;
			get;
		}

		public ReportGetUrlForReportAsCsvRequestBuilder()
			: base("report", "getUrlForReportAsCsv")
		{
		}

		public ReportGetUrlForReportAsCsvRequestBuilder(string reportTitle, string reportText, string headers, ReportType reportType, ReportInputFilter reportInputFilter, string dimension, FilterPager pager, string order, string objectIds, ReportResponseOptions responseOptions)
			: this()
		{
			this.ReportTitle = reportTitle;
			this.ReportText = reportText;
			this.Headers = headers;
			this.ReportType = reportType;
			this.ReportInputFilter = reportInputFilter;
			this.Dimension = dimension;
			this.Pager = pager;
			this.Order = order;
			this.ObjectIds = objectIds;
			this.ResponseOptions = responseOptions;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("reportTitle"))
				kparams.AddIfNotNull("reportTitle", ReportTitle);
			if (!isMapped("reportText"))
				kparams.AddIfNotNull("reportText", ReportText);
			if (!isMapped("headers"))
				kparams.AddIfNotNull("headers", Headers);
			if (!isMapped("reportType"))
				kparams.AddIfNotNull("reportType", ReportType);
			if (!isMapped("reportInputFilter"))
				kparams.AddIfNotNull("reportInputFilter", ReportInputFilter);
			if (!isMapped("dimension"))
				kparams.AddIfNotNull("dimension", Dimension);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			if (!isMapped("order"))
				kparams.AddIfNotNull("order", Order);
			if (!isMapped("objectIds"))
				kparams.AddIfNotNull("objectIds", ObjectIds);
			if (!isMapped("responseOptions"))
				kparams.AddIfNotNull("responseOptions", ResponseOptions);
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

	public class ReportServeRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public ReportServeRequestBuilder()
			: base("report", "serve")
		{
		}

		public ReportServeRequestBuilder(string id)
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


	public class ReportService
	{
		private ReportService()
		{
		}

		public static ReportExecuteRequestBuilder Execute(int id, IList<KeyValue> params_ = null)
		{
			return new ReportExecuteRequestBuilder(id, params_);
		}

		public static ReportExportToCsvRequestBuilder ExportToCsv(ReportExportParams params_)
		{
			return new ReportExportToCsvRequestBuilder(params_);
		}

		public static ReportGetBaseTotalRequestBuilder GetBaseTotal(ReportType reportType, ReportInputFilter reportInputFilter, string objectIds = null, ReportResponseOptions responseOptions = null)
		{
			return new ReportGetBaseTotalRequestBuilder(reportType, reportInputFilter, objectIds, responseOptions);
		}

		public static ReportGetGraphsRequestBuilder GetGraphs(ReportType reportType, ReportInputFilter reportInputFilter, string dimension = null, string objectIds = null, ReportResponseOptions responseOptions = null)
		{
			return new ReportGetGraphsRequestBuilder(reportType, reportInputFilter, dimension, objectIds, responseOptions);
		}

		public static ReportGetTableRequestBuilder GetTable(ReportType reportType, ReportInputFilter reportInputFilter, FilterPager pager, string order = null, string objectIds = null, ReportResponseOptions responseOptions = null)
		{
			return new ReportGetTableRequestBuilder(reportType, reportInputFilter, pager, order, objectIds, responseOptions);
		}

		public static ReportGetTotalRequestBuilder GetTotal(ReportType reportType, ReportInputFilter reportInputFilter, string objectIds = null, ReportResponseOptions responseOptions = null)
		{
			return new ReportGetTotalRequestBuilder(reportType, reportInputFilter, objectIds, responseOptions);
		}

		public static ReportGetUrlForReportAsCsvRequestBuilder GetUrlForReportAsCsv(string reportTitle, string reportText, string headers, ReportType reportType, ReportInputFilter reportInputFilter, string dimension = null, FilterPager pager = null, string order = null, string objectIds = null, ReportResponseOptions responseOptions = null)
		{
			return new ReportGetUrlForReportAsCsvRequestBuilder(reportTitle, reportText, headers, reportType, reportInputFilter, dimension, pager, order, objectIds, responseOptions);
		}

		public static ReportServeRequestBuilder Serve(string id)
		{
			return new ReportServeRequestBuilder(id);
		}
	}
}
