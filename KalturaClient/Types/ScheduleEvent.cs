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
	public class ScheduleEvent : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string PARENT_ID = "parentId";
		public const string SUMMARY = "summary";
		public const string DESCRIPTION = "description";
		public const string STATUS = "status";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string REFERENCE_ID = "referenceId";
		public const string CLASSIFICATION_TYPE = "classificationType";
		public const string GEO_LATITUDE = "geoLatitude";
		public const string GEO_LONGITUDE = "geoLongitude";
		public const string LOCATION = "location";
		public const string ORGANIZER = "organizer";
		public const string OWNER_ID = "ownerId";
		public const string PRIORITY = "priority";
		public const string SEQUENCE = "sequence";
		public const string RECURRENCE_TYPE = "recurrenceType";
		public const string DURATION = "duration";
		public const string CONTACT = "contact";
		public const string COMMENT = "comment";
		public const string TAGS = "tags";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string RECURRENCE = "recurrence";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _ParentId = Int32.MinValue;
		private string _Summary = null;
		private string _Description = null;
		private ScheduleEventStatus _Status = (ScheduleEventStatus)Int32.MinValue;
		private int _StartDate = Int32.MinValue;
		private int _EndDate = Int32.MinValue;
		private string _ReferenceId = null;
		private ScheduleEventClassificationType _ClassificationType = (ScheduleEventClassificationType)Int32.MinValue;
		private float _GeoLatitude = Single.MinValue;
		private float _GeoLongitude = Single.MinValue;
		private string _Location = null;
		private string _Organizer = null;
		private string _OwnerId = null;
		private int _Priority = Int32.MinValue;
		private int _Sequence = Int32.MinValue;
		private ScheduleEventRecurrenceType _RecurrenceType = (ScheduleEventRecurrenceType)Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private string _Contact = null;
		private string _Comment = null;
		private string _Tags = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private ScheduleEventRecurrence _Recurrence;
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
		public int ParentId
		{
			get { return _ParentId; }
			private set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		[JsonProperty]
		public string Summary
		{
			get { return _Summary; }
			set 
			{ 
				_Summary = value;
				OnPropertyChanged("Summary");
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
		public ScheduleEventStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public int StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		[JsonProperty]
		public int EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
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
		public ScheduleEventClassificationType ClassificationType
		{
			get { return _ClassificationType; }
			set 
			{ 
				_ClassificationType = value;
				OnPropertyChanged("ClassificationType");
			}
		}
		[JsonProperty]
		public float GeoLatitude
		{
			get { return _GeoLatitude; }
			set 
			{ 
				_GeoLatitude = value;
				OnPropertyChanged("GeoLatitude");
			}
		}
		[JsonProperty]
		public float GeoLongitude
		{
			get { return _GeoLongitude; }
			set 
			{ 
				_GeoLongitude = value;
				OnPropertyChanged("GeoLongitude");
			}
		}
		[JsonProperty]
		public string Location
		{
			get { return _Location; }
			set 
			{ 
				_Location = value;
				OnPropertyChanged("Location");
			}
		}
		[JsonProperty]
		public string Organizer
		{
			get { return _Organizer; }
			set 
			{ 
				_Organizer = value;
				OnPropertyChanged("Organizer");
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
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		[JsonProperty]
		public int Sequence
		{
			get { return _Sequence; }
			set 
			{ 
				_Sequence = value;
				OnPropertyChanged("Sequence");
			}
		}
		[JsonProperty]
		public ScheduleEventRecurrenceType RecurrenceType
		{
			get { return _RecurrenceType; }
			set 
			{ 
				_RecurrenceType = value;
				OnPropertyChanged("RecurrenceType");
			}
		}
		[JsonProperty]
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		[JsonProperty]
		public string Contact
		{
			get { return _Contact; }
			set 
			{ 
				_Contact = value;
				OnPropertyChanged("Contact");
			}
		}
		[JsonProperty]
		public string Comment
		{
			get { return _Comment; }
			set 
			{ 
				_Comment = value;
				OnPropertyChanged("Comment");
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
		public ScheduleEventRecurrence Recurrence
		{
			get { return _Recurrence; }
			set 
			{ 
				_Recurrence = value;
				OnPropertyChanged("Recurrence");
			}
		}
		#endregion

		#region CTor
		public ScheduleEvent()
		{
		}

		public ScheduleEvent(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["parentId"] != null)
			{
				this._ParentId = ParseInt(node["parentId"].Value<string>());
			}
			if(node["summary"] != null)
			{
				this._Summary = node["summary"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (ScheduleEventStatus)ParseEnum(typeof(ScheduleEventStatus), node["status"].Value<string>());
			}
			if(node["startDate"] != null)
			{
				this._StartDate = ParseInt(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseInt(node["endDate"].Value<string>());
			}
			if(node["referenceId"] != null)
			{
				this._ReferenceId = node["referenceId"].Value<string>();
			}
			if(node["classificationType"] != null)
			{
				this._ClassificationType = (ScheduleEventClassificationType)ParseEnum(typeof(ScheduleEventClassificationType), node["classificationType"].Value<string>());
			}
			if(node["geoLatitude"] != null)
			{
				this._GeoLatitude = ParseFloat(node["geoLatitude"].Value<string>());
			}
			if(node["geoLongitude"] != null)
			{
				this._GeoLongitude = ParseFloat(node["geoLongitude"].Value<string>());
			}
			if(node["location"] != null)
			{
				this._Location = node["location"].Value<string>();
			}
			if(node["organizer"] != null)
			{
				this._Organizer = node["organizer"].Value<string>();
			}
			if(node["ownerId"] != null)
			{
				this._OwnerId = node["ownerId"].Value<string>();
			}
			if(node["priority"] != null)
			{
				this._Priority = ParseInt(node["priority"].Value<string>());
			}
			if(node["sequence"] != null)
			{
				this._Sequence = ParseInt(node["sequence"].Value<string>());
			}
			if(node["recurrenceType"] != null)
			{
				this._RecurrenceType = (ScheduleEventRecurrenceType)ParseEnum(typeof(ScheduleEventRecurrenceType), node["recurrenceType"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["contact"] != null)
			{
				this._Contact = node["contact"].Value<string>();
			}
			if(node["comment"] != null)
			{
				this._Comment = node["comment"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["recurrence"] != null)
			{
				this._Recurrence = ObjectFactory.Create<ScheduleEventRecurrence>(node["recurrence"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduleEvent");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("summary", this._Summary);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("classificationType", this._ClassificationType);
			kparams.AddIfNotNull("geoLatitude", this._GeoLatitude);
			kparams.AddIfNotNull("geoLongitude", this._GeoLongitude);
			kparams.AddIfNotNull("location", this._Location);
			kparams.AddIfNotNull("organizer", this._Organizer);
			kparams.AddIfNotNull("ownerId", this._OwnerId);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("sequence", this._Sequence);
			kparams.AddIfNotNull("recurrenceType", this._RecurrenceType);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("contact", this._Contact);
			kparams.AddIfNotNull("comment", this._Comment);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("recurrence", this._Recurrence);
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
				case PARENT_ID:
					return "ParentId";
				case SUMMARY:
					return "Summary";
				case DESCRIPTION:
					return "Description";
				case STATUS:
					return "Status";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case REFERENCE_ID:
					return "ReferenceId";
				case CLASSIFICATION_TYPE:
					return "ClassificationType";
				case GEO_LATITUDE:
					return "GeoLatitude";
				case GEO_LONGITUDE:
					return "GeoLongitude";
				case LOCATION:
					return "Location";
				case ORGANIZER:
					return "Organizer";
				case OWNER_ID:
					return "OwnerId";
				case PRIORITY:
					return "Priority";
				case SEQUENCE:
					return "Sequence";
				case RECURRENCE_TYPE:
					return "RecurrenceType";
				case DURATION:
					return "Duration";
				case CONTACT:
					return "Contact";
				case COMMENT:
					return "Comment";
				case TAGS:
					return "Tags";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case RECURRENCE:
					return "Recurrence";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

