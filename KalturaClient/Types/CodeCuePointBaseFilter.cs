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
		public string CodeLike
		{
			get { return _CodeLike; }
			set 
			{ 
				_CodeLike = value;
				OnPropertyChanged("CodeLike");
			}
		}
		public string CodeMultiLikeOr
		{
			get { return _CodeMultiLikeOr; }
			set 
			{ 
				_CodeMultiLikeOr = value;
				OnPropertyChanged("CodeMultiLikeOr");
			}
		}
		public string CodeMultiLikeAnd
		{
			get { return _CodeMultiLikeAnd; }
			set 
			{ 
				_CodeMultiLikeAnd = value;
				OnPropertyChanged("CodeMultiLikeAnd");
			}
		}
		public string CodeEqual
		{
			get { return _CodeEqual; }
			set 
			{ 
				_CodeEqual = value;
				OnPropertyChanged("CodeEqual");
			}
		}
		public string CodeIn
		{
			get { return _CodeIn; }
			set 
			{ 
				_CodeIn = value;
				OnPropertyChanged("CodeIn");
			}
		}
		public string DescriptionLike
		{
			get { return _DescriptionLike; }
			set 
			{ 
				_DescriptionLike = value;
				OnPropertyChanged("DescriptionLike");
			}
		}
		public string DescriptionMultiLikeOr
		{
			get { return _DescriptionMultiLikeOr; }
			set 
			{ 
				_DescriptionMultiLikeOr = value;
				OnPropertyChanged("DescriptionMultiLikeOr");
			}
		}
		public string DescriptionMultiLikeAnd
		{
			get { return _DescriptionMultiLikeAnd; }
			set 
			{ 
				_DescriptionMultiLikeAnd = value;
				OnPropertyChanged("DescriptionMultiLikeAnd");
			}
		}
		public int EndTimeGreaterThanOrEqual
		{
			get { return _EndTimeGreaterThanOrEqual; }
			set 
			{ 
				_EndTimeGreaterThanOrEqual = value;
				OnPropertyChanged("EndTimeGreaterThanOrEqual");
			}
		}
		public int EndTimeLessThanOrEqual
		{
			get { return _EndTimeLessThanOrEqual; }
			set 
			{ 
				_EndTimeLessThanOrEqual = value;
				OnPropertyChanged("EndTimeLessThanOrEqual");
			}
		}
		public int DurationGreaterThanOrEqual
		{
			get { return _DurationGreaterThanOrEqual; }
			set 
			{ 
				_DurationGreaterThanOrEqual = value;
				OnPropertyChanged("DurationGreaterThanOrEqual");
			}
		}
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

		public CodeCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "codeLike":
						this._CodeLike = propertyNode.InnerText;
						continue;
					case "codeMultiLikeOr":
						this._CodeMultiLikeOr = propertyNode.InnerText;
						continue;
					case "codeMultiLikeAnd":
						this._CodeMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "codeEqual":
						this._CodeEqual = propertyNode.InnerText;
						continue;
					case "codeIn":
						this._CodeIn = propertyNode.InnerText;
						continue;
					case "descriptionLike":
						this._DescriptionLike = propertyNode.InnerText;
						continue;
					case "descriptionMultiLikeOr":
						this._DescriptionMultiLikeOr = propertyNode.InnerText;
						continue;
					case "descriptionMultiLikeAnd":
						this._DescriptionMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "endTimeGreaterThanOrEqual":
						this._EndTimeGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "endTimeLessThanOrEqual":
						this._EndTimeLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "durationGreaterThanOrEqual":
						this._DurationGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "durationLessThanOrEqual":
						this._DurationLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public CodeCuePointBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._CodeLike = data.TryGetValueSafe<string>("codeLike");
			    this._CodeMultiLikeOr = data.TryGetValueSafe<string>("codeMultiLikeOr");
			    this._CodeMultiLikeAnd = data.TryGetValueSafe<string>("codeMultiLikeAnd");
			    this._CodeEqual = data.TryGetValueSafe<string>("codeEqual");
			    this._CodeIn = data.TryGetValueSafe<string>("codeIn");
			    this._DescriptionLike = data.TryGetValueSafe<string>("descriptionLike");
			    this._DescriptionMultiLikeOr = data.TryGetValueSafe<string>("descriptionMultiLikeOr");
			    this._DescriptionMultiLikeAnd = data.TryGetValueSafe<string>("descriptionMultiLikeAnd");
			    this._EndTimeGreaterThanOrEqual = data.TryGetValueSafe<int>("endTimeGreaterThanOrEqual");
			    this._EndTimeLessThanOrEqual = data.TryGetValueSafe<int>("endTimeLessThanOrEqual");
			    this._DurationGreaterThanOrEqual = data.TryGetValueSafe<int>("durationGreaterThanOrEqual");
			    this._DurationLessThanOrEqual = data.TryGetValueSafe<int>("durationLessThanOrEqual");
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

