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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class CodeCuePointBaseFilter : CuePointFilter
	{
		#region Constants
		public const string CODE_LIKE = "codeLike";
		public const string CODE_MULTI_LIKE_OR = "codeMultiLikeOr";
		public const string CODE_MULTI_LIKE_AND = "codeMultiLikeAnd";
		public const string CODE_EQUAL = "codeEqual";
		public const string CODE_IN = "codeIn";
		public const string DESCRIPTION_LIKE = "descriptionLike";
		public const string DESCRIPTION_MULTI_LIKE_OR = "descriptionMultiLikeOr";
		public const string DESCRIPTION_MULTI_LIKE_AND = "descriptionMultiLikeAnd";
		public const string END_TIME_GREATER_THAN_OR_EQUAL = "endTimeGreaterThanOrEqual";
		public const string END_TIME_LESS_THAN_OR_EQUAL = "endTimeLessThanOrEqual";
		public const string DURATION_GREATER_THAN_OR_EQUAL = "durationGreaterThanOrEqual";
		public const string DURATION_LESS_THAN_OR_EQUAL = "durationLessThanOrEqual";
		#endregion

		#region Private Fields
		private string _CodeLike = null;
		private string _CodeMultiLikeOr = null;
		private string _CodeMultiLikeAnd = null;
		private string _CodeEqual = null;
		private string _CodeIn = null;
		private string _DescriptionLike = null;
		private string _DescriptionMultiLikeOr = null;
		private string _DescriptionMultiLikeAnd = null;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string CodeLike
		{
			get { return _CodeLike; }
			set 
			{ 
				_CodeLike = value;
				OnPropertyChanged("CodeLike");
			}
		}
		[JsonProperty]
		public string CodeMultiLikeOr
		{
			get { return _CodeMultiLikeOr; }
			set 
			{ 
				_CodeMultiLikeOr = value;
				OnPropertyChanged("CodeMultiLikeOr");
			}
		}
		[JsonProperty]
		public string CodeMultiLikeAnd
		{
			get { return _CodeMultiLikeAnd; }
			set 
			{ 
				_CodeMultiLikeAnd = value;
				OnPropertyChanged("CodeMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string CodeEqual
		{
			get { return _CodeEqual; }
			set 
			{ 
				_CodeEqual = value;
				OnPropertyChanged("CodeEqual");
			}
		}
		[JsonProperty]
		public string CodeIn
		{
			get { return _CodeIn; }
			set 
			{ 
				_CodeIn = value;
				OnPropertyChanged("CodeIn");
			}
		}
		[JsonProperty]
		public string DescriptionLike
		{
			get { return _DescriptionLike; }
			set 
			{ 
				_DescriptionLike = value;
				OnPropertyChanged("DescriptionLike");
			}
		}
		[JsonProperty]
		public string DescriptionMultiLikeOr
		{
			get { return _DescriptionMultiLikeOr; }
			set 
			{ 
				_DescriptionMultiLikeOr = value;
				OnPropertyChanged("DescriptionMultiLikeOr");
			}
		}
		[JsonProperty]
		public string DescriptionMultiLikeAnd
		{
			get { return _DescriptionMultiLikeAnd; }
			set 
			{ 
				_DescriptionMultiLikeAnd = value;
				OnPropertyChanged("DescriptionMultiLikeAnd");
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
		public CodeCuePointBaseFilter()
		{
		}

		public CodeCuePointBaseFilter(JToken node) : base(node)
		{
			if(node["codeLike"] != null)
			{
				this._CodeLike = node["codeLike"].Value<string>();
			}
			if(node["codeMultiLikeOr"] != null)
			{
				this._CodeMultiLikeOr = node["codeMultiLikeOr"].Value<string>();
			}
			if(node["codeMultiLikeAnd"] != null)
			{
				this._CodeMultiLikeAnd = node["codeMultiLikeAnd"].Value<string>();
			}
			if(node["codeEqual"] != null)
			{
				this._CodeEqual = node["codeEqual"].Value<string>();
			}
			if(node["codeIn"] != null)
			{
				this._CodeIn = node["codeIn"].Value<string>();
			}
			if(node["descriptionLike"] != null)
			{
				this._DescriptionLike = node["descriptionLike"].Value<string>();
			}
			if(node["descriptionMultiLikeOr"] != null)
			{
				this._DescriptionMultiLikeOr = node["descriptionMultiLikeOr"].Value<string>();
			}
			if(node["descriptionMultiLikeAnd"] != null)
			{
				this._DescriptionMultiLikeAnd = node["descriptionMultiLikeAnd"].Value<string>();
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
				kparams.AddReplace("objectType", "KalturaCodeCuePointBaseFilter");
			kparams.AddIfNotNull("codeLike", this._CodeLike);
			kparams.AddIfNotNull("codeMultiLikeOr", this._CodeMultiLikeOr);
			kparams.AddIfNotNull("codeMultiLikeAnd", this._CodeMultiLikeAnd);
			kparams.AddIfNotNull("codeEqual", this._CodeEqual);
			kparams.AddIfNotNull("codeIn", this._CodeIn);
			kparams.AddIfNotNull("descriptionLike", this._DescriptionLike);
			kparams.AddIfNotNull("descriptionMultiLikeOr", this._DescriptionMultiLikeOr);
			kparams.AddIfNotNull("descriptionMultiLikeAnd", this._DescriptionMultiLikeAnd);
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
				case CODE_LIKE:
					return "CodeLike";
				case CODE_MULTI_LIKE_OR:
					return "CodeMultiLikeOr";
				case CODE_MULTI_LIKE_AND:
					return "CodeMultiLikeAnd";
				case CODE_EQUAL:
					return "CodeEqual";
				case CODE_IN:
					return "CodeIn";
				case DESCRIPTION_LIKE:
					return "DescriptionLike";
				case DESCRIPTION_MULTI_LIKE_OR:
					return "DescriptionMultiLikeOr";
				case DESCRIPTION_MULTI_LIKE_AND:
					return "DescriptionMultiLikeAnd";
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

