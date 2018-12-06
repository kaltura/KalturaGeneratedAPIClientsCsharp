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
		private float _Rank = Single.MinValue;
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
		#endregion

		#region Properties
		public string Id
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public string CreatorId
		{
			get { return _CreatorId; }
			set 
			{ 
				_CreatorId = value;
				OnPropertyChanged("CreatorId");
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
		public string AdminTags
		{
			get { return _AdminTags; }
			set 
			{ 
				_AdminTags = value;
				OnPropertyChanged("AdminTags");
			}
		}
		public string Categories
		{
			get { return _Categories; }
			set 
			{ 
				_Categories = value;
				OnPropertyChanged("Categories");
			}
		}
		public string CategoriesIds
		{
			get { return _CategoriesIds; }
			set 
			{ 
				_CategoriesIds = value;
				OnPropertyChanged("CategoriesIds");
			}
		}
		public EntryStatus Status
		{
			get { return _Status; }
		}
		public EntryModerationStatus ModerationStatus
		{
			get { return _ModerationStatus; }
		}
		public int ModerationCount
		{
			get { return _ModerationCount; }
		}
		public EntryType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public float Rank
		{
			get { return _Rank; }
		}
		public int TotalRank
		{
			get { return _TotalRank; }
		}
		public int Votes
		{
			get { return _Votes; }
		}
		public int GroupId
		{
			get { return _GroupId; }
			set 
			{ 
				_GroupId = value;
				OnPropertyChanged("GroupId");
			}
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		public string DownloadUrl
		{
			get { return _DownloadUrl; }
		}
		public string SearchText
		{
			get { return _SearchText; }
		}
		public LicenseType LicenseType
		{
			get { return _LicenseType; }
			set 
			{ 
				_LicenseType = value;
				OnPropertyChanged("LicenseType");
			}
		}
		public int Version
		{
			get { return _Version; }
		}
		public string ThumbnailUrl
		{
			get { return _ThumbnailUrl; }
		}
		public int AccessControlId
		{
			get { return _AccessControlId; }
			set 
			{ 
				_AccessControlId = value;
				OnPropertyChanged("AccessControlId");
			}
		}
		public int StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		public int EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		public string ReferenceId
		{
			get { return _ReferenceId; }
			set 
			{ 
				_ReferenceId = value;
				OnPropertyChanged("ReferenceId");
			}
		}
		public string ReplacingEntryId
		{
			get { return _ReplacingEntryId; }
		}
		public string ReplacedEntryId
		{
			get { return _ReplacedEntryId; }
		}
		public EntryReplacementStatus ReplacementStatus
		{
			get { return _ReplacementStatus; }
		}
		public int PartnerSortValue
		{
			get { return _PartnerSortValue; }
			set 
			{ 
				_PartnerSortValue = value;
				OnPropertyChanged("PartnerSortValue");
			}
		}
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		public string RedirectEntryId
		{
			get { return _RedirectEntryId; }
			set 
			{ 
				_RedirectEntryId = value;
				OnPropertyChanged("RedirectEntryId");
			}
		}
		public string RootEntryId
		{
			get { return _RootEntryId; }
		}
		public string ParentEntryId
		{
			get { return _ParentEntryId; }
			set 
			{ 
				_ParentEntryId = value;
				OnPropertyChanged("ParentEntryId");
			}
		}
		public IList<OperationAttributes> OperationAttributes
		{
			get { return _OperationAttributes; }
			set 
			{ 
				_OperationAttributes = value;
				OnPropertyChanged("OperationAttributes");
			}
		}
		public string EntitledUsersEdit
		{
			get { return _EntitledUsersEdit; }
			set 
			{ 
				_EntitledUsersEdit = value;
				OnPropertyChanged("EntitledUsersEdit");
			}
		}
		public string EntitledUsersPublish
		{
			get { return _EntitledUsersPublish; }
			set 
			{ 
				_EntitledUsersPublish = value;
				OnPropertyChanged("EntitledUsersPublish");
			}
		}
		public string EntitledUsersView
		{
			get { return _EntitledUsersView; }
			set 
			{ 
				_EntitledUsersView = value;
				OnPropertyChanged("EntitledUsersView");
			}
		}
		public string Capabilities
		{
			get { return _Capabilities; }
		}
		public string TemplateEntryId
		{
			get { return _TemplateEntryId; }
			set 
			{ 
				_TemplateEntryId = value;
				OnPropertyChanged("TemplateEntryId");
			}
		}
		public EntryDisplayInSearchType DisplayInSearch
		{
			get { return _DisplayInSearch; }
			set 
			{ 
				_DisplayInSearch = value;
				OnPropertyChanged("DisplayInSearch");
			}
		}
		#endregion

		#region CTor
		public BaseEntry()
		{
		}

		public BaseEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "creatorId":
						this._CreatorId = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "adminTags":
						this._AdminTags = propertyNode.InnerText;
						continue;
					case "categories":
						this._Categories = propertyNode.InnerText;
						continue;
					case "categoriesIds":
						this._CategoriesIds = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (EntryStatus)StringEnum.Parse(typeof(EntryStatus), propertyNode.InnerText);
						continue;
					case "moderationStatus":
						this._ModerationStatus = (EntryModerationStatus)ParseEnum(typeof(EntryModerationStatus), propertyNode.InnerText);
						continue;
					case "moderationCount":
						this._ModerationCount = ParseInt(propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (EntryType)StringEnum.Parse(typeof(EntryType), propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "rank":
						this._Rank = ParseFloat(propertyNode.InnerText);
						continue;
					case "totalRank":
						this._TotalRank = ParseInt(propertyNode.InnerText);
						continue;
					case "votes":
						this._Votes = ParseInt(propertyNode.InnerText);
						continue;
					case "groupId":
						this._GroupId = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerData":
						this._PartnerData = propertyNode.InnerText;
						continue;
					case "downloadUrl":
						this._DownloadUrl = propertyNode.InnerText;
						continue;
					case "searchText":
						this._SearchText = propertyNode.InnerText;
						continue;
					case "licenseType":
						this._LicenseType = (LicenseType)ParseEnum(typeof(LicenseType), propertyNode.InnerText);
						continue;
					case "version":
						this._Version = ParseInt(propertyNode.InnerText);
						continue;
					case "thumbnailUrl":
						this._ThumbnailUrl = propertyNode.InnerText;
						continue;
					case "accessControlId":
						this._AccessControlId = ParseInt(propertyNode.InnerText);
						continue;
					case "startDate":
						this._StartDate = ParseInt(propertyNode.InnerText);
						continue;
					case "endDate":
						this._EndDate = ParseInt(propertyNode.InnerText);
						continue;
					case "referenceId":
						this._ReferenceId = propertyNode.InnerText;
						continue;
					case "replacingEntryId":
						this._ReplacingEntryId = propertyNode.InnerText;
						continue;
					case "replacedEntryId":
						this._ReplacedEntryId = propertyNode.InnerText;
						continue;
					case "replacementStatus":
						this._ReplacementStatus = (EntryReplacementStatus)StringEnum.Parse(typeof(EntryReplacementStatus), propertyNode.InnerText);
						continue;
					case "partnerSortValue":
						this._PartnerSortValue = ParseInt(propertyNode.InnerText);
						continue;
					case "conversionProfileId":
						this._ConversionProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "redirectEntryId":
						this._RedirectEntryId = propertyNode.InnerText;
						continue;
					case "rootEntryId":
						this._RootEntryId = propertyNode.InnerText;
						continue;
					case "parentEntryId":
						this._ParentEntryId = propertyNode.InnerText;
						continue;
					case "operationAttributes":
						this._OperationAttributes = new List<OperationAttributes>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OperationAttributes.Add(ObjectFactory.Create<OperationAttributes>(arrayNode));
						}
						continue;
					case "entitledUsersEdit":
						this._EntitledUsersEdit = propertyNode.InnerText;
						continue;
					case "entitledUsersPublish":
						this._EntitledUsersPublish = propertyNode.InnerText;
						continue;
					case "entitledUsersView":
						this._EntitledUsersView = propertyNode.InnerText;
						continue;
					case "capabilities":
						this._Capabilities = propertyNode.InnerText;
						continue;
					case "templateEntryId":
						this._TemplateEntryId = propertyNode.InnerText;
						continue;
					case "displayInSearch":
						this._DisplayInSearch = (EntryDisplayInSearchType)ParseEnum(typeof(EntryDisplayInSearchType), propertyNode.InnerText);
						continue;
				}
			}
		}

		public BaseEntry(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<string>("id");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._CreatorId = data.TryGetValueSafe<string>("creatorId");
			    this._Tags = data.TryGetValueSafe<string>("tags");
			    this._AdminTags = data.TryGetValueSafe<string>("adminTags");
			    this._Categories = data.TryGetValueSafe<string>("categories");
			    this._CategoriesIds = data.TryGetValueSafe<string>("categoriesIds");
			    this._Status = (EntryStatus)StringEnum.Parse(typeof(EntryStatus), data.TryGetValueSafe<string>("status"));
			    this._ModerationStatus = (EntryModerationStatus)ParseEnum(typeof(EntryModerationStatus), data.TryGetValueSafe<int>("moderationStatus"));
			    this._ModerationCount = data.TryGetValueSafe<int>("moderationCount");
			    this._Type = (EntryType)StringEnum.Parse(typeof(EntryType), data.TryGetValueSafe<string>("type"));
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._Rank = data.TryGetValueSafe<float>("rank");
			    this._TotalRank = data.TryGetValueSafe<int>("totalRank");
			    this._Votes = data.TryGetValueSafe<int>("votes");
			    this._GroupId = data.TryGetValueSafe<int>("groupId");
			    this._PartnerData = data.TryGetValueSafe<string>("partnerData");
			    this._DownloadUrl = data.TryGetValueSafe<string>("downloadUrl");
			    this._SearchText = data.TryGetValueSafe<string>("searchText");
			    this._LicenseType = (LicenseType)ParseEnum(typeof(LicenseType), data.TryGetValueSafe<int>("licenseType"));
			    this._Version = data.TryGetValueSafe<int>("version");
			    this._ThumbnailUrl = data.TryGetValueSafe<string>("thumbnailUrl");
			    this._AccessControlId = data.TryGetValueSafe<int>("accessControlId");
			    this._StartDate = data.TryGetValueSafe<int>("startDate");
			    this._EndDate = data.TryGetValueSafe<int>("endDate");
			    this._ReferenceId = data.TryGetValueSafe<string>("referenceId");
			    this._ReplacingEntryId = data.TryGetValueSafe<string>("replacingEntryId");
			    this._ReplacedEntryId = data.TryGetValueSafe<string>("replacedEntryId");
			    this._ReplacementStatus = (EntryReplacementStatus)StringEnum.Parse(typeof(EntryReplacementStatus), data.TryGetValueSafe<string>("replacementStatus"));
			    this._PartnerSortValue = data.TryGetValueSafe<int>("partnerSortValue");
			    this._ConversionProfileId = data.TryGetValueSafe<int>("conversionProfileId");
			    this._RedirectEntryId = data.TryGetValueSafe<string>("redirectEntryId");
			    this._RootEntryId = data.TryGetValueSafe<string>("rootEntryId");
			    this._ParentEntryId = data.TryGetValueSafe<string>("parentEntryId");
			    this._OperationAttributes = new List<OperationAttributes>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("operationAttributes", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._OperationAttributes.Add(ObjectFactory.Create<OperationAttributes>((IDictionary<string,object>)dataDictionary));
			    }
			    this._EntitledUsersEdit = data.TryGetValueSafe<string>("entitledUsersEdit");
			    this._EntitledUsersPublish = data.TryGetValueSafe<string>("entitledUsersPublish");
			    this._EntitledUsersView = data.TryGetValueSafe<string>("entitledUsersView");
			    this._Capabilities = data.TryGetValueSafe<string>("capabilities");
			    this._TemplateEntryId = data.TryGetValueSafe<string>("templateEntryId");
			    this._DisplayInSearch = (EntryDisplayInSearchType)ParseEnum(typeof(EntryDisplayInSearchType), data.TryGetValueSafe<int>("displayInSearch"));
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

