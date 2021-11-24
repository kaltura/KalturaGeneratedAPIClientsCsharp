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
	public class BaseEntry : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string DESCRIPTION = "description";
		public const string PARTNER_ID = "partnerId";
		public const string USER_ID = "userId";
		public const string CREATOR_ID = "creatorId";
		public const string TAGS = "tags";
		public const string ADMIN_TAGS = "adminTags";
		public const string CATEGORIES = "categories";
		public const string CATEGORIES_IDS = "categoriesIds";
		public const string STATUS = "status";
		public const string MODERATION_STATUS = "moderationStatus";
		public const string MODERATION_COUNT = "moderationCount";
		public const string TYPE = "type";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string RANK = "rank";
		public const string TOTAL_RANK = "totalRank";
		public const string VOTES = "votes";
		public const string GROUP_ID = "groupId";
		public const string PARTNER_DATA = "partnerData";
		public const string DOWNLOAD_URL = "downloadUrl";
		public const string SEARCH_TEXT = "searchText";
		public const string LICENSE_TYPE = "licenseType";
		public const string VERSION = "version";
		public const string THUMBNAIL_URL = "thumbnailUrl";
		public const string ACCESS_CONTROL_ID = "accessControlId";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string REFERENCE_ID = "referenceId";
		public const string REPLACING_ENTRY_ID = "replacingEntryId";
		public const string REPLACED_ENTRY_ID = "replacedEntryId";
		public const string REPLACEMENT_STATUS = "replacementStatus";
		public const string PARTNER_SORT_VALUE = "partnerSortValue";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string REDIRECT_ENTRY_ID = "redirectEntryId";
		public const string ROOT_ENTRY_ID = "rootEntryId";
		public const string PARENT_ENTRY_ID = "parentEntryId";
		public const string OPERATION_ATTRIBUTES = "operationAttributes";
		public const string ENTITLED_USERS_EDIT = "entitledUsersEdit";
		public const string ENTITLED_USERS_PUBLISH = "entitledUsersPublish";
		public const string ENTITLED_USERS_VIEW = "entitledUsersView";
		public const string CAPABILITIES = "capabilities";
		public const string TEMPLATE_ENTRY_ID = "templateEntryId";
		public const string DISPLAY_IN_SEARCH = "displayInSearch";
		public const string APPLICATION = "application";
		public const string APPLICATION_VERSION = "applicationVersion";
		public const string BLOCK_AUTO_TRANSCRIPT = "blockAutoTranscript";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _Name = null;
		private string _Description = null;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private string _CreatorId = null;
		private string _Tags = null;
		private string _AdminTags = null;
		private string _Categories = null;
		private string _CategoriesIds = null;
		private EntryStatus _Status = null;
		private EntryModerationStatus _ModerationStatus = (EntryModerationStatus)Int32.MinValue;
		private int _ModerationCount = Int32.MinValue;
		private EntryType _Type = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private double _Rank = Double.MinValue;
		private int _TotalRank = Int32.MinValue;
		private int _Votes = Int32.MinValue;
		private int _GroupId = Int32.MinValue;
		private string _PartnerData = null;
		private string _DownloadUrl = null;
		private string _SearchText = null;
		private LicenseType _LicenseType = (LicenseType)Int32.MinValue;
		private int _Version = Int32.MinValue;
		private string _ThumbnailUrl = null;
		private int _AccessControlId = Int32.MinValue;
		private int _StartDate = Int32.MinValue;
		private int _EndDate = Int32.MinValue;
		private string _ReferenceId = null;
		private string _ReplacingEntryId = null;
		private string _ReplacedEntryId = null;
		private EntryReplacementStatus _ReplacementStatus = null;
		private int _PartnerSortValue = Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private string _RedirectEntryId = null;
		private string _RootEntryId = null;
		private string _ParentEntryId = null;
		private IList<OperationAttributes> _OperationAttributes;
		private string _EntitledUsersEdit = null;
		private string _EntitledUsersPublish = null;
		private string _EntitledUsersView = null;
		private string _Capabilities = null;
		private string _TemplateEntryId = null;
		private EntryDisplayInSearchType _DisplayInSearch = (EntryDisplayInSearchType)Int32.MinValue;
		private EntryApplication _Application = null;
		private string _ApplicationVersion = null;
		private bool? _BlockAutoTranscript = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		/// Use UserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		/// <summary>
		/// Use CreatorIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CreatorId
		{
			get { return _CreatorId; }
			set 
			{ 
				_CreatorId = value;
				OnPropertyChanged("CreatorId");
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
		/// Use AdminTagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdminTags
		{
			get { return _AdminTags; }
			set 
			{ 
				_AdminTags = value;
				OnPropertyChanged("AdminTags");
			}
		}
		/// <summary>
		/// Use CategoriesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Categories
		{
			get { return _Categories; }
			set 
			{ 
				_Categories = value;
				OnPropertyChanged("Categories");
			}
		}
		/// <summary>
		/// Use CategoriesIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CategoriesIds
		{
			get { return _CategoriesIds; }
			set 
			{ 
				_CategoriesIds = value;
				OnPropertyChanged("CategoriesIds");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use ModerationStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryModerationStatus ModerationStatus
		{
			get { return _ModerationStatus; }
			private set 
			{ 
				_ModerationStatus = value;
				OnPropertyChanged("ModerationStatus");
			}
		}
		/// <summary>
		/// Use ModerationCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ModerationCount
		{
			get { return _ModerationCount; }
			private set 
			{ 
				_ModerationCount = value;
				OnPropertyChanged("ModerationCount");
			}
		}
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
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
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use RankAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Rank
		{
			get { return _Rank; }
			private set 
			{ 
				_Rank = value;
				OnPropertyChanged("Rank");
			}
		}
		/// <summary>
		/// Use TotalRankAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int TotalRank
		{
			get { return _TotalRank; }
			private set 
			{ 
				_TotalRank = value;
				OnPropertyChanged("TotalRank");
			}
		}
		/// <summary>
		/// Use VotesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Votes
		{
			get { return _Votes; }
			private set 
			{ 
				_Votes = value;
				OnPropertyChanged("Votes");
			}
		}
		/// <summary>
		/// Use GroupIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int GroupId
		{
			get { return _GroupId; }
			set 
			{ 
				_GroupId = value;
				OnPropertyChanged("GroupId");
			}
		}
		/// <summary>
		/// Use PartnerDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		/// <summary>
		/// Use DownloadUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DownloadUrl
		{
			get { return _DownloadUrl; }
			private set 
			{ 
				_DownloadUrl = value;
				OnPropertyChanged("DownloadUrl");
			}
		}
		/// <summary>
		/// Use SearchTextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SearchText
		{
			get { return _SearchText; }
			private set 
			{ 
				_SearchText = value;
				OnPropertyChanged("SearchText");
			}
		}
		/// <summary>
		/// Use LicenseTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public LicenseType LicenseType
		{
			get { return _LicenseType; }
			set 
			{ 
				_LicenseType = value;
				OnPropertyChanged("LicenseType");
			}
		}
		/// <summary>
		/// Use VersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Version
		{
			get { return _Version; }
			private set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		/// <summary>
		/// Use ThumbnailUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ThumbnailUrl
		{
			get { return _ThumbnailUrl; }
			private set 
			{ 
				_ThumbnailUrl = value;
				OnPropertyChanged("ThumbnailUrl");
			}
		}
		/// <summary>
		/// Use AccessControlIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AccessControlId
		{
			get { return _AccessControlId; }
			set 
			{ 
				_AccessControlId = value;
				OnPropertyChanged("AccessControlId");
			}
		}
		/// <summary>
		/// Use StartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		/// <summary>
		/// Use EndDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
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
		/// Use ReplacingEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReplacingEntryId
		{
			get { return _ReplacingEntryId; }
			private set 
			{ 
				_ReplacingEntryId = value;
				OnPropertyChanged("ReplacingEntryId");
			}
		}
		/// <summary>
		/// Use ReplacedEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReplacedEntryId
		{
			get { return _ReplacedEntryId; }
			private set 
			{ 
				_ReplacedEntryId = value;
				OnPropertyChanged("ReplacedEntryId");
			}
		}
		/// <summary>
		/// Use ReplacementStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryReplacementStatus ReplacementStatus
		{
			get { return _ReplacementStatus; }
			private set 
			{ 
				_ReplacementStatus = value;
				OnPropertyChanged("ReplacementStatus");
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
		/// Use ConversionProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		/// <summary>
		/// Use RedirectEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RedirectEntryId
		{
			get { return _RedirectEntryId; }
			set 
			{ 
				_RedirectEntryId = value;
				OnPropertyChanged("RedirectEntryId");
			}
		}
		/// <summary>
		/// Use RootEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RootEntryId
		{
			get { return _RootEntryId; }
			private set 
			{ 
				_RootEntryId = value;
				OnPropertyChanged("RootEntryId");
			}
		}
		/// <summary>
		/// Use ParentEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentEntryId
		{
			get { return _ParentEntryId; }
			set 
			{ 
				_ParentEntryId = value;
				OnPropertyChanged("ParentEntryId");
			}
		}
		/// <summary>
		/// Use OperationAttributesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<OperationAttributes> OperationAttributes
		{
			get { return _OperationAttributes; }
			set 
			{ 
				_OperationAttributes = value;
				OnPropertyChanged("OperationAttributes");
			}
		}
		/// <summary>
		/// Use EntitledUsersEditAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntitledUsersEdit
		{
			get { return _EntitledUsersEdit; }
			set 
			{ 
				_EntitledUsersEdit = value;
				OnPropertyChanged("EntitledUsersEdit");
			}
		}
		/// <summary>
		/// Use EntitledUsersPublishAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntitledUsersPublish
		{
			get { return _EntitledUsersPublish; }
			set 
			{ 
				_EntitledUsersPublish = value;
				OnPropertyChanged("EntitledUsersPublish");
			}
		}
		/// <summary>
		/// Use EntitledUsersViewAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntitledUsersView
		{
			get { return _EntitledUsersView; }
			set 
			{ 
				_EntitledUsersView = value;
				OnPropertyChanged("EntitledUsersView");
			}
		}
		/// <summary>
		/// Use CapabilitiesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Capabilities
		{
			get { return _Capabilities; }
			private set 
			{ 
				_Capabilities = value;
				OnPropertyChanged("Capabilities");
			}
		}
		/// <summary>
		/// Use TemplateEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TemplateEntryId
		{
			get { return _TemplateEntryId; }
			set 
			{ 
				_TemplateEntryId = value;
				OnPropertyChanged("TemplateEntryId");
			}
		}
		/// <summary>
		/// Use DisplayInSearchAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryDisplayInSearchType DisplayInSearch
		{
			get { return _DisplayInSearch; }
			set 
			{ 
				_DisplayInSearch = value;
				OnPropertyChanged("DisplayInSearch");
			}
		}
		/// <summary>
		/// Use ApplicationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryApplication Application
		{
			get { return _Application; }
			set 
			{ 
				_Application = value;
				OnPropertyChanged("Application");
			}
		}
		/// <summary>
		/// Use ApplicationVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ApplicationVersion
		{
			get { return _ApplicationVersion; }
			set 
			{ 
				_ApplicationVersion = value;
				OnPropertyChanged("ApplicationVersion");
			}
		}
		/// <summary>
		/// Use BlockAutoTranscriptAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? BlockAutoTranscript
		{
			get { return _BlockAutoTranscript; }
			set 
			{ 
				_BlockAutoTranscript = value;
				OnPropertyChanged("BlockAutoTranscript");
			}
		}
		#endregion

		#region CTor
		public BaseEntry()
		{
		}

		public BaseEntry(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["creatorId"] != null)
			{
				this._CreatorId = node["creatorId"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["adminTags"] != null)
			{
				this._AdminTags = node["adminTags"].Value<string>();
			}
			if(node["categories"] != null)
			{
				this._Categories = node["categories"].Value<string>();
			}
			if(node["categoriesIds"] != null)
			{
				this._CategoriesIds = node["categoriesIds"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (EntryStatus)StringEnum.Parse(typeof(EntryStatus), node["status"].Value<string>());
			}
			if(node["moderationStatus"] != null)
			{
				this._ModerationStatus = (EntryModerationStatus)ParseEnum(typeof(EntryModerationStatus), node["moderationStatus"].Value<string>());
			}
			if(node["moderationCount"] != null)
			{
				this._ModerationCount = ParseInt(node["moderationCount"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (EntryType)StringEnum.Parse(typeof(EntryType), node["type"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["rank"] != null)
			{
				this._Rank = ParseDouble(node["rank"].Value<string>());
			}
			if(node["totalRank"] != null)
			{
				this._TotalRank = ParseInt(node["totalRank"].Value<string>());
			}
			if(node["votes"] != null)
			{
				this._Votes = ParseInt(node["votes"].Value<string>());
			}
			if(node["groupId"] != null)
			{
				this._GroupId = ParseInt(node["groupId"].Value<string>());
			}
			if(node["partnerData"] != null)
			{
				this._PartnerData = node["partnerData"].Value<string>();
			}
			if(node["downloadUrl"] != null)
			{
				this._DownloadUrl = node["downloadUrl"].Value<string>();
			}
			if(node["searchText"] != null)
			{
				this._SearchText = node["searchText"].Value<string>();
			}
			if(node["licenseType"] != null)
			{
				this._LicenseType = (LicenseType)ParseEnum(typeof(LicenseType), node["licenseType"].Value<string>());
			}
			if(node["version"] != null)
			{
				this._Version = ParseInt(node["version"].Value<string>());
			}
			if(node["thumbnailUrl"] != null)
			{
				this._ThumbnailUrl = node["thumbnailUrl"].Value<string>();
			}
			if(node["accessControlId"] != null)
			{
				this._AccessControlId = ParseInt(node["accessControlId"].Value<string>());
			}
			if(node["startDate"] != null)
			{
				this._StartDate = ParseInt(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseInt(node["endDate"].Value<string>());
			}
			if(node["referenceId"] != null)
			{
				this._ReferenceId = node["referenceId"].Value<string>();
			}
			if(node["replacingEntryId"] != null)
			{
				this._ReplacingEntryId = node["replacingEntryId"].Value<string>();
			}
			if(node["replacedEntryId"] != null)
			{
				this._ReplacedEntryId = node["replacedEntryId"].Value<string>();
			}
			if(node["replacementStatus"] != null)
			{
				this._ReplacementStatus = (EntryReplacementStatus)StringEnum.Parse(typeof(EntryReplacementStatus), node["replacementStatus"].Value<string>());
			}
			if(node["partnerSortValue"] != null)
			{
				this._PartnerSortValue = ParseInt(node["partnerSortValue"].Value<string>());
			}
			if(node["conversionProfileId"] != null)
			{
				this._ConversionProfileId = ParseInt(node["conversionProfileId"].Value<string>());
			}
			if(node["redirectEntryId"] != null)
			{
				this._RedirectEntryId = node["redirectEntryId"].Value<string>();
			}
			if(node["rootEntryId"] != null)
			{
				this._RootEntryId = node["rootEntryId"].Value<string>();
			}
			if(node["parentEntryId"] != null)
			{
				this._ParentEntryId = node["parentEntryId"].Value<string>();
			}
			if(node["operationAttributes"] != null)
			{
				this._OperationAttributes = new List<OperationAttributes>();
				foreach(var arrayNode in node["operationAttributes"].Children())
				{
					this._OperationAttributes.Add(ObjectFactory.Create<OperationAttributes>(arrayNode));
				}
			}
			if(node["entitledUsersEdit"] != null)
			{
				this._EntitledUsersEdit = node["entitledUsersEdit"].Value<string>();
			}
			if(node["entitledUsersPublish"] != null)
			{
				this._EntitledUsersPublish = node["entitledUsersPublish"].Value<string>();
			}
			if(node["entitledUsersView"] != null)
			{
				this._EntitledUsersView = node["entitledUsersView"].Value<string>();
			}
			if(node["capabilities"] != null)
			{
				this._Capabilities = node["capabilities"].Value<string>();
			}
			if(node["templateEntryId"] != null)
			{
				this._TemplateEntryId = node["templateEntryId"].Value<string>();
			}
			if(node["displayInSearch"] != null)
			{
				this._DisplayInSearch = (EntryDisplayInSearchType)ParseEnum(typeof(EntryDisplayInSearchType), node["displayInSearch"].Value<string>());
			}
			if(node["application"] != null)
			{
				this._Application = (EntryApplication)StringEnum.Parse(typeof(EntryApplication), node["application"].Value<string>());
			}
			if(node["applicationVersion"] != null)
			{
				this._ApplicationVersion = node["applicationVersion"].Value<string>();
			}
			if(node["blockAutoTranscript"] != null)
			{
				this._BlockAutoTranscript = ParseBool(node["blockAutoTranscript"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseEntry");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("creatorId", this._CreatorId);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("adminTags", this._AdminTags);
			kparams.AddIfNotNull("categories", this._Categories);
			kparams.AddIfNotNull("categoriesIds", this._CategoriesIds);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("moderationStatus", this._ModerationStatus);
			kparams.AddIfNotNull("moderationCount", this._ModerationCount);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("rank", this._Rank);
			kparams.AddIfNotNull("totalRank", this._TotalRank);
			kparams.AddIfNotNull("votes", this._Votes);
			kparams.AddIfNotNull("groupId", this._GroupId);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("downloadUrl", this._DownloadUrl);
			kparams.AddIfNotNull("searchText", this._SearchText);
			kparams.AddIfNotNull("licenseType", this._LicenseType);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("thumbnailUrl", this._ThumbnailUrl);
			kparams.AddIfNotNull("accessControlId", this._AccessControlId);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("replacingEntryId", this._ReplacingEntryId);
			kparams.AddIfNotNull("replacedEntryId", this._ReplacedEntryId);
			kparams.AddIfNotNull("replacementStatus", this._ReplacementStatus);
			kparams.AddIfNotNull("partnerSortValue", this._PartnerSortValue);
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("redirectEntryId", this._RedirectEntryId);
			kparams.AddIfNotNull("rootEntryId", this._RootEntryId);
			kparams.AddIfNotNull("parentEntryId", this._ParentEntryId);
			kparams.AddIfNotNull("operationAttributes", this._OperationAttributes);
			kparams.AddIfNotNull("entitledUsersEdit", this._EntitledUsersEdit);
			kparams.AddIfNotNull("entitledUsersPublish", this._EntitledUsersPublish);
			kparams.AddIfNotNull("entitledUsersView", this._EntitledUsersView);
			kparams.AddIfNotNull("capabilities", this._Capabilities);
			kparams.AddIfNotNull("templateEntryId", this._TemplateEntryId);
			kparams.AddIfNotNull("displayInSearch", this._DisplayInSearch);
			kparams.AddIfNotNull("application", this._Application);
			kparams.AddIfNotNull("applicationVersion", this._ApplicationVersion);
			kparams.AddIfNotNull("blockAutoTranscript", this._BlockAutoTranscript);
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
				case DESCRIPTION:
					return "Description";
				case PARTNER_ID:
					return "PartnerId";
				case USER_ID:
					return "UserId";
				case CREATOR_ID:
					return "CreatorId";
				case TAGS:
					return "Tags";
				case ADMIN_TAGS:
					return "AdminTags";
				case CATEGORIES:
					return "Categories";
				case CATEGORIES_IDS:
					return "CategoriesIds";
				case STATUS:
					return "Status";
				case MODERATION_STATUS:
					return "ModerationStatus";
				case MODERATION_COUNT:
					return "ModerationCount";
				case TYPE:
					return "Type";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case RANK:
					return "Rank";
				case TOTAL_RANK:
					return "TotalRank";
				case VOTES:
					return "Votes";
				case GROUP_ID:
					return "GroupId";
				case PARTNER_DATA:
					return "PartnerData";
				case DOWNLOAD_URL:
					return "DownloadUrl";
				case SEARCH_TEXT:
					return "SearchText";
				case LICENSE_TYPE:
					return "LicenseType";
				case VERSION:
					return "Version";
				case THUMBNAIL_URL:
					return "ThumbnailUrl";
				case ACCESS_CONTROL_ID:
					return "AccessControlId";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case REFERENCE_ID:
					return "ReferenceId";
				case REPLACING_ENTRY_ID:
					return "ReplacingEntryId";
				case REPLACED_ENTRY_ID:
					return "ReplacedEntryId";
				case REPLACEMENT_STATUS:
					return "ReplacementStatus";
				case PARTNER_SORT_VALUE:
					return "PartnerSortValue";
				case CONVERSION_PROFILE_ID:
					return "ConversionProfileId";
				case REDIRECT_ENTRY_ID:
					return "RedirectEntryId";
				case ROOT_ENTRY_ID:
					return "RootEntryId";
				case PARENT_ENTRY_ID:
					return "ParentEntryId";
				case OPERATION_ATTRIBUTES:
					return "OperationAttributes";
				case ENTITLED_USERS_EDIT:
					return "EntitledUsersEdit";
				case ENTITLED_USERS_PUBLISH:
					return "EntitledUsersPublish";
				case ENTITLED_USERS_VIEW:
					return "EntitledUsersView";
				case CAPABILITIES:
					return "Capabilities";
				case TEMPLATE_ENTRY_ID:
					return "TemplateEntryId";
				case DISPLAY_IN_SEARCH:
					return "DisplayInSearch";
				case APPLICATION:
					return "Application";
				case APPLICATION_VERSION:
					return "ApplicationVersion";
				case BLOCK_AUTO_TRANSCRIPT:
					return "BlockAutoTranscript";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

