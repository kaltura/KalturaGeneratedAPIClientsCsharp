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
// Copyright (C) 2006-2011  Kaltura Inc.
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
		private bool? _AllowEmbed = false;
		private int _PlayerUiconfId = Int32.MinValue;
		private int _FlavorParamId = Int32.MinValue;
		private bool? _TranscodeExistingContent = false;
		private bool? _AddToDefaultConversionProfile = false;
		private string _Categories = null;
		private int _StorageId = Int32.MinValue;
		private KalturaSyndicationFeedEntriesOrderBy _EntriesOrderBy = null;
		private bool? _EnforceEntitlement = false;
		private string _PrivacyContext = null;
		private int _UpdatedAt = Int32.MinValue;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string FeedUrl
		{
			get { return _FeedUrl; }
			set 
			{ 
				_FeedUrl = value;
				OnPropertyChanged("FeedUrl");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
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
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
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
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
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
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		#endregion

		#region CTor
		public KalturaBaseSyndicationFeed()
		{
		}

		public KalturaBaseSyndicationFeed(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "feedUrl":
						this.FeedUrl = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "playlistId":
						this.PlaylistId = txt;
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "status":
						this.Status = (KalturaSyndicationFeedStatus)ParseEnum(typeof(KalturaSyndicationFeedStatus), txt);
						continue;
					case "type":
						this.Type = (KalturaSyndicationFeedType)ParseEnum(typeof(KalturaSyndicationFeedType), txt);
						continue;
					case "landingPage":
						this.LandingPage = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "allowEmbed":
						this.AllowEmbed = ParseBool(txt);
						continue;
					case "playerUiconfId":
						this.PlayerUiconfId = ParseInt(txt);
						continue;
					case "flavorParamId":
						this.FlavorParamId = ParseInt(txt);
						continue;
					case "transcodeExistingContent":
						this.TranscodeExistingContent = ParseBool(txt);
						continue;
					case "addToDefaultConversionProfile":
						this.AddToDefaultConversionProfile = ParseBool(txt);
						continue;
					case "categories":
						this.Categories = txt;
						continue;
					case "storageId":
						this.StorageId = ParseInt(txt);
						continue;
					case "entriesOrderBy":
						this.EntriesOrderBy = (KalturaSyndicationFeedEntriesOrderBy)KalturaStringEnum.Parse(typeof(KalturaSyndicationFeedEntriesOrderBy), txt);
						continue;
					case "enforceEntitlement":
						this.EnforceEntitlement = ParseBool(txt);
						continue;
					case "privacyContext":
						this.PrivacyContext = txt;
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
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
			kparams.AddStringIfNotNull("id", this.Id);
			kparams.AddStringIfNotNull("feedUrl", this.FeedUrl);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("playlistId", this.PlaylistId);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("landingPage", this.LandingPage);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddBoolIfNotNull("allowEmbed", this.AllowEmbed);
			kparams.AddIntIfNotNull("playerUiconfId", this.PlayerUiconfId);
			kparams.AddIntIfNotNull("flavorParamId", this.FlavorParamId);
			kparams.AddBoolIfNotNull("transcodeExistingContent", this.TranscodeExistingContent);
			kparams.AddBoolIfNotNull("addToDefaultConversionProfile", this.AddToDefaultConversionProfile);
			kparams.AddStringIfNotNull("categories", this.Categories);
			kparams.AddIntIfNotNull("storageId", this.StorageId);
			kparams.AddStringEnumIfNotNull("entriesOrderBy", this.EntriesOrderBy);
			kparams.AddBoolIfNotNull("enforceEntitlement", this.EnforceEntitlement);
			kparams.AddStringIfNotNull("privacyContext", this.PrivacyContext);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			return kparams;
		}
		#endregion
	}
}

