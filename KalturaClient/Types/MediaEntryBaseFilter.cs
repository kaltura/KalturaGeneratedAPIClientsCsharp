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
	public class MediaEntryBaseFilter : PlayableEntryFilter
	{
		#region Constants
		public const string MEDIA_TYPE_EQUAL = "mediaTypeEqual";
		public const string MEDIA_TYPE_IN = "mediaTypeIn";
		public const string SOURCE_TYPE_EQUAL = "sourceTypeEqual";
		public const string SOURCE_TYPE_NOT_EQUAL = "sourceTypeNotEqual";
		public const string SOURCE_TYPE_IN = "sourceTypeIn";
		public const string SOURCE_TYPE_NOT_IN = "sourceTypeNotIn";
		public const string MEDIA_DATE_GREATER_THAN_OR_EQUAL = "mediaDateGreaterThanOrEqual";
		public const string MEDIA_DATE_LESS_THAN_OR_EQUAL = "mediaDateLessThanOrEqual";
		public const string FLAVOR_PARAMS_IDS_MATCH_OR = "flavorParamsIdsMatchOr";
		public const string FLAVOR_PARAMS_IDS_MATCH_AND = "flavorParamsIdsMatchAnd";
		#endregion

		#region Private Fields
		private MediaType _MediaTypeEqual = (MediaType)Int32.MinValue;
		private string _MediaTypeIn = null;
		private SourceType _SourceTypeEqual = null;
		private SourceType _SourceTypeNotEqual = null;
		private string _SourceTypeIn = null;
		private string _SourceTypeNotIn = null;
		private int _MediaDateGreaterThanOrEqual = Int32.MinValue;
		private int _MediaDateLessThanOrEqual = Int32.MinValue;
		private string _FlavorParamsIdsMatchOr = null;
		private string _FlavorParamsIdsMatchAnd = null;
		#endregion

		#region Properties
		public MediaType MediaTypeEqual
		{
			get { return _MediaTypeEqual; }
			set 
			{ 
				_MediaTypeEqual = value;
				OnPropertyChanged("MediaTypeEqual");
			}
		}
		public string MediaTypeIn
		{
			get { return _MediaTypeIn; }
			set 
			{ 
				_MediaTypeIn = value;
				OnPropertyChanged("MediaTypeIn");
			}
		}
		public SourceType SourceTypeEqual
		{
			get { return _SourceTypeEqual; }
			set 
			{ 
				_SourceTypeEqual = value;
				OnPropertyChanged("SourceTypeEqual");
			}
		}
		public SourceType SourceTypeNotEqual
		{
			get { return _SourceTypeNotEqual; }
			set 
			{ 
				_SourceTypeNotEqual = value;
				OnPropertyChanged("SourceTypeNotEqual");
			}
		}
		public string SourceTypeIn
		{
			get { return _SourceTypeIn; }
			set 
			{ 
				_SourceTypeIn = value;
				OnPropertyChanged("SourceTypeIn");
			}
		}
		public string SourceTypeNotIn
		{
			get { return _SourceTypeNotIn; }
			set 
			{ 
				_SourceTypeNotIn = value;
				OnPropertyChanged("SourceTypeNotIn");
			}
		}
		public int MediaDateGreaterThanOrEqual
		{
			get { return _MediaDateGreaterThanOrEqual; }
			set 
			{ 
				_MediaDateGreaterThanOrEqual = value;
				OnPropertyChanged("MediaDateGreaterThanOrEqual");
			}
		}
		public int MediaDateLessThanOrEqual
		{
			get { return _MediaDateLessThanOrEqual; }
			set 
			{ 
				_MediaDateLessThanOrEqual = value;
				OnPropertyChanged("MediaDateLessThanOrEqual");
			}
		}
		public string FlavorParamsIdsMatchOr
		{
			get { return _FlavorParamsIdsMatchOr; }
			set 
			{ 
				_FlavorParamsIdsMatchOr = value;
				OnPropertyChanged("FlavorParamsIdsMatchOr");
			}
		}
		public string FlavorParamsIdsMatchAnd
		{
			get { return _FlavorParamsIdsMatchAnd; }
			set 
			{ 
				_FlavorParamsIdsMatchAnd = value;
				OnPropertyChanged("FlavorParamsIdsMatchAnd");
			}
		}
		#endregion

		#region CTor
		public MediaEntryBaseFilter()
		{
		}

		public MediaEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "mediaTypeEqual":
						this._MediaTypeEqual = (MediaType)ParseEnum(typeof(MediaType), propertyNode.InnerText);
						continue;
					case "mediaTypeIn":
						this._MediaTypeIn = propertyNode.InnerText;
						continue;
					case "sourceTypeEqual":
						this._SourceTypeEqual = (SourceType)StringEnum.Parse(typeof(SourceType), propertyNode.InnerText);
						continue;
					case "sourceTypeNotEqual":
						this._SourceTypeNotEqual = (SourceType)StringEnum.Parse(typeof(SourceType), propertyNode.InnerText);
						continue;
					case "sourceTypeIn":
						this._SourceTypeIn = propertyNode.InnerText;
						continue;
					case "sourceTypeNotIn":
						this._SourceTypeNotIn = propertyNode.InnerText;
						continue;
					case "mediaDateGreaterThanOrEqual":
						this._MediaDateGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "mediaDateLessThanOrEqual":
						this._MediaDateLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "flavorParamsIdsMatchOr":
						this._FlavorParamsIdsMatchOr = propertyNode.InnerText;
						continue;
					case "flavorParamsIdsMatchAnd":
						this._FlavorParamsIdsMatchAnd = propertyNode.InnerText;
						continue;
				}
			}
		}

		public MediaEntryBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._MediaTypeEqual = (MediaType)ParseEnum(typeof(MediaType), data.TryGetValueSafe<int>("mediaTypeEqual"));
			    this._MediaTypeIn = data.TryGetValueSafe<string>("mediaTypeIn");
			    this._SourceTypeEqual = (SourceType)StringEnum.Parse(typeof(SourceType), data.TryGetValueSafe<string>("sourceTypeEqual"));
			    this._SourceTypeNotEqual = (SourceType)StringEnum.Parse(typeof(SourceType), data.TryGetValueSafe<string>("sourceTypeNotEqual"));
			    this._SourceTypeIn = data.TryGetValueSafe<string>("sourceTypeIn");
			    this._SourceTypeNotIn = data.TryGetValueSafe<string>("sourceTypeNotIn");
			    this._MediaDateGreaterThanOrEqual = data.TryGetValueSafe<int>("mediaDateGreaterThanOrEqual");
			    this._MediaDateLessThanOrEqual = data.TryGetValueSafe<int>("mediaDateLessThanOrEqual");
			    this._FlavorParamsIdsMatchOr = data.TryGetValueSafe<string>("flavorParamsIdsMatchOr");
			    this._FlavorParamsIdsMatchAnd = data.TryGetValueSafe<string>("flavorParamsIdsMatchAnd");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaEntryBaseFilter");
			kparams.AddIfNotNull("mediaTypeEqual", this._MediaTypeEqual);
			kparams.AddIfNotNull("mediaTypeIn", this._MediaTypeIn);
			kparams.AddIfNotNull("sourceTypeEqual", this._SourceTypeEqual);
			kparams.AddIfNotNull("sourceTypeNotEqual", this._SourceTypeNotEqual);
			kparams.AddIfNotNull("sourceTypeIn", this._SourceTypeIn);
			kparams.AddIfNotNull("sourceTypeNotIn", this._SourceTypeNotIn);
			kparams.AddIfNotNull("mediaDateGreaterThanOrEqual", this._MediaDateGreaterThanOrEqual);
			kparams.AddIfNotNull("mediaDateLessThanOrEqual", this._MediaDateLessThanOrEqual);
			kparams.AddIfNotNull("flavorParamsIdsMatchOr", this._FlavorParamsIdsMatchOr);
			kparams.AddIfNotNull("flavorParamsIdsMatchAnd", this._FlavorParamsIdsMatchAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MEDIA_TYPE_EQUAL:
					return "MediaTypeEqual";
				case MEDIA_TYPE_IN:
					return "MediaTypeIn";
				case SOURCE_TYPE_EQUAL:
					return "SourceTypeEqual";
				case SOURCE_TYPE_NOT_EQUAL:
					return "SourceTypeNotEqual";
				case SOURCE_TYPE_IN:
					return "SourceTypeIn";
				case SOURCE_TYPE_NOT_IN:
					return "SourceTypeNotIn";
				case MEDIA_DATE_GREATER_THAN_OR_EQUAL:
					return "MediaDateGreaterThanOrEqual";
				case MEDIA_DATE_LESS_THAN_OR_EQUAL:
					return "MediaDateLessThanOrEqual";
				case FLAVOR_PARAMS_IDS_MATCH_OR:
					return "FlavorParamsIdsMatchOr";
				case FLAVOR_PARAMS_IDS_MATCH_AND:
					return "FlavorParamsIdsMatchAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

