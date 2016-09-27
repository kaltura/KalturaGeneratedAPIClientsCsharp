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
// Copyright (C) 2006-2016  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaMediaEntryBaseFilter : KalturaPlayableEntryFilter
	{
		#region Private Fields
		private KalturaMediaType _MediaTypeEqual = (KalturaMediaType)Int32.MinValue;
		private string _MediaTypeIn = null;
		private KalturaSourceType _SourceTypeEqual = null;
		private KalturaSourceType _SourceTypeNotEqual = null;
		private string _SourceTypeIn = null;
		private string _SourceTypeNotIn = null;
		private int _MediaDateGreaterThanOrEqual = Int32.MinValue;
		private int _MediaDateLessThanOrEqual = Int32.MinValue;
		private string _FlavorParamsIdsMatchOr = null;
		private string _FlavorParamsIdsMatchAnd = null;
		#endregion

		#region Properties
		public KalturaMediaType MediaTypeEqual
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
		public KalturaSourceType SourceTypeEqual
		{
			get { return _SourceTypeEqual; }
			set 
			{ 
				_SourceTypeEqual = value;
				OnPropertyChanged("SourceTypeEqual");
			}
		}
		public KalturaSourceType SourceTypeNotEqual
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
		public KalturaMediaEntryBaseFilter()
		{
		}

		public KalturaMediaEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "mediaTypeEqual":
						this._MediaTypeEqual = (KalturaMediaType)ParseEnum(typeof(KalturaMediaType), txt);
						continue;
					case "mediaTypeIn":
						this._MediaTypeIn = txt;
						continue;
					case "sourceTypeEqual":
						this._SourceTypeEqual = (KalturaSourceType)KalturaStringEnum.Parse(typeof(KalturaSourceType), txt);
						continue;
					case "sourceTypeNotEqual":
						this._SourceTypeNotEqual = (KalturaSourceType)KalturaStringEnum.Parse(typeof(KalturaSourceType), txt);
						continue;
					case "sourceTypeIn":
						this._SourceTypeIn = txt;
						continue;
					case "sourceTypeNotIn":
						this._SourceTypeNotIn = txt;
						continue;
					case "mediaDateGreaterThanOrEqual":
						this._MediaDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "mediaDateLessThanOrEqual":
						this._MediaDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "flavorParamsIdsMatchOr":
						this._FlavorParamsIdsMatchOr = txt;
						continue;
					case "flavorParamsIdsMatchAnd":
						this._FlavorParamsIdsMatchAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

