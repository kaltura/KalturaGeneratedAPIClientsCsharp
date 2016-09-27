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
	public class KalturaScheduleEvent : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _ParentId = Int32.MinValue;
		private string _Summary = null;
		private string _Description = null;
		private KalturaScheduleEventStatus _Status = (KalturaScheduleEventStatus)Int32.MinValue;
		private int _StartDate = Int32.MinValue;
		private int _EndDate = Int32.MinValue;
		private string _ReferenceId = null;
		private KalturaScheduleEventClassificationType _ClassificationType = (KalturaScheduleEventClassificationType)Int32.MinValue;
		private float _GeoLatitude = Single.MinValue;
		private float _GeoLongitude = Single.MinValue;
		private string _Location = null;
		private string _Organizer = null;
		private string _OwnerId = null;
		private int _Priority = Int32.MinValue;
		private int _Sequence = Int32.MinValue;
		private KalturaScheduleEventRecurrenceType _RecurrenceType = (KalturaScheduleEventRecurrenceType)Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private string _Contact = null;
		private string _Comment = null;
		private string _Tags = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private KalturaScheduleEventRecurrence _Recurrence;
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
		public KalturaScheduleEventStatus Status
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
		public KalturaScheduleEventClassificationType ClassificationType
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
		public KalturaScheduleEventRecurrenceType RecurrenceType
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
		public KalturaScheduleEventRecurrence Recurrence
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
		public KalturaScheduleEvent()
		{
		}

		public KalturaScheduleEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "parentId":
						this._ParentId = ParseInt(txt);
						continue;
					case "summary":
						this._Summary = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "status":
						this._Status = (KalturaScheduleEventStatus)ParseEnum(typeof(KalturaScheduleEventStatus), txt);
						continue;
					case "startDate":
						this._StartDate = ParseInt(txt);
						continue;
					case "endDate":
						this._EndDate = ParseInt(txt);
						continue;
					case "referenceId":
						this._ReferenceId = txt;
						continue;
					case "classificationType":
						this._ClassificationType = (KalturaScheduleEventClassificationType)ParseEnum(typeof(KalturaScheduleEventClassificationType), txt);
						continue;
					case "geoLatitude":
						this._GeoLatitude = ParseFloat(txt);
						continue;
					case "geoLongitude":
						this._GeoLongitude = ParseFloat(txt);
						continue;
					case "location":
						this._Location = txt;
						continue;
					case "organizer":
						this._Organizer = txt;
						continue;
					case "ownerId":
						this._OwnerId = txt;
						continue;
					case "priority":
						this._Priority = ParseInt(txt);
						continue;
					case "sequence":
						this._Sequence = ParseInt(txt);
						continue;
					case "recurrenceType":
						this._RecurrenceType = (KalturaScheduleEventRecurrenceType)ParseEnum(typeof(KalturaScheduleEventRecurrenceType), txt);
						continue;
					case "duration":
						this._Duration = ParseInt(txt);
						continue;
					case "contact":
						this._Contact = txt;
						continue;
					case "comment":
						this._Comment = txt;
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "recurrence":
						this._Recurrence = (KalturaScheduleEventRecurrence)KalturaObjectFactory.Create(propertyNode, "KalturaScheduleEventRecurrence");
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

