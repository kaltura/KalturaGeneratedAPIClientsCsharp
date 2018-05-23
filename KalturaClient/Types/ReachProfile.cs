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
		public const string DEFAULT_SOURCE_LANGUAGE = "defaultSourceLanguage";
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
		public const string CONTENT_DELETION_POLICY = "contentDeletionPolicy";
		public const string RULES = "rules";
		public const string CREDIT = "credit";
		public const string USED_CREDIT = "usedCredit";
		public const string DICTIONARIES = "dictionaries";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private ReachProfileStatus _Status = (ReachProfileStatus)Int32.MinValue;
		private ReachProfileType _ProfileType = (ReachProfileType)Int32.MinValue;
		private CatalogItemLanguage _DefaultSourceLanguage = null;
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
		private ReachProfileContentDeletionPolicy _ContentDeletionPolicy = (ReachProfileContentDeletionPolicy)Int32.MinValue;
		private IList<Rule> _Rules;
		private BaseVendorCredit _Credit;
		private int _UsedCredit = Int32.MinValue;
		private IList<Dictionary> _Dictionaries;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
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
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public ReachProfileStatus Status
		{
			get { return _Status; }
		}
		public ReachProfileType ProfileType
		{
			get { return _ProfileType; }
			set 
			{ 
				_ProfileType = value;
				OnPropertyChanged("ProfileType");
			}
		}
		public CatalogItemLanguage DefaultSourceLanguage
		{
			get { return _DefaultSourceLanguage; }
			set 
			{ 
				_DefaultSourceLanguage = value;
				OnPropertyChanged("DefaultSourceLanguage");
			}
		}
		public VendorCatalogItemOutputFormat DefaultOutputFormat
		{
			get { return _DefaultOutputFormat; }
			set 
			{ 
				_DefaultOutputFormat = value;
				OnPropertyChanged("DefaultOutputFormat");
			}
		}
		public NullableBoolean EnableMachineModeration
		{
			get { return _EnableMachineModeration; }
			set 
			{ 
				_EnableMachineModeration = value;
				OnPropertyChanged("EnableMachineModeration");
			}
		}
		public NullableBoolean EnableHumanModeration
		{
			get { return _EnableHumanModeration; }
			set 
			{ 
				_EnableHumanModeration = value;
				OnPropertyChanged("EnableHumanModeration");
			}
		}
		public NullableBoolean AutoDisplayMachineCaptionsOnPlayer
		{
			get { return _AutoDisplayMachineCaptionsOnPlayer; }
			set 
			{ 
				_AutoDisplayMachineCaptionsOnPlayer = value;
				OnPropertyChanged("AutoDisplayMachineCaptionsOnPlayer");
			}
		}
		public NullableBoolean AutoDisplayHumanCaptionsOnPlayer
		{
			get { return _AutoDisplayHumanCaptionsOnPlayer; }
			set 
			{ 
				_AutoDisplayHumanCaptionsOnPlayer = value;
				OnPropertyChanged("AutoDisplayHumanCaptionsOnPlayer");
			}
		}
		public NullableBoolean EnableMetadataExtraction
		{
			get { return _EnableMetadataExtraction; }
			set 
			{ 
				_EnableMetadataExtraction = value;
				OnPropertyChanged("EnableMetadataExtraction");
			}
		}
		public NullableBoolean EnableSpeakerChangeIndication
		{
			get { return _EnableSpeakerChangeIndication; }
			set 
			{ 
				_EnableSpeakerChangeIndication = value;
				OnPropertyChanged("EnableSpeakerChangeIndication");
			}
		}
		public NullableBoolean EnableAudioTags
		{
			get { return _EnableAudioTags; }
			set 
			{ 
				_EnableAudioTags = value;
				OnPropertyChanged("EnableAudioTags");
			}
		}
		public NullableBoolean EnableProfanityRemoval
		{
			get { return _EnableProfanityRemoval; }
			set 
			{ 
				_EnableProfanityRemoval = value;
				OnPropertyChanged("EnableProfanityRemoval");
			}
		}
		public int MaxCharactersPerCaptionLine
		{
			get { return _MaxCharactersPerCaptionLine; }
			set 
			{ 
				_MaxCharactersPerCaptionLine = value;
				OnPropertyChanged("MaxCharactersPerCaptionLine");
			}
		}
		public ReachProfileContentDeletionPolicy ContentDeletionPolicy
		{
			get { return _ContentDeletionPolicy; }
			set 
			{ 
				_ContentDeletionPolicy = value;
				OnPropertyChanged("ContentDeletionPolicy");
			}
		}
		public IList<Rule> Rules
		{
			get { return _Rules; }
			set 
			{ 
				_Rules = value;
				OnPropertyChanged("Rules");
			}
		}
		public BaseVendorCredit Credit
		{
			get { return _Credit; }
			set 
			{ 
				_Credit = value;
				OnPropertyChanged("Credit");
			}
		}
		public int UsedCredit
		{
			get { return _UsedCredit; }
		}
		public IList<Dictionary> Dictionaries
		{
			get { return _Dictionaries; }
			set 
			{ 
				_Dictionaries = value;
				OnPropertyChanged("Dictionaries");
			}
		}
		#endregion

		#region CTor
		public ReachProfile()
		{
		}

		public ReachProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (ReachProfileStatus)ParseEnum(typeof(ReachProfileStatus), propertyNode.InnerText);
						continue;
					case "profileType":
						this._ProfileType = (ReachProfileType)ParseEnum(typeof(ReachProfileType), propertyNode.InnerText);
						continue;
					case "defaultSourceLanguage":
						this._DefaultSourceLanguage = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), propertyNode.InnerText);
						continue;
					case "defaultOutputFormat":
						this._DefaultOutputFormat = (VendorCatalogItemOutputFormat)ParseEnum(typeof(VendorCatalogItemOutputFormat), propertyNode.InnerText);
						continue;
					case "enableMachineModeration":
						this._EnableMachineModeration = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "enableHumanModeration":
						this._EnableHumanModeration = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "autoDisplayMachineCaptionsOnPlayer":
						this._AutoDisplayMachineCaptionsOnPlayer = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "autoDisplayHumanCaptionsOnPlayer":
						this._AutoDisplayHumanCaptionsOnPlayer = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "enableMetadataExtraction":
						this._EnableMetadataExtraction = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "enableSpeakerChangeIndication":
						this._EnableSpeakerChangeIndication = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "enableAudioTags":
						this._EnableAudioTags = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "enableProfanityRemoval":
						this._EnableProfanityRemoval = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "maxCharactersPerCaptionLine":
						this._MaxCharactersPerCaptionLine = ParseInt(propertyNode.InnerText);
						continue;
					case "contentDeletionPolicy":
						this._ContentDeletionPolicy = (ReachProfileContentDeletionPolicy)ParseEnum(typeof(ReachProfileContentDeletionPolicy), propertyNode.InnerText);
						continue;
					case "rules":
						this._Rules = new List<Rule>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Rules.Add(ObjectFactory.Create<Rule>(arrayNode));
						}
						continue;
					case "credit":
						this._Credit = ObjectFactory.Create<BaseVendorCredit>(propertyNode);
						continue;
					case "usedCredit":
						this._UsedCredit = ParseInt(propertyNode.InnerText);
						continue;
					case "dictionaries":
						this._Dictionaries = new List<Dictionary>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Dictionaries.Add(ObjectFactory.Create<Dictionary>(arrayNode));
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
				kparams.AddReplace("objectType", "KalturaReachProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("profileType", this._ProfileType);
			kparams.AddIfNotNull("defaultSourceLanguage", this._DefaultSourceLanguage);
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
			kparams.AddIfNotNull("contentDeletionPolicy", this._ContentDeletionPolicy);
			kparams.AddIfNotNull("rules", this._Rules);
			kparams.AddIfNotNull("credit", this._Credit);
			kparams.AddIfNotNull("usedCredit", this._UsedCredit);
			kparams.AddIfNotNull("dictionaries", this._Dictionaries);
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
				case DEFAULT_SOURCE_LANGUAGE:
					return "DefaultSourceLanguage";
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

