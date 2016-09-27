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
	public class KalturaBaseSyndicationFeed : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private string _FeedUrl = null;
		private int _PartnerId = Int32.MinValue;
		private string _PlaylistId = null;
		private string _Name = null;
		private KalturaSyndicationFeedStatus _Status = (KalturaSyndicationFeedStatus)Int32.MinValue;
		private KalturaSyndicationFeedType _Type = (KalturaSyndicationFeedType)Int32.MinValue;
		private string _LandingPage = null;
		private int _CreatedAt = Int32.MinValue;
		private bool? _AllowEmbed = null;
		private int _PlayerUiconfId = Int32.MinValue;
		private int _FlavorParamId = Int32.MinValue;
		private bool? _TranscodeExistingContent = null;
		private bool? _AddToDefaultConversionProfile = null;
		private string _Categories = null;
		private int _StorageId = Int32.MinValue;
		private KalturaSyndicationFeedEntriesOrderBy _EntriesOrderBy = null;
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
		public KalturaSyndicationFeedStatus Status
		{
			get { return _Status; }
		}
		public KalturaSyndicationFeedType Type
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
		public KalturaSyndicationFeedEntriesOrderBy EntriesOrderBy
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
		public KalturaBaseSyndicationFeed()
		{
		}

		public KalturaBaseSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = txt;
						continue;
					case "feedUrl":
						this._FeedUrl = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "playlistId":
						this._PlaylistId = txt;
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "status":
						this._Status = (KalturaSyndicationFeedStatus)ParseEnum(typeof(KalturaSyndicationFeedStatus), txt);
						continue;
					case "type":
						this._Type = (KalturaSyndicationFeedType)ParseEnum(typeof(KalturaSyndicationFeedType), txt);
						continue;
					case "landingPage":
						this._LandingPage = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "allowEmbed":
						this._AllowEmbed = ParseBool(txt);
						continue;
					case "playerUiconfId":
						this._PlayerUiconfId = ParseInt(txt);
						continue;
					case "flavorParamId":
						this._FlavorParamId = ParseInt(txt);
						continue;
					case "transcodeExistingContent":
						this._TranscodeExistingContent = ParseBool(txt);
						continue;
					case "addToDefaultConversionProfile":
						this._AddToDefaultConversionProfile = ParseBool(txt);
						continue;
					case "categories":
						this._Categories = txt;
						continue;
					case "storageId":
						this._StorageId = ParseInt(txt);
						continue;
					case "entriesOrderBy":
						this._EntriesOrderBy = (KalturaSyndicationFeedEntriesOrderBy)KalturaStringEnum.Parse(typeof(KalturaSyndicationFeedEntriesOrderBy), txt);
						continue;
					case "enforceEntitlement":
						this._EnforceEntitlement = ParseBool(txt);
						continue;
					case "privacyContext":
						this._PrivacyContext = txt;
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "useCategoryEntries":
						this._UseCategoryEntries = ParseBool(txt);
						continue;
					case "feedContentTypeHeader":
						this._FeedContentTypeHeader = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

