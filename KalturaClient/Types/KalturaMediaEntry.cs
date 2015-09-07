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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaMediaEntry : KalturaPlayableEntry
	{
		#region Private Fields
		private KalturaMediaType _MediaType = (KalturaMediaType)Int32.MinValue;
		private string _ConversionQuality = null;
		private KalturaSourceType _SourceType = null;
		private KalturaSearchProviderType _SearchProviderType = (KalturaSearchProviderType)Int32.MinValue;
		private string _SearchProviderId = null;
		private string _CreditUserName = null;
		private string _CreditUrl = null;
		private int _MediaDate = Int32.MinValue;
		private string _DataUrl = null;
		private string _FlavorParamsIds = null;
		private KalturaNullableBoolean _IsTrimDisabled = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public KalturaMediaType MediaType
		{
			get { return _MediaType; }
			set 
			{ 
				_MediaType = value;
				OnPropertyChanged("MediaType");
			}
		}
		public string ConversionQuality
		{
			get { return _ConversionQuality; }
			set 
			{ 
				_ConversionQuality = value;
				OnPropertyChanged("ConversionQuality");
			}
		}
		public KalturaSourceType SourceType
		{
			get { return _SourceType; }
			set 
			{ 
				_SourceType = value;
				OnPropertyChanged("SourceType");
			}
		}
		public KalturaSearchProviderType SearchProviderType
		{
			get { return _SearchProviderType; }
			set 
			{ 
				_SearchProviderType = value;
				OnPropertyChanged("SearchProviderType");
			}
		}
		public string SearchProviderId
		{
			get { return _SearchProviderId; }
			set 
			{ 
				_SearchProviderId = value;
				OnPropertyChanged("SearchProviderId");
			}
		}
		public string CreditUserName
		{
			get { return _CreditUserName; }
			set 
			{ 
				_CreditUserName = value;
				OnPropertyChanged("CreditUserName");
			}
		}
		public string CreditUrl
		{
			get { return _CreditUrl; }
			set 
			{ 
				_CreditUrl = value;
				OnPropertyChanged("CreditUrl");
			}
		}
		public int MediaDate
		{
			get { return _MediaDate; }
			set 
			{ 
				_MediaDate = value;
				OnPropertyChanged("MediaDate");
			}
		}
		public string DataUrl
		{
			get { return _DataUrl; }
			set 
			{ 
				_DataUrl = value;
				OnPropertyChanged("DataUrl");
			}
		}
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		public KalturaNullableBoolean IsTrimDisabled
		{
			get { return _IsTrimDisabled; }
			set 
			{ 
				_IsTrimDisabled = value;
				OnPropertyChanged("IsTrimDisabled");
			}
		}
		#endregion

		#region CTor
		public KalturaMediaEntry()
		{
		}

		public KalturaMediaEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "mediaType":
						this.MediaType = (KalturaMediaType)ParseEnum(typeof(KalturaMediaType), txt);
						continue;
					case "conversionQuality":
						this.ConversionQuality = txt;
						continue;
					case "sourceType":
						this.SourceType = (KalturaSourceType)KalturaStringEnum.Parse(typeof(KalturaSourceType), txt);
						continue;
					case "searchProviderType":
						this.SearchProviderType = (KalturaSearchProviderType)ParseEnum(typeof(KalturaSearchProviderType), txt);
						continue;
					case "searchProviderId":
						this.SearchProviderId = txt;
						continue;
					case "creditUserName":
						this.CreditUserName = txt;
						continue;
					case "creditUrl":
						this.CreditUrl = txt;
						continue;
					case "mediaDate":
						this.MediaDate = ParseInt(txt);
						continue;
					case "dataUrl":
						this.DataUrl = txt;
						continue;
					case "flavorParamsIds":
						this.FlavorParamsIds = txt;
						continue;
					case "isTrimDisabled":
						this.IsTrimDisabled = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaMediaEntry");
			kparams.AddIfNotNull("mediaType", this.MediaType);
			kparams.AddIfNotNull("conversionQuality", this.ConversionQuality);
			kparams.AddIfNotNull("sourceType", this.SourceType);
			kparams.AddIfNotNull("searchProviderType", this.SearchProviderType);
			kparams.AddIfNotNull("searchProviderId", this.SearchProviderId);
			kparams.AddIfNotNull("creditUserName", this.CreditUserName);
			kparams.AddIfNotNull("creditUrl", this.CreditUrl);
			kparams.AddIfNotNull("mediaDate", this.MediaDate);
			kparams.AddIfNotNull("dataUrl", this.DataUrl);
			kparams.AddIfNotNull("flavorParamsIds", this.FlavorParamsIds);
			kparams.AddIfNotNull("isTrimDisabled", this.IsTrimDisabled);
			return kparams;
		}
		#endregion
	}
}

