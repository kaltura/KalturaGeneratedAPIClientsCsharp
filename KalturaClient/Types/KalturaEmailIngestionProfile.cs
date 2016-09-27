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
	public class KalturaEmailIngestionProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private string _EmailAddress = null;
		private string _MailboxId = null;
		private int _PartnerId = Int32.MinValue;
		private int _ConversionProfile2Id = Int32.MinValue;
		private KalturaEntryModerationStatus _ModerationStatus = (KalturaEntryModerationStatus)Int32.MinValue;
		private KalturaEmailIngestionProfileStatus _Status = (KalturaEmailIngestionProfileStatus)Int32.MinValue;
		private string _CreatedAt = null;
		private string _DefaultCategory = null;
		private string _DefaultUserId = null;
		private string _DefaultTags = null;
		private string _DefaultAdminTags = null;
		private int _MaxAttachmentSizeKbytes = Int32.MinValue;
		private int _MaxAttachmentsPerMail = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
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
		public string EmailAddress
		{
			get { return _EmailAddress; }
			set 
			{ 
				_EmailAddress = value;
				OnPropertyChanged("EmailAddress");
			}
		}
		public string MailboxId
		{
			get { return _MailboxId; }
			set 
			{ 
				_MailboxId = value;
				OnPropertyChanged("MailboxId");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int ConversionProfile2Id
		{
			get { return _ConversionProfile2Id; }
			set 
			{ 
				_ConversionProfile2Id = value;
				OnPropertyChanged("ConversionProfile2Id");
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
		public KalturaEmailIngestionProfileStatus Status
		{
			get { return _Status; }
		}
		public string CreatedAt
		{
			get { return _CreatedAt; }
		}
		public string DefaultCategory
		{
			get { return _DefaultCategory; }
			set 
			{ 
				_DefaultCategory = value;
				OnPropertyChanged("DefaultCategory");
			}
		}
		public string DefaultUserId
		{
			get { return _DefaultUserId; }
			set 
			{ 
				_DefaultUserId = value;
				OnPropertyChanged("DefaultUserId");
			}
		}
		public string DefaultTags
		{
			get { return _DefaultTags; }
			set 
			{ 
				_DefaultTags = value;
				OnPropertyChanged("DefaultTags");
			}
		}
		public string DefaultAdminTags
		{
			get { return _DefaultAdminTags; }
			set 
			{ 
				_DefaultAdminTags = value;
				OnPropertyChanged("DefaultAdminTags");
			}
		}
		public int MaxAttachmentSizeKbytes
		{
			get { return _MaxAttachmentSizeKbytes; }
			set 
			{ 
				_MaxAttachmentSizeKbytes = value;
				OnPropertyChanged("MaxAttachmentSizeKbytes");
			}
		}
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
		public KalturaEmailIngestionProfile()
		{
		}

		public KalturaEmailIngestionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "emailAddress":
						this._EmailAddress = txt;
						continue;
					case "mailboxId":
						this._MailboxId = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "conversionProfile2Id":
						this._ConversionProfile2Id = ParseInt(txt);
						continue;
					case "moderationStatus":
						this._ModerationStatus = (KalturaEntryModerationStatus)ParseEnum(typeof(KalturaEntryModerationStatus), txt);
						continue;
					case "status":
						this._Status = (KalturaEmailIngestionProfileStatus)ParseEnum(typeof(KalturaEmailIngestionProfileStatus), txt);
						continue;
					case "createdAt":
						this._CreatedAt = txt;
						continue;
					case "defaultCategory":
						this._DefaultCategory = txt;
						continue;
					case "defaultUserId":
						this._DefaultUserId = txt;
						continue;
					case "defaultTags":
						this._DefaultTags = txt;
						continue;
					case "defaultAdminTags":
						this._DefaultAdminTags = txt;
						continue;
					case "maxAttachmentSizeKbytes":
						this._MaxAttachmentSizeKbytes = ParseInt(txt);
						continue;
					case "maxAttachmentsPerMail":
						this._MaxAttachmentsPerMail = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

