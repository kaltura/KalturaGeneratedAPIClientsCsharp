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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaBulkUploadResultEntry : KalturaBulkUploadResult
	{
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
		private bool? _ThumbnailSaved = false;
		private string _SshPrivateKey = null;
		private string _SshPublicKey = null;
		private string _SshKeyPassphrase = null;
		private string _CreatorId = null;
		private string _EntitledUsersEdit = null;
		private string _EntitledUsersPublish = null;
		private string _OwnerId = null;
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
		#endregion

		#region CTor
		public KalturaBulkUploadResultEntry()
		{
		}

		public KalturaBulkUploadResultEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "entryId":
						this.EntryId = txt;
						continue;
					case "title":
						this.Title = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "url":
						this.Url = txt;
						continue;
					case "contentType":
						this.ContentType = txt;
						continue;
					case "conversionProfileId":
						this.ConversionProfileId = ParseInt(txt);
						continue;
					case "accessControlProfileId":
						this.AccessControlProfileId = ParseInt(txt);
						continue;
					case "category":
						this.Category = txt;
						continue;
					case "scheduleStartDate":
						this.ScheduleStartDate = ParseInt(txt);
						continue;
					case "scheduleEndDate":
						this.ScheduleEndDate = ParseInt(txt);
						continue;
					case "entryStatus":
						this.EntryStatus = ParseInt(txt);
						continue;
					case "thumbnailUrl":
						this.ThumbnailUrl = txt;
						continue;
					case "thumbnailSaved":
						this.ThumbnailSaved = ParseBool(txt);
						continue;
					case "sshPrivateKey":
						this.SshPrivateKey = txt;
						continue;
					case "sshPublicKey":
						this.SshPublicKey = txt;
						continue;
					case "sshKeyPassphrase":
						this.SshKeyPassphrase = txt;
						continue;
					case "creatorId":
						this.CreatorId = txt;
						continue;
					case "entitledUsersEdit":
						this.EntitledUsersEdit = txt;
						continue;
					case "entitledUsersPublish":
						this.EntitledUsersPublish = txt;
						continue;
					case "ownerId":
						this.OwnerId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUploadResultEntry");
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddStringIfNotNull("title", this.Title);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("url", this.Url);
			kparams.AddStringIfNotNull("contentType", this.ContentType);
			kparams.AddIntIfNotNull("conversionProfileId", this.ConversionProfileId);
			kparams.AddIntIfNotNull("accessControlProfileId", this.AccessControlProfileId);
			kparams.AddStringIfNotNull("category", this.Category);
			kparams.AddIntIfNotNull("scheduleStartDate", this.ScheduleStartDate);
			kparams.AddIntIfNotNull("scheduleEndDate", this.ScheduleEndDate);
			kparams.AddIntIfNotNull("entryStatus", this.EntryStatus);
			kparams.AddStringIfNotNull("thumbnailUrl", this.ThumbnailUrl);
			kparams.AddBoolIfNotNull("thumbnailSaved", this.ThumbnailSaved);
			kparams.AddStringIfNotNull("sshPrivateKey", this.SshPrivateKey);
			kparams.AddStringIfNotNull("sshPublicKey", this.SshPublicKey);
			kparams.AddStringIfNotNull("sshKeyPassphrase", this.SshKeyPassphrase);
			kparams.AddStringIfNotNull("creatorId", this.CreatorId);
			kparams.AddStringIfNotNull("entitledUsersEdit", this.EntitledUsersEdit);
			kparams.AddStringIfNotNull("entitledUsersPublish", this.EntitledUsersPublish);
			kparams.AddStringIfNotNull("ownerId", this.OwnerId);
			return kparams;
		}
		#endregion
	}
}

