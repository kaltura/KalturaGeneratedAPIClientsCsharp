// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
		public const string CONDITIONAL_PROFILES = "conditionalProfiles";
		public const string DETECT_GOP = "detectGOP";
		public const string MEDIA_INFO_XSL_TRANSFORMATION = "mediaInfoXslTransformation";
		public const string DEFAULT_REPLACEMENT_OPTIONS = "defaultReplacementOptions";
		public const string DEFAULT_AUDIO_LANG = "defaultAudioLang";
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
		private string _ConditionalProfiles = null;
		private int _DetectGOP = Int32.MinValue;
		private string _MediaInfoXslTransformation = null;
		private EntryReplacementOptions _DefaultReplacementOptions;
		private Language _DefaultAudioLang = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ConversionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ConversionProfileType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use SystemNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		/// <summary>
		/// Use TagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use DefaultEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefaultEntryId
		{
			get { return _DefaultEntryId; }
			set 
			{ 
				_DefaultEntryId = value;
				OnPropertyChanged("DefaultEntryId");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use FlavorParamsIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		/// <summary>
		/// Use IsDefaultAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		/// <summary>
		/// Use IsPartnerDefaultAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsPartnerDefault
		{
			get { return _IsPartnerDefault; }
			private set 
			{ 
				_IsPartnerDefault = value;
				OnPropertyChanged("IsPartnerDefault");
			}
		}
		/// <summary>
		/// Use CropDimensionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CropDimensions CropDimensions
		{
			get { return _CropDimensions; }
			set 
			{ 
				_CropDimensions = value;
				OnPropertyChanged("CropDimensions");
			}
		}
		/// <summary>
		/// Use ClipStartAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ClipStart
		{
			get { return _ClipStart; }
			set 
			{ 
				_ClipStart = value;
				OnPropertyChanged("ClipStart");
			}
		}
		/// <summary>
		/// Use ClipDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ClipDuration
		{
			get { return _ClipDuration; }
			set 
			{ 
				_ClipDuration = value;
				OnPropertyChanged("ClipDuration");
			}
		}
		/// <summary>
		/// Use XslTransformationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string XslTransformation
		{
			get { return _XslTransformation; }
			set 
			{ 
				_XslTransformation = value;
				OnPropertyChanged("XslTransformation");
			}
		}
		/// <summary>
		/// Use StorageProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StorageProfileId
		{
			get { return _StorageProfileId; }
			set 
			{ 
				_StorageProfileId = value;
				OnPropertyChanged("StorageProfileId");
			}
		}
		/// <summary>
		/// Use MediaParserTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MediaParserType MediaParserType
		{
			get { return _MediaParserType; }
			set 
			{ 
				_MediaParserType = value;
				OnPropertyChanged("MediaParserType");
			}
		}
		/// <summary>
		/// Use CalculateComplexityAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean CalculateComplexity
		{
			get { return _CalculateComplexity; }
			set 
			{ 
				_CalculateComplexity = value;
				OnPropertyChanged("CalculateComplexity");
			}
		}
		/// <summary>
		/// Use CollectionTagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CollectionTags
		{
			get { return _CollectionTags; }
			set 
			{ 
				_CollectionTags = value;
				OnPropertyChanged("CollectionTags");
			}
		}
		/// <summary>
		/// Use ConditionalProfilesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ConditionalProfiles
		{
			get { return _ConditionalProfiles; }
			set 
			{ 
				_ConditionalProfiles = value;
				OnPropertyChanged("ConditionalProfiles");
			}
		}
		/// <summary>
		/// Use DetectGOPAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DetectGOP
		{
			get { return _DetectGOP; }
			set 
			{ 
				_DetectGOP = value;
				OnPropertyChanged("DetectGOP");
			}
		}
		/// <summary>
		/// Use MediaInfoXslTransformationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MediaInfoXslTransformation
		{
			get { return _MediaInfoXslTransformation; }
			set 
			{ 
				_MediaInfoXslTransformation = value;
				OnPropertyChanged("MediaInfoXslTransformation");
			}
		}
		/// <summary>
		/// Use DefaultReplacementOptionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryReplacementOptions DefaultReplacementOptions
		{
			get { return _DefaultReplacementOptions; }
			set 
			{ 
				_DefaultReplacementOptions = value;
				OnPropertyChanged("DefaultReplacementOptions");
			}
		}
		/// <summary>
		/// Use DefaultAudioLangAsDouble property instead
		/// </summary>
		[JsonProperty]
		public Language DefaultAudioLang
		{
			get { return _DefaultAudioLang; }
			set 
			{ 
				_DefaultAudioLang = value;
				OnPropertyChanged("DefaultAudioLang");
			}
		}
		#endregion

		#region CTor
		public ConversionProfile()
		{
		}

		public ConversionProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (ConversionProfileStatus)StringEnum.Parse(typeof(ConversionProfileStatus), node["status"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (ConversionProfileType)StringEnum.Parse(typeof(ConversionProfileType), node["type"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["defaultEntryId"] != null)
			{
				this._DefaultEntryId = node["defaultEntryId"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["flavorParamsIds"] != null)
			{
				this._FlavorParamsIds = node["flavorParamsIds"].Value<string>();
			}
			if(node["isDefault"] != null)
			{
				this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isDefault"].Value<string>());
			}
			if(node["isPartnerDefault"] != null)
			{
				this._IsPartnerDefault = ParseBool(node["isPartnerDefault"].Value<string>());
			}
			if(node["cropDimensions"] != null)
			{
				this._CropDimensions = ObjectFactory.Create<CropDimensions>(node["cropDimensions"]);
			}
			if(node["clipStart"] != null)
			{
				this._ClipStart = ParseInt(node["clipStart"].Value<string>());
			}
			if(node["clipDuration"] != null)
			{
				this._ClipDuration = ParseInt(node["clipDuration"].Value<string>());
			}
			if(node["xslTransformation"] != null)
			{
				this._XslTransformation = node["xslTransformation"].Value<string>();
			}
			if(node["storageProfileId"] != null)
			{
				this._StorageProfileId = ParseInt(node["storageProfileId"].Value<string>());
			}
			if(node["mediaParserType"] != null)
			{
				this._MediaParserType = (MediaParserType)StringEnum.Parse(typeof(MediaParserType), node["mediaParserType"].Value<string>());
			}
			if(node["calculateComplexity"] != null)
			{
				this._CalculateComplexity = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["calculateComplexity"].Value<string>());
			}
			if(node["collectionTags"] != null)
			{
				this._CollectionTags = node["collectionTags"].Value<string>();
			}
			if(node["conditionalProfiles"] != null)
			{
				this._ConditionalProfiles = node["conditionalProfiles"].Value<string>();
			}
			if(node["detectGOP"] != null)
			{
				this._DetectGOP = ParseInt(node["detectGOP"].Value<string>());
			}
			if(node["mediaInfoXslTransformation"] != null)
			{
				this._MediaInfoXslTransformation = node["mediaInfoXslTransformation"].Value<string>();
			}
			if(node["defaultReplacementOptions"] != null)
			{
				this._DefaultReplacementOptions = ObjectFactory.Create<EntryReplacementOptions>(node["defaultReplacementOptions"]);
			}
			if(node["defaultAudioLang"] != null)
			{
				this._DefaultAudioLang = (Language)StringEnum.Parse(typeof(Language), node["defaultAudioLang"].Value<string>());
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
			kparams.AddIfNotNull("conditionalProfiles", this._ConditionalProfiles);
			kparams.AddIfNotNull("detectGOP", this._DetectGOP);
			kparams.AddIfNotNull("mediaInfoXslTransformation", this._MediaInfoXslTransformation);
			kparams.AddIfNotNull("defaultReplacementOptions", this._DefaultReplacementOptions);
			kparams.AddIfNotNull("defaultAudioLang", this._DefaultAudioLang);
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
				case CONDITIONAL_PROFILES:
					return "ConditionalProfiles";
				case DETECT_GOP:
					return "DetectGOP";
				case MEDIA_INFO_XSL_TRANSFORMATION:
					return "MediaInfoXslTransformation";
				case DEFAULT_REPLACEMENT_OPTIONS:
					return "DefaultReplacementOptions";
				case DEFAULT_AUDIO_LANG:
					return "DefaultAudioLang";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

