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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class BulkUploadResultEntry : BulkUploadResult
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string TITLE = "title";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string URL = "url";
		public const string CONTENT_TYPE = "contentType";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string ACCESS_CONTROL_PROFILE_ID = "accessControlProfileId";
		public const string CATEGORY = "category";
		public const string SCHEDULE_START_DATE = "scheduleStartDate";
		public const string SCHEDULE_END_DATE = "scheduleEndDate";
		public const string ENTRY_STATUS = "entryStatus";
		public const string THUMBNAIL_URL = "thumbnailUrl";
		public const string THUMBNAIL_SAVED = "thumbnailSaved";
		public const string SSH_PRIVATE_KEY = "sshPrivateKey";
		public const string SSH_PUBLIC_KEY = "sshPublicKey";
		public const string SSH_KEY_PASSPHRASE = "sshKeyPassphrase";
		public const string CREATOR_ID = "creatorId";
		public const string ENTITLED_USERS_EDIT = "entitledUsersEdit";
		public const string ENTITLED_USERS_PUBLISH = "entitledUsersPublish";
		public const string OWNER_ID = "ownerId";
		public const string REFERENCE_ID = "referenceId";
		public const string TEMPLATE_ENTRY_ID = "templateEntryId";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private string _Title = null;
		private string _Description = null;
		private string _Tags = null;
		private string _Url = null;
		private string _ContentType = null;
		private int _ConversionProfileId = Int32.MinValue;
		private int _AccessControlProfileId = Int32.MinValue;
		private string _Category = null;
		private int _ScheduleStartDate = Int32.MinValue;
		private int _ScheduleEndDate = Int32.MinValue;
		private int _EntryStatus = Int32.MinValue;
		private string _ThumbnailUrl = null;
		private bool? _ThumbnailSaved = null;
		private string _SshPrivateKey = null;
		private string _SshPublicKey = null;
		private string _SshKeyPassphrase = null;
		private string _CreatorId = null;
		private string _EntitledUsersEdit = null;
		private string _EntitledUsersPublish = null;
		private string _OwnerId = null;
		private string _ReferenceId = null;
		private string _TemplateEntryId = null;
		#endregion

		#region Properties
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
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
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public string ContentType
		{
			get { return _ContentType; }
			set 
			{ 
				_ContentType = value;
				OnPropertyChanged("ContentType");
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
		public int AccessControlProfileId
		{
			get { return _AccessControlProfileId; }
			set 
			{ 
				_AccessControlProfileId = value;
				OnPropertyChanged("AccessControlProfileId");
			}
		}
		public string Category
		{
			get { return _Category; }
			set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		public int ScheduleStartDate
		{
			get { return _ScheduleStartDate; }
			set 
			{ 
				_ScheduleStartDate = value;
				OnPropertyChanged("ScheduleStartDate");
			}
		}
		public int ScheduleEndDate
		{
			get { return _ScheduleEndDate; }
			set 
			{ 
				_ScheduleEndDate = value;
				OnPropertyChanged("ScheduleEndDate");
			}
		}
		public int EntryStatus
		{
			get { return _EntryStatus; }
			set 
			{ 
				_EntryStatus = value;
				OnPropertyChanged("EntryStatus");
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
		public bool? ThumbnailSaved
		{
			get { return _ThumbnailSaved; }
			set 
			{ 
				_ThumbnailSaved = value;
				OnPropertyChanged("ThumbnailSaved");
			}
		}
		public string SshPrivateKey
		{
			get { return _SshPrivateKey; }
			set 
			{ 
				_SshPrivateKey = value;
				OnPropertyChanged("SshPrivateKey");
			}
		}
		public string SshPublicKey
		{
			get { return _SshPublicKey; }
			set 
			{ 
				_SshPublicKey = value;
				OnPropertyChanged("SshPublicKey");
			}
		}
		public string SshKeyPassphrase
		{
			get { return _SshKeyPassphrase; }
			set 
			{ 
				_SshKeyPassphrase = value;
				OnPropertyChanged("SshKeyPassphrase");
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
		public string OwnerId
		{
			get { return _OwnerId; }
			set 
			{ 
				_OwnerId = value;
				OnPropertyChanged("OwnerId");
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
		public BulkUploadResultEntry()
		{
		}

		public BulkUploadResultEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "title":
						this._Title = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "url":
						this._Url = propertyNode.InnerText;
						continue;
					case "contentType":
						this._ContentType = propertyNode.InnerText;
						continue;
					case "conversionProfileId":
						this._ConversionProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "accessControlProfileId":
						this._AccessControlProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "category":
						this._Category = propertyNode.InnerText;
						continue;
					case "scheduleStartDate":
						this._ScheduleStartDate = ParseInt(propertyNode.InnerText);
						continue;
					case "scheduleEndDate":
						this._ScheduleEndDate = ParseInt(propertyNode.InnerText);
						continue;
					case "entryStatus":
						this._EntryStatus = ParseInt(propertyNode.InnerText);
						continue;
					case "thumbnailUrl":
						this._ThumbnailUrl = propertyNode.InnerText;
						continue;
					case "thumbnailSaved":
						this._ThumbnailSaved = ParseBool(propertyNode.InnerText);
						continue;
					case "sshPrivateKey":
						this._SshPrivateKey = propertyNode.InnerText;
						continue;
					case "sshPublicKey":
						this._SshPublicKey = propertyNode.InnerText;
						continue;
					case "sshKeyPassphrase":
						this._SshKeyPassphrase = propertyNode.InnerText;
						continue;
					case "creatorId":
						this._CreatorId = propertyNode.InnerText;
						continue;
					case "entitledUsersEdit":
						this._EntitledUsersEdit = propertyNode.InnerText;
						continue;
					case "entitledUsersPublish":
						this._EntitledUsersPublish = propertyNode.InnerText;
						continue;
					case "ownerId":
						this._OwnerId = propertyNode.InnerText;
						continue;
					case "referenceId":
						this._ReferenceId = propertyNode.InnerText;
						continue;
					case "templateEntryId":
						this._TemplateEntryId = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaBulkUploadResultEntry");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("contentType", this._ContentType);
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("accessControlProfileId", this._AccessControlProfileId);
			kparams.AddIfNotNull("category", this._Category);
			kparams.AddIfNotNull("scheduleStartDate", this._ScheduleStartDate);
			kparams.AddIfNotNull("scheduleEndDate", this._ScheduleEndDate);
			kparams.AddIfNotNull("entryStatus", this._EntryStatus);
			kparams.AddIfNotNull("thumbnailUrl", this._ThumbnailUrl);
			kparams.AddIfNotNull("thumbnailSaved", this._ThumbnailSaved);
			kparams.AddIfNotNull("sshPrivateKey", this._SshPrivateKey);
			kparams.AddIfNotNull("sshPublicKey", this._SshPublicKey);
			kparams.AddIfNotNull("sshKeyPassphrase", this._SshKeyPassphrase);
			kparams.AddIfNotNull("creatorId", this._CreatorId);
			kparams.AddIfNotNull("entitledUsersEdit", this._EntitledUsersEdit);
			kparams.AddIfNotNull("entitledUsersPublish", this._EntitledUsersPublish);
			kparams.AddIfNotNull("ownerId", this._OwnerId);
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("templateEntryId", this._TemplateEntryId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case TITLE:
					return "Title";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
				case URL:
					return "Url";
				case CONTENT_TYPE:
					return "ContentType";
				case CONVERSION_PROFILE_ID:
					return "ConversionProfileId";
				case ACCESS_CONTROL_PROFILE_ID:
					return "AccessControlProfileId";
				case CATEGORY:
					return "Category";
				case SCHEDULE_START_DATE:
					return "ScheduleStartDate";
				case SCHEDULE_END_DATE:
					return "ScheduleEndDate";
				case ENTRY_STATUS:
					return "EntryStatus";
				case THUMBNAIL_URL:
					return "ThumbnailUrl";
				case THUMBNAIL_SAVED:
					return "ThumbnailSaved";
				case SSH_PRIVATE_KEY:
					return "SshPrivateKey";
				case SSH_PUBLIC_KEY:
					return "SshPublicKey";
				case SSH_KEY_PASSPHRASE:
					return "SshKeyPassphrase";
				case CREATOR_ID:
					return "CreatorId";
				case ENTITLED_USERS_EDIT:
					return "EntitledUsersEdit";
				case ENTITLED_USERS_PUBLISH:
					return "EntitledUsersPublish";
				case OWNER_ID:
					return "OwnerId";
				case REFERENCE_ID:
					return "ReferenceId";
				case TEMPLATE_ENTRY_ID:
					return "TemplateEntryId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

