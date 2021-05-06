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
	public class ReachProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		public const string PROFILE_TYPE = "profileType";
		public const string DEFAULT_OUTPUT_FORMAT = "defaultOutputFormat";
		public const string ENABLE_MACHINE_MODERATION = "enableMachineModeration";
		public const string ENABLE_HUMAN_MODERATION = "enableHumanModeration";
		public const string AUTO_DISPLAY_MACHINE_CAPTIONS_ON_PLAYER = "autoDisplayMachineCaptionsOnPlayer";
		public const string AUTO_DISPLAY_HUMAN_CAPTIONS_ON_PLAYER = "autoDisplayHumanCaptionsOnPlayer";
		public const string ENABLE_METADATA_EXTRACTION = "enableMetadataExtraction";
		public const string ENABLE_SPEAKER_CHANGE_INDICATION = "enableSpeakerChangeIndication";
		public const string ENABLE_AUDIO_TAGS = "enableAudioTags";
		public const string ENABLE_PROFANITY_REMOVAL = "enableProfanityRemoval";
		public const string MAX_CHARACTERS_PER_CAPTION_LINE = "maxCharactersPerCaptionLine";
		public const string LABEL_ADDITION_FOR_MACHINE_SERVICE_TYPE = "labelAdditionForMachineServiceType";
		public const string LABEL_ADDITION_FOR_HUMAN_SERVICE_TYPE = "labelAdditionForHumanServiceType";
		public const string CONTENT_DELETION_POLICY = "contentDeletionPolicy";
		public const string RULES = "rules";
		public const string CREDIT = "credit";
		public const string USED_CREDIT = "usedCredit";
		public const string DICTIONARIES = "dictionaries";
		public const string FLAVOR_PARAMS_IDS = "flavorParamsIds";
		public const string VENDOR_TASK_PROCESSING_REGION = "vendorTaskProcessingRegion";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private ReachProfileStatus _Status = (ReachProfileStatus)Int32.MinValue;
		private ReachProfileType _ProfileType = (ReachProfileType)Int32.MinValue;
		private VendorCatalogItemOutputFormat _DefaultOutputFormat = (VendorCatalogItemOutputFormat)Int32.MinValue;
		private NullableBoolean _EnableMachineModeration = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _EnableHumanModeration = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _AutoDisplayMachineCaptionsOnPlayer = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _AutoDisplayHumanCaptionsOnPlayer = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _EnableMetadataExtraction = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _EnableSpeakerChangeIndication = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _EnableAudioTags = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _EnableProfanityRemoval = (NullableBoolean)Int32.MinValue;
		private int _MaxCharactersPerCaptionLine = Int32.MinValue;
		private string _LabelAdditionForMachineServiceType = null;
		private string _LabelAdditionForHumanServiceType = null;
		private ReachProfileContentDeletionPolicy _ContentDeletionPolicy = (ReachProfileContentDeletionPolicy)Int32.MinValue;
		private IList<Rule> _Rules;
		private BaseVendorCredit _Credit;
		private float _UsedCredit = Single.MinValue;
		private IList<Dictionary> _Dictionaries;
		private string _FlavorParamsIds = null;
		private VendorTaskProcessingRegion _VendorTaskProcessingRegion = (VendorTaskProcessingRegion)Int32.MinValue;
		#endregion

		#region Properties
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
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		[JsonProperty]
		public ReachProfileStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public ReachProfileType ProfileType
		{
			get { return _ProfileType; }
			set 
			{ 
				_ProfileType = value;
				OnPropertyChanged("ProfileType");
			}
		}
		[JsonProperty]
		public VendorCatalogItemOutputFormat DefaultOutputFormat
		{
			get { return _DefaultOutputFormat; }
			set 
			{ 
				_DefaultOutputFormat = value;
				OnPropertyChanged("DefaultOutputFormat");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableMachineModeration
		{
			get { return _EnableMachineModeration; }
			set 
			{ 
				_EnableMachineModeration = value;
				OnPropertyChanged("EnableMachineModeration");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableHumanModeration
		{
			get { return _EnableHumanModeration; }
			set 
			{ 
				_EnableHumanModeration = value;
				OnPropertyChanged("EnableHumanModeration");
			}
		}
		[JsonProperty]
		public NullableBoolean AutoDisplayMachineCaptionsOnPlayer
		{
			get { return _AutoDisplayMachineCaptionsOnPlayer; }
			set 
			{ 
				_AutoDisplayMachineCaptionsOnPlayer = value;
				OnPropertyChanged("AutoDisplayMachineCaptionsOnPlayer");
			}
		}
		[JsonProperty]
		public NullableBoolean AutoDisplayHumanCaptionsOnPlayer
		{
			get { return _AutoDisplayHumanCaptionsOnPlayer; }
			set 
			{ 
				_AutoDisplayHumanCaptionsOnPlayer = value;
				OnPropertyChanged("AutoDisplayHumanCaptionsOnPlayer");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableMetadataExtraction
		{
			get { return _EnableMetadataExtraction; }
			set 
			{ 
				_EnableMetadataExtraction = value;
				OnPropertyChanged("EnableMetadataExtraction");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableSpeakerChangeIndication
		{
			get { return _EnableSpeakerChangeIndication; }
			set 
			{ 
				_EnableSpeakerChangeIndication = value;
				OnPropertyChanged("EnableSpeakerChangeIndication");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableAudioTags
		{
			get { return _EnableAudioTags; }
			set 
			{ 
				_EnableAudioTags = value;
				OnPropertyChanged("EnableAudioTags");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableProfanityRemoval
		{
			get { return _EnableProfanityRemoval; }
			set 
			{ 
				_EnableProfanityRemoval = value;
				OnPropertyChanged("EnableProfanityRemoval");
			}
		}
		[JsonProperty]
		public int MaxCharactersPerCaptionLine
		{
			get { return _MaxCharactersPerCaptionLine; }
			set 
			{ 
				_MaxCharactersPerCaptionLine = value;
				OnPropertyChanged("MaxCharactersPerCaptionLine");
			}
		}
		[JsonProperty]
		public string LabelAdditionForMachineServiceType
		{
			get { return _LabelAdditionForMachineServiceType; }
			set 
			{ 
				_LabelAdditionForMachineServiceType = value;
				OnPropertyChanged("LabelAdditionForMachineServiceType");
			}
		}
		[JsonProperty]
		public string LabelAdditionForHumanServiceType
		{
			get { return _LabelAdditionForHumanServiceType; }
			set 
			{ 
				_LabelAdditionForHumanServiceType = value;
				OnPropertyChanged("LabelAdditionForHumanServiceType");
			}
		}
		[JsonProperty]
		public ReachProfileContentDeletionPolicy ContentDeletionPolicy
		{
			get { return _ContentDeletionPolicy; }
			set 
			{ 
				_ContentDeletionPolicy = value;
				OnPropertyChanged("ContentDeletionPolicy");
			}
		}
		[JsonProperty]
		public IList<Rule> Rules
		{
			get { return _Rules; }
			set 
			{ 
				_Rules = value;
				OnPropertyChanged("Rules");
			}
		}
		[JsonProperty]
		public BaseVendorCredit Credit
		{
			get { return _Credit; }
			set 
			{ 
				_Credit = value;
				OnPropertyChanged("Credit");
			}
		}
		[JsonProperty]
		public float UsedCredit
		{
			get { return _UsedCredit; }
			private set 
			{ 
				_UsedCredit = value;
				OnPropertyChanged("UsedCredit");
			}
		}
		[JsonProperty]
		public IList<Dictionary> Dictionaries
		{
			get { return _Dictionaries; }
			set 
			{ 
				_Dictionaries = value;
				OnPropertyChanged("Dictionaries");
			}
		}
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
		[JsonProperty]
		public VendorTaskProcessingRegion VendorTaskProcessingRegion
		{
			get { return _VendorTaskProcessingRegion; }
			set 
			{ 
				_VendorTaskProcessingRegion = value;
				OnPropertyChanged("VendorTaskProcessingRegion");
			}
		}
		#endregion

		#region CTor
		public ReachProfile()
		{
		}

		public ReachProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (ReachProfileStatus)ParseEnum(typeof(ReachProfileStatus), node["status"].Value<string>());
			}
			if(node["profileType"] != null)
			{
				this._ProfileType = (ReachProfileType)ParseEnum(typeof(ReachProfileType), node["profileType"].Value<string>());
			}
			if(node["defaultOutputFormat"] != null)
			{
				this._DefaultOutputFormat = (VendorCatalogItemOutputFormat)ParseEnum(typeof(VendorCatalogItemOutputFormat), node["defaultOutputFormat"].Value<string>());
			}
			if(node["enableMachineModeration"] != null)
			{
				this._EnableMachineModeration = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableMachineModeration"].Value<string>());
			}
			if(node["enableHumanModeration"] != null)
			{
				this._EnableHumanModeration = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableHumanModeration"].Value<string>());
			}
			if(node["autoDisplayMachineCaptionsOnPlayer"] != null)
			{
				this._AutoDisplayMachineCaptionsOnPlayer = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["autoDisplayMachineCaptionsOnPlayer"].Value<string>());
			}
			if(node["autoDisplayHumanCaptionsOnPlayer"] != null)
			{
				this._AutoDisplayHumanCaptionsOnPlayer = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["autoDisplayHumanCaptionsOnPlayer"].Value<string>());
			}
			if(node["enableMetadataExtraction"] != null)
			{
				this._EnableMetadataExtraction = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableMetadataExtraction"].Value<string>());
			}
			if(node["enableSpeakerChangeIndication"] != null)
			{
				this._EnableSpeakerChangeIndication = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableSpeakerChangeIndication"].Value<string>());
			}
			if(node["enableAudioTags"] != null)
			{
				this._EnableAudioTags = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableAudioTags"].Value<string>());
			}
			if(node["enableProfanityRemoval"] != null)
			{
				this._EnableProfanityRemoval = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableProfanityRemoval"].Value<string>());
			}
			if(node["maxCharactersPerCaptionLine"] != null)
			{
				this._MaxCharactersPerCaptionLine = ParseInt(node["maxCharactersPerCaptionLine"].Value<string>());
			}
			if(node["labelAdditionForMachineServiceType"] != null)
			{
				this._LabelAdditionForMachineServiceType = node["labelAdditionForMachineServiceType"].Value<string>();
			}
			if(node["labelAdditionForHumanServiceType"] != null)
			{
				this._LabelAdditionForHumanServiceType = node["labelAdditionForHumanServiceType"].Value<string>();
			}
			if(node["contentDeletionPolicy"] != null)
			{
				this._ContentDeletionPolicy = (ReachProfileContentDeletionPolicy)ParseEnum(typeof(ReachProfileContentDeletionPolicy), node["contentDeletionPolicy"].Value<string>());
			}
			if(node["rules"] != null)
			{
				this._Rules = new List<Rule>();
				foreach(var arrayNode in node["rules"].Children())
				{
					this._Rules.Add(ObjectFactory.Create<Rule>(arrayNode));
				}
			}
			if(node["credit"] != null)
			{
				this._Credit = ObjectFactory.Create<BaseVendorCredit>(node["credit"]);
			}
			if(node["usedCredit"] != null)
			{
				this._UsedCredit = ParseFloat(node["usedCredit"].Value<string>());
			}
			if(node["dictionaries"] != null)
			{
				this._Dictionaries = new List<Dictionary>();
				foreach(var arrayNode in node["dictionaries"].Children())
				{
					this._Dictionaries.Add(ObjectFactory.Create<Dictionary>(arrayNode));
				}
			}
			if(node["flavorParamsIds"] != null)
			{
				this._FlavorParamsIds = node["flavorParamsIds"].Value<string>();
			}
			if(node["vendorTaskProcessingRegion"] != null)
			{
				this._VendorTaskProcessingRegion = (VendorTaskProcessingRegion)ParseEnum(typeof(VendorTaskProcessingRegion), node["vendorTaskProcessingRegion"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReachProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("profileType", this._ProfileType);
			kparams.AddIfNotNull("defaultOutputFormat", this._DefaultOutputFormat);
			kparams.AddIfNotNull("enableMachineModeration", this._EnableMachineModeration);
			kparams.AddIfNotNull("enableHumanModeration", this._EnableHumanModeration);
			kparams.AddIfNotNull("autoDisplayMachineCaptionsOnPlayer", this._AutoDisplayMachineCaptionsOnPlayer);
			kparams.AddIfNotNull("autoDisplayHumanCaptionsOnPlayer", this._AutoDisplayHumanCaptionsOnPlayer);
			kparams.AddIfNotNull("enableMetadataExtraction", this._EnableMetadataExtraction);
			kparams.AddIfNotNull("enableSpeakerChangeIndication", this._EnableSpeakerChangeIndication);
			kparams.AddIfNotNull("enableAudioTags", this._EnableAudioTags);
			kparams.AddIfNotNull("enableProfanityRemoval", this._EnableProfanityRemoval);
			kparams.AddIfNotNull("maxCharactersPerCaptionLine", this._MaxCharactersPerCaptionLine);
			kparams.AddIfNotNull("labelAdditionForMachineServiceType", this._LabelAdditionForMachineServiceType);
			kparams.AddIfNotNull("labelAdditionForHumanServiceType", this._LabelAdditionForHumanServiceType);
			kparams.AddIfNotNull("contentDeletionPolicy", this._ContentDeletionPolicy);
			kparams.AddIfNotNull("rules", this._Rules);
			kparams.AddIfNotNull("credit", this._Credit);
			kparams.AddIfNotNull("usedCredit", this._UsedCredit);
			kparams.AddIfNotNull("dictionaries", this._Dictionaries);
			kparams.AddIfNotNull("flavorParamsIds", this._FlavorParamsIds);
			kparams.AddIfNotNull("vendorTaskProcessingRegion", this._VendorTaskProcessingRegion);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				case PROFILE_TYPE:
					return "ProfileType";
				case DEFAULT_OUTPUT_FORMAT:
					return "DefaultOutputFormat";
				case ENABLE_MACHINE_MODERATION:
					return "EnableMachineModeration";
				case ENABLE_HUMAN_MODERATION:
					return "EnableHumanModeration";
				case AUTO_DISPLAY_MACHINE_CAPTIONS_ON_PLAYER:
					return "AutoDisplayMachineCaptionsOnPlayer";
				case AUTO_DISPLAY_HUMAN_CAPTIONS_ON_PLAYER:
					return "AutoDisplayHumanCaptionsOnPlayer";
				case ENABLE_METADATA_EXTRACTION:
					return "EnableMetadataExtraction";
				case ENABLE_SPEAKER_CHANGE_INDICATION:
					return "EnableSpeakerChangeIndication";
				case ENABLE_AUDIO_TAGS:
					return "EnableAudioTags";
				case ENABLE_PROFANITY_REMOVAL:
					return "EnableProfanityRemoval";
				case MAX_CHARACTERS_PER_CAPTION_LINE:
					return "MaxCharactersPerCaptionLine";
				case LABEL_ADDITION_FOR_MACHINE_SERVICE_TYPE:
					return "LabelAdditionForMachineServiceType";
				case LABEL_ADDITION_FOR_HUMAN_SERVICE_TYPE:
					return "LabelAdditionForHumanServiceType";
				case CONTENT_DELETION_POLICY:
					return "ContentDeletionPolicy";
				case RULES:
					return "Rules";
				case CREDIT:
					return "Credit";
				case USED_CREDIT:
					return "UsedCredit";
				case DICTIONARIES:
					return "Dictionaries";
				case FLAVOR_PARAMS_IDS:
					return "FlavorParamsIds";
				case VENDOR_TASK_PROCESSING_REGION:
					return "VendorTaskProcessingRegion";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

