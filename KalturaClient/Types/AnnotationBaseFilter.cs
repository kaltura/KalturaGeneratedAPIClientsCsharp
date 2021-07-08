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
	public class AnnotationBaseFilter : CuePointFilter
	{
		#region Constants
		public const string PARENT_ID_EQUAL = "parentIdEqual";
		public const string PARENT_ID_IN = "parentIdIn";
		public const string TEXT_LIKE = "textLike";
		public const string TEXT_MULTI_LIKE_OR = "textMultiLikeOr";
		public const string TEXT_MULTI_LIKE_AND = "textMultiLikeAnd";
		public const string END_TIME_GREATER_THAN_OR_EQUAL = "endTimeGreaterThanOrEqual";
		public const string END_TIME_LESS_THAN_OR_EQUAL = "endTimeLessThanOrEqual";
		public const string DURATION_GREATER_THAN_OR_EQUAL = "durationGreaterThanOrEqual";
		public const string DURATION_LESS_THAN_OR_EQUAL = "durationLessThanOrEqual";
		public const string IS_PUBLIC_EQUAL = "isPublicEqual";
		#endregion

		#region Private Fields
		private string _ParentIdEqual = null;
		private string _ParentIdIn = null;
		private string _TextLike = null;
		private string _TextMultiLikeOr = null;
		private string _TextMultiLikeAnd = null;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		private NullableBoolean _IsPublicEqual = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use ParentIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		/// <summary>
		/// Use ParentIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		/// <summary>
		/// Use TextLikeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TextLike
		{
			get { return _TextLike; }
			set 
			{ 
				_TextLike = value;
				OnPropertyChanged("TextLike");
			}
		}
		/// <summary>
		/// Use TextMultiLikeOrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TextMultiLikeOr
		{
			get { return _TextMultiLikeOr; }
			set 
			{ 
				_TextMultiLikeOr = value;
				OnPropertyChanged("TextMultiLikeOr");
			}
		}
		/// <summary>
		/// Use TextMultiLikeAndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TextMultiLikeAnd
		{
			get { return _TextMultiLikeAnd; }
			set 
			{ 
				_TextMultiLikeAnd = value;
				OnPropertyChanged("TextMultiLikeAnd");
			}
		}
		/// <summary>
		/// Use EndTimeGreaterThanOrEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use EndTimeLessThanOrEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DurationGreaterThanOrEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DurationLessThanOrEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use IsPublicEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsPublicEqual
		{
			get { return _IsPublicEqual; }
			set 
			{ 
				_IsPublicEqual = value;
				OnPropertyChanged("IsPublicEqual");
			}
		}
		#endregion

		#region CTor
		public AnnotationBaseFilter()
		{
		}

		public AnnotationBaseFilter(JToken node) : base(node)
		{
			if(node["parentIdEqual"] != null)
			{
				this._ParentIdEqual = node["parentIdEqual"].Value<string>();
			}
			if(node["parentIdIn"] != null)
			{
				this._ParentIdIn = node["parentIdIn"].Value<string>();
			}
			if(node["textLike"] != null)
			{
				this._TextLike = node["textLike"].Value<string>();
			}
			if(node["textMultiLikeOr"] != null)
			{
				this._TextMultiLikeOr = node["textMultiLikeOr"].Value<string>();
			}
			if(node["textMultiLikeAnd"] != null)
			{
				this._TextMultiLikeAnd = node["textMultiLikeAnd"].Value<string>();
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
			if(node["isPublicEqual"] != null)
			{
				this._IsPublicEqual = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isPublicEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAnnotationBaseFilter");
			kparams.AddIfNotNull("parentIdEqual", this._ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this._ParentIdIn);
			kparams.AddIfNotNull("textLike", this._TextLike);
			kparams.AddIfNotNull("textMultiLikeOr", this._TextMultiLikeOr);
			kparams.AddIfNotNull("textMultiLikeAnd", this._TextMultiLikeAnd);
			kparams.AddIfNotNull("endTimeGreaterThanOrEqual", this._EndTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("endTimeLessThanOrEqual", this._EndTimeLessThanOrEqual);
			kparams.AddIfNotNull("durationGreaterThanOrEqual", this._DurationGreaterThanOrEqual);
			kparams.AddIfNotNull("durationLessThanOrEqual", this._DurationLessThanOrEqual);
			kparams.AddIfNotNull("isPublicEqual", this._IsPublicEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARENT_ID_EQUAL:
					return "ParentIdEqual";
				case PARENT_ID_IN:
					return "ParentIdIn";
				case TEXT_LIKE:
					return "TextLike";
				case TEXT_MULTI_LIKE_OR:
					return "TextMultiLikeOr";
				case TEXT_MULTI_LIKE_AND:
					return "TextMultiLikeAnd";
				case END_TIME_GREATER_THAN_OR_EQUAL:
					return "EndTimeGreaterThanOrEqual";
				case END_TIME_LESS_THAN_OR_EQUAL:
					return "EndTimeLessThanOrEqual";
				case DURATION_GREATER_THAN_OR_EQUAL:
					return "DurationGreaterThanOrEqual";
				case DURATION_LESS_THAN_OR_EQUAL:
					return "DurationLessThanOrEqual";
				case IS_PUBLIC_EQUAL:
					return "IsPublicEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

