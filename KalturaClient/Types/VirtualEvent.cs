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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class VirtualEvent : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string DESCRIPTION = "description";
		public const string STATUS = "status";
		public const string TAGS = "tags";
		public const string ATTENDEES_GROUP_IDS = "attendeesGroupIds";
		public const string ADMINS_GROUP_IDS = "adminsGroupIds";
		public const string REGISTRATION_SCHEDULE_EVENT_ID = "registrationScheduleEventId";
		public const string AGENDA_SCHEDULE_EVENT_ID = "agendaScheduleEventId";
		public const string MAIN_EVENT_SCHEDULE_EVENT_ID = "mainEventScheduleEventId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string DELETION_DUE_DATE = "deletionDueDate";
		public const string REGISTRATION_FORM_SCHEMA = "registrationFormSchema";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private VirtualEventStatus _Status = (VirtualEventStatus)Int32.MinValue;
		private string _Tags = null;
		private string _AttendeesGroupIds = null;
		private string _AdminsGroupIds = null;
		private int _RegistrationScheduleEventId = Int32.MinValue;
		private int _AgendaScheduleEventId = Int32.MinValue;
		private int _MainEventScheduleEventId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _DeletionDueDate = Int32.MinValue;
		private string _RegistrationFormSchema = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VirtualEventStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use TagsAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use AttendeesGroupIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AttendeesGroupIds
		{
			get { return _AttendeesGroupIds; }
			set 
			{ 
				_AttendeesGroupIds = value;
				OnPropertyChanged("AttendeesGroupIds");
			}
		}
		/// <summary>
		/// Use AdminsGroupIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdminsGroupIds
		{
			get { return _AdminsGroupIds; }
			set 
			{ 
				_AdminsGroupIds = value;
				OnPropertyChanged("AdminsGroupIds");
			}
		}
		/// <summary>
		/// Use RegistrationScheduleEventIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RegistrationScheduleEventId
		{
			get { return _RegistrationScheduleEventId; }
			set 
			{ 
				_RegistrationScheduleEventId = value;
				OnPropertyChanged("RegistrationScheduleEventId");
			}
		}
		/// <summary>
		/// Use AgendaScheduleEventIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AgendaScheduleEventId
		{
			get { return _AgendaScheduleEventId; }
			set 
			{ 
				_AgendaScheduleEventId = value;
				OnPropertyChanged("AgendaScheduleEventId");
			}
		}
		/// <summary>
		/// Use MainEventScheduleEventIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MainEventScheduleEventId
		{
			get { return _MainEventScheduleEventId; }
			set 
			{ 
				_MainEventScheduleEventId = value;
				OnPropertyChanged("MainEventScheduleEventId");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DeletionDueDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DeletionDueDate
		{
			get { return _DeletionDueDate; }
			set 
			{ 
				_DeletionDueDate = value;
				OnPropertyChanged("DeletionDueDate");
			}
		}
		/// <summary>
		/// Use RegistrationFormSchemaAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RegistrationFormSchema
		{
			get { return _RegistrationFormSchema; }
			set 
			{ 
				_RegistrationFormSchema = value;
				OnPropertyChanged("RegistrationFormSchema");
			}
		}
		#endregion

		#region CTor
		public VirtualEvent()
		{
		}

		public VirtualEvent(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (VirtualEventStatus)ParseEnum(typeof(VirtualEventStatus), node["status"].Value<string>());
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["attendeesGroupIds"] != null)
			{
				this._AttendeesGroupIds = node["attendeesGroupIds"].Value<string>();
			}
			if(node["adminsGroupIds"] != null)
			{
				this._AdminsGroupIds = node["adminsGroupIds"].Value<string>();
			}
			if(node["registrationScheduleEventId"] != null)
			{
				this._RegistrationScheduleEventId = ParseInt(node["registrationScheduleEventId"].Value<string>());
			}
			if(node["agendaScheduleEventId"] != null)
			{
				this._AgendaScheduleEventId = ParseInt(node["agendaScheduleEventId"].Value<string>());
			}
			if(node["mainEventScheduleEventId"] != null)
			{
				this._MainEventScheduleEventId = ParseInt(node["mainEventScheduleEventId"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["deletionDueDate"] != null)
			{
				this._DeletionDueDate = ParseInt(node["deletionDueDate"].Value<string>());
			}
			if(node["registrationFormSchema"] != null)
			{
				this._RegistrationFormSchema = node["registrationFormSchema"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVirtualEvent");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("attendeesGroupIds", this._AttendeesGroupIds);
			kparams.AddIfNotNull("adminsGroupIds", this._AdminsGroupIds);
			kparams.AddIfNotNull("registrationScheduleEventId", this._RegistrationScheduleEventId);
			kparams.AddIfNotNull("agendaScheduleEventId", this._AgendaScheduleEventId);
			kparams.AddIfNotNull("mainEventScheduleEventId", this._MainEventScheduleEventId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("deletionDueDate", this._DeletionDueDate);
			kparams.AddIfNotNull("registrationFormSchema", this._RegistrationFormSchema);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case DESCRIPTION:
					return "Description";
				case STATUS:
					return "Status";
				case TAGS:
					return "Tags";
				case ATTENDEES_GROUP_IDS:
					return "AttendeesGroupIds";
				case ADMINS_GROUP_IDS:
					return "AdminsGroupIds";
				case REGISTRATION_SCHEDULE_EVENT_ID:
					return "RegistrationScheduleEventId";
				case AGENDA_SCHEDULE_EVENT_ID:
					return "AgendaScheduleEventId";
				case MAIN_EVENT_SCHEDULE_EVENT_ID:
					return "MainEventScheduleEventId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case DELETION_DUE_DATE:
					return "DeletionDueDate";
				case REGISTRATION_FORM_SCHEMA:
					return "RegistrationFormSchema";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

