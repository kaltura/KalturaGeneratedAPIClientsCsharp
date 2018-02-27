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
	public class CaptionAssetItemFilter : CaptionAssetFilter
	{
		#region Constants
		public const string CONTENT_LIKE = "contentLike";
		public const string CONTENT_MULTI_LIKE_OR = "contentMultiLikeOr";
		public const string CONTENT_MULTI_LIKE_AND = "contentMultiLikeAnd";
		public const string PARTNER_DESCRIPTION_LIKE = "partnerDescriptionLike";
		public const string PARTNER_DESCRIPTION_MULTI_LIKE_OR = "partnerDescriptionMultiLikeOr";
		public const string PARTNER_DESCRIPTION_MULTI_LIKE_AND = "partnerDescriptionMultiLikeAnd";
		public const string LANGUAGE_EQUAL = "languageEqual";
		public const string LANGUAGE_IN = "languageIn";
		public const string LABEL_EQUAL = "labelEqual";
		public const string LABEL_IN = "labelIn";
		public const string START_TIME_GREATER_THAN_OR_EQUAL = "startTimeGreaterThanOrEqual";
		public const string START_TIME_LESS_THAN_OR_EQUAL = "startTimeLessThanOrEqual";
		public const string END_TIME_GREATER_THAN_OR_EQUAL = "endTimeGreaterThanOrEqual";
		public const string END_TIME_LESS_THAN_OR_EQUAL = "endTimeLessThanOrEqual";
		#endregion

		#region Private Fields
		private string _ContentLike = null;
		private string _ContentMultiLikeOr = null;
		private string _ContentMultiLikeAnd = null;
		private string _PartnerDescriptionLike = null;
		private string _PartnerDescriptionMultiLikeOr = null;
		private string _PartnerDescriptionMultiLikeAnd = null;
		private Language _LanguageEqual = null;
		private string _LanguageIn = null;
		private string _LabelEqual = null;
		private string _LabelIn = null;
		private int _StartTimeGreaterThanOrEqual = Int32.MinValue;
		private int _StartTimeLessThanOrEqual = Int32.MinValue;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public string ContentLike
		{
			get { return _ContentLike; }
			set 
			{ 
				_ContentLike = value;
				OnPropertyChanged("ContentLike");
			}
		}
		public string ContentMultiLikeOr
		{
			get { return _ContentMultiLikeOr; }
			set 
			{ 
				_ContentMultiLikeOr = value;
				OnPropertyChanged("ContentMultiLikeOr");
			}
		}
		public string ContentMultiLikeAnd
		{
			get { return _ContentMultiLikeAnd; }
			set 
			{ 
				_ContentMultiLikeAnd = value;
				OnPropertyChanged("ContentMultiLikeAnd");
			}
		}
		public string PartnerDescriptionLike
		{
			get { return _PartnerDescriptionLike; }
			set 
			{ 
				_PartnerDescriptionLike = value;
				OnPropertyChanged("PartnerDescriptionLike");
			}
		}
		public string PartnerDescriptionMultiLikeOr
		{
			get { return _PartnerDescriptionMultiLikeOr; }
			set 
			{ 
				_PartnerDescriptionMultiLikeOr = value;
				OnPropertyChanged("PartnerDescriptionMultiLikeOr");
			}
		}
		public string PartnerDescriptionMultiLikeAnd
		{
			get { return _PartnerDescriptionMultiLikeAnd; }
			set 
			{ 
				_PartnerDescriptionMultiLikeAnd = value;
				OnPropertyChanged("PartnerDescriptionMultiLikeAnd");
			}
		}
		public Language LanguageEqual
		{
			get { return _LanguageEqual; }
			set 
			{ 
				_LanguageEqual = value;
				OnPropertyChanged("LanguageEqual");
			}
		}
		public string LanguageIn
		{
			get { return _LanguageIn; }
			set 
			{ 
				_LanguageIn = value;
				OnPropertyChanged("LanguageIn");
			}
		}
		public string LabelEqual
		{
			get { return _LabelEqual; }
			set 
			{ 
				_LabelEqual = value;
				OnPropertyChanged("LabelEqual");
			}
		}
		public string LabelIn
		{
			get { return _LabelIn; }
			set 
			{ 
				_LabelIn = value;
				OnPropertyChanged("LabelIn");
			}
		}
		public int StartTimeGreaterThanOrEqual
		{
			get { return _StartTimeGreaterThanOrEqual; }
			set 
			{ 
				_StartTimeGreaterThanOrEqual = value;
				OnPropertyChanged("StartTimeGreaterThanOrEqual");
			}
		}
		public int StartTimeLessThanOrEqual
		{
			get { return _StartTimeLessThanOrEqual; }
			set 
			{ 
				_StartTimeLessThanOrEqual = value;
				OnPropertyChanged("StartTimeLessThanOrEqual");
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
		#endregion

		#region CTor
		public CaptionAssetItemFilter()
		{
		}

		public CaptionAssetItemFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "contentLike":
						this._ContentLike = propertyNode.InnerText;
						continue;
					case "contentMultiLikeOr":
						this._ContentMultiLikeOr = propertyNode.InnerText;
						continue;
					case "contentMultiLikeAnd":
						this._ContentMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "partnerDescriptionLike":
						this._PartnerDescriptionLike = propertyNode.InnerText;
						continue;
					case "partnerDescriptionMultiLikeOr":
						this._PartnerDescriptionMultiLikeOr = propertyNode.InnerText;
						continue;
					case "partnerDescriptionMultiLikeAnd":
						this._PartnerDescriptionMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "languageEqual":
						this._LanguageEqual = (Language)StringEnum.Parse(typeof(Language), propertyNode.InnerText);
						continue;
					case "languageIn":
						this._LanguageIn = propertyNode.InnerText;
						continue;
					case "labelEqual":
						this._LabelEqual = propertyNode.InnerText;
						continue;
					case "labelIn":
						this._LabelIn = propertyNode.InnerText;
						continue;
					case "startTimeGreaterThanOrEqual":
						this._StartTimeGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "startTimeLessThanOrEqual":
						this._StartTimeLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "endTimeGreaterThanOrEqual":
						this._EndTimeGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "endTimeLessThanOrEqual":
						this._EndTimeLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptionAssetItemFilter");
			kparams.AddIfNotNull("contentLike", this._ContentLike);
			kparams.AddIfNotNull("contentMultiLikeOr", this._ContentMultiLikeOr);
			kparams.AddIfNotNull("contentMultiLikeAnd", this._ContentMultiLikeAnd);
			kparams.AddIfNotNull("partnerDescriptionLike", this._PartnerDescriptionLike);
			kparams.AddIfNotNull("partnerDescriptionMultiLikeOr", this._PartnerDescriptionMultiLikeOr);
			kparams.AddIfNotNull("partnerDescriptionMultiLikeAnd", this._PartnerDescriptionMultiLikeAnd);
			kparams.AddIfNotNull("languageEqual", this._LanguageEqual);
			kparams.AddIfNotNull("languageIn", this._LanguageIn);
			kparams.AddIfNotNull("labelEqual", this._LabelEqual);
			kparams.AddIfNotNull("labelIn", this._LabelIn);
			kparams.AddIfNotNull("startTimeGreaterThanOrEqual", this._StartTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("startTimeLessThanOrEqual", this._StartTimeLessThanOrEqual);
			kparams.AddIfNotNull("endTimeGreaterThanOrEqual", this._EndTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("endTimeLessThanOrEqual", this._EndTimeLessThanOrEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONTENT_LIKE:
					return "ContentLike";
				case CONTENT_MULTI_LIKE_OR:
					return "ContentMultiLikeOr";
				case CONTENT_MULTI_LIKE_AND:
					return "ContentMultiLikeAnd";
				case PARTNER_DESCRIPTION_LIKE:
					return "PartnerDescriptionLike";
				case PARTNER_DESCRIPTION_MULTI_LIKE_OR:
					return "PartnerDescriptionMultiLikeOr";
				case PARTNER_DESCRIPTION_MULTI_LIKE_AND:
					return "PartnerDescriptionMultiLikeAnd";
				case LANGUAGE_EQUAL:
					return "LanguageEqual";
				case LANGUAGE_IN:
					return "LanguageIn";
				case LABEL_EQUAL:
					return "LabelEqual";
				case LABEL_IN:
					return "LabelIn";
				case START_TIME_GREATER_THAN_OR_EQUAL:
					return "StartTimeGreaterThanOrEqual";
				case START_TIME_LESS_THAN_OR_EQUAL:
					return "StartTimeLessThanOrEqual";
				case END_TIME_GREATER_THAN_OR_EQUAL:
					return "EndTimeGreaterThanOrEqual";
				case END_TIME_LESS_THAN_OR_EQUAL:
					return "EndTimeLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

