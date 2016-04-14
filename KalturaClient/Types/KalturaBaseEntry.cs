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
	public class KalturaBaseEntry : KalturaObjectBase
	{
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
		private KalturaEntryStatus _Status = null;
		private KalturaEntryModerationStatus _ModerationStatus = (KalturaEntryModerationStatus)Int32.MinValue;
		private int _ModerationCount = Int32.MinValue;
		private KalturaEntryType _Type = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private float _Rank = Single.MinValue;
		private int _TotalRank = Int32.MinValue;
		private int _Votes = Int32.MinValue;
		private int _GroupId = Int32.MinValue;
		private string _PartnerData = null;
		private string _DownloadUrl = null;
		private string _SearchText = null;
		private KalturaLicenseType _LicenseType = (KalturaLicenseType)Int32.MinValue;
		private int _Version = Int32.MinValue;
		private string _ThumbnailUrl = null;
		private int _AccessControlId = Int32.MinValue;
		private int _StartDate = Int32.MinValue;
		private int _EndDate = Int32.MinValue;
		private string _ReferenceId = null;
		private string _ReplacingEntryId = null;
		private string _ReplacedEntryId = null;
		private KalturaEntryReplacementStatus _ReplacementStatus = null;
		private int _PartnerSortValue = Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private string _RedirectEntryId = null;
		private string _RootEntryId = null;
		private string _ParentEntryId = null;
		private IList<KalturaOperationAttributes> _OperationAttributes;
		private string _EntitledUsersEdit = null;
		private string _EntitledUsersPublish = null;
		private string _Capabilities = null;
		private string _TemplateEntryId = null;
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
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
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
		public KalturaEntryStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaEntryModerationStatus ModerationStatus
		{
			get { return _ModerationStatus; }
			set 
			{ 
				_ModerationStatus = value;
				OnPropertyChanged("ModerationStatus");
			}
		}
		public int ModerationCount
		{
			get { return _ModerationCount; }
			set 
			{ 
				_ModerationCount = value;
				OnPropertyChanged("ModerationCount");
			}
		}
		public KalturaEntryType Type
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
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
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
		public float Rank
		{
			get { return _Rank; }
			set 
			{ 
				_Rank = value;
				OnPropertyChanged("Rank");
			}
		}
		public int TotalRank
		{
			get { return _TotalRank; }
			set 
			{ 
				_TotalRank = value;
				OnPropertyChanged("TotalRank");
			}
		}
		public int Votes
		{
			get { return _Votes; }
			set 
			{ 
				_Votes = value;
				OnPropertyChanged("Votes");
			}
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
			set 
			{ 
				_DownloadUrl = value;
				OnPropertyChanged("DownloadUrl");
			}
		}
		public string SearchText
		{
			get { return _SearchText; }
			set 
			{ 
				_SearchText = value;
				OnPropertyChanged("SearchText");
			}
		}
		public KalturaLicenseType LicenseType
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
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		public string ThumbnailUrl
		{
			get { return _ThumbnailUrl; }
			set 
			{ 
				_ThumbnailUrl = value;
				OnPropertyChanged("ThumbnailUrl");
			}
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
			set 
			{ 
				_ReplacingEntryId = value;
				OnPropertyChanged("ReplacingEntryId");
			}
		}
		public string ReplacedEntryId
		{
			get { return _ReplacedEntryId; }
			set 
			{ 
				_ReplacedEntryId = value;
				OnPropertyChanged("ReplacedEntryId");
			}
		}
		public KalturaEntryReplacementStatus ReplacementStatus
		{
			get { return _ReplacementStatus; }
			set 
			{ 
				_ReplacementStatus = value;
				OnPropertyChanged("ReplacementStatus");
			}
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
			set 
			{ 
				_RootEntryId = value;
				OnPropertyChanged("RootEntryId");
			}
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
		public IList<KalturaOperationAttributes> OperationAttributes
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
		public string Capabilities
		{
			get { return _Capabilities; }
			set 
			{ 
				_Capabilities = value;
				OnPropertyChanged("Capabilities");
			}
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
		#endregion

		#region CTor
		public KalturaBaseEntry()
		{
		}

		public KalturaBaseEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "userId":
						this.UserId = txt;
						continue;
					case "creatorId":
						this.CreatorId = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "adminTags":
						this.AdminTags = txt;
						continue;
					case "categories":
						this.Categories = txt;
						continue;
					case "categoriesIds":
						this.CategoriesIds = txt;
						continue;
					case "status":
						this.Status = (KalturaEntryStatus)KalturaStringEnum.Parse(typeof(KalturaEntryStatus), txt);
						continue;
					case "moderationStatus":
						this.ModerationStatus = (KalturaEntryModerationStatus)ParseEnum(typeof(KalturaEntryModerationStatus), txt);
						continue;
					case "moderationCount":
						this.ModerationCount = ParseInt(txt);
						continue;
					case "type":
						this.Type = (KalturaEntryType)KalturaStringEnum.Parse(typeof(KalturaEntryType), txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "rank":
						this.Rank = ParseFloat(txt);
						continue;
					case "totalRank":
						this.TotalRank = ParseInt(txt);
						continue;
					case "votes":
						this.Votes = ParseInt(txt);
						continue;
					case "groupId":
						this.GroupId = ParseInt(txt);
						continue;
					case "partnerData":
						this.PartnerData = txt;
						continue;
					case "downloadUrl":
						this.DownloadUrl = txt;
						continue;
					case "searchText":
						this.SearchText = txt;
						continue;
					case "licenseType":
						this.LicenseType = (KalturaLicenseType)ParseEnum(typeof(KalturaLicenseType), txt);
						continue;
					case "version":
						this.Version = ParseInt(txt);
						continue;
					case "thumbnailUrl":
						this.ThumbnailUrl = txt;
						continue;
					case "accessControlId":
						this.AccessControlId = ParseInt(txt);
						continue;
					case "startDate":
						this.StartDate = ParseInt(txt);
						continue;
					case "endDate":
						this.EndDate = ParseInt(txt);
						continue;
					case "referenceId":
						this.ReferenceId = txt;
						continue;
					case "replacingEntryId":
						this.ReplacingEntryId = txt;
						continue;
					case "replacedEntryId":
						this.ReplacedEntryId = txt;
						continue;
					case "replacementStatus":
						this.ReplacementStatus = (KalturaEntryReplacementStatus)KalturaStringEnum.Parse(typeof(KalturaEntryReplacementStatus), txt);
						continue;
					case "partnerSortValue":
						this.PartnerSortValue = ParseInt(txt);
						continue;
					case "conversionProfileId":
						this.ConversionProfileId = ParseInt(txt);
						continue;
					case "redirectEntryId":
						this.RedirectEntryId = txt;
						continue;
					case "rootEntryId":
						this.RootEntryId = txt;
						continue;
					case "parentEntryId":
						this.ParentEntryId = txt;
						continue;
					case "operationAttributes":
						this.OperationAttributes = new List<KalturaOperationAttributes>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.OperationAttributes.Add((KalturaOperationAttributes)KalturaObjectFactory.Create(arrayNode, "KalturaOperationAttributes"));
						}
						continue;
					case "entitledUsersEdit":
						this.EntitledUsersEdit = txt;
						continue;
					case "entitledUsersPublish":
						this.EntitledUsersPublish = txt;
						continue;
					case "capabilities":
						this.Capabilities = txt;
						continue;
					case "templateEntryId":
						this.TemplateEntryId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBaseEntry");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("userId", this.UserId);
			kparams.AddIfNotNull("creatorId", this.CreatorId);
			kparams.AddIfNotNull("tags", this.Tags);
			kparams.AddIfNotNull("adminTags", this.AdminTags);
			kparams.AddIfNotNull("categories", this.Categories);
			kparams.AddIfNotNull("categoriesIds", this.CategoriesIds);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("moderationStatus", this.ModerationStatus);
			kparams.AddIfNotNull("moderationCount", this.ModerationCount);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("rank", this.Rank);
			kparams.AddIfNotNull("totalRank", this.TotalRank);
			kparams.AddIfNotNull("votes", this.Votes);
			kparams.AddIfNotNull("groupId", this.GroupId);
			kparams.AddIfNotNull("partnerData", this.PartnerData);
			kparams.AddIfNotNull("downloadUrl", this.DownloadUrl);
			kparams.AddIfNotNull("searchText", this.SearchText);
			kparams.AddIfNotNull("licenseType", this.LicenseType);
			kparams.AddIfNotNull("version", this.Version);
			kparams.AddIfNotNull("thumbnailUrl", this.ThumbnailUrl);
			kparams.AddIfNotNull("accessControlId", this.AccessControlId);
			kparams.AddIfNotNull("startDate", this.StartDate);
			kparams.AddIfNotNull("endDate", this.EndDate);
			kparams.AddIfNotNull("referenceId", this.ReferenceId);
			kparams.AddIfNotNull("replacingEntryId", this.ReplacingEntryId);
			kparams.AddIfNotNull("replacedEntryId", this.ReplacedEntryId);
			kparams.AddIfNotNull("replacementStatus", this.ReplacementStatus);
			kparams.AddIfNotNull("partnerSortValue", this.PartnerSortValue);
			kparams.AddIfNotNull("conversionProfileId", this.ConversionProfileId);
			kparams.AddIfNotNull("redirectEntryId", this.RedirectEntryId);
			kparams.AddIfNotNull("rootEntryId", this.RootEntryId);
			kparams.AddIfNotNull("parentEntryId", this.ParentEntryId);
			kparams.AddIfNotNull("operationAttributes", this.OperationAttributes);
			kparams.AddIfNotNull("entitledUsersEdit", this.EntitledUsersEdit);
			kparams.AddIfNotNull("entitledUsersPublish", this.EntitledUsersPublish);
			kparams.AddIfNotNull("capabilities", this.Capabilities);
			kparams.AddIfNotNull("templateEntryId", this.TemplateEntryId);
			return kparams;
		}
		#endregion
	}
}

