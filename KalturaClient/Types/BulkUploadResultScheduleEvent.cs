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
	public class BulkUploadResultScheduleEvent : BulkUploadResult
	{
		#region Constants
		public const string REFERENCE_ID = "referenceId";
		public const string TEMPLATE_ENTRY_ID = "templateEntryId";
		public const string EVENT_TYPE = "eventType";
		public const string TITLE = "title";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string CATEGORY_IDS = "categoryIds";
		public const string RESOURCE_ID = "resourceId";
		public const string START_TIME = "startTime";
		public const string DURATION = "duration";
		public const string END_TIME = "endTime";
		public const string RECURRENCE = "recurrence";
		public const string CO_EDITORS = "coEditors";
		public const string CO_PUBLISHERS = "coPublishers";
		public const string EVENT_ORGANIZER_ID = "eventOrganizerId";
		public const string CONTENT_OWNER_ID = "contentOwnerId";
		public const string TEMPLATE_ENTRY_TYPE = "templateEntryType";
		#endregion

		#region Private Fields
		private string _ReferenceId = null;
		private string _TemplateEntryId = null;
		private int _EventType = Int32.MinValue;
		private string _Title = null;
		private string _Description = null;
		private string _Tags = null;
		private string _CategoryIds = null;
		private string _ResourceId = null;
		private int _StartTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _EndTime = Int32.MinValue;
		private string _Recurrence = null;
		private string _CoEditors = null;
		private string _CoPublishers = null;
		private string _EventOrganizerId = null;
		private string _ContentOwnerId = null;
		private string _TemplateEntryType = null;
		#endregion

		#region Properties
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
		[JsonProperty]
		public int EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
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
		public string CategoryIds
		{
			get { return _CategoryIds; }
			set 
			{ 
				_CategoryIds = value;
				OnPropertyChanged("CategoryIds");
			}
		}
		[JsonProperty]
		public string ResourceId
		{
			get { return _ResourceId; }
			set 
			{ 
				_ResourceId = value;
				OnPropertyChanged("ResourceId");
			}
		}
		[JsonProperty]
		public int StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
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
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		[JsonProperty]
		public string Recurrence
		{
			get { return _Recurrence; }
			set 
			{ 
				_Recurrence = value;
				OnPropertyChanged("Recurrence");
			}
		}
		[JsonProperty]
		public string CoEditors
		{
			get { return _CoEditors; }
			set 
			{ 
				_CoEditors = value;
				OnPropertyChanged("CoEditors");
			}
		}
		[JsonProperty]
		public string CoPublishers
		{
			get { return _CoPublishers; }
			set 
			{ 
				_CoPublishers = value;
				OnPropertyChanged("CoPublishers");
			}
		}
		[JsonProperty]
		public string EventOrganizerId
		{
			get { return _EventOrganizerId; }
			set 
			{ 
				_EventOrganizerId = value;
				OnPropertyChanged("EventOrganizerId");
			}
		}
		[JsonProperty]
		public string ContentOwnerId
		{
			get { return _ContentOwnerId; }
			set 
			{ 
				_ContentOwnerId = value;
				OnPropertyChanged("ContentOwnerId");
			}
		}
		[JsonProperty]
		public string TemplateEntryType
		{
			get { return _TemplateEntryType; }
			set 
			{ 
				_TemplateEntryType = value;
				OnPropertyChanged("TemplateEntryType");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResultScheduleEvent()
		{
		}

		public BulkUploadResultScheduleEvent(JToken node) : base(node)
		{
			if(node["referenceId"] != null)
			{
				this._ReferenceId = node["referenceId"].Value<string>();
			}
			if(node["templateEntryId"] != null)
			{
				this._TemplateEntryId = node["templateEntryId"].Value<string>();
			}
			if(node["eventType"] != null)
			{
				this._EventType = ParseInt(node["eventType"].Value<string>());
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
			if(node["categoryIds"] != null)
			{
				this._CategoryIds = node["categoryIds"].Value<string>();
			}
			if(node["resourceId"] != null)
			{
				this._ResourceId = node["resourceId"].Value<string>();
			}
			if(node["startTime"] != null)
			{
				this._StartTime = ParseInt(node["startTime"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["endTime"] != null)
			{
				this._EndTime = ParseInt(node["endTime"].Value<string>());
			}
			if(node["recurrence"] != null)
			{
				this._Recurrence = node["recurrence"].Value<string>();
			}
			if(node["coEditors"] != null)
			{
				this._CoEditors = node["coEditors"].Value<string>();
			}
			if(node["coPublishers"] != null)
			{
				this._CoPublishers = node["coPublishers"].Value<string>();
			}
			if(node["eventOrganizerId"] != null)
			{
				this._EventOrganizerId = node["eventOrganizerId"].Value<string>();
			}
			if(node["contentOwnerId"] != null)
			{
				this._ContentOwnerId = node["contentOwnerId"].Value<string>();
			}
			if(node["templateEntryType"] != null)
			{
				this._TemplateEntryType = node["templateEntryType"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadResultScheduleEvent");
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("templateEntryId", this._TemplateEntryId);
			kparams.AddIfNotNull("eventType", this._EventType);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("categoryIds", this._CategoryIds);
			kparams.AddIfNotNull("resourceId", this._ResourceId);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("recurrence", this._Recurrence);
			kparams.AddIfNotNull("coEditors", this._CoEditors);
			kparams.AddIfNotNull("coPublishers", this._CoPublishers);
			kparams.AddIfNotNull("eventOrganizerId", this._EventOrganizerId);
			kparams.AddIfNotNull("contentOwnerId", this._ContentOwnerId);
			kparams.AddIfNotNull("templateEntryType", this._TemplateEntryType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case REFERENCE_ID:
					return "ReferenceId";
				case TEMPLATE_ENTRY_ID:
					return "TemplateEntryId";
				case EVENT_TYPE:
					return "EventType";
				case TITLE:
					return "Title";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
				case CATEGORY_IDS:
					return "CategoryIds";
				case RESOURCE_ID:
					return "ResourceId";
				case START_TIME:
					return "StartTime";
				case DURATION:
					return "Duration";
				case END_TIME:
					return "EndTime";
				case RECURRENCE:
					return "Recurrence";
				case CO_EDITORS:
					return "CoEditors";
				case CO_PUBLISHERS:
					return "CoPublishers";
				case EVENT_ORGANIZER_ID:
					return "EventOrganizerId";
				case CONTENT_OWNER_ID:
					return "ContentOwnerId";
				case TEMPLATE_ENTRY_TYPE:
					return "TemplateEntryType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

