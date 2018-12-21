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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
		[JsonProperty]
		public string FeedUrl
		{
			get { return _FeedUrl; }
			private set 
			{ 
				_FeedUrl = value;
				OnPropertyChanged("FeedUrl");
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
		public string PlaylistId
		{
			get { return _PlaylistId; }
			set 
			{ 
				_PlaylistId = value;
				OnPropertyChanged("PlaylistId");
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
		public SyndicationFeedStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public SyndicationFeedType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public string LandingPage
		{
			get { return _LandingPage; }
			set 
			{ 
				_LandingPage = value;
				OnPropertyChanged("LandingPage");
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
		public bool? AllowEmbed
		{
			get { return _AllowEmbed; }
			set 
			{ 
				_AllowEmbed = value;
				OnPropertyChanged("AllowEmbed");
			}
		}
		[JsonProperty]
		public int PlayerUiconfId
		{
			get { return _PlayerUiconfId; }
			set 
			{ 
				_PlayerUiconfId = value;
				OnPropertyChanged("PlayerUiconfId");
			}
		}
		[JsonProperty]
		public int FlavorParamId
		{
			get { return _FlavorParamId; }
			set 
			{ 
				_FlavorParamId = value;
				OnPropertyChanged("FlavorParamId");
			}
		}
		[JsonProperty]
		public bool? TranscodeExistingContent
		{
			get { return _TranscodeExistingContent; }
			set 
			{ 
				_TranscodeExistingContent = value;
				OnPropertyChanged("TranscodeExistingContent");
			}
		}
		[JsonProperty]
		public bool? AddToDefaultConversionProfile
		{
			get { return _AddToDefaultConversionProfile; }
			set 
			{ 
				_AddToDefaultConversionProfile = value;
				OnPropertyChanged("AddToDefaultConversionProfile");
			}
		}
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
		[JsonProperty]
		public int StorageId
		{
			get { return _StorageId; }
			set 
			{ 
				_StorageId = value;
				OnPropertyChanged("StorageId");
			}
		}
		[JsonProperty]
		public SyndicationFeedEntriesOrderBy EntriesOrderBy
		{
			get { return _EntriesOrderBy; }
			set 
			{ 
				_EntriesOrderBy = value;
				OnPropertyChanged("EntriesOrderBy");
			}
		}
		[JsonProperty]
		public bool? EnforceEntitlement
		{
			get { return _EnforceEntitlement; }
			set 
			{ 
				_EnforceEntitlement = value;
				OnPropertyChanged("EnforceEntitlement");
			}
		}
		[JsonProperty]
		public string PrivacyContext
		{
			get { return _PrivacyContext; }
			set 
			{ 
				_PrivacyContext = value;
				OnPropertyChanged("PrivacyContext");
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
		public bool? UseCategoryEntries
		{
			get { return _UseCategoryEntries; }
			set 
			{ 
				_UseCategoryEntries = value;
				OnPropertyChanged("UseCategoryEntries");
			}
		}
		[JsonProperty]
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

		public BaseSyndicationFeed(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["feedUrl"] != null)
			{
				this._FeedUrl = node["feedUrl"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["playlistId"] != null)
			{
				this._PlaylistId = node["playlistId"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (SyndicationFeedStatus)ParseEnum(typeof(SyndicationFeedStatus), node["status"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (SyndicationFeedType)ParseEnum(typeof(SyndicationFeedType), node["type"].Value<string>());
			}
			if(node["landingPage"] != null)
			{
				this._LandingPage = node["landingPage"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["allowEmbed"] != null)
			{
				this._AllowEmbed = ParseBool(node["allowEmbed"].Value<string>());
			}
			if(node["playerUiconfId"] != null)
			{
				this._PlayerUiconfId = ParseInt(node["playerUiconfId"].Value<string>());
			}
			if(node["flavorParamId"] != null)
			{
				this._FlavorParamId = ParseInt(node["flavorParamId"].Value<string>());
			}
			if(node["transcodeExistingContent"] != null)
			{
				this._TranscodeExistingContent = ParseBool(node["transcodeExistingContent"].Value<string>());
			}
			if(node["addToDefaultConversionProfile"] != null)
			{
				this._AddToDefaultConversionProfile = ParseBool(node["addToDefaultConversionProfile"].Value<string>());
			}
			if(node["categories"] != null)
			{
				this._Categories = node["categories"].Value<string>();
			}
			if(node["storageId"] != null)
			{
				this._StorageId = ParseInt(node["storageId"].Value<string>());
			}
			if(node["entriesOrderBy"] != null)
			{
				this._EntriesOrderBy = (SyndicationFeedEntriesOrderBy)StringEnum.Parse(typeof(SyndicationFeedEntriesOrderBy), node["entriesOrderBy"].Value<string>());
			}
			if(node["enforceEntitlement"] != null)
			{
				this._EnforceEntitlement = ParseBool(node["enforceEntitlement"].Value<string>());
			}
			if(node["privacyContext"] != null)
			{
				this._PrivacyContext = node["privacyContext"].Value<string>();
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["useCategoryEntries"] != null)
			{
				this._UseCategoryEntries = ParseBool(node["useCategoryEntries"].Value<string>());
			}
			if(node["feedContentTypeHeader"] != null)
			{
				this._FeedContentTypeHeader = node["feedContentTypeHeader"].Value<string>();
			}
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

