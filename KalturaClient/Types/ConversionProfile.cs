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
	public class ConversionProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string STATUS = "status";
		public const string TYPE = "type";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string TAGS = "tags";
		public const string DESCRIPTION = "description";
		public const string DEFAULT_ENTRY_ID = "defaultEntryId";
		public const string CREATED_AT = "createdAt";
		public const string FLAVOR_PARAMS_IDS = "flavorParamsIds";
		public const string IS_DEFAULT = "isDefault";
		public const string IS_PARTNER_DEFAULT = "isPartnerDefault";
		public const string CROP_DIMENSIONS = "cropDimensions";
		public const string CLIP_START = "clipStart";
		public const string CLIP_DURATION = "clipDuration";
		public const string XSL_TRANSFORMATION = "xslTransformation";
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		public const string MEDIA_PARSER_TYPE = "mediaParserType";
		public const string CALCULATE_COMPLEXITY = "calculateComplexity";
		public const string COLLECTION_TAGS = "collectionTags";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private ConversionProfileStatus _Status = null;
		private ConversionProfileType _Type = null;
		private string _Name = null;
		private string _SystemName = null;
		private string _Tags = null;
		private string _Description = null;
		private string _DefaultEntryId = null;
		private int _CreatedAt = Int32.MinValue;
		private string _FlavorParamsIds = null;
		private NullableBoolean _IsDefault = (NullableBoolean)Int32.MinValue;
		private bool? _IsPartnerDefault = null;
		private CropDimensions _CropDimensions;
		private int _ClipStart = Int32.MinValue;
		private int _ClipDuration = Int32.MinValue;
		private string _XslTransformation = null;
		private int _StorageProfileId = Int32.MinValue;
		private MediaParserType _MediaParserType = null;
		private NullableBoolean _CalculateComplexity = (NullableBoolean)Int32.MinValue;
		private string _CollectionTags = null;
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
		public ConversionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public ConversionProfileType Type
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
		public NullableBoolean IsDefault
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
		public CropDimensions CropDimensions
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
		public MediaParserType MediaParserType
		{
			get { return _MediaParserType; }
			set 
			{ 
				_MediaParserType = value;
				OnPropertyChanged("MediaParserType");
			}
		}
		public NullableBoolean CalculateComplexity
		{
			get { return _CalculateComplexity; }
			set 
			{ 
				_CalculateComplexity = value;
				OnPropertyChanged("CalculateComplexity");
			}
		}
		public string CollectionTags
		{
			get { return _CollectionTags; }
			set 
			{ 
				_CollectionTags = value;
				OnPropertyChanged("CollectionTags");
			}
		}
		#endregion

		#region CTor
		public ConversionProfile()
		{
		}

		public ConversionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (ConversionProfileStatus)StringEnum.Parse(typeof(ConversionProfileStatus), propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (ConversionProfileType)StringEnum.Parse(typeof(ConversionProfileType), propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "defaultEntryId":
						this._DefaultEntryId = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "flavorParamsIds":
						this._FlavorParamsIds = propertyNode.InnerText;
						continue;
					case "isDefault":
						this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "isPartnerDefault":
						this._IsPartnerDefault = ParseBool(propertyNode.InnerText);
						continue;
					case "cropDimensions":
						this._CropDimensions = ObjectFactory.Create<CropDimensions>(propertyNode);
						continue;
					case "clipStart":
						this._ClipStart = ParseInt(propertyNode.InnerText);
						continue;
					case "clipDuration":
						this._ClipDuration = ParseInt(propertyNode.InnerText);
						continue;
					case "xslTransformation":
						this._XslTransformation = propertyNode.InnerText;
						continue;
					case "storageProfileId":
						this._StorageProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "mediaParserType":
						this._MediaParserType = (MediaParserType)StringEnum.Parse(typeof(MediaParserType), propertyNode.InnerText);
						continue;
					case "calculateComplexity":
						this._CalculateComplexity = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "collectionTags":
						this._CollectionTags = propertyNode.InnerText;
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
			kparams.AddIfNotNull("collectionTags", this._CollectionTags);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case STATUS:
					return "Status";
				case TYPE:
					return "Type";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case TAGS:
					return "Tags";
				case DESCRIPTION:
					return "Description";
				case DEFAULT_ENTRY_ID:
					return "DefaultEntryId";
				case CREATED_AT:
					return "CreatedAt";
				case FLAVOR_PARAMS_IDS:
					return "FlavorParamsIds";
				case IS_DEFAULT:
					return "IsDefault";
				case IS_PARTNER_DEFAULT:
					return "IsPartnerDefault";
				case CROP_DIMENSIONS:
					return "CropDimensions";
				case CLIP_START:
					return "ClipStart";
				case CLIP_DURATION:
					return "ClipDuration";
				case XSL_TRANSFORMATION:
					return "XslTransformation";
				case STORAGE_PROFILE_ID:
					return "StorageProfileId";
				case MEDIA_PARSER_TYPE:
					return "MediaParserType";
				case CALCULATE_COMPLEXITY:
					return "CalculateComplexity";
				case COLLECTION_TAGS:
					return "CollectionTags";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

