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
	public class VirtualScheduleEvent : ScheduleEvent
	{
		#region Constants
		public const string VIRTUAL_EVENT_ID = "virtualEventId";
		public const string VIRTUAL_SCHEDULE_EVENT_SUB_TYPE = "virtualScheduleEventSubType";
		#endregion

		#region Private Fields
		private int _VirtualEventId = Int32.MinValue;
		private VirtualScheduleEventSubType _VirtualScheduleEventSubType = (VirtualScheduleEventSubType)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use VirtualEventIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VirtualEventId
		{
			get { return _VirtualEventId; }
			set 
			{ 
				_VirtualEventId = value;
				OnPropertyChanged("VirtualEventId");
			}
		}
		/// <summary>
		/// Use VirtualScheduleEventSubTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VirtualScheduleEventSubType VirtualScheduleEventSubType
		{
			get { return _VirtualScheduleEventSubType; }
			set 
			{ 
				_VirtualScheduleEventSubType = value;
				OnPropertyChanged("VirtualScheduleEventSubType");
			}
		}
		#endregion

		#region CTor
		public VirtualScheduleEvent()
		{
		}

		public VirtualScheduleEvent(JToken node) : base(node)
		{
			if(node["virtualEventId"] != null)
			{
				this._VirtualEventId = ParseInt(node["virtualEventId"].Value<string>());
			}
			if(node["virtualScheduleEventSubType"] != null)
			{
				this._VirtualScheduleEventSubType = (VirtualScheduleEventSubType)ParseEnum(typeof(VirtualScheduleEventSubType), node["virtualScheduleEventSubType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVirtualScheduleEvent");
			kparams.AddIfNotNull("virtualEventId", this._VirtualEventId);
			kparams.AddIfNotNull("virtualScheduleEventSubType", this._VirtualScheduleEventSubType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VIRTUAL_EVENT_ID:
					return "VirtualEventId";
				case VIRTUAL_SCHEDULE_EVENT_SUB_TYPE:
					return "VirtualScheduleEventSubType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

