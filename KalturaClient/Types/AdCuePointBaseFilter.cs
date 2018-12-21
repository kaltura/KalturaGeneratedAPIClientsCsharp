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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class AdCuePointBaseFilter : CuePointFilter
	{
		#region Constants
		public const string PROTOCOL_TYPE_EQUAL = "protocolTypeEqual";
		public const string PROTOCOL_TYPE_IN = "protocolTypeIn";
		public const string TITLE_LIKE = "titleLike";
		public const string TITLE_MULTI_LIKE_OR = "titleMultiLikeOr";
		public const string TITLE_MULTI_LIKE_AND = "titleMultiLikeAnd";
		public const string END_TIME_GREATER_THAN_OR_EQUAL = "endTimeGreaterThanOrEqual";
		public const string END_TIME_LESS_THAN_OR_EQUAL = "endTimeLessThanOrEqual";
		public const string DURATION_GREATER_THAN_OR_EQUAL = "durationGreaterThanOrEqual";
		public const string DURATION_LESS_THAN_OR_EQUAL = "durationLessThanOrEqual";
		#endregion

		#region Private Fields
		private AdProtocolType _ProtocolTypeEqual = null;
		private string _ProtocolTypeIn = null;
		private string _TitleLike = null;
		private string _TitleMultiLikeOr = null;
		private string _TitleMultiLikeAnd = null;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public AdProtocolType ProtocolTypeEqual
		{
			get { return _ProtocolTypeEqual; }
			set 
			{ 
				_ProtocolTypeEqual = value;
				OnPropertyChanged("ProtocolTypeEqual");
			}
		}
		[JsonProperty]
		public string ProtocolTypeIn
		{
			get { return _ProtocolTypeIn; }
			set 
			{ 
				_ProtocolTypeIn = value;
				OnPropertyChanged("ProtocolTypeIn");
			}
		}
		[JsonProperty]
		public string TitleLike
		{
			get { return _TitleLike; }
			set 
			{ 
				_TitleLike = value;
				OnPropertyChanged("TitleLike");
			}
		}
		[JsonProperty]
		public string TitleMultiLikeOr
		{
			get { return _TitleMultiLikeOr; }
			set 
			{ 
				_TitleMultiLikeOr = value;
				OnPropertyChanged("TitleMultiLikeOr");
			}
		}
		[JsonProperty]
		public string TitleMultiLikeAnd
		{
			get { return _TitleMultiLikeAnd; }
			set 
			{ 
				_TitleMultiLikeAnd = value;
				OnPropertyChanged("TitleMultiLikeAnd");
			}
		}
		[JsonProperty]
		public int EndTimeGreaterThanOrEqual
		{
			get { return _EndTimeGreaterThanOrEqual; }
			set 
			{ 
				_EndTimeGreaterThanOrEqual = value;
				OnPropertyChanged("EndTimeGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int EndTimeLessThanOrEqual
		{
			get { return _EndTimeLessThanOrEqual; }
			set 
			{ 
				_EndTimeLessThanOrEqual = value;
				OnPropertyChanged("EndTimeLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int DurationGreaterThanOrEqual
		{
			get { return _DurationGreaterThanOrEqual; }
			set 
			{ 
				_DurationGreaterThanOrEqual = value;
				OnPropertyChanged("DurationGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int DurationLessThanOrEqual
		{
			get { return _DurationLessThanOrEqual; }
			set 
			{ 
				_DurationLessThanOrEqual = value;
				OnPropertyChanged("DurationLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public AdCuePointBaseFilter()
		{
		}

		public AdCuePointBaseFilter(JToken node) : base(node)
		{
			if(node["protocolTypeEqual"] != null)
			{
				this._ProtocolTypeEqual = (AdProtocolType)StringEnum.Parse(typeof(AdProtocolType), node["protocolTypeEqual"].Value<string>());
			}
			if(node["protocolTypeIn"] != null)
			{
				this._ProtocolTypeIn = node["protocolTypeIn"].Value<string>();
			}
			if(node["titleLike"] != null)
			{
				this._TitleLike = node["titleLike"].Value<string>();
			}
			if(node["titleMultiLikeOr"] != null)
			{
				this._TitleMultiLikeOr = node["titleMultiLikeOr"].Value<string>();
			}
			if(node["titleMultiLikeAnd"] != null)
			{
				this._TitleMultiLikeAnd = node["titleMultiLikeAnd"].Value<string>();
			}
			if(node["endTimeGreaterThanOrEqual"] != null)
			{
				this._EndTimeGreaterThanOrEqual = ParseInt(node["endTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["endTimeLessThanOrEqual"] != null)
			{
				this._EndTimeLessThanOrEqual = ParseInt(node["endTimeLessThanOrEqual"].Value<string>());
			}
			if(node["durationGreaterThanOrEqual"] != null)
			{
				this._DurationGreaterThanOrEqual = ParseInt(node["durationGreaterThanOrEqual"].Value<string>());
			}
			if(node["durationLessThanOrEqual"] != null)
			{
				this._DurationLessThanOrEqual = ParseInt(node["durationLessThanOrEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAdCuePointBaseFilter");
			kparams.AddIfNotNull("protocolTypeEqual", this._ProtocolTypeEqual);
			kparams.AddIfNotNull("protocolTypeIn", this._ProtocolTypeIn);
			kparams.AddIfNotNull("titleLike", this._TitleLike);
			kparams.AddIfNotNull("titleMultiLikeOr", this._TitleMultiLikeOr);
			kparams.AddIfNotNull("titleMultiLikeAnd", this._TitleMultiLikeAnd);
			kparams.AddIfNotNull("endTimeGreaterThanOrEqual", this._EndTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("endTimeLessThanOrEqual", this._EndTimeLessThanOrEqual);
			kparams.AddIfNotNull("durationGreaterThanOrEqual", this._DurationGreaterThanOrEqual);
			kparams.AddIfNotNull("durationLessThanOrEqual", this._DurationLessThanOrEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROTOCOL_TYPE_EQUAL:
					return "ProtocolTypeEqual";
				case PROTOCOL_TYPE_IN:
					return "ProtocolTypeIn";
				case TITLE_LIKE:
					return "TitleLike";
				case TITLE_MULTI_LIKE_OR:
					return "TitleMultiLikeOr";
				case TITLE_MULTI_LIKE_AND:
					return "TitleMultiLikeAnd";
				case END_TIME_GREATER_THAN_OR_EQUAL:
					return "EndTimeGreaterThanOrEqual";
				case END_TIME_LESS_THAN_OR_EQUAL:
					return "EndTimeLessThanOrEqual";
				case DURATION_GREATER_THAN_OR_EQUAL:
					return "DurationGreaterThanOrEqual";
				case DURATION_LESS_THAN_OR_EQUAL:
					return "DurationLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

