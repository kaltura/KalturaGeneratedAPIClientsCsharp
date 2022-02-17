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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class LiveReportInputFilter : ObjectBase
	{
		#region Constants
		public const string ENTRY_IDS = "entryIds";
		public const string FROM_TIME = "fromTime";
		public const string TO_TIME = "toTime";
		public const string LIVE = "live";
		public const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _EntryIds = null;
		private int _FromTime = Int32.MinValue;
		private int _ToTime = Int32.MinValue;
		private NullableBoolean _Live = (NullableBoolean)Int32.MinValue;
		private LiveReportOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EntryIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIds
		{
			get { return _EntryIds; }
			set 
			{ 
				_EntryIds = value;
				OnPropertyChanged("EntryIds");
			}
		}
		/// <summary>
		/// Use FromTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FromTime
		{
			get { return _FromTime; }
			set 
			{ 
				_FromTime = value;
				OnPropertyChanged("FromTime");
			}
		}
		/// <summary>
		/// Use ToTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ToTime
		{
			get { return _ToTime; }
			set 
			{ 
				_ToTime = value;
				OnPropertyChanged("ToTime");
			}
		}
		/// <summary>
		/// Use LiveAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean Live
		{
			get { return _Live; }
			set 
			{ 
				_Live = value;
				OnPropertyChanged("Live");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public LiveReportOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public LiveReportInputFilter()
		{
		}

		public LiveReportInputFilter(JToken node) : base(node)
		{
			if(node["entryIds"] != null)
			{
				this._EntryIds = node["entryIds"].Value<string>();
			}
			if(node["fromTime"] != null)
			{
				this._FromTime = ParseInt(node["fromTime"].Value<string>());
			}
			if(node["toTime"] != null)
			{
				this._ToTime = ParseInt(node["toTime"].Value<string>());
			}
			if(node["live"] != null)
			{
				this._Live = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["live"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (LiveReportOrderBy)StringEnum.Parse(typeof(LiveReportOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveReportInputFilter");
			kparams.AddIfNotNull("entryIds", this._EntryIds);
			kparams.AddIfNotNull("fromTime", this._FromTime);
			kparams.AddIfNotNull("toTime", this._ToTime);
			kparams.AddIfNotNull("live", this._Live);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_IDS:
					return "EntryIds";
				case FROM_TIME:
					return "FromTime";
				case TO_TIME:
					return "ToTime";
				case LIVE:
					return "Live";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

