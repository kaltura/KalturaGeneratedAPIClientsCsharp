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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class BulkUploadResultCategory : BulkUploadResult
	{
		#region Constants
		public const string RELATIVE_PATH = "relativePath";
		public const string NAME = "name";
		public const string REFERENCE_ID = "referenceId";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string APPEAR_IN_LIST = "appearInList";
		public const string PRIVACY = "privacy";
		public const string INHERITANCE_TYPE = "inheritanceType";
		public const string USER_JOIN_POLICY = "userJoinPolicy";
		public const string DEFAULT_PERMISSION_LEVEL = "defaultPermissionLevel";
		public const string OWNER = "owner";
		public const string CONTRIBUTION_POLICY = "contributionPolicy";
		public const string PARTNER_SORT_VALUE = "partnerSortValue";
		public const string MODERATION = "moderation";
		#endregion

		#region Private Fields
		private string _RelativePath = null;
		private string _Name = null;
		private string _ReferenceId = null;
		private string _Description = null;
		private string _Tags = null;
		private int _AppearInList = Int32.MinValue;
		private int _Privacy = Int32.MinValue;
		private int _InheritanceType = Int32.MinValue;
		private int _UserJoinPolicy = Int32.MinValue;
		private int _DefaultPermissionLevel = Int32.MinValue;
		private string _Owner = null;
		private int _ContributionPolicy = Int32.MinValue;
		private int _PartnerSortValue = Int32.MinValue;
		private bool? _Moderation = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use RelativePathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RelativePath
		{
			get { return _RelativePath; }
			set 
			{ 
				_RelativePath = value;
				OnPropertyChanged("RelativePath");
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
		/// Use ReferenceIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReferenceId
		{
			get { return _ReferenceId; }
			set 
			{ 
				_ReferenceId = value;
				OnPropertyChanged("ReferenceId");
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
		/// Use AppearInListAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AppearInList
		{
			get { return _AppearInList; }
			set 
			{ 
				_AppearInList = value;
				OnPropertyChanged("AppearInList");
			}
		}
		/// <summary>
		/// Use PrivacyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Privacy
		{
			get { return _Privacy; }
			set 
			{ 
				_Privacy = value;
				OnPropertyChanged("Privacy");
			}
		}
		/// <summary>
		/// Use InheritanceTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int InheritanceType
		{
			get { return _InheritanceType; }
			set 
			{ 
				_InheritanceType = value;
				OnPropertyChanged("InheritanceType");
			}
		}
		/// <summary>
		/// Use UserJoinPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UserJoinPolicy
		{
			get { return _UserJoinPolicy; }
			set 
			{ 
				_UserJoinPolicy = value;
				OnPropertyChanged("UserJoinPolicy");
			}
		}
		/// <summary>
		/// Use DefaultPermissionLevelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DefaultPermissionLevel
		{
			get { return _DefaultPermissionLevel; }
			set 
			{ 
				_DefaultPermissionLevel = value;
				OnPropertyChanged("DefaultPermissionLevel");
			}
		}
		/// <summary>
		/// Use OwnerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Owner
		{
			get { return _Owner; }
			set 
			{ 
				_Owner = value;
				OnPropertyChanged("Owner");
			}
		}
		/// <summary>
		/// Use ContributionPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ContributionPolicy
		{
			get { return _ContributionPolicy; }
			set 
			{ 
				_ContributionPolicy = value;
				OnPropertyChanged("ContributionPolicy");
			}
		}
		/// <summary>
		/// Use PartnerSortValueAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerSortValue
		{
			get { return _PartnerSortValue; }
			set 
			{ 
				_PartnerSortValue = value;
				OnPropertyChanged("PartnerSortValue");
			}
		}
		/// <summary>
		/// Use ModerationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? Moderation
		{
			get { return _Moderation; }
			set 
			{ 
				_Moderation = value;
				OnPropertyChanged("Moderation");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResultCategory()
		{
		}

		public BulkUploadResultCategory(JToken node) : base(node)
		{
			if(node["relativePath"] != null)
			{
				this._RelativePath = node["relativePath"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["referenceId"] != null)
			{
				this._ReferenceId = node["referenceId"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["appearInList"] != null)
			{
				this._AppearInList = ParseInt(node["appearInList"].Value<string>());
			}
			if(node["privacy"] != null)
			{
				this._Privacy = ParseInt(node["privacy"].Value<string>());
			}
			if(node["inheritanceType"] != null)
			{
				this._InheritanceType = ParseInt(node["inheritanceType"].Value<string>());
			}
			if(node["userJoinPolicy"] != null)
			{
				this._UserJoinPolicy = ParseInt(node["userJoinPolicy"].Value<string>());
			}
			if(node["defaultPermissionLevel"] != null)
			{
				this._DefaultPermissionLevel = ParseInt(node["defaultPermissionLevel"].Value<string>());
			}
			if(node["owner"] != null)
			{
				this._Owner = node["owner"].Value<string>();
			}
			if(node["contributionPolicy"] != null)
			{
				this._ContributionPolicy = ParseInt(node["contributionPolicy"].Value<string>());
			}
			if(node["partnerSortValue"] != null)
			{
				this._PartnerSortValue = ParseInt(node["partnerSortValue"].Value<string>());
			}
			if(node["moderation"] != null)
			{
				this._Moderation = ParseBool(node["moderation"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadResultCategory");
			kparams.AddIfNotNull("relativePath", this._RelativePath);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("appearInList", this._AppearInList);
			kparams.AddIfNotNull("privacy", this._Privacy);
			kparams.AddIfNotNull("inheritanceType", this._InheritanceType);
			kparams.AddIfNotNull("userJoinPolicy", this._UserJoinPolicy);
			kparams.AddIfNotNull("defaultPermissionLevel", this._DefaultPermissionLevel);
			kparams.AddIfNotNull("owner", this._Owner);
			kparams.AddIfNotNull("contributionPolicy", this._ContributionPolicy);
			kparams.AddIfNotNull("partnerSortValue", this._PartnerSortValue);
			kparams.AddIfNotNull("moderation", this._Moderation);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RELATIVE_PATH:
					return "RelativePath";
				case NAME:
					return "Name";
				case REFERENCE_ID:
					return "ReferenceId";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
				case APPEAR_IN_LIST:
					return "AppearInList";
				case PRIVACY:
					return "Privacy";
				case INHERITANCE_TYPE:
					return "InheritanceType";
				case USER_JOIN_POLICY:
					return "UserJoinPolicy";
				case DEFAULT_PERMISSION_LEVEL:
					return "DefaultPermissionLevel";
				case OWNER:
					return "Owner";
				case CONTRIBUTION_POLICY:
					return "ContributionPolicy";
				case PARTNER_SORT_VALUE:
					return "PartnerSortValue";
				case MODERATION:
					return "Moderation";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

