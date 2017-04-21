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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class EventCuePointBaseFilter : CuePointFilter
	{
		#region Constants
		public const string EVENT_TYPE_EQUAL = "eventTypeEqual";
		public const string EVENT_TYPE_IN = "eventTypeIn";
		#endregion

		#region Private Fields
		private EventType _EventTypeEqual = null;
		private string _EventTypeIn = null;
		#endregion

		#region Properties
		public EventType EventTypeEqual
		{
			get { return _EventTypeEqual; }
			set 
			{ 
				_EventTypeEqual = value;
				OnPropertyChanged("EventTypeEqual");
			}
		}
		public string EventTypeIn
		{
			get { return _EventTypeIn; }
			set 
			{ 
				_EventTypeIn = value;
				OnPropertyChanged("EventTypeIn");
			}
		}
		#endregion

		#region CTor
		public EventCuePointBaseFilter()
		{
		}

		public EventCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "eventTypeEqual":
						this._EventTypeEqual = (EventType)StringEnum.Parse(typeof(EventType), propertyNode.InnerText);
						continue;
					case "eventTypeIn":
						this._EventTypeIn = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaEventCuePointBaseFilter");
			kparams.AddIfNotNull("eventTypeEqual", this._EventTypeEqual);
			kparams.AddIfNotNull("eventTypeIn", this._EventTypeIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EVENT_TYPE_EQUAL:
					return "EventTypeEqual";
				case EVENT_TYPE_IN:
					return "EventTypeIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

