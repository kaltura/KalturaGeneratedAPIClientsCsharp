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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class ScheduleEventResourceBaseFilter : RelatedFilter
	{
		#region Constants
		public const string EVENT_ID_EQUAL = "eventIdEqual";
		public const string EVENT_ID_IN = "eventIdIn";
		public const string RESOURCE_ID_EQUAL = "resourceIdEqual";
		public const string RESOURCE_ID_IN = "resourceIdIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		#endregion

		#region Private Fields
		private int _EventIdEqual = Int32.MinValue;
		private string _EventIdIn = null;
		private int _ResourceIdEqual = Int32.MinValue;
		private string _ResourceIdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use EventIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EventIdEqual
		{
			get { return _EventIdEqual; }
			set 
			{ 
				_EventIdEqual = value;
				OnPropertyChanged("EventIdEqual");
			}
		}
		/// <summary>
		/// Use EventIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EventIdIn
		{
			get { return _EventIdIn; }
			set 
			{ 
				_EventIdIn = value;
				OnPropertyChanged("EventIdIn");
			}
		}
		/// <summary>
		/// Use ResourceIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ResourceIdEqual
		{
			get { return _ResourceIdEqual; }
			set 
			{ 
				_ResourceIdEqual = value;
				OnPropertyChanged("ResourceIdEqual");
			}
		}
		/// <summary>
		/// Use ResourceIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ResourceIdIn
		{
			get { return _ResourceIdIn; }
			set 
			{ 
				_ResourceIdIn = value;
				OnPropertyChanged("ResourceIdIn");
			}
		}
		/// <summary>
		/// Use CreatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use UpdatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use UpdatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public ScheduleEventResourceBaseFilter()
		{
		}

		public ScheduleEventResourceBaseFilter(JToken node) : base(node)
		{
			if(node["eventIdEqual"] != null)
			{
				this._EventIdEqual = ParseInt(node["eventIdEqual"].Value<string>());
			}
			if(node["eventIdIn"] != null)
			{
				this._EventIdIn = node["eventIdIn"].Value<string>();
			}
			if(node["resourceIdEqual"] != null)
			{
				this._ResourceIdEqual = ParseInt(node["resourceIdEqual"].Value<string>());
			}
			if(node["resourceIdIn"] != null)
			{
				this._ResourceIdIn = node["resourceIdIn"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduleEventResourceBaseFilter");
			kparams.AddIfNotNull("eventIdEqual", this._EventIdEqual);
			kparams.AddIfNotNull("eventIdIn", this._EventIdIn);
			kparams.AddIfNotNull("resourceIdEqual", this._ResourceIdEqual);
			kparams.AddIfNotNull("resourceIdIn", this._ResourceIdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EVENT_ID_EQUAL:
					return "EventIdEqual";
				case EVENT_ID_IN:
					return "EventIdIn";
				case RESOURCE_ID_EQUAL:
					return "ResourceIdEqual";
				case RESOURCE_ID_IN:
					return "ResourceIdIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

