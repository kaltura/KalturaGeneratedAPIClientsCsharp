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
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class ReportExportItem : ObjectBase
	{
		#region Constants
		public const string REPORT_TITLE = "reportTitle";
		public const string ACTION = "action";
		public const string REPORT_TYPE = "reportType";
		public const string FILTER = "filter";
		public const string ORDER = "order";
		public const string OBJECT_IDS = "objectIds";
		public const string RESPONSE_OPTIONS = "responseOptions";
		#endregion

		#region Private Fields
		private string _ReportTitle = null;
		private ReportExportItemType _Action = (ReportExportItemType)Int32.MinValue;
		private ReportType _ReportType = null;
		private ReportInputFilter _Filter;
		private string _Order = null;
		private string _ObjectIds = null;
		private ReportResponseOptions _ResponseOptions;
		#endregion

		#region Properties
		[JsonProperty]
		public string ReportTitle
		{
			get { return _ReportTitle; }
			set 
			{ 
				_ReportTitle = value;
				OnPropertyChanged("ReportTitle");
			}
		}
		[JsonProperty]
		public ReportExportItemType Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		[JsonProperty]
		public ReportType ReportType
		{
			get { return _ReportType; }
			set 
			{ 
				_ReportType = value;
				OnPropertyChanged("ReportType");
			}
		}
		[JsonProperty]
		public ReportInputFilter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		[JsonProperty]
		public string Order
		{
			get { return _Order; }
			set 
			{ 
				_Order = value;
				OnPropertyChanged("Order");
			}
		}
		[JsonProperty]
		public string ObjectIds
		{
			get { return _ObjectIds; }
			set 
			{ 
				_ObjectIds = value;
				OnPropertyChanged("ObjectIds");
			}
		}
		[JsonProperty]
		public ReportResponseOptions ResponseOptions
		{
			get { return _ResponseOptions; }
			set 
			{ 
				_ResponseOptions = value;
				OnPropertyChanged("ResponseOptions");
			}
		}
		#endregion

		#region CTor
		public ReportExportItem()
		{
		}

		public ReportExportItem(JToken node) : base(node)
		{
			if(node["reportTitle"] != null)
			{
				this._ReportTitle = node["reportTitle"].Value<string>();
			}
			if(node["action"] != null)
			{
				this._Action = (ReportExportItemType)ParseEnum(typeof(ReportExportItemType), node["action"].Value<string>());
			}
			if(node["reportType"] != null)
			{
				this._ReportType = (ReportType)StringEnum.Parse(typeof(ReportType), node["reportType"].Value<string>());
			}
			if(node["filter"] != null)
			{
				this._Filter = ObjectFactory.Create<ReportInputFilter>(node["filter"]);
			}
			if(node["order"] != null)
			{
				this._Order = node["order"].Value<string>();
			}
			if(node["objectIds"] != null)
			{
				this._ObjectIds = node["objectIds"].Value<string>();
			}
			if(node["responseOptions"] != null)
			{
				this._ResponseOptions = ObjectFactory.Create<ReportResponseOptions>(node["responseOptions"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportExportItem");
			kparams.AddIfNotNull("reportTitle", this._ReportTitle);
			kparams.AddIfNotNull("action", this._Action);
			kparams.AddIfNotNull("reportType", this._ReportType);
			kparams.AddIfNotNull("filter", this._Filter);
			kparams.AddIfNotNull("order", this._Order);
			kparams.AddIfNotNull("objectIds", this._ObjectIds);
			kparams.AddIfNotNull("responseOptions", this._ResponseOptions);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case REPORT_TITLE:
					return "ReportTitle";
				case ACTION:
					return "Action";
				case REPORT_TYPE:
					return "ReportType";
				case FILTER:
					return "Filter";
				case ORDER:
					return "Order";
				case OBJECT_IDS:
					return "ObjectIds";
				case RESPONSE_OPTIONS:
					return "ResponseOptions";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

