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
	public class BaseSyndicationFeed : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string FEED_URL = "feedUrl";
		public const string PARTNER_ID = "partnerId";
		public const string PLAYLIST_ID = "playlistId";
		public const string NAME = "name";
		public const string STATUS = "status";
		public const string TYPE = "type";
		public const string LANDING_PAGE = "landingPage";
		public const string CREATED_AT = "createdAt";
		public const string ALLOW_EMBED = "allowEmbed";
		public const string PLAYER_UICONF_ID = "playerUiconfId";
		public const string FLAVOR_PARAM_ID = "flavorParamId";
		public const string TRANSCODE_EXISTING_CONTENT = "transcodeExistingContent";
		public const string ADD_TO_DEFAULT_CONVERSION_PROFILE = "addToDefaultConversionProfile";
		public const string CATEGORIES = "categories";
		public const string STORAGE_ID = "storageId";
		public const string ENTRIES_ORDER_BY = "entriesOrderBy";
		public const string ENFORCE_ENTITLEMENT = "enforceEntitlement";
		public const string PRIVACY_CONTEXT = "privacyContext";
		public const string UPDATED_AT = "updatedAt";
		public const string USE_CATEGORY_ENTRIES = "useCategoryEntries";
		public const string FEED_CONTENT_TYPE_HEADER = "feedContentTypeHeader";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _FeedUrl = null;
		private int _PartnerId = Int32.MinValue;
		private string _PlaylistId = null;
		private string _Name = null;
		private SyndicationFeedStatus _Status = (SyndicationFeedStatus)Int32.MinValue;
		private SyndicationFeedType _Type = (SyndicationFeedType)Int32.MinValue;
		private string _LandingPage = null;
		private int _CreatedAt = Int32.MinValue;
		private bool? _AllowEmbed = null;
		private int _PlayerUiconfId = Int32.MinValue;
		private int _FlavorParamId = Int32.MinValue;
		private bool? _TranscodeExistingContent = null;
		private bool? _AddToDefaultConversionProfile = null;
		private string _Categories = null;
		private int _StorageId = Int32.MinValue;
		private SyndicationFeedEntriesOrderBy _EntriesOrderBy = null;
		private bool? _EnforceEntitlement = null;
		private string _PrivacyContext = null;
		private int _UpdatedAt = Int32.MinValue;
		private bool? _UseCategoryEntries = null;
		private string _FeedContentTypeHeader = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public string FeedUrl
		{
			get { return _FeedUrl; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string PlaylistId
		{
			get { return _PlaylistId; }
			set 
			{ 
				_PlaylistId = value;
				OnPropertyChanged("PlaylistId");
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
		public SyndicationFeedStatus Status
		{
			get { return _Status; }
		}
		public SyndicationFeedType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string LandingPage
		{
			get { return _LandingPage; }
			set 
			{ 
				_LandingPage = value;
				OnPropertyChanged("LandingPage");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public bool? AllowEmbed
		{
			get { return _AllowEmbed; }
			set 
			{ 
				_AllowEmbed = value;
				OnPropertyChanged("AllowEmbed");
			}
		}
		public int PlayerUiconfId
		{
			get { return _PlayerUiconfId; }
			set 
			{ 
				_PlayerUiconfId = value;
				OnPropertyChanged("PlayerUiconfId");
			}
		}
		public int FlavorParamId
		{
			get { return _FlavorParamId; }
			set 
			{ 
				_FlavorParamId = value;
				OnPropertyChanged("FlavorParamId");
			}
		}
		public bool? TranscodeExistingContent
		{
			get { return _TranscodeExistingContent; }
			set 
			{ 
				_TranscodeExistingContent = value;
				OnPropertyChanged("TranscodeExistingContent");
			}
		}
		public bool? AddToDefaultConversionProfile
		{
			get { return _AddToDefaultConversionProfile; }
			set 
			{ 
				_AddToDefaultConversionProfile = value;
				OnPropertyChanged("AddToDefaultConversionProfile");
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
		public int StorageId
		{
			get { return _StorageId; }
			set 
			{ 
				_StorageId = value;
				OnPropertyChanged("StorageId");
			}
		}
		public SyndicationFeedEntriesOrderBy EntriesOrderBy
		{
			get { return _EntriesOrderBy; }
			set 
			{ 
				_EntriesOrderBy = value;
				OnPropertyChanged("EntriesOrderBy");
			}
		}
		public bool? EnforceEntitlement
		{
			get { return _EnforceEntitlement; }
			set 
			{ 
				_EnforceEntitlement = value;
				OnPropertyChanged("EnforceEntitlement");
			}
		}
		public string PrivacyContext
		{
			get { return _PrivacyContext; }
			set 
			{ 
				_PrivacyContext = value;
				OnPropertyChanged("PrivacyContext");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public bool? UseCategoryEntries
		{
			get { return _UseCategoryEntries; }
			set 
			{ 
				_UseCategoryEntries = value;
				OnPropertyChanged("UseCategoryEntries");
			}
		}
		public string FeedContentTypeHeader
		{
			get { return _FeedContentTypeHeader; }
			set 
			{ 
				_FeedContentTypeHeader = value;
				OnPropertyChanged("FeedContentTypeHeader");
			}
		}
		#endregion

		#region CTor
		public BaseSyndicationFeed()
		{
		}

		public BaseSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "feedUrl":
						this._FeedUrl = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "playlistId":
						this._PlaylistId = propertyNode.InnerText;
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (SyndicationFeedStatus)ParseEnum(typeof(SyndicationFeedStatus), propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (SyndicationFeedType)ParseEnum(typeof(SyndicationFeedType), propertyNode.InnerText);
						continue;
					case "landingPage":
						this._LandingPage = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "allowEmbed":
						this._AllowEmbed = ParseBool(propertyNode.InnerText);
						continue;
					case "playerUiconfId":
						this._PlayerUiconfId = ParseInt(propertyNode.InnerText);
						continue;
					case "flavorParamId":
						this._FlavorParamId = ParseInt(propertyNode.InnerText);
						continue;
					case "transcodeExistingContent":
						this._TranscodeExistingContent = ParseBool(propertyNode.InnerText);
						continue;
					case "addToDefaultConversionProfile":
						this._AddToDefaultConversionProfile = ParseBool(propertyNode.InnerText);
						continue;
					case "categories":
						this._Categories = propertyNode.InnerText;
						continue;
					case "storageId":
						this._StorageId = ParseInt(propertyNode.InnerText);
						continue;
					case "entriesOrderBy":
						this._EntriesOrderBy = (SyndicationFeedEntriesOrderBy)StringEnum.Parse(typeof(SyndicationFeedEntriesOrderBy), propertyNode.InnerText);
						continue;
					case "enforceEntitlement":
						this._EnforceEntitlement = ParseBool(propertyNode.InnerText);
						continue;
					case "privacyContext":
						this._PrivacyContext = propertyNode.InnerText;
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "useCategoryEntries":
						this._UseCategoryEntries = ParseBool(propertyNode.InnerText);
						continue;
					case "feedContentTypeHeader":
						this._FeedContentTypeHeader = propertyNode.InnerText;
						continue;
				}
			}
		}

		public BaseSyndicationFeed(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<string>("id");
			    this._FeedUrl = data.TryGetValueSafe<string>("feedUrl");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._PlaylistId = data.TryGetValueSafe<string>("playlistId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._Status = (SyndicationFeedStatus)ParseEnum(typeof(SyndicationFeedStatus), data.TryGetValueSafe<int>("status"));
			    this._Type = (SyndicationFeedType)ParseEnum(typeof(SyndicationFeedType), data.TryGetValueSafe<int>("type"));
			    this._LandingPage = data.TryGetValueSafe<string>("landingPage");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._AllowEmbed = data.TryGetValueSafe<bool>("allowEmbed");
			    this._PlayerUiconfId = data.TryGetValueSafe<int>("playerUiconfId");
			    this._FlavorParamId = data.TryGetValueSafe<int>("flavorParamId");
			    this._TranscodeExistingContent = data.TryGetValueSafe<bool>("transcodeExistingContent");
			    this._AddToDefaultConversionProfile = data.TryGetValueSafe<bool>("addToDefaultConversionProfile");
			    this._Categories = data.TryGetValueSafe<string>("categories");
			    this._StorageId = data.TryGetValueSafe<int>("storageId");
			    this._EntriesOrderBy = (SyndicationFeedEntriesOrderBy)StringEnum.Parse(typeof(SyndicationFeedEntriesOrderBy), data.TryGetValueSafe<string>("entriesOrderBy"));
			    this._EnforceEntitlement = data.TryGetValueSafe<bool>("enforceEntitlement");
			    this._PrivacyContext = data.TryGetValueSafe<string>("privacyContext");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._UseCategoryEntries = data.TryGetValueSafe<bool>("useCategoryEntries");
			    this._FeedContentTypeHeader = data.TryGetValueSafe<string>("feedContentTypeHeader");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseSyndicationFeed");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("playlistId", this._PlaylistId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("landingPage", this._LandingPage);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("allowEmbed", this._AllowEmbed);
			kparams.AddIfNotNull("playerUiconfId", this._PlayerUiconfId);
			kparams.AddIfNotNull("flavorParamId", this._FlavorParamId);
			kparams.AddIfNotNull("transcodeExistingContent", this._TranscodeExistingContent);
			kparams.AddIfNotNull("addToDefaultConversionProfile", this._AddToDefaultConversionProfile);
			kparams.AddIfNotNull("categories", this._Categories);
			kparams.AddIfNotNull("storageId", this._StorageId);
			kparams.AddIfNotNull("entriesOrderBy", this._EntriesOrderBy);
			kparams.AddIfNotNull("enforceEntitlement", this._EnforceEntitlement);
			kparams.AddIfNotNull("privacyContext", this._PrivacyContext);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("useCategoryEntries", this._UseCategoryEntries);
			kparams.AddIfNotNull("feedContentTypeHeader", this._FeedContentTypeHeader);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case FEED_URL:
					return "FeedUrl";
				case PARTNER_ID:
					return "PartnerId";
				case PLAYLIST_ID:
					return "PlaylistId";
				case NAME:
					return "Name";
				case STATUS:
					return "Status";
				case TYPE:
					return "Type";
				case LANDING_PAGE:
					return "LandingPage";
				case CREATED_AT:
					return "CreatedAt";
				case ALLOW_EMBED:
					return "AllowEmbed";
				case PLAYER_UICONF_ID:
					return "PlayerUiconfId";
				case FLAVOR_PARAM_ID:
					return "FlavorParamId";
				case TRANSCODE_EXISTING_CONTENT:
					return "TranscodeExistingContent";
				case ADD_TO_DEFAULT_CONVERSION_PROFILE:
					return "AddToDefaultConversionProfile";
				case CATEGORIES:
					return "Categories";
				case STORAGE_ID:
					return "StorageId";
				case ENTRIES_ORDER_BY:
					return "EntriesOrderBy";
				case ENFORCE_ENTITLEMENT:
					return "EnforceEntitlement";
				case PRIVACY_CONTEXT:
					return "PrivacyContext";
				case UPDATED_AT:
					return "UpdatedAt";
				case USE_CATEGORY_ENTRIES:
					return "UseCategoryEntries";
				case FEED_CONTENT_TYPE_HEADER:
					return "FeedContentTypeHeader";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

