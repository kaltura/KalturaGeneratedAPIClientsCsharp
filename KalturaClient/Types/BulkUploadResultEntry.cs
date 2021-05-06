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
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
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
		[JsonProperty]
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		[JsonProperty]
		public string ContentType
		{
			get { return _ContentType; }
			set 
			{ 
				_ContentType = value;
				OnPropertyChanged("ContentType");
			}
		}
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
		[JsonProperty]
		public int AccessControlProfileId
		{
			get { return _AccessControlProfileId; }
			set 
			{ 
				_AccessControlProfileId = value;
				OnPropertyChanged("AccessControlProfileId");
			}
		}
		[JsonProperty]
		public string Category
		{
			get { return _Category; }
			set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		[JsonProperty]
		public int ScheduleStartDate
		{
			get { return _ScheduleStartDate; }
			set 
			{ 
				_ScheduleStartDate = value;
				OnPropertyChanged("ScheduleStartDate");
			}
		}
		[JsonProperty]
		public int ScheduleEndDate
		{
			get { return _ScheduleEndDate; }
			set 
			{ 
				_ScheduleEndDate = value;
				OnPropertyChanged("ScheduleEndDate");
			}
		}
		[JsonProperty]
		public int EntryStatus
		{
			get { return _EntryStatus; }
			set 
			{ 
				_EntryStatus = value;
				OnPropertyChanged("EntryStatus");
			}
		}
		[JsonProperty]
		public string ThumbnailUrl
		{
			get { return _ThumbnailUrl; }
			set 
			{ 
				_ThumbnailUrl = value;
				OnPropertyChanged("ThumbnailUrl");
			}
		}
		[JsonProperty]
		public bool? ThumbnailSaved
		{
			get { return _ThumbnailSaved; }
			set 
			{ 
				_ThumbnailSaved = value;
				OnPropertyChanged("ThumbnailSaved");
			}
		}
		[JsonProperty]
		public string SshPrivateKey
		{
			get { return _SshPrivateKey; }
			set 
			{ 
				_SshPrivateKey = value;
				OnPropertyChanged("SshPrivateKey");
			}
		}
		[JsonProperty]
		public string SshPublicKey
		{
			get { return _SshPublicKey; }
			set 
			{ 
				_SshPublicKey = value;
				OnPropertyChanged("SshPublicKey");
			}
		}
		[JsonProperty]
		public string SshKeyPassphrase
		{
			get { return _SshKeyPassphrase; }
			set 
			{ 
				_SshKeyPassphrase = value;
				OnPropertyChanged("SshKeyPassphrase");
			}
		}
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
		[JsonProperty]
		public string OwnerId
		{
			get { return _OwnerId; }
			set 
			{ 
				_OwnerId = value;
				OnPropertyChanged("OwnerId");
			}
		}
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
		#endregion

		#region CTor
		public BulkUploadResultEntry()
		{
		}

		public BulkUploadResultEntry(JToken node) : base(node)
		{
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["title"] != null)
			{
				this._Title = node["title"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["url"] != null)
			{
				this._Url = node["url"].Value<string>();
			}
			if(node["contentType"] != null)
			{
				this._ContentType = node["contentType"].Value<string>();
			}
			if(node["conversionProfileId"] != null)
			{
				this._ConversionProfileId = ParseInt(node["conversionProfileId"].Value<string>());
			}
			if(node["accessControlProfileId"] != null)
			{
				this._AccessControlProfileId = ParseInt(node["accessControlProfileId"].Value<string>());
			}
			if(node["category"] != null)
			{
				this._Category = node["category"].Value<string>();
			}
			if(node["scheduleStartDate"] != null)
			{
				this._ScheduleStartDate = ParseInt(node["scheduleStartDate"].Value<string>());
			}
			if(node["scheduleEndDate"] != null)
			{
				this._ScheduleEndDate = ParseInt(node["scheduleEndDate"].Value<string>());
			}
			if(node["entryStatus"] != null)
			{
				this._EntryStatus = ParseInt(node["entryStatus"].Value<string>());
			}
			if(node["thumbnailUrl"] != null)
			{
				this._ThumbnailUrl = node["thumbnailUrl"].Value<string>();
			}
			if(node["thumbnailSaved"] != null)
			{
				this._ThumbnailSaved = ParseBool(node["thumbnailSaved"].Value<string>());
			}
			if(node["sshPrivateKey"] != null)
			{
				this._SshPrivateKey = node["sshPrivateKey"].Value<string>();
			}
			if(node["sshPublicKey"] != null)
			{
				this._SshPublicKey = node["sshPublicKey"].Value<string>();
			}
			if(node["sshKeyPassphrase"] != null)
			{
				this._SshKeyPassphrase = node["sshKeyPassphrase"].Value<string>();
			}
			if(node["creatorId"] != null)
			{
				this._CreatorId = node["creatorId"].Value<string>();
			}
			if(node["entitledUsersEdit"] != null)
			{
				this._EntitledUsersEdit = node["entitledUsersEdit"].Value<string>();
			}
			if(node["entitledUsersPublish"] != null)
			{
				this._EntitledUsersPublish = node["entitledUsersPublish"].Value<string>();
			}
			if(node["ownerId"] != null)
			{
				this._OwnerId = node["ownerId"].Value<string>();
			}
			if(node["referenceId"] != null)
			{
				this._ReferenceId = node["referenceId"].Value<string>();
			}
			if(node["templateEntryId"] != null)
			{
				this._TemplateEntryId = node["templateEntryId"].Value<string>();
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

