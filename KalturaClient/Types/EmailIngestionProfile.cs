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
	public class EmailIngestionProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string DESCRIPTION = "description";
		public const string EMAIL_ADDRESS = "emailAddress";
		public const string MAILBOX_ID = "mailboxId";
		public const string PARTNER_ID = "partnerId";
		public const string CONVERSION_PROFILE2ID = "conversionProfile2Id";
		public const string MODERATION_STATUS = "moderationStatus";
		public const string STATUS = "status";
		public const string CREATED_AT = "createdAt";
		public const string DEFAULT_CATEGORY = "defaultCategory";
		public const string DEFAULT_USER_ID = "defaultUserId";
		public const string DEFAULT_TAGS = "defaultTags";
		public const string DEFAULT_ADMIN_TAGS = "defaultAdminTags";
		public const string MAX_ATTACHMENT_SIZE_KBYTES = "maxAttachmentSizeKbytes";
		public const string MAX_ATTACHMENTS_PER_MAIL = "maxAttachmentsPerMail";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private string _EmailAddress = null;
		private string _MailboxId = null;
		private int _PartnerId = Int32.MinValue;
		private int _ConversionProfile2Id = Int32.MinValue;
		private EntryModerationStatus _ModerationStatus = (EntryModerationStatus)Int32.MinValue;
		private EmailIngestionProfileStatus _Status = (EmailIngestionProfileStatus)Int32.MinValue;
		private string _CreatedAt = null;
		private string _DefaultCategory = null;
		private string _DefaultUserId = null;
		private string _DefaultTags = null;
		private string _DefaultAdminTags = null;
		private int _MaxAttachmentSizeKbytes = Int32.MinValue;
		private int _MaxAttachmentsPerMail = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		public string EmailAddress
		{
			get { return _EmailAddress; }
			set 
			{ 
				_EmailAddress = value;
				OnPropertyChanged("EmailAddress");
			}
		}
		[JsonProperty]
		public string MailboxId
		{
			get { return _MailboxId; }
			set 
			{ 
				_MailboxId = value;
				OnPropertyChanged("MailboxId");
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
		public int ConversionProfile2Id
		{
			get { return _ConversionProfile2Id; }
			set 
			{ 
				_ConversionProfile2Id = value;
				OnPropertyChanged("ConversionProfile2Id");
			}
		}
		[JsonProperty]
		public EntryModerationStatus ModerationStatus
		{
			get { return _ModerationStatus; }
			set 
			{ 
				_ModerationStatus = value;
				OnPropertyChanged("ModerationStatus");
			}
		}
		[JsonProperty]
		public EmailIngestionProfileStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public string CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public string DefaultCategory
		{
			get { return _DefaultCategory; }
			set 
			{ 
				_DefaultCategory = value;
				OnPropertyChanged("DefaultCategory");
			}
		}
		[JsonProperty]
		public string DefaultUserId
		{
			get { return _DefaultUserId; }
			set 
			{ 
				_DefaultUserId = value;
				OnPropertyChanged("DefaultUserId");
			}
		}
		[JsonProperty]
		public string DefaultTags
		{
			get { return _DefaultTags; }
			set 
			{ 
				_DefaultTags = value;
				OnPropertyChanged("DefaultTags");
			}
		}
		[JsonProperty]
		public string DefaultAdminTags
		{
			get { return _DefaultAdminTags; }
			set 
			{ 
				_DefaultAdminTags = value;
				OnPropertyChanged("DefaultAdminTags");
			}
		}
		[JsonProperty]
		public int MaxAttachmentSizeKbytes
		{
			get { return _MaxAttachmentSizeKbytes; }
			set 
			{ 
				_MaxAttachmentSizeKbytes = value;
				OnPropertyChanged("MaxAttachmentSizeKbytes");
			}
		}
		[JsonProperty]
		public int MaxAttachmentsPerMail
		{
			get { return _MaxAttachmentsPerMail; }
			set 
			{ 
				_MaxAttachmentsPerMail = value;
				OnPropertyChanged("MaxAttachmentsPerMail");
			}
		}
		#endregion

		#region CTor
		public EmailIngestionProfile()
		{
		}

		public EmailIngestionProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["emailAddress"] != null)
			{
				this._EmailAddress = node["emailAddress"].Value<string>();
			}
			if(node["mailboxId"] != null)
			{
				this._MailboxId = node["mailboxId"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["conversionProfile2Id"] != null)
			{
				this._ConversionProfile2Id = ParseInt(node["conversionProfile2Id"].Value<string>());
			}
			if(node["moderationStatus"] != null)
			{
				this._ModerationStatus = (EntryModerationStatus)ParseEnum(typeof(EntryModerationStatus), node["moderationStatus"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (EmailIngestionProfileStatus)ParseEnum(typeof(EmailIngestionProfileStatus), node["status"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = node["createdAt"].Value<string>();
			}
			if(node["defaultCategory"] != null)
			{
				this._DefaultCategory = node["defaultCategory"].Value<string>();
			}
			if(node["defaultUserId"] != null)
			{
				this._DefaultUserId = node["defaultUserId"].Value<string>();
			}
			if(node["defaultTags"] != null)
			{
				this._DefaultTags = node["defaultTags"].Value<string>();
			}
			if(node["defaultAdminTags"] != null)
			{
				this._DefaultAdminTags = node["defaultAdminTags"].Value<string>();
			}
			if(node["maxAttachmentSizeKbytes"] != null)
			{
				this._MaxAttachmentSizeKbytes = ParseInt(node["maxAttachmentSizeKbytes"].Value<string>());
			}
			if(node["maxAttachmentsPerMail"] != null)
			{
				this._MaxAttachmentsPerMail = ParseInt(node["maxAttachmentsPerMail"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEmailIngestionProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("emailAddress", this._EmailAddress);
			kparams.AddIfNotNull("mailboxId", this._MailboxId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("conversionProfile2Id", this._ConversionProfile2Id);
			kparams.AddIfNotNull("moderationStatus", this._ModerationStatus);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("defaultCategory", this._DefaultCategory);
			kparams.AddIfNotNull("defaultUserId", this._DefaultUserId);
			kparams.AddIfNotNull("defaultTags", this._DefaultTags);
			kparams.AddIfNotNull("defaultAdminTags", this._DefaultAdminTags);
			kparams.AddIfNotNull("maxAttachmentSizeKbytes", this._MaxAttachmentSizeKbytes);
			kparams.AddIfNotNull("maxAttachmentsPerMail", this._MaxAttachmentsPerMail);
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
				case EMAIL_ADDRESS:
					return "EmailAddress";
				case MAILBOX_ID:
					return "MailboxId";
				case PARTNER_ID:
					return "PartnerId";
				case CONVERSION_PROFILE2ID:
					return "ConversionProfile2Id";
				case MODERATION_STATUS:
					return "ModerationStatus";
				case STATUS:
					return "Status";
				case CREATED_AT:
					return "CreatedAt";
				case DEFAULT_CATEGORY:
					return "DefaultCategory";
				case DEFAULT_USER_ID:
					return "DefaultUserId";
				case DEFAULT_TAGS:
					return "DefaultTags";
				case DEFAULT_ADMIN_TAGS:
					return "DefaultAdminTags";
				case MAX_ATTACHMENT_SIZE_KBYTES:
					return "MaxAttachmentSizeKbytes";
				case MAX_ATTACHMENTS_PER_MAIL:
					return "MaxAttachmentsPerMail";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

