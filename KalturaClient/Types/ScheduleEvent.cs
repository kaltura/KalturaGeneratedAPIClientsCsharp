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
using Kaltura.Enums;
using Kaltura.Request;

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
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int ParentId
		{
			get { return _ParentId; }
		}
		public string Summary
		{
			get { return _Summary; }
			set 
			{ 
				_Summary = value;
				OnPropertyChanged("Summary");
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
		public ScheduleEventStatus Status
		{
			get { return _Status; }
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
		public ScheduleEventClassificationType ClassificationType
		{
			get { return _ClassificationType; }
			set 
			{ 
				_ClassificationType = value;
				OnPropertyChanged("ClassificationType");
			}
		}
		public float GeoLatitude
		{
			get { return _GeoLatitude; }
			set 
			{ 
				_GeoLatitude = value;
				OnPropertyChanged("GeoLatitude");
			}
		}
		public float GeoLongitude
		{
			get { return _GeoLongitude; }
			set 
			{ 
				_GeoLongitude = value;
				OnPropertyChanged("GeoLongitude");
			}
		}
		public string Location
		{
			get { return _Location; }
			set 
			{ 
				_Location = value;
				OnPropertyChanged("Location");
			}
		}
		public string Organizer
		{
			get { return _Organizer; }
			set 
			{ 
				_Organizer = value;
				OnPropertyChanged("Organizer");
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
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public int Sequence
		{
			get { return _Sequence; }
			set 
			{ 
				_Sequence = value;
				OnPropertyChanged("Sequence");
			}
		}
		public ScheduleEventRecurrenceType RecurrenceType
		{
			get { return _RecurrenceType; }
			set 
			{ 
				_RecurrenceType = value;
				OnPropertyChanged("RecurrenceType");
			}
		}
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public string Contact
		{
			get { return _Contact; }
			set 
			{ 
				_Contact = value;
				OnPropertyChanged("Contact");
			}
		}
		public string Comment
		{
			get { return _Comment; }
			set 
			{ 
				_Comment = value;
				OnPropertyChanged("Comment");
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
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
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

		public ScheduleEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "parentId":
						this._ParentId = ParseInt(propertyNode.InnerText);
						continue;
					case "summary":
						this._Summary = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (ScheduleEventStatus)ParseEnum(typeof(ScheduleEventStatus), propertyNode.InnerText);
						continue;
					case "startDate":
						this._StartDate = ParseInt(propertyNode.InnerText);
						continue;
					case "endDate":
						this._EndDate = ParseInt(propertyNode.InnerText);
						continue;
					case "referenceId":
						this._ReferenceId = propertyNode.InnerText;
						continue;
					case "classificationType":
						this._ClassificationType = (ScheduleEventClassificationType)ParseEnum(typeof(ScheduleEventClassificationType), propertyNode.InnerText);
						continue;
					case "geoLatitude":
						this._GeoLatitude = ParseFloat(propertyNode.InnerText);
						continue;
					case "geoLongitude":
						this._GeoLongitude = ParseFloat(propertyNode.InnerText);
						continue;
					case "location":
						this._Location = propertyNode.InnerText;
						continue;
					case "organizer":
						this._Organizer = propertyNode.InnerText;
						continue;
					case "ownerId":
						this._OwnerId = propertyNode.InnerText;
						continue;
					case "priority":
						this._Priority = ParseInt(propertyNode.InnerText);
						continue;
					case "sequence":
						this._Sequence = ParseInt(propertyNode.InnerText);
						continue;
					case "recurrenceType":
						this._RecurrenceType = (ScheduleEventRecurrenceType)ParseEnum(typeof(ScheduleEventRecurrenceType), propertyNode.InnerText);
						continue;
					case "duration":
						this._Duration = ParseInt(propertyNode.InnerText);
						continue;
					case "contact":
						this._Contact = propertyNode.InnerText;
						continue;
					case "comment":
						this._Comment = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "recurrence":
						this._Recurrence = ObjectFactory.Create<ScheduleEventRecurrence>(propertyNode);
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

