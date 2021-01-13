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
		[JsonProperty]
		public MediaType MediaTypeEqual
		{
			get { return _MediaTypeEqual; }
			set 
			{ 
				_MediaTypeEqual = value;
				OnPropertyChanged("MediaTypeEqual");
			}
		}
		[JsonProperty]
		public string MediaTypeIn
		{
			get { return _MediaTypeIn; }
			set 
			{ 
				_MediaTypeIn = value;
				OnPropertyChanged("MediaTypeIn");
			}
		}
		[JsonProperty]
		public SourceType SourceTypeEqual
		{
			get { return _SourceTypeEqual; }
			set 
			{ 
				_SourceTypeEqual = value;
				OnPropertyChanged("SourceTypeEqual");
			}
		}
		[JsonProperty]
		public SourceType SourceTypeNotEqual
		{
			get { return _SourceTypeNotEqual; }
			set 
			{ 
				_SourceTypeNotEqual = value;
				OnPropertyChanged("SourceTypeNotEqual");
			}
		}
		[JsonProperty]
		public string SourceTypeIn
		{
			get { return _SourceTypeIn; }
			set 
			{ 
				_SourceTypeIn = value;
				OnPropertyChanged("SourceTypeIn");
			}
		}
		[JsonProperty]
		public string SourceTypeNotIn
		{
			get { return _SourceTypeNotIn; }
			set 
			{ 
				_SourceTypeNotIn = value;
				OnPropertyChanged("SourceTypeNotIn");
			}
		}
		[JsonProperty]
		public int MediaDateGreaterThanOrEqual
		{
			get { return _MediaDateGreaterThanOrEqual; }
			set 
			{ 
				_MediaDateGreaterThanOrEqual = value;
				OnPropertyChanged("MediaDateGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int MediaDateLessThanOrEqual
		{
			get { return _MediaDateLessThanOrEqual; }
			set 
			{ 
				_MediaDateLessThanOrEqual = value;
				OnPropertyChanged("MediaDateLessThanOrEqual");
			}
		}
		[JsonProperty]
		public string FlavorParamsIdsMatchOr
		{
			get { return _FlavorParamsIdsMatchOr; }
			set 
			{ 
				_FlavorParamsIdsMatchOr = value;
				OnPropertyChanged("FlavorParamsIdsMatchOr");
			}
		}
		[JsonProperty]
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

		public MediaEntryBaseFilter(JToken node) : base(node)
		{
			if(node["mediaTypeEqual"] != null)
			{
				this._MediaTypeEqual = (MediaType)ParseEnum(typeof(MediaType), node["mediaTypeEqual"].Value<string>());
			}
			if(node["mediaTypeIn"] != null)
			{
				this._MediaTypeIn = node["mediaTypeIn"].Value<string>();
			}
			if(node["sourceTypeEqual"] != null)
			{
				this._SourceTypeEqual = (SourceType)StringEnum.Parse(typeof(SourceType), node["sourceTypeEqual"].Value<string>());
			}
			if(node["sourceTypeNotEqual"] != null)
			{
				this._SourceTypeNotEqual = (SourceType)StringEnum.Parse(typeof(SourceType), node["sourceTypeNotEqual"].Value<string>());
			}
			if(node["sourceTypeIn"] != null)
			{
				this._SourceTypeIn = node["sourceTypeIn"].Value<string>();
			}
			if(node["sourceTypeNotIn"] != null)
			{
				this._SourceTypeNotIn = node["sourceTypeNotIn"].Value<string>();
			}
			if(node["mediaDateGreaterThanOrEqual"] != null)
			{
				this._MediaDateGreaterThanOrEqual = ParseInt(node["mediaDateGreaterThanOrEqual"].Value<string>());
			}
			if(node["mediaDateLessThanOrEqual"] != null)
			{
				this._MediaDateLessThanOrEqual = ParseInt(node["mediaDateLessThanOrEqual"].Value<string>());
			}
			if(node["flavorParamsIdsMatchOr"] != null)
			{
				this._FlavorParamsIdsMatchOr = node["flavorParamsIdsMatchOr"].Value<string>();
			}
			if(node["flavorParamsIdsMatchAnd"] != null)
			{
				this._FlavorParamsIdsMatchAnd = node["flavorParamsIdsMatchAnd"].Value<string>();
			}
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

