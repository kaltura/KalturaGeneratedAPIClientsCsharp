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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class ThumbCuePointBaseFilter : CuePointFilter
	{
		#region Constants
		public const string DESCRIPTION_LIKE = "descriptionLike";
		public const string DESCRIPTION_MULTI_LIKE_OR = "descriptionMultiLikeOr";
		public const string DESCRIPTION_MULTI_LIKE_AND = "descriptionMultiLikeAnd";
		public const string TITLE_LIKE = "titleLike";
		public const string TITLE_MULTI_LIKE_OR = "titleMultiLikeOr";
		public const string TITLE_MULTI_LIKE_AND = "titleMultiLikeAnd";
		public const string SUB_TYPE_EQUAL = "subTypeEqual";
		public const string SUB_TYPE_IN = "subTypeIn";
		#endregion

		#region Private Fields
		private string _DescriptionLike = null;
		private string _DescriptionMultiLikeOr = null;
		private string _DescriptionMultiLikeAnd = null;
		private string _TitleLike = null;
		private string _TitleMultiLikeOr = null;
		private string _TitleMultiLikeAnd = null;
		private ThumbCuePointSubType _SubTypeEqual = (ThumbCuePointSubType)Int32.MinValue;
		private string _SubTypeIn = null;
		#endregion

		#region Properties
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
		public string TitleLike
		{
			get { return _TitleLike; }
			set 
			{ 
				_TitleLike = value;
				OnPropertyChanged("TitleLike");
			}
		}
		public string TitleMultiLikeOr
		{
			get { return _TitleMultiLikeOr; }
			set 
			{ 
				_TitleMultiLikeOr = value;
				OnPropertyChanged("TitleMultiLikeOr");
			}
		}
		public string TitleMultiLikeAnd
		{
			get { return _TitleMultiLikeAnd; }
			set 
			{ 
				_TitleMultiLikeAnd = value;
				OnPropertyChanged("TitleMultiLikeAnd");
			}
		}
		public ThumbCuePointSubType SubTypeEqual
		{
			get { return _SubTypeEqual; }
			set 
			{ 
				_SubTypeEqual = value;
				OnPropertyChanged("SubTypeEqual");
			}
		}
		public string SubTypeIn
		{
			get { return _SubTypeIn; }
			set 
			{ 
				_SubTypeIn = value;
				OnPropertyChanged("SubTypeIn");
			}
		}
		#endregion

		#region CTor
		public ThumbCuePointBaseFilter()
		{
		}

		public ThumbCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "descriptionLike":
						this._DescriptionLike = propertyNode.InnerText;
						continue;
					case "descriptionMultiLikeOr":
						this._DescriptionMultiLikeOr = propertyNode.InnerText;
						continue;
					case "descriptionMultiLikeAnd":
						this._DescriptionMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "titleLike":
						this._TitleLike = propertyNode.InnerText;
						continue;
					case "titleMultiLikeOr":
						this._TitleMultiLikeOr = propertyNode.InnerText;
						continue;
					case "titleMultiLikeAnd":
						this._TitleMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "subTypeEqual":
						this._SubTypeEqual = (ThumbCuePointSubType)ParseEnum(typeof(ThumbCuePointSubType), propertyNode.InnerText);
						continue;
					case "subTypeIn":
						this._SubTypeIn = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaThumbCuePointBaseFilter");
			kparams.AddIfNotNull("descriptionLike", this._DescriptionLike);
			kparams.AddIfNotNull("descriptionMultiLikeOr", this._DescriptionMultiLikeOr);
			kparams.AddIfNotNull("descriptionMultiLikeAnd", this._DescriptionMultiLikeAnd);
			kparams.AddIfNotNull("titleLike", this._TitleLike);
			kparams.AddIfNotNull("titleMultiLikeOr", this._TitleMultiLikeOr);
			kparams.AddIfNotNull("titleMultiLikeAnd", this._TitleMultiLikeAnd);
			kparams.AddIfNotNull("subTypeEqual", this._SubTypeEqual);
			kparams.AddIfNotNull("subTypeIn", this._SubTypeIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DESCRIPTION_LIKE:
					return "DescriptionLike";
				case DESCRIPTION_MULTI_LIKE_OR:
					return "DescriptionMultiLikeOr";
				case DESCRIPTION_MULTI_LIKE_AND:
					return "DescriptionMultiLikeAnd";
				case TITLE_LIKE:
					return "TitleLike";
				case TITLE_MULTI_LIKE_OR:
					return "TitleMultiLikeOr";
				case TITLE_MULTI_LIKE_AND:
					return "TitleMultiLikeAnd";
				case SUB_TYPE_EQUAL:
					return "SubTypeEqual";
				case SUB_TYPE_IN:
					return "SubTypeIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

