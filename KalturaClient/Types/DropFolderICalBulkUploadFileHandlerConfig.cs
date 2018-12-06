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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class DropFolderICalBulkUploadFileHandlerConfig : DropFolderFileHandlerConfig
	{
		#region Constants
		public const string EVENTS_TYPE = "eventsType";
		#endregion

		#region Private Fields
		private ScheduleEventType _EventsType = (ScheduleEventType)Int32.MinValue;
		#endregion

		#region Properties
		public ScheduleEventType EventsType
		{
			get { return _EventsType; }
			set 
			{ 
				_EventsType = value;
				OnPropertyChanged("EventsType");
			}
		}
		#endregion

		#region CTor
		public DropFolderICalBulkUploadFileHandlerConfig()
		{
		}

		public DropFolderICalBulkUploadFileHandlerConfig(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "eventsType":
						this._EventsType = (ScheduleEventType)ParseEnum(typeof(ScheduleEventType), propertyNode.InnerText);
						continue;
				}
			}
		}

		public DropFolderICalBulkUploadFileHandlerConfig(IDictionary<string,object> data) : base(data)
		{
			    this._EventsType = (ScheduleEventType)ParseEnum(typeof(ScheduleEventType), data.TryGetValueSafe<int>("eventsType"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDropFolderICalBulkUploadFileHandlerConfig");
			kparams.AddIfNotNull("eventsType", this._EventsType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EVENTS_TYPE:
					return "EventsType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

