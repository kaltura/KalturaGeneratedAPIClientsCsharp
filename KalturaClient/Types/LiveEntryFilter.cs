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
	public class LiveEntryFilter : LiveEntryBaseFilter
	{
		#region Constants
		public const string IS_LIVE = "isLive";
		public const string IS_RECORDED_ENTRY_ID_EMPTY = "isRecordedEntryIdEmpty";
		public const string HAS_MEDIA_SERVER_HOSTNAME = "hasMediaServerHostname";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private NullableBoolean _IsLive = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _IsRecordedEntryIdEmpty = (NullableBoolean)Int32.MinValue;
		private string _HasMediaServerHostname = null;
		private LiveEntryOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IsLiveAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsLive
		{
			get { return _IsLive; }
			set 
			{ 
				_IsLive = value;
				OnPropertyChanged("IsLive");
			}
		}
		/// <summary>
		/// Use IsRecordedEntryIdEmptyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsRecordedEntryIdEmpty
		{
			get { return _IsRecordedEntryIdEmpty; }
			set 
			{ 
				_IsRecordedEntryIdEmpty = value;
				OnPropertyChanged("IsRecordedEntryIdEmpty");
			}
		}
		/// <summary>
		/// Use HasMediaServerHostnameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HasMediaServerHostname
		{
			get { return _HasMediaServerHostname; }
			set 
			{ 
				_HasMediaServerHostname = value;
				OnPropertyChanged("HasMediaServerHostname");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new LiveEntryOrderBy OrderBy
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
		public LiveEntryFilter()
		{
		}

		public LiveEntryFilter(JToken node) : base(node)
		{
			if(node["isLive"] != null)
			{
				this._IsLive = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isLive"].Value<string>());
			}
			if(node["isRecordedEntryIdEmpty"] != null)
			{
				this._IsRecordedEntryIdEmpty = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isRecordedEntryIdEmpty"].Value<string>());
			}
			if(node["hasMediaServerHostname"] != null)
			{
				this._HasMediaServerHostname = node["hasMediaServerHostname"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (LiveEntryOrderBy)StringEnum.Parse(typeof(LiveEntryOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveEntryFilter");
			kparams.AddIfNotNull("isLive", this._IsLive);
			kparams.AddIfNotNull("isRecordedEntryIdEmpty", this._IsRecordedEntryIdEmpty);
			kparams.AddIfNotNull("hasMediaServerHostname", this._HasMediaServerHostname);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IS_LIVE:
					return "IsLive";
				case IS_RECORDED_ENTRY_ID_EMPTY:
					return "IsRecordedEntryIdEmpty";
				case HAS_MEDIA_SERVER_HOSTNAME:
					return "HasMediaServerHostname";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

