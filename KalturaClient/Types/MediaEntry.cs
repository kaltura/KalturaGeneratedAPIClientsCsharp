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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class MediaEntry : PlayableEntry
	{
		#region Constants
		public const string MEDIA_TYPE = "mediaType";
		public const string CONVERSION_QUALITY = "conversionQuality";
		public const string SOURCE_TYPE = "sourceType";
		public const string SEARCH_PROVIDER_TYPE = "searchProviderType";
		public const string SEARCH_PROVIDER_ID = "searchProviderId";
		public const string CREDIT_USER_NAME = "creditUserName";
		public const string CREDIT_URL = "creditUrl";
		public const string MEDIA_DATE = "mediaDate";
		public const string DATA_URL = "dataUrl";
		public const string FLAVOR_PARAMS_IDS = "flavorParamsIds";
		public const string IS_TRIM_DISABLED = "isTrimDisabled";
		public const string STREAMS = "streams";
		#endregion

		#region Private Fields
		private MediaType _MediaType = (MediaType)Int32.MinValue;
		private string _ConversionQuality = null;
		private SourceType _SourceType = null;
		private SearchProviderType _SearchProviderType = (SearchProviderType)Int32.MinValue;
		private string _SearchProviderId = null;
		private string _CreditUserName = null;
		private string _CreditUrl = null;
		private int _MediaDate = Int32.MinValue;
		private string _DataUrl = null;
		private string _FlavorParamsIds = null;
		private NullableBoolean _IsTrimDisabled = (NullableBoolean)Int32.MinValue;
		private IList<StreamContainer> _Streams;
		#endregion

		#region Properties
		public MediaType MediaType
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
		public SourceType SourceType
		{
			get { return _SourceType; }
			set 
			{ 
				_SourceType = value;
				OnPropertyChanged("SourceType");
			}
		}
		public SearchProviderType SearchProviderType
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
		}
		public string DataUrl
		{
			get { return _DataUrl; }
		}
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
		}
		public NullableBoolean IsTrimDisabled
		{
			get { return _IsTrimDisabled; }
		}
		public IList<StreamContainer> Streams
		{
			get { return _Streams; }
			set 
			{ 
				_Streams = value;
				OnPropertyChanged("Streams");
			}
		}
		#endregion

		#region CTor
		public MediaEntry()
		{
		}

		public MediaEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "mediaType":
						this._MediaType = (MediaType)ParseEnum(typeof(MediaType), txt);
						continue;
					case "conversionQuality":
						this._ConversionQuality = txt;
						continue;
					case "sourceType":
						this._SourceType = (SourceType)StringEnum.Parse(typeof(SourceType), txt);
						continue;
					case "searchProviderType":
						this._SearchProviderType = (SearchProviderType)ParseEnum(typeof(SearchProviderType), txt);
						continue;
					case "searchProviderId":
						this._SearchProviderId = txt;
						continue;
					case "creditUserName":
						this._CreditUserName = txt;
						continue;
					case "creditUrl":
						this._CreditUrl = txt;
						continue;
					case "mediaDate":
						this._MediaDate = ParseInt(txt);
						continue;
					case "dataUrl":
						this._DataUrl = txt;
						continue;
					case "flavorParamsIds":
						this._FlavorParamsIds = txt;
						continue;
					case "isTrimDisabled":
						this._IsTrimDisabled = (NullableBoolean)ParseEnum(typeof(NullableBoolean), txt);
						continue;
					case "streams":
						this._Streams = new List<StreamContainer>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Streams.Add(ObjectFactory.Create<StreamContainer>(arrayNode));
						}
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
				kparams.AddReplace("objectType", "KalturaMediaEntry");
			kparams.AddIfNotNull("mediaType", this._MediaType);
			kparams.AddIfNotNull("conversionQuality", this._ConversionQuality);
			kparams.AddIfNotNull("sourceType", this._SourceType);
			kparams.AddIfNotNull("searchProviderType", this._SearchProviderType);
			kparams.AddIfNotNull("searchProviderId", this._SearchProviderId);
			kparams.AddIfNotNull("creditUserName", this._CreditUserName);
			kparams.AddIfNotNull("creditUrl", this._CreditUrl);
			kparams.AddIfNotNull("mediaDate", this._MediaDate);
			kparams.AddIfNotNull("dataUrl", this._DataUrl);
			kparams.AddIfNotNull("flavorParamsIds", this._FlavorParamsIds);
			kparams.AddIfNotNull("isTrimDisabled", this._IsTrimDisabled);
			kparams.AddIfNotNull("streams", this._Streams);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MEDIA_TYPE:
					return "MediaType";
				case CONVERSION_QUALITY:
					return "ConversionQuality";
				case SOURCE_TYPE:
					return "SourceType";
				case SEARCH_PROVIDER_TYPE:
					return "SearchProviderType";
				case SEARCH_PROVIDER_ID:
					return "SearchProviderId";
				case CREDIT_USER_NAME:
					return "CreditUserName";
				case CREDIT_URL:
					return "CreditUrl";
				case MEDIA_DATE:
					return "MediaDate";
				case DATA_URL:
					return "DataUrl";
				case FLAVOR_PARAMS_IDS:
					return "FlavorParamsIds";
				case IS_TRIM_DISABLED:
					return "IsTrimDisabled";
				case STREAMS:
					return "Streams";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

