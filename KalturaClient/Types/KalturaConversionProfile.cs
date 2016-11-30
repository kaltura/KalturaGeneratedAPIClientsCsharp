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
	public class KalturaConversionProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private KalturaConversionProfileStatus _Status = null;
		private KalturaConversionProfileType _Type = null;
		private string _Name = null;
		private string _SystemName = null;
		private string _Tags = null;
		private string _Description = null;
		private string _DefaultEntryId = null;
		private int _CreatedAt = Int32.MinValue;
		private string _FlavorParamsIds = null;
		private KalturaNullableBoolean _IsDefault = (KalturaNullableBoolean)Int32.MinValue;
		private bool? _IsPartnerDefault = null;
		private KalturaCropDimensions _CropDimensions;
		private int _ClipStart = Int32.MinValue;
		private int _ClipDuration = Int32.MinValue;
		private string _XslTransformation = null;
		private int _StorageProfileId = Int32.MinValue;
		private KalturaMediaParserType _MediaParserType = null;
		private KalturaNullableBoolean _CalculateComplexity = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public KalturaConversionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaConversionProfileType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string DefaultEntryId
		{
			get { return _DefaultEntryId; }
			set 
			{ 
				_DefaultEntryId = value;
				OnPropertyChanged("DefaultEntryId");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
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
		public KalturaNullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public bool? IsPartnerDefault
		{
			get { return _IsPartnerDefault; }
		}
		public KalturaCropDimensions CropDimensions
		{
			get { return _CropDimensions; }
			set 
			{ 
				_CropDimensions = value;
				OnPropertyChanged("CropDimensions");
			}
		}
		public int ClipStart
		{
			get { return _ClipStart; }
			set 
			{ 
				_ClipStart = value;
				OnPropertyChanged("ClipStart");
			}
		}
		public int ClipDuration
		{
			get { return _ClipDuration; }
			set 
			{ 
				_ClipDuration = value;
				OnPropertyChanged("ClipDuration");
			}
		}
		public string XslTransformation
		{
			get { return _XslTransformation; }
			set 
			{ 
				_XslTransformation = value;
				OnPropertyChanged("XslTransformation");
			}
		}
		public int StorageProfileId
		{
			get { return _StorageProfileId; }
			set 
			{ 
				_StorageProfileId = value;
				OnPropertyChanged("StorageProfileId");
			}
		}
		public KalturaMediaParserType MediaParserType
		{
			get { return _MediaParserType; }
			set 
			{ 
				_MediaParserType = value;
				OnPropertyChanged("MediaParserType");
			}
		}
		public KalturaNullableBoolean CalculateComplexity
		{
			get { return _CalculateComplexity; }
			set 
			{ 
				_CalculateComplexity = value;
				OnPropertyChanged("CalculateComplexity");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfile()
		{
		}

		public KalturaConversionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "status":
						this._Status = (KalturaConversionProfileStatus)KalturaStringEnum.Parse(typeof(KalturaConversionProfileStatus), txt);
						continue;
					case "type":
						this._Type = (KalturaConversionProfileType)KalturaStringEnum.Parse(typeof(KalturaConversionProfileType), txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "systemName":
						this._SystemName = txt;
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "defaultEntryId":
						this._DefaultEntryId = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "flavorParamsIds":
						this._FlavorParamsIds = txt;
						continue;
					case "isDefault":
						this._IsDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "isPartnerDefault":
						this._IsPartnerDefault = ParseBool(txt);
						continue;
					case "cropDimensions":
						this._CropDimensions = (KalturaCropDimensions)KalturaObjectFactory.Create(propertyNode, "KalturaCropDimensions");
						continue;
					case "clipStart":
						this._ClipStart = ParseInt(txt);
						continue;
					case "clipDuration":
						this._ClipDuration = ParseInt(txt);
						continue;
					case "xslTransformation":
						this._XslTransformation = txt;
						continue;
					case "storageProfileId":
						this._StorageProfileId = ParseInt(txt);
						continue;
					case "mediaParserType":
						this._MediaParserType = (KalturaMediaParserType)KalturaStringEnum.Parse(typeof(KalturaMediaParserType), txt);
						continue;
					case "calculateComplexity":
						this._CalculateComplexity = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConversionProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("defaultEntryId", this._DefaultEntryId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("flavorParamsIds", this._FlavorParamsIds);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("isPartnerDefault", this._IsPartnerDefault);
			kparams.AddIfNotNull("cropDimensions", this._CropDimensions);
			kparams.AddIfNotNull("clipStart", this._ClipStart);
			kparams.AddIfNotNull("clipDuration", this._ClipDuration);
			kparams.AddIfNotNull("xslTransformation", this._XslTransformation);
			kparams.AddIfNotNull("storageProfileId", this._StorageProfileId);
			kparams.AddIfNotNull("mediaParserType", this._MediaParserType);
			kparams.AddIfNotNull("calculateComplexity", this._CalculateComplexity);
			return kparams;
		}
		#endregion
	}
}

