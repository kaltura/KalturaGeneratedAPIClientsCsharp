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

	public class KalturaReportService : KalturaServiceBase
	{
	public KalturaReportService(KalturaClient client)
			: base(client)
		{
		}

		public IList<KalturaReportGraph> GetGraphs(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter)
		{
			return this.GetGraphs(reportType, reportInputFilter, null);
		}

		public IList<KalturaReportGraph> GetGraphs(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, string dimension)
		{
			return this.GetGraphs(reportType, reportInputFilter, dimension, null);
		}

		public IList<KalturaReportGraph> GetGraphs(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, string dimension, string objectIds)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("reportType", reportType);
			if (reportInputFilter != null)
				kparams.Add("reportInputFilter", reportInputFilter.ToParams());
			kparams.AddStringIfNotNull("dimension", dimension);
			kparams.AddStringIfNotNull("objectIds", objectIds);
			_Client.QueueServiceCall("report", "getGraphs", "KalturaReportGraph", kparams);
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

		public KalturaReportTotal GetTotal(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter)
		{
			return this.GetTotal(reportType, reportInputFilter, null);
		}

		public KalturaReportTotal GetTotal(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, string objectIds)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("reportType", reportType);
			if (reportInputFilter != null)
				kparams.Add("reportInputFilter", reportInputFilter.ToParams());
			kparams.AddStringIfNotNull("objectIds", objectIds);
			_Client.QueueServiceCall("report", "getTotal", "KalturaReportTotal", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaReportTotal)KalturaObjectFactory.Create(result, "KalturaReportTotal");
		}

		public IList<KalturaReportBaseTotal> GetBaseTotal(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter)
		{
			return this.GetBaseTotal(reportType, reportInputFilter, null);
		}

		public IList<KalturaReportBaseTotal> GetBaseTotal(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, string objectIds)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("reportType", reportType);
			if (reportInputFilter != null)
				kparams.Add("reportInputFilter", reportInputFilter.ToParams());
			kparams.AddStringIfNotNull("objectIds", objectIds);
			_Client.QueueServiceCall("report", "getBaseTotal", "KalturaReportBaseTotal", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaReportBaseTotal> list = new List<KalturaReportBaseTotal>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaReportBaseTotal)KalturaObjectFactory.Create(node, "KalturaReportBaseTotal"));
			}
			return list;
		}

		public KalturaReportTable GetTable(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, KalturaFilterPager pager)
		{
			return this.GetTable(reportType, reportInputFilter, pager, null);
		}

		public KalturaReportTable GetTable(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, KalturaFilterPager pager, string order)
		{
			return this.GetTable(reportType, reportInputFilter, pager, order, null);
		}

		public KalturaReportTable GetTable(KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, KalturaFilterPager pager, string order, string objectIds)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("reportType", reportType);
			if (reportInputFilter != null)
				kparams.Add("reportInputFilter", reportInputFilter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			kparams.AddStringIfNotNull("order", order);
			kparams.AddStringIfNotNull("objectIds", objectIds);
			_Client.QueueServiceCall("report", "getTable", "KalturaReportTable", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaReportTable)KalturaObjectFactory.Create(result, "KalturaReportTable");
		}

		public string GetUrlForReportAsCsv(string reportTitle, string reportText, string headers, KalturaReportType reportType, KalturaReportInputFilter reportInputFilter)
		{
			return this.GetUrlForReportAsCsv(reportTitle, reportText, headers, reportType, reportInputFilter, null);
		}

		public string GetUrlForReportAsCsv(string reportTitle, string reportText, string headers, KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, string dimension)
		{
			return this.GetUrlForReportAsCsv(reportTitle, reportText, headers, reportType, reportInputFilter, dimension, null);
		}

		public string GetUrlForReportAsCsv(string reportTitle, string reportText, string headers, KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, string dimension, KalturaFilterPager pager)
		{
			return this.GetUrlForReportAsCsv(reportTitle, reportText, headers, reportType, reportInputFilter, dimension, pager, null);
		}

		public string GetUrlForReportAsCsv(string reportTitle, string reportText, string headers, KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, string dimension, KalturaFilterPager pager, string order)
		{
			return this.GetUrlForReportAsCsv(reportTitle, reportText, headers, reportType, reportInputFilter, dimension, pager, order, null);
		}

		public string GetUrlForReportAsCsv(string reportTitle, string reportText, string headers, KalturaReportType reportType, KalturaReportInputFilter reportInputFilter, string dimension, KalturaFilterPager pager, string order, string objectIds)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("reportTitle", reportTitle);
			kparams.AddStringIfNotNull("reportText", reportText);
			kparams.AddStringIfNotNull("headers", headers);
			kparams.AddEnumIfNotNull("reportType", reportType);
			if (reportInputFilter != null)
				kparams.Add("reportInputFilter", reportInputFilter.ToParams());
			kparams.AddStringIfNotNull("dimension", dimension);
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			kparams.AddStringIfNotNull("order", order);
			kparams.AddStringIfNotNull("objectIds", objectIds);
			_Client.QueueServiceCall("report", "getUrlForReportAsCsv", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public string Serve(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("report", "serve", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaReportResponse Execute(int id)
		{
			return this.Execute(id, null);
		}

		public KalturaReportResponse Execute(int id, IList<KalturaKeyValue> params_)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			foreach(KalturaKeyValue obj in params_)
			{
				kparams.Add("params", obj.ToParams());
			}
			_Client.QueueServiceCall("report", "execute", "KalturaReportResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaReportResponse)KalturaObjectFactory.Create(result, "KalturaReportResponse");
		}
	}
}
